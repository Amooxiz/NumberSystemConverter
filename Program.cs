using System;



namespace systemy_poz_test
{
    class Program
    {
        static string solve(int number, int systemIn, int systemOut)
        {
            string numberToReturn = "";
            int toDecimal = 0;
            if (systemIn != 10)
            {
                int i = 0;
                while (number != 0)
                {
                    toDecimal += System.Convert.ToInt32(number % 10 * Math.Pow(systemIn, i));
                    number /= 10;
                    i++;
                }
            }
            else
            {
                toDecimal = number;
            }
            Console.WriteLine(toDecimal);
            int x = 0;
            while (Math.Pow(systemOut, x + 1) <= toDecimal)
            {
                x++;
            }
            for (int i = x; i >= 0; i--)
            {
                int k = 0;
                char numbersToLetters;
                while ((k + 1) * Math.Pow(systemOut, i) <= toDecimal)
                {
                    k++;
                }
                if (k > 9)
                {
                    numbersToLetters = ((char)(k + 55));
                    numberToReturn += System.Convert.ToString(numbersToLetters);
                }
                else
                {
                    numberToReturn += System.Convert.ToString(k);
                }
                toDecimal -= System.Convert.ToInt32(k * Math.Pow(systemOut, i));
            }
            return numberToReturn;
        }

        static void Main(string[] args)
        {
            string xd = solve(156, 10, 16);
            Console.WriteLine(xd);
        }
    }
}
