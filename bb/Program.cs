namespace bb;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int count = 0;
        
        int[] numbers = { 3, 5, 6, 2, 7, 8 };
        for (int i = 1; i < numbers.Length; i+=2)

        {



            if (numbers[i] % 2 == 0)
            {
                count++;
                sum += numbers[i];
            }

            }Console.WriteLine(sum + " " + count);

       
        

        


    }
}

