using System;



namespace FromA2B

{

    class Program

    {



        static void Main(string[] args)

        {

            string line;



            string holder = (" ");



            line = Console.ReadLine();



            holder = line;



            string[] split = holder.Split(' ');



            int[] aandb = Array.ConvertAll(split, x => int.Parse(x));



            int a = (int)aandb.GetValue(0);



            int b = (int)aandb.GetValue(1);



            int operations = 0;



            while (a != b)

            {

                if (a < b)

                {

                    a++;

                    operations++;

                }

                else if (a > b && a % 2 == 0)

                {

                    a = a / 2;

                    operations++;

                }

                else if (a > b && a % 2 == 1)

                {

                    a++;

                    operations++;

                }

            }



            Console.WriteLine(operations);

        }

    }

}


rs
