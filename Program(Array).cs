using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            تمرین 1 : "یک عدد خاص در ارایه وجود دارد یا نه"

            int[] number = new int[] {1,2,3,4,5,6,7,8,9,10 };

            Console.WriteLine("please enter Your NUmber :");
            int entry = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number.Length; i++)
            {
                if (entry == i)
                {
                    Console.WriteLine("Array Entkhbi shoma :" + i);
                }
            }
            Console.ReadKey();
            */



            /*
             حذف یک عدد از آرایه : تمرین 2
            int[] Array = { 3, 7, 2, 8, 2, 9, 2 };
            int n = Array.Length;

            Console.Write("Enter Your Number :");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                if (Array[i] == num)
                {
                    for (int j = i; j < n - 1; j++)
                    {
                        Array[j] = Array[j + 1];
                    }
                    n--;
                    i--;
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(Array[i] + " ");
            }


            Console.ReadKey();
             */





            /*
             کپی کردن یک ارایه در ارایه دیگر : تمرین 3
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            int[] CoPY = new int[Array.Length] ;

            for (int i = 0; i < Array.Length; i++)
            {
                CoPY[i] = Array[i];
                Console.WriteLine(CoPY[i]);
            }
            Console.ReadKey();
            */



            /*
           یک عدد را در مکان مورد نظر آرایه درج نماید : تمرین 4
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };

            Console.WriteLine("please Enter Your number :");
            int Target = int.Parse(Console.ReadLine()) - 1;

            int Number = 3;

            Array[Target] = Number;

            for (int i = 0; i < Array.Length; i++)
            {
               
                Console.WriteLine(Array[i]);
            }
            Console.ReadKey();
             */


            /*
          مقادیر تکراری دو عدد در  یک آرایه : تمرین 5
            

            int[] Array = new int[7] { 1, 2, 3, 4, 5 , 3 , 2 };
            Console.WriteLine("Duplicate Value :");
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] == Array[j])
                    {
                        Console.WriteLine(Array[i]);
                    
                    }
                }
            }
            Console.ReadKey();
            */







            /*
             مقادیر تکراری دو عدد در آرایه : تمرین 6
             
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            int[] Second = new int[5] { 5, 6, 7, 8, 3 };

            for (int i = 0; i < Array.Length; i++)
            {
                for (int J = 0; J < Second.Length; J++)
                {
                    if (Array[i] == Second[J])
                    {
                        Console.WriteLine("Duplicate Value :" + Array[i]);
                    }
                }
            }
            Console.ReadKey();
            */





            /*
              حذف مقادیر تکراری یک آرایه : تمرین 7
            int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
            int n = arr.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        for (int k = j; k < n - 1; k++)
                        {
                            arr[k] = arr[k + 1];
                        }
                        n--;
                        j--;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
              */





            /*
             چک کردن برابری دو آرایه : تمرین 8
            int[] Array = new int[5] { 1, 2, 3, 4, 5 };
            int[] Second = new int[5] { 1, 2, 3, 4, 5 };

            bool equal = true;

            if (Array.Length != Second.Length)
            {
                equal = false;
            }
            else
            {
                for (int i = 0; i < Array.Length; i++)
                {
                    if (Array[i] != Second[i])
                    {
                        equal = false;
                        break;
                    }
                }
            }

            if (equal)
            {
                Console.WriteLine("The values are different.");
            }
            else
            {
                Console.WriteLine("The values are equal.");
            }

            Console.ReadKey();
            */




            /*
             صفرها را به انتهای آرایه منتقل کن : تمرین 9
            int[] Array = new int[7] { 1, 2, 0, 3, 4, 0, 5 };
            int N = Array.Length;
            int Index = 0;

            for (int i = 0; i < N; i++)
            {
                if (Array[i] != 0)
                {
                    Array[Index] = Array[i];
                    Index++;
                }
            }

            while (Index < N)
            {
                Array[Index] = 0;
                Index++;
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(Array[i] + " ");
            }


            Console.ReadKey();
        }
              */





            /*
             شیفت خلاف جهت عقربه‌های ساعت : تمرین 10
           int[] arr = { 1, 2, 3, 4, 5 };
           int temp = arr[0];

           for (int i = 0; i < arr.Length - 1; i++)
           {
               arr[i] = arr[i + 1];
           }

           arr[arr.Length - 1] = temp;

           for (int i = 0; i < arr.Length; i++)
           {
               Console.Write(arr[i] + " ");
           }

           Console.ReadKey();
             */



            /*
             منفی‌ها سمت چپ، مثبت‌ها سمت راست : تمرین 11
        int[] Array = { -1, 2, -3, 4, 5, -6 };
        int[] Result = new int[Array.Length];
        int Index = 0;

        for (int I = 0; I < Array.Length; I++)
        {
            if (Array[I] < 0)
            {
                Result[Index] = Array[I];
                Index++;
            }
        }

        for (int I = 0; I < Array.Length; I++)
        {
            if (Array[I] >= 0)
            {
                Result[Index] = Array[I];
                Index++;
            }
        }

        for (int I = 0; I < Result.Length; I++)
        {
            Console.Write(Result[I] + " ");
        }

        Console.ReadKey();
             */




        }
    }
}

