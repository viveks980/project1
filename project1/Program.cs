using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    internal class Demo
    {
        /*int x = 50;
        int y = 55;
        char c = 'a';
        double d = 4.562D;
        string s = "Any Name"; */ 
        
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Enter Your Age : ");
                int age = Convert.ToInt32(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("You Are Eligible For Vote...!!!");
                }
                else
                {
                    Console.WriteLine("You Are Not Eligible For Vote...!!!");
                }


            }








            /*  Demo demo = new Demo();
               Console.WriteLine(demo.x + demo.y);
               Console.WriteLine(demo.c);
               Console.WriteLine(demo.d);
               Console.WriteLine(demo.s); 
               Console.WriteLine("Enter Your Username : ");
               string UserName=Console.ReadLine();

               Console.WriteLine("UserName Is : " + UserName); 

            Console.WriteLine("======Enter Your Result==== ");
            Console.WriteLine("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter First Subject number : ");
            int sub1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Subject Number : ");
            int sub2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third Subject Number : ");
            int sub3 = Convert.ToInt32(Console.ReadLine());
            int total = sub1 + sub2 + sub3;
            Console.WriteLine("========RESULT========");
            Console.WriteLine("Name  :  " + name.ToUpper());

            Console.WriteLine(" First Subject Number Is :  "+sub1);
            Console.WriteLine(" Second Subject Number Is :  " + sub2);
            Console.WriteLine(" Third Subject Number Is :  " + sub3);


            Console.WriteLine("The total Is : " + total);
            Console.WriteLine("Your Percentage Is :  " + (total/3) + "%");
            if ((total / 3) >= 33)
            {
                Console.WriteLine("Congratulations " +name+" You are Pass ...Your percentage is : " + (total / 3) + "%");
            }
            else
            {
                Console.WriteLine("You Are Fail...!!!");
            }*/






        }
    }
}
