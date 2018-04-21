namespace ControlWork
{
    partial class FormMatrixAdd
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_C = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_B = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_A = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_j = new System.Windows.Forms.TextBox();
            this.textBox_i = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button_Create_Matrix = new System.Windows.Forms.Button();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_C);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBox_B);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_A);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(256, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Формула формирования матрицы";
            // 
            // textBox_C
            // 
            this.textBox_C.Location = new System.Drawing.Point(201, 88);
            this.textBox_C.Name = "textBox_C";
            this.textBox_C.Size = new System.Drawing.Size(44, 20);
            this.textBox_C.TabIndex = 5;
            this.textBox_C.Text = "1,0";
            this.textBox_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_C.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_float);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(173, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "C";
            // 
            // textBox_B
            // 
            this.textBox_B.Location = new System.Drawing.Point(116, 88);
            this.textBox_B.Name = "textBox_B";
            this.textBox_B.Size = new System.Drawing.Size(44, 20);
            this.textBox_B.TabIndex = 4;
            this.textBox_B.Text = "1,0";
            this.textBox_B.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_B.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_float);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(88, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "B";
            // 
            // textBox_A
            // 
            this.textBox_A.Location = new System.Drawing.Point(34, 88);
            this.textBox_A.Name = "textBox_A";
            this.textBox_A.Size = new System.Drawing.Size(44, 20);
            this.textBox_A.TabIndex = 3;
            this.textBox_A.Text = "1,0";
            this.textBox_A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_A.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_float);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(6, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "A";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ControlWork.Properties.Resources.formula_verdana_12;
            this.pictureBox1.Location = new System.Drawing.Point(10, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_j);
            this.groupBox2.Controls.Add(this.textBox_i);
            this.groupBox2.Location = new System.Drawing.Point(13, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(116, 85);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Размер матрицы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "j";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(14, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "i";
            // 
            // textBox_j
            // 
            this.textBox_j.Location = new System.Drawing.Point(38, 57);
            this.textBox_j.MaxLength = 5;
            this.textBox_j.Name = "textBox_j";
            this.textBox_j.Size = new System.Drawing.Size(65, 20);
            this.textBox_j.TabIndex = 2;
            this.textBox_j.Text = "1";
            this.textBox_j.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_j.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_int);
            // 
            // textBox_i
            // 
            this.textBox_i.Location = new System.Drawing.Point(38, 20);
            this.textBox_i.MaxLength = 5;
            this.textBox_i.Name = "textBox_i";
            this.textBox_i.Size = new System.Drawing.Size(65, 20);
            this.textBox_i.TabIndex = 1;
            this.textBox_i.Text = "1";
            this.textBox_i.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox_i.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress_int);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ControlWork.Properties.Resources.matrix_verdana;
            this.pictureBox2.Location = new System.Drawing.Point(136, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 83);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // button_Create_Matrix
            // 
            this.button_Create_Matrix.Location = new System.Drawing.Point(72, 237);
            this.button_Create_Matrix.Name = "button_Create_Matrix";
            this.button_Create_Matrix.Size = new System.Drawing.Size(95, 23);
            this.button_Create_Matrix.TabIndex = 6;
            this.button_Create_Matrix.Text = "Ok";
            this.button_Create_Matrix.UseVisualStyleBackColor = true;
            this.button_Create_Matrix.Click += new System.EventHandler(this.button_Create_Matrix_Click);
            // 
            // button_Cancel
            // 
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Location = new System.Drawing.Point(173, 237);
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.Size = new System.Drawing.Size(95, 23);
            this.button_Cancel.TabIndex = 7;
            this.button_Cancel.Text = "Отмена";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.button_Cancel_Click);
            // 
            // FormMatrixAdd
            // 
            this.AcceptButton = this.button_Create_Matrix;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.ClientSize = new System.Drawing.Size(279, 272);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.button_Create_Matrix);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(295, 310);
            this.MinimumSize = new System.Drawing.Size(295, 310);
            this.Name = "FormMatrixAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Создать матрицу";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_j;
        private System.Windows.Forms.TextBox textBox_i;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_C;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox_A;
        private System.Windows.Forms.Button button_Create_Matrix;
        private System.Windows.Forms.Button button_Cancel;
    }
}