using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgoZaSort
{
    public partial class Form1 : Form
    {
     
        int[] RandArray;
        Graphics s;
        
        public Form1()
        {
            InitializeComponent();
            this.Resize += Form1_Resize; //za otkrivanje i automatski refresh grafa i n, poziva funkciju Form1_Resize za to
        }

        void Form1_Resize(object sender, EventArgs e)//refresha n i ponovo crta random graf, da se automatski graf prilaogdi veličini panela
        {
            label1.Text = Convert.ToString(panel1.Width);
            crtanje_graf();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(panel1.Width);//stavljamo da se odmah label refresha pri pocetku, bez njega samo nam pise label1
        }

        private void butReset_Click(object sender, EventArgs e)//manualni reset grafa ako ne želimo mijnjati n
        {
            crtanje_graf();
        }

        private void crtanje_graf()
        {
            label1.Text = Convert.ToString(panel1.Width);
            s = panel1.CreateGraphics();
            int n = panel1.Width;
            int MaxVrijednost = panel1.Height;
            RandArray = new int[n];
            s.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.Black), 0, 0, n, MaxVrijednost); //popunjavanje panela crnom bojom
            Random rand = new Random();
            for (int i = 0; i < n; i++)//upisivanje radnom vrijednosti u array
            {
                RandArray[i] = rand.Next(0, MaxVrijednost);
            }
            for (int i = 0; i < n; i++)//crtanje RandArraya na pannel1
            {
                s.FillRectangle(new System.Drawing.SolidBrush(System.Drawing.Color.White), i, MaxVrijednost - RandArray[i], 1, MaxVrijednost);
            }
        }

        //pozivanje sortiranja
        private void butStart_Click(object sender, EventArgs e)
        {
            Vrijednost bs = new BubbleSort();
            bs.Vrijednosti(RandArray, s, panel1.Height);
        }

        private void ButQS_Click(object sender, EventArgs e)
        {
            Vrijednost qs = new QuickSort();
            qs.Vrijednosti(RandArray, s, panel1.Height);
        }

        private void butSS_Click(object sender, EventArgs e)
        {
            Vrijednost ss = new ShellSort();
            ss.Vrijednosti(RandArray, s, panel1.Height);
        }

        private void butIS_Click(object sender, EventArgs e)
        {
            Vrijednost Isort = new InsertionSort();
            Isort.Vrijednosti(RandArray, s, panel1.Height);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vrijednost Selsort = new SelectionSort();
            Selsort.Vrijednosti(RandArray, s, panel1.Height);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Vrijednost rs = new RadixSort();
            rs.Vrijednosti(RandArray, s, panel1.Height);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Vrijednost cs = new CountingSort();
            cs.Vrijednosti(RandArray, s, panel1.Height);
        }       
    }
}
