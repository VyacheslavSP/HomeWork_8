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
void CheckMinSumm(byte[,] myArray) // метод отрабатывает первое вхождение минимальной суммы
{
  int tmpSumm=0;
  int[] tmpArraySumm=new int[myArray.GetLength(0)];
  for (int i=0; i<myArray.GetLength(0); i++) {
    for (int j=0; j<myArray.GetLength(1); j++) {
      tmpSumm+=myArray[i,j];
    }
    tmpArraySumm[i]=tmpSumm;
    tmpSumm=0;
  }
  int minVal=tmpArraySumm.Min();
  int indexMin=Array.IndexOf(tmpArraySumm,minVal);
  Console.WriteLine(++indexMin+ " строка");
}
byte [,] myArray=new byte[,] {{1,4,7,2},{5,9,2,3},{8,4,2,4},{5,2,6,7}}; //как задается не сказано поэтому хардкод
Print2DArray(myArray);
CheckMinSumm(myArray);
