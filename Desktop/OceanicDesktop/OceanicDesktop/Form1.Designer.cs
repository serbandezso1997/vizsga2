namespace OceanicDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            nameLbl = new Label();
            dateLbl = new Label();
            categoryLbl = new Label();
            sumLbl = new Label();
            commentLbl = new Label();
            boatNameTxtBox = new TextBox();
            commentTxtBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(731, 189);
            dataGridView1.TabIndex = 0;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Location = new Point(35, 229);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(67, 15);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "Yacht neve:";
            // 
            // dateLbl
            // 
            dateLbl.AutoSize = true;
            dateLbl.Location = new Point(35, 274);
            dateLbl.Name = "dateLbl";
            dateLbl.Size = new Size(46, 15);
            dateLbl.TabIndex = 2;
            dateLbl.Text = "Dátum:";
            // 
            // categoryLbl
            // 
            categoryLbl.AutoSize = true;
            categoryLbl.Location = new Point(35, 311);
            categoryLbl.Name = "categoryLbl";
            categoryLbl.Size = new Size(60, 15);
            categoryLbl.TabIndex = 3;
            categoryLbl.Text = "Kategória:";
            // 
            // sumLbl
            // 
            sumLbl.AutoSize = true;
            sumLbl.Location = new Point(35, 345);
            sumLbl.Name = "sumLbl";
            sumLbl.Size = new Size(64, 15);
            sumLbl.TabIndex = 4;
            sumLbl.Text = "Összeg (E):";
            // 
            // commentLbl
            // 
            commentLbl.AutoSize = true;
            commentLbl.Location = new Point(35, 384);
            commentLbl.Name = "commentLbl";
            commentLbl.Size = new Size(72, 15);
            commentLbl.TabIndex = 5;
            commentLbl.Text = "Megjegyzés:";
            // 
            // boatNameTxtBox
            // 
            boatNameTxtBox.Location = new Point(159, 229);
            boatNameTxtBox.Name = "boatNameTxtBox";
            boatNameTxtBox.Size = new Size(526, 23);
            boatNameTxtBox.TabIndex = 6;
            // 
            // commentTxtBox
            // 
            commentTxtBox.Location = new Point(159, 376);
            commentTxtBox.Name = "commentTxtBox";
            commentTxtBox.Size = new Size(526, 23);
            commentTxtBox.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(159, 268);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Maintenance", "Repairs", "Insurance", "Docking Fees", "Other" });
            comboBox1.Location = new Point(159, 308);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 9;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(160, 343);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 10;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(338, 441);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 11;
            addBtn.Text = "Hozzáadás";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 498);
            Controls.Add(addBtn);
            Controls.Add(numericUpDown1);
            Controls.Add(comboBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(commentTxtBox);
            Controls.Add(boatNameTxtBox);
            Controls.Add(commentLbl);
            Controls.Add(sumLbl);
            Controls.Add(categoryLbl);
            Controls.Add(dateLbl);
            Controls.Add(nameLbl);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label nameLbl;
        private Label dateLbl;
        private Label categoryLbl;
        private Label sumLbl;
        private Label commentLbl;
        private TextBox boatNameTxtBox;
        private TextBox commentTxtBox;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private Button addBtn;
    }
}
