#!/usr/bin/env python3

async def return_number_async(n):
    print('in return_number_async')
    return n

async def silly_example():
    print('start of async function')
    fut = return_number_async(10)
    print('called return_number_async(10)')
    n = await fut
    print(f'result: {n}')

if __name__ == '__main__':
    import asyncio
    asyncio.run(silly_example())

