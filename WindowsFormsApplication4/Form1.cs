using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masslovo = textBox1.Text;
            char[] mas = new char[16];
            //textBox1.Text += Convert.ToString(mas2.Length);

            /*for (int i = 0; i < mas2.Length; i++)
            {
                textBox1.Text += mas2[i]+"-";
            }*/
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < 4; i++)
                {
                    mas[j*4+i] = Convert.ToChar(masslovo[j*6+i]);
                }
            }
            int[] mas1 = new int[4];
            int[] mas2 = new int[4];
            int[] mas3 = new int[4];
            int[] mas4 = new int[4];

            mas1[0] = 0;
            mas1[1] = 3;
            mas1[2] = 15;
            mas1[3] = 12;
            mas2[0] = 1;
            mas2[1] = 7;
            mas2[2] = 14;
            mas2[3] = 8;
            mas3[0] = 2;
            mas3[1] = 11;
            mas3[2] = 13;
            mas3[3] = 4;
            mas4[0] = 5;
            mas4[1] = 6;
            mas4[2] = 10;
            mas4[3] = 9;
            int[] mas_slovo = new int[4];
            int count = 0;
            for (int k = 0; k < 4; k++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int ki = k + i;
                            if (ki > 3)
                                ki = ki % 4;
                            int ji = j + i;
                            if (ji > 3)
                                ji = ji % 4;
                            int mi = m + i;
                            if (mi > 3)
                                mi = mi % 4;
                            mas_slovo[0] = mas1[i];
                            mas_slovo[1] = mas2[ki];
                            mas_slovo[2] = mas3[mi];
                            mas_slovo[3] = mas4[ji];
                            int temp;
                            for (int b = 0; b < 3; b++)
                            {
                                for (int n = b + 1; n < 4; n++)
                                {
                                    if (mas_slovo[b] > mas_slovo[n])
                                    {
                                        temp = mas_slovo[b];
                                        mas_slovo[b] = mas_slovo[n];
                                        mas_slovo[n] = temp;
                                    }
                                }
                            }
                            for (int b = 0; b < 4; b++)
                                textBox2.Text += mas[mas_slovo[b]];
                            textBox2.Text += " ";
                            count++;
                            if(count%60==0)
                                textBox2.Text += "\r\n";
                        }
                        textBox2.Text += "|";
                    }
                }
            }
            /*
            for (int k = 0; k < 4; k++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int ki = k + i;
                            if (ki > 3)
                                ki = ki % 4;
                            int ji = j + i;
                            if (ji > 3)
                                ji = ji % 4;
                            int mi = m + i;
                            if (mi > 3)
                                mi = mi % 4;
                            mas_slovo[0] = mas1[i];
                            mas_slovo[1] = mas2[ki];
                            mas_slovo[2] = mas4[mi];
                            mas_slovo[3] = mas3[ji];
                            int temp;
                            for (int b = 0; b < 3; b++)
                            {
                                for (int n = b + 1; n < 4; n++)
                                {
                                    if (mas_slovo[b] > mas_slovo[n])
                                    {
                                        temp = mas_slovo[b];
                                        mas_slovo[b] = mas_slovo[n];
                                        mas_slovo[n] = temp;
                                    }
                                }
                            }
                            for (int b = 0; b < 4; b++)
                                textBox2.Text += mas[mas_slovo[b]];
                            textBox2.Text += " ";
                            count++;
                            if (count % 60 == 0)
                                textBox2.Text += "\r\n";
                        }
                        textBox2.Text += "|";
                    }
                }
            }
            for (int k = 0; k < 4; k++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int ki = k + i;
                            if (ki > 3)
                                ki = ki % 4;
                            int ji = j + i;
                            if (ji > 3)
                                ji = ji % 4;
                            int mi = m + i;
                            if (mi > 3)
                                mi = mi % 4;
                            mas_slovo[0] = mas1[i];
                            mas_slovo[1] = mas3[ki];
                            mas_slovo[2] = mas2[mi];
                            mas_slovo[3] = mas4[ji];
                            int temp;
                            for (int b = 0; b < 3; b++)
                            {
                                for (int n = b + 1; n < 4; n++)
                                {
                                    if (mas_slovo[b] > mas_slovo[n])
                                    {
                                        temp = mas_slovo[b];
                                        mas_slovo[b] = mas_slovo[n];
                                        mas_slovo[n] = temp;
                                    }
                                }
                            }
                            for (int b = 0; b < 4; b++)
                                textBox2.Text += mas[mas_slovo[b]];
                            textBox2.Text += " ";
                            count++;
                            if (count % 60 == 0)
                                textBox2.Text += "\r\n";
                        }
                        textBox2.Text += "|";
                    }
                }
            }
            for (int k = 0; k < 4; k++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int ki = k + i;
                            if (ki > 3)
                                ki = ki % 4;
                            int ji = j + i;
                            if (ji > 3)
                                ji = ji % 4;
                            int mi = m + i;
                            if (mi > 3)
                                mi = mi % 4;
                            mas_slovo[0] = mas1[i];
                            mas_slovo[1] = mas3[ki];
                            mas_slovo[2] = mas4[mi];
                            mas_slovo[3] = mas2[ji];
                            int temp;
                            for (int b = 0; b < 3; b++)
                            {
                                for (int n = b + 1; n < 4; n++)
                                {
                                    if (mas_slovo[b] > mas_slovo[n])
                                    {
                                        temp = mas_slovo[b];
                                        mas_slovo[b] = mas_slovo[n];
                                        mas_slovo[n] = temp;
                                    }
                                }
                            }
                            for (int b = 0; b < 4; b++)
                                textBox2.Text += mas[mas_slovo[b]];
                            textBox2.Text += " ";
                            count++;
                            if (count % 60 == 0)
                                textBox2.Text += "\r\n";
                        }
                        textBox2.Text += "|";
                    }
                }
            }
            for (int k = 0; k < 4; k++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int ki = k + i;
                            if (ki > 3)
                                ki = ki % 4;
                            int ji = j + i;
                            if (ji > 3)
                                ji = ji % 4;
                            int mi = m + i;
                            if (mi > 3)
                                mi = mi % 4;
                            mas_slovo[0] = mas1[i];
                            mas_slovo[1] = mas4[ki];
                            mas_slovo[2] = mas2[mi];
                            mas_slovo[3] = mas3[ji];
                            int temp;
                            for (int b = 0; b < 3; b++)
                            {
                                for (int n = b + 1; n < 4; n++)
                                {
                                    if (mas_slovo[b] > mas_slovo[n])
                                    {
                                        temp = mas_slovo[b];
                                        mas_slovo[b] = mas_slovo[n];
                                        mas_slovo[n] = temp;
                                    }
                                }
                            }
                            for (int b = 0; b < 4; b++)
                                textBox2.Text += mas[mas_slovo[b]];
                            textBox2.Text += " ";
                            count++;
                            if (count % 60 == 0)
                                textBox2.Text += "\r\n";
                        }
                        textBox2.Text += "|";
                    }
                }
            }
            for (int k = 0; k < 4; k++)
            {
                for (int m = 0; m < 4; m++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            int ki = k + i;
                            if (ki > 3)
                                ki = ki % 4;
                            int ji = j + i;
                            if (ji > 3)
                                ji = ji % 4;
                            int mi = m + i;
                            if (mi > 3)
                                mi = mi % 4;
                            mas_slovo[0] = mas1[i];
                            mas_slovo[1] = mas4[ki];
                            mas_slovo[2] = mas3[mi];
                            mas_slovo[3] = mas2[ji];
                            int temp;
                            for (int b = 0; b < 3; b++)
                            {
                                for (int n = b + 1; n < 4; n++)
                                {
                                    if (mas_slovo[b] > mas_slovo[n])
                                    {
                                        temp = mas_slovo[b];
                                        mas_slovo[b] = mas_slovo[n];
                                        mas_slovo[n] = temp;
                                    }
                                }
                            }
                            for (int b = 0; b < 4; b++)
                                textBox2.Text += mas[mas_slovo[b]];
                            textBox2.Text += " ";
                            count++;
                            if (count % 60 == 0)
                                textBox2.Text += "\r\n";
                        }
                        textBox2.Text += "|";
                    }
                }
            }
            //textBox2.Text += Convert.ToString(mas[0])+Convert.ToString(mas[9])+Convert.ToString(mas[14])+Convert.ToString(mas[3])+Convert.ToString(mas[5])+Convert.ToString(mas[8])+Convert.ToString(mas[1])+Convert.ToString(mas[6])+Convert.ToString(mas[15])+ Convert.ToString(mas[7])+Convert.ToString(mas[10])+Convert.ToString(mas[12]);//+mas[9]+mas[14] + mas[3] + mas[5] + mas[8] + mas[1] + mas[6] + mas[15] + mas[7] + mas[10] + mas[12]);
        */}
    }
}
