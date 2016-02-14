namespace mhope.Math.FSharp

open System.Numerics

module Fibonnaci =

    let GetFibonacciNumberAtIndex (index : uint64) : uint64 =
         let rec fib index : uint64 =
            match index with
            | 0UL -> 0UL
            | 1UL -> 1UL
            | _ -> fib (index - 1UL) + fib (index - 2UL)
         fib index

    let GetFibonacciSequence (index : uint64) =
        let fib (n : uint64) = 
            seq<uint64> {
                for i in 0UL..n do
                   yield GetFibonacciNumberAtIndex i
            }
        fib index
 
    let PrintSequence (s : System.Collections.Generic.IEnumerable<uint64>) =
        s
        |> Seq.iter (fun i -> printf "%s \r" (i.ToString()))
        
          



    

        
