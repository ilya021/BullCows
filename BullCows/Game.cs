using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullCows
{
    public class Game
    {
        public int cow, bull;
        public int[] num = new int[4];
        public int[] num1 = new int[4];

        public void CheckBullCow()
        {
            bull = 0;
            cow = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (num[i] == num1[j])
                    {
                        if (i == j)
                            bull++;
                        else
                            cow++;
                    }
                }
            }
            Console.WriteLine("Быки: "  + bull);
            Console.WriteLine("Коровы: "  + cow);
            
        }
    }
}
