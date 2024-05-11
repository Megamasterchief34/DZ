
void Main()
   {
      
   string[] GenerateArray(int size)
      {
         string[] tempArray = new string[size];
         for (int i = 0; i < size; i++)
         {
            Console.WriteLine("Введите элемент массива: ");
            tempArray[i] = Console.ReadLine()!;
         
         }
         return tempArray;
         
      }
   void PrintArray(string[] arrayForPrint)
{
    foreach (string number in arrayForPrint)
    {
        System.Console.Write(number + " ");
    }

}
   }

Main();
