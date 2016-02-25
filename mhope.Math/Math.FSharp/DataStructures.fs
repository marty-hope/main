module DataStructures

    type SimpleStack<'T>() =
        let mutable _stack : List<'T> = []
        member this.Push value =
            _stack <- value :: _stack
        member this.Pop value =
            match _stack with
            | [] -> failwith "Empty Stack"
            | result::remainder ->
               _stack <- remainder
               result
        member this.TryPop() =
            match _stack with
            | result:: newStack ->
                _stack <- newStack
                result |> Some
            | [] -> None
        member this.SafeSwap() =
            match _stack with
            | a::b::tail -> _stack <- b::a::tail
            | _ -> failwith "Stack does not have enough elements"
           
