using System;

namespace _8LAB
{
    public partial class Form1 : Form
    {
        int[] a = new int[1000];
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;
            string spisok;
            spisok = "";
            n = Convert.ToInt32(textBox1.Text);
            listBox1.Text = ""; //очистка списка
            label4.Text = ""; //очистка метки
            for (i = 1; i <= n; i++)
            {
                a[i] = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Ai=", "Enter array", ""));
                listBox1.Items.Add(a[i]); //добавление в listbox1
                spisok = spisok + Convert.ToString(i) + ") " +
               Convert.ToString(a[i]) + " " + Environment.NewLine; //для Label7
            }
            label6.Text = spisok;

        }

        private void label3_Click(object sender, EventArgs e)
        {
            int i, n, p;
            double s, sr;
            s = 0;
            p = 0;
            n = Convert.ToInt32(textBox1.Text);
            for (i = 1; i <= n; i++) 
            {
                if (a[i] > 0) { s = s + a[i]; p++; }
            }
            sr = s / p;
            label4.Text = "Ср. величина \r\nположительных элементов =\r\n " +
           Convert.ToString(sr);//вывод ср.ар. значения
        }
    }
}