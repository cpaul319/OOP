//extra credit


using System;
class extraCredit
{
    static void Main(string[] args)
    {
        for (int i = 1; i <= 10; ++i)
        {
            {
                for (int j = 1; j <= i; ++j)

                    Console.Write("*");

                Console.WriteLine();
            }

            Console.Write("*");


            for (int l = 0; l > 10; ++l)
            {
                for (int j = 0; j < i; ++j)
                {
                    Console.Write("*");
                }
                { Console.WriteLine(); }




            }
        }
    }
}
