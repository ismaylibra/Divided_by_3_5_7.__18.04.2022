﻿using System;

namespace Arrayy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eded daxil edin: ");
            int num = Convert.ToInt32(Console.ReadLine());
            ;
            if (num<=50)
            {
                Console.Write("3-e bolunen ededler: ");
                for (int i = 0; i < num; i++)
                { 
                   


                    if (i%3==0)
                        
                    { int num3Size = (num/ 3)+1;
                        int[] num3 = new int[num3Size];
                        Console.Write(i+" ");
                    }
                }
            }
            if (num>50 && num<=100)
            {
                Console.Write("5- bolunen ededler: ");

                for (int i = 0; i < num; i++)
                {



                    if (i % 5 == 0)

                    {
                        int num5Size = (num / 5) + 1;
                        int[] num3 = new int[num5Size];

                        Console.Write(i + " ");
                    }
                }
            }
            if (num>100)
            {
                 Console.Write("8-e bolunen ededler: ");
                for (int i = 0; i < num; i++)
                {



                    if (i % 8 == 0)

                    {
                        int num8Size = (num / 8) + 1;
                        int[] num3 = new int[num8Size];
                        Console.Write(i + " ");
                    }
                }
            }

        }
    } }
