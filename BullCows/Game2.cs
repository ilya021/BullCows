using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BullCows
{
    public class Game2
    {
        public int cow, bull, c;
        public int[] num2 = new int[4];
        public int[] num2_1 = new int[4];
        public int[] num2_2 = new int[4];

        public void CheckBullCow()
        {
            int t, q = 0;
            c = 0;
            for (int i = 1; i < 10; i++)
            {
                bull = 0;
                for (int j = 0; j < 4; j++)
                {
                    num2_1[j] = i;
                }

                for (int l = 0; l < 4; l++)
                {
                    if (num2[l] == num2_1[l])
                    {
                        bull++;
                    }
                }
                c++;

                if (bull != 0)
                {
                    num2_2[q] = i;
                    q++;
                }

                if (bull == 4)
                {
                    break;
                }

            };

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    c++;
                    cow = 0;
                    if ((num2[i] == num2_2[j]) && (i != j))
                    {
                        cow++;
                    }

                    if (cow!=0)
                    {
                        t = num2_2[i];
                        num2_2[i] = num2_2[j];
                        num2_2[j] = t;
                        break;
                    }
                }
            }
        }
    }
}
