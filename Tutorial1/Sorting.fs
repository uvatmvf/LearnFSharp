let rec quicksort list = 
    match list with 
    | [] ->
        []
    | firstElem::otherElements ->
        let smallerElements = 
            otherElements
            |> List.filter (fun e -> e < firstElem)
            |> quicksort
        let largerElements =
            otherElements
            |> List.filter (fun e -> e >= firstElem)
            |> quicksort
        List.concat[smallerElements; [firstElem]; largerElements];

printfn "%A" (quicksort [1;5;23;18;9;1;3])


//public static class QuickSortExtension
//{
//        this IEnumerable<T> values) where T : IComparable
//    {
//        if (values == null || !values.Any())
//        {
//            return new List<T>();
//        }

//        //split the list into the first element and the rest         
//          var firstElement = values.First();
//        var rest = values.Skip(1);

//        //get the smaller and larger elements         
//          var smallerElements = rest
//                .Where(i => i.CompareTo(firstElement) < 0)
//                .QuickSort();

//        var largerElements = rest
//                .Where(i => i.CompareTo(firstElement) >= 0)
//                .QuickSort();

//        //return the result         return smallerElements
//            .Concat(new List<T>{firstElement})
//            .Concat(largerElements);
//    }
//}