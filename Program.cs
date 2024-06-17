namespace Assignment7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 90, 80, 70, 100, 55, 40, 85, 95 };
            foreach (int i in array) { Console.Write(i + " "); }
            int l = array.Length;

            for (int i = 0;i<l-1;i++)
            {
                int minIndex=i;
                int minValue = array[i];

                for (int j = i;j<l;j++)
                {
                    if (array[j] < minValue)
                    {
                        minIndex = j;
                        minValue = array[j];
                    }

                }
                int temp= array[i];
                array[i] = minValue;
                array[minIndex] = temp;
            }
            Console.WriteLine();
            Console.WriteLine();
            foreach (int i in array) { Console.Write(i+" "); }


                
        }
    }
}
