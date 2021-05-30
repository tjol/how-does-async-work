#!/usr/bin/env python

class return_number_async(object):
    def __init__(self, n):
        self.n = n

    def __next__(self):
        print('in return_number_async')
        e = StopIteration()
        e.value = self.n
        raise e
    
    def __iter__(self):
        return self
    
    next = __next__

def silly_example():
    print('start of async function')
    fut = return_number_async(10)
    print('called return_number_async(10)')
    try:
        while True:
            n = next(fut)
            yield n
    except StopIteration as e:
        n = e.value
    print('result: {}'.format(n))

if __name__ == '__main__':
    for v in silly_example():
        print('yielded {}'.format(v))

