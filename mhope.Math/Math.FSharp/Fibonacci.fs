namespace Math.FSharp

module Fibonacci =

    let getFibonacciSequence (index: int)  =
        let rec fib n =
            if n = 0 then 0
            elif n = 1 then 1
            else fib (n - 1) + fib (n - 2)
        let arr = 
            [|
                for i in 0 .. index - 1 -> fib i
           
            |]
        arr