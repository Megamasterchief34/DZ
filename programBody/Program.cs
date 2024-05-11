
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
string[] homework = GenerateArray(5);
   PrintArray(homework);
   string[] newHomework = homework.Where(h => h.Length <= 3).ToArray();
   foreach (string work in newHomework)
      Console.WriteLine("Элементы, удовлетворяющие критерию: " + work);
               

            
PrintArray(newHomework);
   }

Main();
