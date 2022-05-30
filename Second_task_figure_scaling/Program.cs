// 2.Написать программу масштабирования фигуры

Console.Clear();
  Console.Write("Введите коэффициент K, для масштабирования фигуры: ");
double k = Console.ReadLine();
// int k = int.Parse(Console.ReadLine()?? "");
double[,] matrix = new double [4, 2];

   for(int row = 0; row < matrix.GetLength(0); row++)
   {
       for(int column = 0; column < matrix.GetLength(1); column++)
       {
         matrix[row, column] = new Random().NextDouble(1,5);
       } 

}    

for(int row = 0; row < matrix.GetLength(0); row++)
   {
    for(int column = 0; column < matrix.GetLength(1); column++)
       {
        Console.Write($"{matrix[row,column] + " "}");
       } 
 Console.WriteLine();
  }            

for(int row = 0; row < matrix.GetLength(0); row++)
   {
    for(int column = 0; column < matrix.GetLength(1); column++)
       {
        Console.Write($"{matrix[row,column] * k + " "}");
       } 
Console.WriteLine();

  }            

//   Console.Write("Введите коэффициент K, для масштабирования фигуры: ");
//   int k = int.Parse(Console.ReadLine()?? "");

// matrix[row][column] = matrix[row][column] * 2;