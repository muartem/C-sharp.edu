using System;

namespace HW2._5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int resolution = 18;
            int tree = resolution / 2;
            int branch = 3;
            
            //////////////////   ZZZZZZZZZZZZZZZZ
            
            Line(resolution, "#");
            for (int i = 1; i < resolution; i++)
            {
                for (int j = 0; j < resolution; j++)
                {
                    if (i == resolution - j)
                    {
                        Console.Write("#");
                    }

                    Console.Write(" ");
                }



                Console.WriteLine();
            }

            Line(resolution, "#");
            Console.WriteLine();

            ///////////////   NNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNNN
            
            
            for (int i = 0; i <= resolution; i++)
            {
                Console.Write("#");
                for (int j = 0; j < resolution; j++)
                {
                    if (i == j)
                    {
                        Console.Write("#");
                    }

                    Console.Write(" ");
                }

                Console.Write("#");

                Console.WriteLine();
            }


            Console.WriteLine();
            Console.WriteLine();
            ///////////////////// X-mas tree

            for (int k = 0; k < branch; k++){
                for (int i = tree - tree / 3; i <= tree; i++)
                {
                    for (int j = 0; j < tree; j++)
                    {
                        if (j == (tree - i) * 3)
                        {
                            Console.Write("#");
                        }

                        Console.Write(" ");
                    }

                    Console.Write("#");
                    for (int j = 0; j <= tree; j++)
                    {
                        if (j == (i - 2*tree/3) * 3)
                        {
                            Console.Write("#");
                        }

                        Console.Write(" ");
                    }


                    Console.WriteLine();
                }

                Line(resolution + 2, "#"); 
            }

            for (int i = tree - tree / 2; i <= tree; i++)
            {
                for (int j = 0; j < tree-1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("#####");
            }


            //delay
            Console.ReadKey();

        }
        
        
        
        
        
        
        

        private static void Line(int r, string s)
        {
            for (int i = 0; i <= r; i++)
            {
                Console.Write(s);
            }
            
            Console.WriteLine();
        }
    }
}