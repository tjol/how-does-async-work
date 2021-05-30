# How do `async` and `await` work?

This repository is a brief exploration of how async and await work in different
languages after I noticed that Python and JavaScript do things quite differently
in this department.

This simple demo program looks almost the same in the various languages with
`async` and `await` keywords:

```python
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
```

The Python version prints:

```
start of async function
called return_number_async(10)
in return_number_async
result: 10
```

The JavaScript equivalent prints

```
start of async function
in return_number_async
called return_number_async(10)
result: 10
```

.net/C# behaves the same way as JavaScript. Both have a very similar task-based
model of async which could be described as ‘eager’ compared to Python’s
coroutine-based model. Rust behaves the same way as Python.

For Python, JavaScript and C#, I've also added variants that do the same thing
but without language support for async.
