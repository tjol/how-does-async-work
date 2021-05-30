#!/usr/bin/env node
"use strict"

function return_number_async(n) {
    console.log("in return_number_async")
    return {
        then(callback) {
            setTimeout(function() {
                callback(n);
            }, 0)
        }
    }
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
