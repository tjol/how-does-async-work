#!/usr/bin/env node
"use strict"

function return_number_async(n) {
    return new Promise(function(resolve, reject) {
        console.log("in return_number_async")
        resolve(n)
    })
}

function silly_example() {
    console.log('start of async function')
    let fut = return_number_async(10)
    let my_promise = fut.then(function(n) {
        console.log(`result: ${n}`)
    })
    console.log('called return_number_async(10)')
    return my_promise
}

silly_example()
