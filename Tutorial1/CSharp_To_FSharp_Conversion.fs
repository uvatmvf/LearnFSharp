let square x = x * x
let sumOfSquares n = 
    [1..n] |> List.map square |> List.sum

sumOfSquares 100

// equivalent c# code for sumOfSquares
//public static class SumofSquaresHelper
//{
//    public static int Square(int i)
//    { // equivalent of squar efunction
//        return i * i;
//    }
//    public static int SumofSquares(int n)
//    {
//        int sum = 0;
//        for (int i =1; i <= nan; i++)
//        {
//            sum += Square(i);
//        }
//        return sum;
//    }
//}

