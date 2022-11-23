int [,] BuildMatrix (byte lenghtMatrix)
{
  int[,]myMatrix=new int [lenghtMatrix,lenghtMatrix];
  for(int ik=0;ik<lenghtMatrix;ik++)
  {
    for (int jk=0;jk<lenghtMatrix;jk++)
    {
      int i=ik+1;
      int j=jk+1;
      int switcher=(j-i+lenghtMatrix)/lenghtMatrix;
      int ic=Math.Abs(i-lenghtMatrix/2-1)+(i-1)/(lenghtMatrix/2)*((lenghtMatrix-1)%2);
      int jc=Math.Abs(j-lenghtMatrix/2-1)+(j-1)/(lenghtMatrix/2)*((lenghtMatrix-1)%2);
      int ring=lenghtMatrix/2-(Math.Abs(ic-jc)+ic+jc)/2;
      int xs=i-ring+j-ring-1;
      int coef=4*ring*(lenghtMatrix-ring);
      myMatrix[ik,jk]=coef+switcher*xs+Math.Abs(switcher-1)*(4*(lenghtMatrix-2*ring)-2-xs);
    }
  }
  return myMatrix;
}
void Print2DArray (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      Console.Write(matrix[i,j].ToString("D2") + "\t"); // для красоты чтоб вывело как в примере
    }
    Console.WriteLine();
  }
}
Console.Clear();
byte lenghtMatrix=4; // нет задачи делать это вариативно,поэтому матрица жестко 4*4.
int[,]myMatrix=BuildMatrix(lenghtMatrix);
Print2DArray(myMatrix);
Console.ReadKey();
/* математика честно взята со статьи на Хабр  https://habr.com/ru/post/560266/. понятно что можно хоть в одну строчку
написать эту формулу, но прочитать это будет невозможно
Алтернативный вариант вроде этого
int i,j =0 ;
int temp=1;
while (temp <= myMatrix.GetLength(0) * myMatrix.GetLength(0)) // ибо матрица квадрат
{
myMatrix[i, j] = (byte) temp;
temp++;
if (i <= j + 1 && i + j < myMatrix.GetLength(1) - 1)
j++;
else if (i < j && i + j >= myMatrix.GetLength(0) - 1)
i++;
else if (i >= j && i + j > myMatrix.GetLength(1) - 1)
j--;
else
i--;
}
Однако здесь ветвления и повторения,от которых вроде как нужно избавляться
