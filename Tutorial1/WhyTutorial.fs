﻿let myInt = 5
let myFloat = 3.14
let myString = "hello"

let twoToFive = [2;3;4;5]

let oneToFive = 1 :: twoToFive

let zeroToFive = [0;1] @ twoToFive

let square x = x * x
square 3

let add x y = x + y
add 2 3

let evens list =
    let isEven x = x%2 = 0
    List.filter isEven list

evens oneToFive

let sumOfSquaresTo100  =
    List.sum (List.map square [1..100])

// list pipes
let sumOfSquaresTo100piped = 
    [1..100] |> List.map square |> List.sum

// lambda in pipe
let sumOfSquaresTo100withFun = 
    [1..100] |> List.map (fun x->x*x) |> List.sum

// switch case statement
let simplePatternMatch = 
    let x = "ba"
    match x with
    | "a" -> printfn "x is a"
    | "b" -> printfn "x is b"
    | _-> printfn "x is something else"

let validValue = Some(99)
let invalidValue = None

let optionPatternMatch input = 
    match input with
    | Some i -> printfn "input is an int=%d" i
    | None -> printfn "missing input"

optionPatternMatch validValue   
optionPatternMatch invalidValue