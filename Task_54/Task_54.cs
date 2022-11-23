void Print2DArray<T>(T[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
  }
}
byte[,] SortArray(byte[,] myArray)
{
  byte[] tmpArray=new byte[myArray.GetLength(1)];
  for (int i=0; i<myArray.GetLength(0); i++) {
    for (int j=0;  j<myArray.GetLength(1); j++) {
      tmpArray[j]=myArray[i,j];
    }
    tmpArray=tmpArray.OrderByDescending(x=>x).ToArray();
    for (int j=0;  j<myArray.GetLength(1); j++) {
    myArray[i,j]=tmpArray[j];
    }
  }
  return myArray;
}
byte [,] myArray=new byte[,] {{1,4,7,2},{5,9,2,3},{8,4,2,4}}; //как задается не сказано поэтому хардкод
Console.WriteLine("Исходный массив");
Print2DArray(myArray);
Console.WriteLine("Отсортированный массив");
Print2DArray(SortArray(myArray));
