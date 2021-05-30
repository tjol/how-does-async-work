#!/usr/bin/env python3

import asyncio

@asyncio.coroutine
def return_number_async(n):
    print('in return_number_async')
    return n

@asyncio.coroutine
def silly_example():
    print('start of async function')
    fut = return_number_async(10)
    print('called return_number_async(10)')
    n = yield from fut
    print(f'result: {n}')

if __name__ == '__main__':
    loop = asyncio.new_event_loop()
    loop.run_until_complete(silly_example())

