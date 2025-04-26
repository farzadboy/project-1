using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* کوچکترین عدد از بین 20
              Console.WriteLine("please enter 20 numbers :");
              int Num = int.Parse(Console.ReadLine());

              for (int i = 0; i < 19; i++)
              {
                  int Entry = int.Parse(Console.ReadLine());

                  if (Num > Entry)
                  {
                      Num = Entry;
                  }
              }
              Console.WriteLine("OutPut :" + Num);
              Console.ReadKey(); */



            /* بزرگترین عدد از بین 20
            Console.WriteLine("please enter 20 numbers :");
            int Num = int.Parse(Console.ReadLine());

            for (int i = 0; i < 19; i++)
            {
                int Entry = int.Parse(Console.ReadLine());

                if (Num < Entry)
                {
                    Num = Entry;
                }
            }
            Console.WriteLine("OutPut :" + Num);
            Console.ReadKey(); 
             */





            /*
            میانگین 20 تا عدد
            int sum = 0, avg = 0;
            for (int i = 1; i < 21; i++)
            {
            Console.WriteLine("please enter your numbers :");
            int entry = int.Parse(Console.ReadLine());

            sum += entry;
            avg = sum / i;
            }
            Console.WriteLine("output :" + avg);

            Console.ReadKey();
            */





            
            /*
             
             بیست عدد رو خوانده عددی که رقم سمت راستش 5 هست .
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("please enter 20 Numbers :");
                int entry = int.Parse(Console.ReadLine());

                if (entry % 10 == 5)
                {
                    Console.WriteLine("out put :" + entry);
                }
                Console.ReadKey();
                */




            /*
           فاکتوریل
            Console.WriteLine("please enter your number :");
            int entry = int.Parse(Console.ReadLine());
            int F = 1;

            for (int i = 1; i <= entry; i++)
			{
			 F = F * i;
                
			}

            Console.WriteLine("OutPut :" + F);
            Console.ReadKey();
            */


            /*
            تعداد ارقام یک عدد
            Console.WriteLine("enter your number:");
            int entry = int.Parse(Console.ReadLine());
            int shomarsh = 0;

            while (entry > 0)
            {
                shomarsh++;
                entry = entry / 10;
          
            }
            Console.WriteLine(shomarsh);

            Console.ReadKey();
             */






            /*
             عدد اول
            Console.WriteLine("enter your number :");
            int entry = int.Parse(Console.ReadLine());

            if (entry % 2 == 1)
            {
                Console.WriteLine(entry + "  is aval");
            }
            else
            {
                Console.WriteLine("number is not aval");
            }
            Console.ReadKey();
              */






            /*
             * اعداد اول از بین 1 تا 1000
            for (int i = 0; i < 1000; i++)
            {
                if (i % 2 == 1)
            {
                Console.WriteLine(i + "  is aval");
            }
            
            }
            Console.ReadKey();
              */





            /*
             * قرینه اعداد چهار رقمی
            for (int i = 1000; i < 9999; i++)
            {
                string a = i.ToString();
                if (a[0] == a[3] && a[1] == a[2] )
                {
                    Console.WriteLine(i);
                }

            }
              Console.ReadKey();
             */







            /*
             برنامه حاصل زوج جمع و فرد تفریق
            Console.WriteLine("enter your number :");
            int entry = int.Parse(Console.ReadLine());
            int sum = 1;
            for (int i = 2; i <= entry; i++)
            {
                if (i % 2 ==0)
                {
                    sum += i;  
                }
                else
                {
                    sum -= i;
                }
                    
            }
            Console.WriteLine(sum);
            Console.ReadKey();
            */






            /*
             کلیه مقسوم علیه ها به همراه جمع و تعدادش
            Console.WriteLine("enter your Number :");
            int enrty = int.Parse(Console.ReadLine());
            int sum = 0, numbers =0;

            for (int i = 1; i < enrty; i++)
            {
                if (enrty % i== 0)
                {
                    sum += i;
                    numbers++;
                    Console.WriteLine("maghsom :"+ i);
                }
                
            }
            Console.WriteLine("jame adad : " + sum);
            Console.WriteLine("tedad : "+numbers);
            Console.ReadKey();
            */




            /*
             چندمین روز سال
            Console.WriteLine("enter month :");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("enter day :");
            int day = int.Parse(Console.ReadLine());

            month = month * 30;

            int date = month + day;

            Console.WriteLine(date+"/365");
            Console.ReadKey();
            */







            /*
             بزرگترین مسقوم علیه دو عدد
            Console.WriteLine("two number :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int A = 0, B = 0;

            for (int i = 1; i < a; i++)
            {
                if (a % i == 0)
                {
                    A = i;
                }
                for (int c = 1; c < b; c++)
                {

                    if (b % c == 0)
                    {
                        B = c;
                    }
                }
            }
            Console.WriteLine("first number :" + A);
            Console.WriteLine("second number :" + B);
            Console.ReadKey();
            */



            /*
             مجموع ارقام یک عدد
            Console.WriteLine("enter your number:");
            int entry = int.Parse(Console.ReadLine());
            int sum = 0;

            while (entry > 0)
            {
                int a = entry % 10;
                entry = entry / 10;
                sum += a;

            }
            Console.WriteLine(sum);

            Console.ReadKey();
             */






            /*
             حقوق و ساعت کاری
            Console.WriteLine("enter your name :");
            string name = Console.ReadLine();

            Console.WriteLine("enter your time for JOP :");
            int time = int.Parse(Console.ReadLine());

            Console.WriteLine("enter your income");
            int salary = int.Parse(Console.ReadLine());

            int income = salary * time;

            Console.WriteLine(name +":"+income);

            Console.ReadKey();
            */

            /*
            int a = 2;
           
            while (a <= 1000)
            {
                Console.WriteLine(a);
                a += 2; 
            }
            Console.ReadKey();
            */





            /*
             مضرب 9
            int a = 9;
           
            while (a <= 1000)
            {
                Console.WriteLine(a);
                a += 9; 
            }
            Console.ReadKey();
            */






            /*
             * دو عدد صحیح را دریافت و مضارب 3 بین عدد
            Console.WriteLine("enter your number :");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
           
            for (int i = a; i< b; i++)
            {
                if (i  % 3 == 0)
                {
                    Console.WriteLine(i);
                }
              
            }
            Console.ReadKey();
             */









            /*
             مجموع ارقام قابل تقسیم
            int sum = 0;
            Console.WriteLine("enter your number:");
            int number = int.Parse(Console.ReadLine());
            int shomarnde = number;
            while (shomarnde > 0)
            {
                sum += shomarnde % 10;
                shomarnde /= 10;
            }
            
            if (number % sum == 0)
            {
                Console.WriteLine("ghable taghsim ast");
            }
            else
            {
                Console.WriteLine("gable thghsim nist");
            }

            Console.ReadKey();
            */


        }

    }
}
