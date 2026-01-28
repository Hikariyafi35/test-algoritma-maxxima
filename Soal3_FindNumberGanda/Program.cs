// See https://aka.ms/new-console-template for more information
class FindPrimeNumber
{
    static void Main()
    {
        Console.WriteLine("tes soal 3");
        int[] numbers = { -3, 7, -3, 5, 9, 3, 5, 8, 5 };

            List<int> duplicates = new List<int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                int countDuplicate = 0;


                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        
                        
                            countDuplicate++;
                        
                    }
                }


                if (countDuplicate > 1 && !duplicates.Contains(numbers[i]))
                {
                    if(numbers [i] ! = -3){
                    duplicates.Add(numbers[i]);
                    }
                }
            }
                Console.WriteLine(string.Join(", ", duplicates));
        }
}

