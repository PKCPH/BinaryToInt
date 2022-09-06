namespace Arrays
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input binary number: ");
            var output = BinaryStringToInt(Console.ReadLine());
            Console.WriteLine(output);
        }

        static int BinaryStringToInt(string input)
        {
            char[] array = input.ToCharArray();

            //reverses the arrays so it start with bit 1 instead of  bit 128
            Array.Reverse(array);
         
            //total sum that will be returned
            int output = 0;

            for (int i = 0; i < array.Length; i++)
            {
                //if the bit is turned on
                if (array[i] == '1')
                {
                    //med 2 opløftet i i. f.eks. 2^3 = 8, så hvis 00001000 = 8
                    output += (int)Math.Pow(2, i);
                }
            }

            return output;
        }
    }
}