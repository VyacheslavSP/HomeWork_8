void ShowElemetAndIndex(byte[,,]my3dArray)
{
  byte l=0;
  for (int i=my3dArray.GetLowerBound(0); i<=my3dArray.GetUpperBound(0); i++) {
    for (int j=my3dArray.GetLowerBound(1); j<=my3dArray.GetUpperBound(1); j++) {
      for (int k=my3dArray.GetLowerBound(2); k<=my3dArray.GetUpperBound(2); k++) {
        Console.Write(my3dArray[i,j,k]+ " "+(i,j,k) + " ");
        l++;
        if (l%2==0) {
          Console.WriteLine();
        }
      }
    }
  }
}
byte [,,] my3dArray= new byte [2,2,2] {{{66,25},{34,41}},{{27,90},{26,55}}}; // не сказано что я должен как то получить данный массив поэтому вот
Console.Clear();
ShowElemetAndIndex(my3dArray);
Console.ReadKey();
///===///
/* хоть задача получить неповторяющиеся числа не стоит,но, т.к. я убил много времени думая об этом то хотел бы узнать
у Вас есть ли более правильное решение.
Для маленького массива типа 2,2,2 можно,конечно,смело использовать Random без всяких проверок, шанс повторения даже при
выборе из byte очень мал. однако, с ростом размера массива при конечном варианте разброса шанс будеть увеличиваться и
вероятность получить уникальное число, если 250 числ в массиве уже есть крайне низка. можно делать проверку на
равенство с уже имеющиемся с последующей заменой, однако этот метод может занимать достаточно много места и времени
единственный гарантированный вариант получения однозначно неповторяющихся чисел видится такой:

byte[] NumArray= new byte [byte.MaxValue];
for (byte i=0;i<=byte.MaxValue-1;i++) // создали массив всех возможных чисел
{
  NumArray[i]=i;
}
var rand = new Random();            // перемешали полученный массив
for (int i = NumArray.Length - 1; i >= 1; i--)
{
  int j = rand.Next(i + 1);
  byte tmp = NumArray[j];
  NumArray[j] = NumArray[i];
  NumArray[i] = tmp;
}
byte[,,] build3dArray(byte[] NumArray)   /// забили искомый массив элементами из случайного массива по порядку (для этого и перемешивали)
{
  byte [,,] random3dArray= new byte [5,10,4]; // произведение размеров должно быть меньше размера NumArray;
  byte l=0;
  for (int i=random3dArray.GetLowerBound(0); i<=random3dArray.GetUpperBound(0); i++) {
    for (int j=random3dArray.GetLowerBound(1); j<=random3dArray.GetUpperBound(1); j++) {
      for (int k=random3dArray.GetLowerBound(2); k<=random3dArray.GetUpperBound(2); k++) {
        random3dArray[i,j,k]=NumArray[l];
        l++;
      }
    }
  }
  return random3dArray;
}
byte [,,] random3dArray=build3dArray(NumArray);
ShowElemetAndIndex(random3dArray);
*/
