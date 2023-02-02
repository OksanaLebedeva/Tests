void PrintArray(string[] array)
{
  for (int i=0; i<array.Length; i++)
  {
    if (array[i]!=String.Empty)
    {
      Console.Write($"'{array[i]}'");
      if (i<array.Length-1) Console.Write(", ");
      else Console.Write("");
    }
  }
  Console.WriteLine();
}
string[] array1 = {"computer", "science", "123", "3", "million", " ", "A"}; 
Console.Write($"Initial array: ");
PrintArray(array1);
string[] array2 = new string[array1.Length];
for (int i=0; i<array1.Length; i++)
{
  if (array1[i].Length <= 3) array2[i] = array1[i];
  else array2[i] = String.Empty;
}
Console.Write($"Final array: ");
PrintArray(array2);