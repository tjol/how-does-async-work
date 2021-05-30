"use strict"

async function return_number_async(n) {
    console.log("in return_number_async")
    return n
}

async function silly_example() {
    console.log('start of async function')
    let fut = return_number_async(10)
    console.log('called return_number_async(10)')
    let n = await fut
    console.log(`result: ${n}`)
}

silly_example()
