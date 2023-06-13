using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoZaSort
{
    class CountingSort : Vrijednost
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

            countingsort(RandArray);
        }


        static void countingsort(int[] data)
        {
            int n = data.Length;
            int max = 0;
            for (int i = 0; i < n; i++)
            {
                if (max < data[i])
                {
                    max = data[i];
                }
            }

            int[] frek = new int[max + 1];
            for (int i = 0; i < max + 1; i++)
            {
                frek[i] = 0;
            }
            for (int i = 0; i < n; i++)
            {
                frek[data[i]]++;
            }

            for (int i = 0, j = 0; i <= max; i++)
            {
                while (frek[i] > 0)
                {
                    data[j] = i;
                    DrawBar(j, data[j]);
                    j++;
                    frek[i]--;
                }
            }
        }

        private static void DrawBar(int i, int p)
        {
            s.FillRectangle(BlackBrush, i, 0, 1, MaxVrijednost);
            s.FillRectangle(WhiteBrush, i, MaxVrijednost - p, 1, MaxVrijednost);
        }
    }
}
