﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    internal class UniqueElements
    {
        static public void elements()
        {
            int[] items = { 2, 3, 5, 3, 7, 5 };
            int n = items.Length;

            Console.WriteLine("Unique array elements: ");

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (items[i] == items[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(items[i]);

                }
            }

            Console.ReadLine();
        }
    }
    }

