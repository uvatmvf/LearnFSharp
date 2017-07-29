let add2 x = x + 2
let mult3 x = x * 3
let square x = x * x

[1..10] |> List.map add2 |> printfn "%A"

let compositeF = add2 >> mult3

compositeF 5
