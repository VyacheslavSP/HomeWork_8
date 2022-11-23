byte[,] BuildArray(byte width, byte height)
{
  byte[,] myArray=new byte[width,height];
  var Rnd=new Random();
  for(byte i=0;i<width;i++)
  {
    for(byte j=0;j<height;j++)
    {
      myArray[i,j]=(byte)Rnd.Next(0,byte.MaxValue);
    }
  }
  return myArray;
}
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
byte[,] UpendArray(byte[,] myArray, int size)
{
  byte tmp;
  for (int i = 0; i < size; i++)
  {
    for (int j = 0; j < i; j++)
    {
      tmp = myArray[i, j];
      myArray[i, j] = myArray[j, i];
      myArray[j,i] = tmp;
    }
  }
  return myArray;
}
Console.Clear();
byte[,] myArray=BuildArray(4,4); // размерности не указаны,как и то что пользователь их задает. поэтому хардкод
Console.WriteLine("Исходный массив ");
Print2DArray(myArray);
if (myArray.GetLength(0)==myArray.GetLength(1)) {
  Console.WriteLine("Итоговый массив ");
  myArray=UpendArray(myArray,myArray.GetLength(0));
  Print2DArray(myArray);
}else{
  Console.WriteLine("Массив не квадратный. Транспонировать нельзя"); /*
  условие задачи "решить НЕ используя второй массив" рассмотрено как условие "переписать в тот же массив без изменения размера"
  доступно только для квадратных массивов*/
}
