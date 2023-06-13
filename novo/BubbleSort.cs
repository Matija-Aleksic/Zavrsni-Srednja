using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoZaSort
{
    class BubbleSort : Vrijednost
    { 
        //kopije potrebnih vrijednosti
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

            Bubble_Sort(RandArray);
        }

        public static void Bubble_Sort(int[] data)
        {
            int i, j;
            int N = data.Length;

            for (j = N - 1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i] > data[i + 1])
                        swap(i, i + 1);
                }
            }
        }

        private static void swap(int i, int p)//funkcija za swichanje mjesta i poivanje crtanja
        {
            int t = RandArray[i];
            RandArray[i] = RandArray[p];
            RandArray[p] = t;

            DrawBar(p, RandArray[p]);
            DrawBar(i, RandArray[i]);
        }
        private static void DrawBar(int i, int p)//crtanje_graf kod switcha
        {
            s.FillRectangle(BlackBrush, i , 0, 1, MaxVrijednost);                 //brise stupic
            s.FillRectangle(WhiteBrush, i , MaxVrijednost - p, 1 , MaxVrijednost);//crta stupic
        }
    }
}
