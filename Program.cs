using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 12, 23, 34, 45, 56, 67,78,89,90 };
            int[] newArr = MakeEvenArr(nums);

            Console.WriteLine("Even numbers:");
            for (int i = 0; i < newArr.Length; i++)
            {
                Console.WriteLine(newArr[i]);
            }
           
            
            int[] alma = { 23, 45, 78 };

            AddNum(ref alma, 8);
            AddNum(ref alma, 94);
            AddNum(ref alma, 56);

            foreach (var item in alma)
            {
                Console.WriteLine(item);
            }


            //Verilmis adlar siyahisinda (string array) nece adin uzunlugunun 5-den boyuk oldugunu tapan proqram

            Console.WriteLine("Adlarin sayini daxil edin:");
            string nameCountStr = Console.ReadLine();
            int nameCount = Convert.ToInt32(nameCountStr);

            string[] names = new string[nameCount];
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{i + 1}. adi daxil et:");
                names[i] = Console.ReadLine();
            }
            int result = FindWordCount(names);
            Console.WriteLine($"result: {result}");





            static int FindWordCount(string[] names)
            {
                int count = 0;

                for (int i = 0; i < names.Length; i++)
                {
                    if (names[i].Length > 5)
                        count++;
                }

                return count;
            }

            //Verilmis ededler siyahisindaki cut ededlerden ibraret yeni bir array qaytaran method.
            //Misalcun gonderilmis ededler siyahisinda {1,3,4,5,6} deyerleri varsa method geriye {4,6} deyerlerinden ibaret bir array qaytarmalidir

            static int[] MakeEvenArr(int[] numbers)
            {
                int newArrSize = FindEvenCount(numbers);

                int[] evenNumbers = new int[newArrSize];

                int index = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        evenNumbers[index] = numbers[i];
                        index++;
                    }
                }

                return evenNumbers;
            }

            static int FindEvenCount(int[] numbers)
            {
                int count = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                        count++;
                }

                return count;
            }
            //Verilmiş artan sıra ilə düzülmüş ədədlər siyahısındaki n ədədinin yerləşdiyi indexi tapan method.

            int[] numbers = { 12, 23, 35, 46, 57, 68, 79, 80, 91,100,111,222,333 };

            int n = 35;

            int max = numbers.Length - 1;
            int min = 0;
            int index = -1;

            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (n == numbers[mid])
                {
                    index = mid;
                    break;
                }
                else if (n > numbers[mid])
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }

            if (index == -1)
            {
                Console.WriteLine("Eded tapilmadi");
            }
            else
            {
               
                Console.WriteLine($"{n} ededi {index} nomreli indexde yerlesir");
            }

            //Verilmiş iki ədədlər siyahısından birincisinin ikincisinin içində olub olmadığını tapan metod.

            int[] numbers1 = { 12, 23, 34,45,68 };
            int[] numbers2 = { 23, 18, 12, 17, 34, 68, 33, 45 };

            bool check = false;
            for (int i = 0; i < numbers1.Length; i++)
            {
                check = false;
                for (int j = 0; j < numbers2.Length; j++)
                {
                    if (numbers2[j] == numbers1[i])
                    {
                        check = true;
                        break;
                    }
                }

                if (!check)
                    break;
            }

            if (check)
                Console.WriteLine("var");
            else
                Console.WriteLine("yoxdur");

            //Verilmiş yazılar siyahısındaki bütün sözlərin A hərfi ilə başlayıb başlamadığını tapan metod
            
            Console.WriteLine("Adlar siyahinizin uzunlugunu daxil edin:");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);
            string[] name = new string[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}. adi daxil et");
                name[i] = Console.ReadLine();
            }


            bool isStartWithA = true;


            for (int i = 0; i < names.Length; i++)
            {
                if (names[i][0] != 'A')
                {
                    isStartWithA = false;
                    
                }
            }

            if (isStartWithA)
                Console.WriteLine("Hamisi A ile baslayir");
            else 
                Console.WriteLine("Hamisi A ile baslamir");

            //Parameter olaraq integer array variable-i ve bir integer value qebul eden ve hemin integer
            //value-nu integer array-e yeni element kimi elave eden metod.
            static void AddNum(ref int[] arr, int value)
            {
                int[] newArr = new int[arr.Length + 1];
                for (int i = 0; i < arr.Length; i++)
                {
                    newArr[i] = arr[i];
                }

                newArr[newArr.Length - 1] = value;
                arr = newArr;
            }

        }
    }
}
