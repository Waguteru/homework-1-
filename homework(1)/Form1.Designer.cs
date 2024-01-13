namespace homework_1_
{
    partial class Form1
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
            Wordbtn = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            textname = new TextBox();
            volume = new TextBox();
            price = new TextBox();
            sum = new TextBox();
            addData = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            deleteline = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Wordbtn
            // 
            Wordbtn.Location = new Point(343, 168);
            Wordbtn.Name = "Wordbtn";
            Wordbtn.Size = new Size(128, 28);
            Wordbtn.TabIndex = 0;
            Wordbtn.Text = "экспорт в Word";
            Wordbtn.UseVisualStyleBackColor = true;
            Wordbtn.Click += Wordbtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(343, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(445, 150);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "название";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "кол-во";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "цена";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "сумма";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // textname
            // 
            textname.Location = new Point(92, 12);
            textname.Name = "textname";
            textname.Size = new Size(100, 23);
            textname.TabIndex = 2;
            // 
            // volume
            // 
            volume.Location = new Point(92, 66);
            volume.Name = "volume";
            volume.Size = new Size(100, 23);
            volume.TabIndex = 3;
            // 
            // price
            // 
            price.Location = new Point(92, 111);
            price.Name = "price";
            price.Size = new Size(100, 23);
            price.TabIndex = 4;
            // 
            // sum
            // 
            sum.Location = new Point(92, 149);
            sum.Name = "sum";
            sum.Size = new Size(100, 23);
            sum.TabIndex = 5;
            // 
            // addData
            // 
            addData.Location = new Point(104, 191);
            addData.Name = "addData";
            addData.Size = new Size(75, 23);
            addData.TabIndex = 6;
            addData.Text = "Добавить";
            addData.UseVisualStyleBackColor = true;
            addData.Click += addData_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 15);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 7;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 69);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 8;
            label2.Text = "Количество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 114);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 9;
            label3.Text = "Цена за шт";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 152);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 10;
            label4.Text = "Сумма";
            // 
            // deleteline
            // 
            deleteline.Location = new Point(238, 81);
            deleteline.Name = "deleteline";
            deleteline.Size = new Size(99, 36);
            deleteline.TabIndex = 11;
            deleteline.Text = "Удалить строку";
            deleteline.UseVisualStyleBackColor = true;
            deleteline.Click += deleteline_Click;
            // 
            // button1
            // 
            button1.Location = new Point(507, 168);
            button1.Name = "button1";
            button1.Size = new Size(128, 28);
            button1.TabIndex = 12;
            button1.Text = "экспорт в PDF";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 226);
            Controls.Add(button1);
            Controls.Add(deleteline);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(addData);
            Controls.Add(sum);
            Controls.Add(price);
            Controls.Add(volume);
            Controls.Add(textname);
            Controls.Add(dataGridView1);
            Controls.Add(Wordbtn);
            Name = "Form1";
            Text = "Оформление чека";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Wordbtn;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox textname;
        private TextBox volume;
        private TextBox price;
        private TextBox sum;
        private Button addData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button deleteline;
        private Button button1;
    }
}