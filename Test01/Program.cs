void PrintArray(string[] array)
{
  for (int i=0; i<array.Length; i++)
  {
    Console.Write($"'{array[i]}'");
    if (i<array.Length-1) Console.Write(", ");
    else Console.Write("");
  }
  Console.WriteLine("]");
}

string[] initialArray = {"computer", "science", "123", "3", "million", "A"}; 
Console.Write($"Initial array: [");
PrintArray(initialArray);
int newArraySize = 0;
for (int i=0; i<initialArray.Length; i++)
{
  if (initialArray[i].Length <= 3) newArraySize++;
}
string[] newArray = new string [newArraySize];
newArraySize = 0;
for (int i=0; i<initialArray.Length; i++)
{
  if (initialArray[i].Length <= 3)
  {
    newArray[newArraySize] = initialArray[i];
    newArraySize++;
  }
}
Console.Write($"Final array: [");
PrintArray(newArray);