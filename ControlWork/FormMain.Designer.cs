namespace ControlWork
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_exit = new System.Windows.Forms.Button();
            this.button_create = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_C = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_B = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_A = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_P = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_Max = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Min = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtGridView_Source = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dtGridView_Pb3 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Source)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Pb3)).BeginInit();
            this.SuspendLayout();
            // 
            // button_exit
            // 
            this.button_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_exit.Location = new System.Drawing.Point(671, 415);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(111, 23);
            this.button_exit.TabIndex = 2;
            this.button_exit.Text = "Выход";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.UseWaitCursor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_create
            // 
            this.button_create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_create.Location = new System.Drawing.Point(8, 19);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(111, 23);
            this.button_create.TabIndex = 1;
            this.button_create.Text = "Сформировать";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.UseWaitCursor = true;
            this.button_create.Click += new System.EventHandler(this.Button_create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label_C);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label_B);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_A);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_P);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label_Max);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label_Min);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_create);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(663, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 190);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Матрица";
            this.groupBox1.UseWaitCursor = true;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Location = new System.Drawing.Point(51, 97);
            this.label_C.MaximumSize = new System.Drawing.Size(70, 13);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(16, 13);
            this.label_C.TabIndex = 13;
            this.label_C.Text = "...";
            this.label_C.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "C";
            this.label6.UseWaitCursor = true;
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Location = new System.Drawing.Point(51, 73);
            this.label_B.MaximumSize = new System.Drawing.Size(70, 13);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(16, 13);
            this.label_B.TabIndex = 11;
            this.label_B.Text = "...";
            this.label_B.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            this.label3.UseWaitCursor = true;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Location = new System.Drawing.Point(51, 49);
            this.label_A.MaximumSize = new System.Drawing.Size(70, 13);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(16, 13);
            this.label_A.TabIndex = 9;
            this.label_A.Text = "...";
            this.label_A.UseWaitCursor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "A";
            this.label7.UseWaitCursor = true;
            // 
            // label_P
            // 
            this.label_P.AutoSize = true;
            this.label_P.Location = new System.Drawing.Point(51, 169);
            this.label_P.MaximumSize = new System.Drawing.Size(70, 13);
            this.label_P.Name = "label_P";
            this.label_P.Size = new System.Drawing.Size(16, 13);
            this.label_P.TabIndex = 7;
            this.label_P.Text = "...";
            this.label_P.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "P";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.label5.UseWaitCursor = true;
            // 
            // label_Max
            // 
            this.label_Max.AutoSize = true;
            this.label_Max.Location = new System.Drawing.Point(51, 145);
            this.label_Max.MaximumSize = new System.Drawing.Size(70, 13);
            this.label_Max.Name = "label_Max";
            this.label_Max.Size = new System.Drawing.Size(16, 13);
            this.label_Max.TabIndex = 5;
            this.label_Max.Text = "...";
            this.label_Max.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(11, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MAX";
            this.label4.UseWaitCursor = true;
            // 
            // label_Min
            // 
            this.label_Min.AutoSize = true;
            this.label_Min.Location = new System.Drawing.Point(51, 121);
            this.label_Min.MaximumSize = new System.Drawing.Size(70, 13);
            this.label_Min.Name = "label_Min";
            this.label_Min.Size = new System.Drawing.Size(16, 13);
            this.label_Min.TabIndex = 3;
            this.label_Min.Text = "...";
            this.label_Min.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "MIN";
            this.label1.UseWaitCursor = true;
            // 
            // dtGridView_Source
            // 
            this.dtGridView_Source.AllowUserToAddRows = false;
            this.dtGridView_Source.AllowUserToDeleteRows = false;
            this.dtGridView_Source.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView_Source.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Source.Location = new System.Drawing.Point(3, 3);
            this.dtGridView_Source.Name = "dtGridView_Source";
            this.dtGridView_Source.ReadOnly = true;
            this.dtGridView_Source.Size = new System.Drawing.Size(639, 187);
            this.dtGridView_Source.TabIndex = 0;
            this.dtGridView_Source.UseWaitCursor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dtGridView_Source, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtGridView_Pb3, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 397);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.UseWaitCursor = true;
            // 
            // dtGridView_Pb3
            // 
            this.dtGridView_Pb3.AllowUserToAddRows = false;
            this.dtGridView_Pb3.AllowUserToDeleteRows = false;
            this.dtGridView_Pb3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtGridView_Pb3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridView_Pb3.Location = new System.Drawing.Point(3, 206);
            this.dtGridView_Pb3.Name = "dtGridView_Pb3";
            this.dtGridView_Pb3.ReadOnly = true;
            this.dtGridView_Pb3.Size = new System.Drawing.Size(639, 188);
            this.dtGridView_Pb3.TabIndex = 0;
            this.dtGridView_Pb3.UseWaitCursor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_exit);
            this.MinimumSize = new System.Drawing.Size(450, 282);
            this.Name = "FormMain";
            this.Text = "Контрольная работа. Вариант №2";
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Source)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridView_Pb3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtGridView_Source;
        private System.Windows.Forms.Label label_Max;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Min;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_P;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dtGridView_Pb3;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.Label label3;
    }
}

