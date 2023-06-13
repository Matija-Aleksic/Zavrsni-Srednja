using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoZaSort
{
    class RadixSort : Vrijednost
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

            RadixSortAlgoritam(RandArray);
        }

        static void RadixSortAlgoritam(int[] data)
        {
            int i, j;
            int[] tmp = new int[data.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < data.Length; ++i)
                {
                    bool move = (data[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                    {
                        data[i - j] = data[i];
                        DrawBar(i-j,data[i-j]);
                    }
                    else
                    {
                        tmp[j++] = data[i];
                    }
                }
                Array.Copy(tmp, 0, data, data.Length - j, j);
            }
        }

        private static void DrawBar(int i, int p)
        {
            s.FillRectangle(BlackBrush, i, 0, 1, MaxVrijednost); 
            s.FillRectangle(WhiteBrush, i, MaxVrijednost - p, 1, MaxVrijednost);
        }
    }
}
