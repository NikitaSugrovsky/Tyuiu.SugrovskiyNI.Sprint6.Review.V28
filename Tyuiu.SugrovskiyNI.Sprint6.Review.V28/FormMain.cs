using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.SugrovskiyNI.Sprint6.Review.V22.Lib;

namespace Tyuiu.SugrovskiyNI.Sprint6.Review.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        Random random = new Random();
        int rows;
        int cols;

        int[,] mtrx;

        int leftBorder;
        int righBorder;

        int firstNum;
        int lastNum;

        private void buttonDone_SNI_Click(object sender, EventArgs e) 
        {
            int R = Convert.ToInt32(textBoxValue_SNI.Text);

            leftBorder = Convert.ToInt32(textBoxLeftBorder_SNI.Text);
            righBorder = Convert.ToInt32(textBoxRightBorder_SNI.Text); 

            if(leftBorder < righBorder && R < rows)
            {
                textBoxResult_SNI.Text = Convert.ToString(ds.GetMatrix(mtrx, R, leftBorder, righBorder));
            }
        }

        private void buttonSetMatrix_SNI_Click(object sender, EventArgs e)
        {
            try
            {
                rows = Convert.ToInt32(textBoxSetRows_SNI.Text);
                cols = Convert.ToInt32(textBoxSetCols_SNI.Text);

                firstNum = Convert.ToInt32(textBoxValueFirstNum_SNI.Text);
                lastNum = Convert.ToInt32(textBoxValueLastNum_SNI.Text);

                mtrx = new int[rows, cols];

                if (firstNum < lastNum)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int value = random.Next(firstNum, lastNum + 1);
                        int sign = 1; // Переменная для чередования знаков

                        for (int i = 0; i < rows; i++)
                        {
                            mtrx[i, j] = value * sign;
                            value++;
                            sign *= -1; // Чередование знаков
                        }
                    }
                    dataGridViewMatrix_SNI.ColumnCount = cols;
                    dataGridViewMatrix_SNI.RowCount = rows;

                    for (int i = 0; i < cols; i++)
                    {
                        dataGridViewMatrix_SNI.Columns[i].Width = 25;
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < cols; j++)
                        {
                            dataGridViewMatrix_SNI.Rows[i].Cells[j].Value = Convert.ToString(mtrx[i, j]);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_SNI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sprint Review выполнил Сугровский Никита Игоревич из группы ИИПб-23-1");
        }
    }
}
