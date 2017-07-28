open Microsoft.FSharp.Core

type Shape = 
    | Circle of radius:int
    | Rectangle of height:int * width:int
    | Point of x:int * y:int
    | Polygon of pointList:(int * int) list
    | Tesseract of dimension:int

let printCircle circle =
    match circle with
    | Circle radius ->
        printfn "this is a circle with radius of %d" radius
    | _ -> failwith "unknown exc"


let draw shape =
    match shape with
    | Circle radius ->
        printCircle shape// printfn "this is a circle with radius of %d" radius
    | Rectangle (height,width) -> 
        printfn "%d X %d rectangle" height width
    | Polygon points ->
        printfn "%A" points
    | Tesseract dimension ->
        printCircle shape
    | _ -> printfn "unknown type"

let circle = Circle(10)
let rect = Rectangle(4,5)
let point = Point(2,3)
let poly = Polygon([(1,1); (2,2); (3,3)])

[circle; rect; point; poly] |> List.iter draw

let t = Tesseract(9)
draw t

