let firstPart, secondPart, _ = (1,2,3)
let elem1::elem2::rest = [1..10]

let listMatcher aList = 
    match aList with 
    | [] -> printfn "empty list"
    | [firstElement] -> printfn "one element in list"
    | [first;second] -> printfn "two elements"
    | _ -> printfn "more than 2 elements"

listMatcher [1;2;3;4]
listMatcher [1;2]
listMatcher [1]
listMatcher []

type Address = { Street: string; City: string;}
type Customer = {ID : int; Name : string; Address: Address}

let cust1 = {ID =1; Name = "Bob";
    Address = {Street = "123 Main"; City="NYC"} }

let { Name=name1 } = cust1
printfn "Customer is %s" name1

let {ID = id2; Name = name2;} = cust1

printfn "The id and name %s %i" name2 id2

