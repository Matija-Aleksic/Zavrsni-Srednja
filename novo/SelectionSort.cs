using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoZaSort
{
    class SelectionSort : Vrijednost
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

            IntArraySelectionSort (RandArray);
        }

        public static int IntArrayMin(int[] data, int start)
        {
            int minPos = start;
            for (int pos = start + 1; pos < data.Length; pos++)
                if (data[pos] < data[minPos])
                    minPos = pos;
            return minPos;
        }

        public static void IntArraySelectionSort(int[] data)
        {
            int i;
            int N = data.Length;

            for (i = 0; i < N - 1; i++)
            {
                int k = IntArrayMin(data, i);
                if (i != k)
                    swap(i, k);
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
