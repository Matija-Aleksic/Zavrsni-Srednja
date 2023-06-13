using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoZaSort
{
    class InsertionSort : Vrijednost
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

            IntArrayInsertionSort(RandArray);
        }

        public static void IntArrayInsertionSort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = 1; j < N; j++)
            {
                for (i = j; i > 0 && data[i] < data[i - 1]; i--)
                {
                    swap(i, i - 1);
                }
            }
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
