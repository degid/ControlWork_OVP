using System;
using System.Windows.Forms;
using System.Drawing;

namespace ControlWork
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Выполнить выход?",
                "Завершение работы",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void Button_create_Click(object sender, EventArgs e)
        {
            FormMatrixAdd Form2 = new FormMatrixAdd();
            Form2.ShowDialog();

            if (Data.Add)
            {
                MatrixPlus mp = new MatrixPlus { };
                mp.New();

                LoadDataGrid(dtGridView_Source, mp);

                label_A.Text = Data.A.ToString();
                label_B.Text = Data.B.ToString();
                label_C.Text = Data.C.ToString();
                label_Min.Text = mp.Min.ToString();
                label_Max.Text = mp.Max.ToString();
                label_P.Text = (mp.Max / mp.Min).ToString();

                if ((mp.Max / mp.Min) > 3)
                {
                    LoadDataGrid(dtGridView_Pb3, mp / mp.Max);
                    LoadDataGrid(dtGridView_Source, mp);
                }
                else
                {
                    dtGridView_Pb3.Columns.Clear();
                    dtGridView_Pb3.Rows.Clear();
                }
            }
        }

        private void LoadDataGrid(DataGridView dataGridView, MatrixPlus matrixPlus)
        {
            dataGridView.Columns.Clear();
            dataGridView.Rows.Clear();
            dataGridView.RowCount = Data.X;
            dataGridView.ColumnCount = Data.Y;
            for (int i = 0; i < Data.X; i++)
            {
                dataGridView.Rows[i].HeaderCell.Value = (i + 1).ToString();
                for (int j = 0; j < Data.Y; j++)
                {
                    if (i < 1)
                    {
                        dataGridView.Columns[j].HeaderText = (j + 1).ToString();
                    }

                    if (double.IsInfinity(matrixPlus.Matrix[i, j])
                        || double.IsNaN(matrixPlus.Matrix[i, j]))
                    {
                        dataGridView.Rows[i].Cells[j].Style.BackColor = Color.Pink;
                    }

                    dataGridView.Rows[i].Cells[j].Value = matrixPlus.Matrix[i, j];
                }
            }

            foreach (Err error in matrixPlus.errs)
            {
                dataGridView.Rows[error.point.X].Cells[error.point.Y].Style.BackColor = Color.Pink;
                dataGridView.Rows[error.point.X].Cells[error.point.Y].Value = error.exception.Message;
            }
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
