// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

let altitudes = [|100; 20; 300; 200; 90; 400; 50; 1098; 300; 798; 100; 50; 120|]

let TotalClimb heights =
    heights
    |> Seq.pairwise
    |> Seq.filter (fun(a, b) -> b > a)
    |> Seq.map (fun (a, b) -> b - a)
    |> Seq.sum
    
TotalClimb altitudes


//altitude on the route which is higher than the altitude immediately before and after
let Peeks heights =
    heights
    |> Seq.windowed 3
    |> Seq.choose (fun(triplet) -> 
        match triplet with
        | [| a; b; c |] when b > a && b > c -> Some b
        | _ -> None)
    
Peeks altitudes

let bArr =  [ 03uy;00uy;00uy;01uy;255uy;254uy;09uy;08uy;100uy;255uy]

let rec GetTail arr =
    match arr with
    | [] -> failwith "No Match Found"
    | a::b::tail when a = 01uy && b = 255uy -> tail
    | a::tail -> GetTail tail
    





