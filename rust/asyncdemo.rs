use futures::executor::block_on;

async fn return_number_async(n: i32) -> i32 {
    println!("in return_number_async");
    return n;
}

async fn silly_example() {
    println!("start of async function");
    let fut = return_number_async(10);
    println!("called return_number_async(10)");
    let n = fut.await;
    println!("result: {0}", n);
}

fn main() {
    block_on(silly_example());
}

