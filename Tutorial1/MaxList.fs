type NameAndSize = {Name:string; Size:int}

let maxNS list =
    let innerMaxNS initialValue rest = 
        let action maxSoFar x = if maxSoFar.Size < x.Size then x else maxSoFar
        rest |> List.fold action initialValue

    match list with 
    | [] ->
        None
    | first :: rest ->
        let max = innerMaxNS first rest
        Some max

let list = [
    {Name="A"; Size=10}
    {Name="B";Size=9}
    {Name="C";Size=12}
    {Name="D";Size=5}
    ]

maxNS list
maxNS []


let product n =
    let initialValue = 2
    let action productSoFar x = productSoFar * x
    [1..n] |> List.fold action initialValue

product 2