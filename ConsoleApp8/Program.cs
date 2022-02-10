using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
           
            // Есть массив целых чисел. 
            // Числа могут повторяться. 
            // Выбрать все числа массива не имеющие пары.
            

            int[] ar0 = new int[] {0, 0, 1, 2, 5 };
            List<int> save = new List<int>();
           
            
            bool flag = false;

            for (int i = 0; i < ar0.Length-1; i++)
            {
                for (int j = 0; j < ar0.Length; j++)
                {
                    if (ar0[i] == ar0[j] && i !=j)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag !=true)
                {
                    save.Add(ar0[i]);
                }
                flag = false;
            }

            var Rez  = ar0
                             .GroupBy(x => x)
                             .Where(g => g.Count() == 1);
                           
            foreach (var item in Rez)
            {
                Console.WriteLine($"Mass " + (item.Key));
            }
        }

        //Ответ на 2 задание 
        //----------------------
        //SELECT * 
        //FROM EMPLOYEE AS chief
        //INNER JOIN EMPLOYEE AS empl ON chief.ID = empl.CHIEF_ID
        //WHERE empl.SALARY > chief.SALARY
        //----------------------
    }
}
