
namespace Tyuiu.SugrovskiyNI.Sprint6.Review.V28
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewMatrix_SNI = new System.Windows.Forms.DataGridView();
            this.buttonHelp_SNI = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSetMatrix_SNI = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxValue_SNI = new System.Windows.Forms.TextBox();
            this.textBoxRightBorder_SNI = new System.Windows.Forms.TextBox();
            this.textBoxLeftBorder_SNI = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValueFirstNum_SNI = new System.Windows.Forms.TextBox();
            this.textBoxValueLastNum_SNI = new System.Windows.Forms.TextBox();
            this.textBoxSetCols_SNI = new System.Windows.Forms.TextBox();
            this.textBoxSetRows_SNI = new System.Windows.Forms.TextBox();
            this.textBoxResult_SNI = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SNI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMatrix_SNI
            // 
            this.dataGridViewMatrix_SNI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_SNI.Location = new System.Drawing.Point(319, 12);
            this.dataGridViewMatrix_SNI.Name = "dataGridViewMatrix_SNI";
            this.dataGridViewMatrix_SNI.RowHeadersWidth = 51;
            this.dataGridViewMatrix_SNI.RowTemplate.Height = 24;
            this.dataGridViewMatrix_SNI.Size = new System.Drawing.Size(413, 354);
            this.dataGridViewMatrix_SNI.TabIndex = 0;
            // 
            // buttonHelp_SNI
            // 
            this.buttonHelp_SNI.Location = new System.Drawing.Point(762, 321);
            this.buttonHelp_SNI.Name = "buttonHelp_SNI";
            this.buttonHelp_SNI.Size = new System.Drawing.Size(60, 45);
            this.buttonHelp_SNI.TabIndex = 1;
            this.buttonHelp_SNI.Text = "?";
            this.buttonHelp_SNI.UseVisualStyleBackColor = true;
            this.buttonHelp_SNI.Click += new System.EventHandler(this.buttonHelp_SNI_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(858, 321);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 45);
            this.button2.TabIndex = 2;
            this.button2.Text = "Выполнить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonDone_SNI_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSetMatrix_SNI);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxValue_SNI);
            this.groupBox1.Controls.Add(this.textBoxRightBorder_SNI);
            this.groupBox1.Controls.Add(this.textBoxLeftBorder_SNI);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxValueFirstNum_SNI);
            this.groupBox1.Controls.Add(this.textBoxValueLastNum_SNI);
            this.groupBox1.Controls.Add(this.textBoxSetCols_SNI);
            this.groupBox1.Controls.Add(this.textBoxSetRows_SNI);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 270);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ввод данных";
            // 
            // buttonSetMatrix_SNI
            // 
            this.buttonSetMatrix_SNI.Location = new System.Drawing.Point(22, 73);
            this.buttonSetMatrix_SNI.Name = "buttonSetMatrix_SNI";
            this.buttonSetMatrix_SNI.Size = new System.Drawing.Size(234, 33);
            this.buttonSetMatrix_SNI.TabIndex = 15;
            this.buttonSetMatrix_SNI.Text = "Задать случайную матрицу";
            this.buttonSetMatrix_SNI.UseVisualStyleBackColor = true;
            this.buttonSetMatrix_SNI.Click += new System.EventHandler(this.buttonSetMatrix_SNI_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(152, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(114, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Правая граница";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Левая граница";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Значение K";
            // 
            // textBoxValue_SNI
            // 
            this.textBoxValue_SNI.Location = new System.Drawing.Point(9, 176);
            this.textBoxValue_SNI.Name = "textBoxValue_SNI";
            this.textBoxValue_SNI.Size = new System.Drawing.Size(103, 22);
            this.textBoxValue_SNI.TabIndex = 11;
            // 
            // textBoxRightBorder_SNI
            // 
            this.textBoxRightBorder_SNI.Location = new System.Drawing.Point(155, 129);
            this.textBoxRightBorder_SNI.Name = "textBoxRightBorder_SNI";
            this.textBoxRightBorder_SNI.Size = new System.Drawing.Size(111, 22);
            this.textBoxRightBorder_SNI.TabIndex = 10;
            // 
            // textBoxLeftBorder_SNI
            // 
            this.textBoxLeftBorder_SNI.Location = new System.Drawing.Point(9, 129);
            this.textBoxLeftBorder_SNI.Name = "textBoxLeftBorder_SNI";
            this.textBoxLeftBorder_SNI.Size = new System.Drawing.Size(103, 22);
            this.textBoxLeftBorder_SNI.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "N1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "N2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columns";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rows";
            // 
            // textBoxValueFirstNum_SNI
            // 
            this.textBoxValueFirstNum_SNI.Location = new System.Drawing.Point(188, 39);
            this.textBoxValueFirstNum_SNI.Name = "textBoxValueFirstNum_SNI";
            this.textBoxValueFirstNum_SNI.Size = new System.Drawing.Size(40, 22);
            this.textBoxValueFirstNum_SNI.TabIndex = 3;
            // 
            // textBoxValueLastNum_SNI
            // 
            this.textBoxValueLastNum_SNI.Location = new System.Drawing.Point(243, 39);
            this.textBoxValueLastNum_SNI.Name = "textBoxValueLastNum_SNI";
            this.textBoxValueLastNum_SNI.Size = new System.Drawing.Size(35, 22);
            this.textBoxValueLastNum_SNI.TabIndex = 2;
            // 
            // textBoxSetCols_SNI
            // 
            this.textBoxSetCols_SNI.Location = new System.Drawing.Point(91, 39);
            this.textBoxSetCols_SNI.Name = "textBoxSetCols_SNI";
            this.textBoxSetCols_SNI.Size = new System.Drawing.Size(77, 22);
            this.textBoxSetCols_SNI.TabIndex = 1;
            // 
            // textBoxSetRows_SNI
            // 
            this.textBoxSetRows_SNI.Location = new System.Drawing.Point(6, 39);
            this.textBoxSetRows_SNI.Name = "textBoxSetRows_SNI";
            this.textBoxSetRows_SNI.Size = new System.Drawing.Size(79, 22);
            this.textBoxSetRows_SNI.TabIndex = 0;
            // 
            // textBoxResult_SNI
            // 
            this.textBoxResult_SNI.Location = new System.Drawing.Point(23, 52);
            this.textBoxResult_SNI.Name = "textBoxResult_SNI";
            this.textBoxResult_SNI.Size = new System.Drawing.Size(140, 22);
            this.textBoxResult_SNI.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxResult_SNI);
            this.groupBox2.Location = new System.Drawing.Point(750, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(188, 303);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вывод данных";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Результат";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 401);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonHelp_SNI);
            this.Controls.Add(this.dataGridViewMatrix_SNI);
            this.Name = "FormMain";
            this.Text = "Спринт 6 | Таск 7 | Вариант 22 | Сугровский Н.И";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_SNI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMatrix_SNI;
        private System.Windows.Forms.Button buttonHelp_SNI;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxValue_SNI;
        private System.Windows.Forms.TextBox textBoxRightBorder_SNI;
        private System.Windows.Forms.TextBox textBoxLeftBorder_SNI;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxValueFirstNum_SNI;
        private System.Windows.Forms.TextBox textBoxValueLastNum_SNI;
        private System.Windows.Forms.TextBox textBoxSetCols_SNI;
        private System.Windows.Forms.TextBox textBoxSetRows_SNI;
        private System.Windows.Forms.TextBox textBoxResult_SNI;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSetMatrix_SNI;
    }
}

