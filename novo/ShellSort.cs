using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoZaSort
{
    class ShellSort : Vrijednost
    {
        private static int[] RandArray;
        private static Graphics s;
        private static int MaxVrijednost;
        static Brush WhiteBrush = new System.Drawing.SolidBrush(System.Drawing.Color.White);
        static Brush BlackBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);


        public void Vrijednosti(int[] RandArrayIN, Graphics sIN, int MaxVrijdnostIN)
        {
            RandArray = RandArrayIN;
            s = sIN;
            MaxVrijednost = MaxVrijdnostIN;

            int[] intervali = GenerateIntervals(RandArray.Length);

            IntArrayShellSort(RandArray, intervali);
        }

        public static void IntArrayShellSort(int[] data, int[] intervals)
        {
            int i, j, k, m;
            int N = data.Length;

            for (k = intervals.Length - 1; k >= 0; k--)
            {
                int interval = intervals[k];
                for (m = 0; m < interval; m++)
                {
                    for (j = m + interval; j < N; j += interval)
                    {
                        for (i = j; i >= interval && data[i] < data[i - interval]; i -= interval)
                        {
                            swap( i, i - interval);
                        }
                    }
                }
            }
        }

        static int[] GenerateIntervals(int n)
        {
            int t = Math.Max(1, (int)Math.Log(n, 3) - 1);
            int[] intervals = new int[t];
            intervals[0] = 1;
            for (int i = 1; i < t; i++)
                intervals[i] = 3 * intervals[i - 1] + 1;
            return intervals;
        }

        private static void swap(int i, int j)
        {
            int t = RandArray[i];
            RandArray[i] = RandArray[j];
            RandArray[j] = t;

            DrawBar(j, RandArray[j]);
            DrawBar(i, RandArray[i]);
        }

        private static void DrawBar(int i, int p)
        {
            s.FillRectangle(BlackBrush, i, 0, 1, MaxVrijednost);    
            s.FillRectangle(WhiteBrush, i, MaxVrijednost - p, 1, MaxVrijednost);
        }

    }
}
