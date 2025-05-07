namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {   //-----1
            //Pow(3);
            //-----2
            //int[] result = PowArr(1, 2, 3, 4, 5);
            //    foreach (int i in result)
            //    {
            //        Console.WriteLine(i);
            //    }
            // ------3
            //Console.WriteLine(Space("Hikmet Abbasov"));
            //--------4
            // int[] number = { 1, 2, 3 };
            //    number = AdElements(number, 4);
            //    foreach (int i in number)
            //    {
            //        Console.WriteLine(i);
            //    }
        }

        public static void Pow(int a)
        {
            int result = a * a;
            Console.WriteLine(result);
        }

            public static int[] PowArr(params int[] numbers)
        {
            int[] num = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                num[i] = numbers[i] * numbers[i];

            }
            return num;
        }

            public static string NOSpaces(string word)
            {
                string news = "";
                foreach (var i in word)
                {
                    if (i != ' ')
                    {
                        news += i;
                    }
                }
                return news;
            }

            public static int[] AdElements(int[] arr, int value)
            {
                int[] newArr = new int[arr.Length + 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }
                newArr[arr.Length] = value;
                return newArr;
            }

    }
}

