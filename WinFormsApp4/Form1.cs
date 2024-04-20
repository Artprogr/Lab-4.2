using System.IO;
using System.Linq.Expressions;

namespace WinFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (StreamWriter streamWriter = File.CreateText(@"C:\Тусур\11 лабораторная\Train.txt"))
            {
                string[] number = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
                Random.Shared.Shuffle(number);
                string[] punkt = { "Томск", "Москва", "Красноярск", "Владивосток", "Санкт-Петербург", "Краснодар", "Новосибирск", "Ростов-на-Дону", "Волгоград", "Сочи" };
                Random.Shared.Shuffle(punkt);
                string[] time = { "19.00", "5.30", "8.20", "1.40", "15.45", "20.00", "23.10", "16.40", "2.10", "13.30" };
                Random.Shared.Shuffle(time);
                for (int i = 0; i < 10; i++)
                {
                    streamWriter.WriteLine(number[i] + " " + punkt[i] + " " + time[i]);
                }
            }

            string[] pun = new string[10];
            string[] num = new string[10];
            string[] tim = new string[10];

            using (StreamReader streamReader = File.OpenText(@"C:\Тусур\11 лабораторная\Train.txt"))
            {
                string input = null;
                int i = 0;
                while ((input = streamReader.ReadLine()) != null)
                {
                    string[] spl = input.Split(" ");
                    num[i] = spl[0];
                    pun[i] = spl[1];
                    tim[i] = spl[2];
                    i++;
                }
                string[] pnt = new string[10];
                for (int i1 = 0; i1 < 10; i1++)
                {
                    pnt[i1] = num[i1] + " " + pun[i1] + " " + tim[i1];
                }
                Array.Sort(pnt);
                string a5;
                a5 = pnt[1];
                for (int i5 = 1; i5 < 9; i5++)
                {
                    pnt[i5] = pnt[i5 + 1];
                }
                pnt[9] = a5;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    string[] spl1 = pnt[i2].Split(" ");
                    num[i2] = spl1[0];
                    pun[i2] = spl1[1];
                    tim[i2] = spl1[2];
                    Label lbl1 = new Label();
                    lbl1.Size = new System.Drawing.Size(170, 20);
                    lbl1.Text = pun[i2];
                    lbl1.Location = new Point(10, 30 * (i2 + 1));
                    panel1.Controls.Add(lbl1);
                    Label lbl2 = new Label();
                    lbl2.Size = new System.Drawing.Size(170, 20);
                    lbl2.Text = num[i2];
                    lbl2.Location = new Point(10, 30 * (i2 + 1));
                    panel2.Controls.Add(lbl2);
                    Label lbl3 = new Label();
                    lbl3.Size = new System.Drawing.Size(170, 20);
                    lbl3.Text = tim[i2];
                    lbl3.Location = new Point(10, 30 * (i2 + 1));
                    panel3.Controls.Add(lbl3);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label9.Visible = false;
                label7.Text = "";
                label8.Text = "";
                label10.Text = "";
            }
            string[] pun = new string[10];
            string[] num = new string[10];
            string[] tim = new string[10];

            using (StreamReader streamReader = File.OpenText(@"C:\Тусур\11 лабораторная\Train.txt"))
            {
                string input = null;
                int i = 0;
                while ((input = streamReader.ReadLine()) != null)
                {
                    string[] spl = input.Split(" ");
                    num[i] = spl[0];
                    pun[i] = spl[1];
                    tim[i] = spl[2];
                    i++;
                }
                string[] pnt = new string[10];
                for (int i1 = 0; i1 < 10; i1++)
                {
                    pnt[i1] = num[i1] + " " + pun[i1] + " " + tim[i1];
                }
                Array.Sort(pnt);
                string a5;
                a5 = pnt[1];
                for (int i5 = 1; i5 < 9; i5++)
                {
                    pnt[i5] = pnt[i5 + 1];
                }
                pnt[9] = a5;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    string[] spl1 = pnt[i2].Split(" ");
                    num[i2] = spl1[0];
                    pun[i2] = spl1[1];
                    tim[i2] = spl1[2];
                }
            }
            try
            {
                int num1;
                num1 = int.Parse(textBox1.Text);
                if (num1 == 1)
                {
                    label7.Text = pun[0];
                    label8.Text = tim[0];
                }
                if (num1 == 2)
                {
                    label7.Text = pun[1];
                    label8.Text = tim[1];
                }
                if (num1 == 3)
                {
                    label7.Text = pun[2];
                    label8.Text = tim[2];
                }
                if (num1 == 4)
                {
                    label7.Text = pun[3];
                    label8.Text = tim[3];
                }
                if (num1 == 5)
                {
                    label7.Text = pun[4];
                    label8.Text = tim[4];
                }
                if (num1 == 6)
                {
                    label7.Text = pun[5];
                    label8.Text = tim[5];
                }
                if (num1 == 7)
                {
                    label7.Text = pun[6];
                    label8.Text = tim[6];
                }
                if (num1 == 8)
                {
                    label7.Text = pun[7];
                    label8.Text = tim[7];
                }
                if (num1 == 9)
                {
                    label7.Text = pun[8];
                    label8.Text = tim[8];
                }
                if (num1 == 10)
                {
                    label7.Text = pun[9];
                    label8.Text = tim[9];
                }
                int k = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (num1 == Convert.ToInt32(num[i]))
                    {
                        k += 1;
                    }
                }
                if (k == 0)
                {
                    label10.Text = "Поезд отсутствует";
                    label7.Text = "";
                    label8.Text = "";
                }
            }
            catch
            {
                label9.Text = "Неверный формат";
            }
        }
    }
}