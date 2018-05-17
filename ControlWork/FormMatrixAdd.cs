using System;
using System.Windows.Forms;
using System.Globalization;

namespace ControlWork
{
    public partial class FormMatrixAdd : Form
    {
        public FormMatrixAdd()
        {
            InitializeComponent();
        }

        private void TextBox_KeyPress_int(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void TextBox_KeyPress_float(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9')
                && e.KeyChar != '\b'
                && e.KeyChar != ','
                && e.KeyChar != '.'
                && e.KeyChar != '-')
                e.Handled = true;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Data.Add = false;
            Close();
        }

        private void button_Create_Matrix_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox_i.Text) < 1 || int.Parse(textBox_j.Text) < 1)
            {
                MessageBox.Show("Размер матрицы не может иметь размер меньше 1",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                Data.X = int.Parse(textBox_i.Text);
                Data.Y = int.Parse(textBox_j.Text);
                try
                {
                    Data.A = double.Parse(textBox_A.Text, CultureInfo.InvariantCulture);
                    Data.B = double.Parse(textBox_B.Text, CultureInfo.InvariantCulture);
                    Data.C = double.Parse(textBox_C.Text, CultureInfo.InvariantCulture);
                    Data.Add = true;
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка в задании параметра A, B или C.\n" + ex.Message,
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }
    }
}
