namespace Assignment10._3
{
    partial class MainUi
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
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbxCPrice = new TextBox();
            tbxCVin = new TextBox();
            tbxCModel = new TextBox();
            cbxManufacturer = new ComboBox();
            bntAdd = new Button();
            bntSubmit = new Button();
            bntUpdateSelect = new Button();
            bntUpdate = new Button();
            bntDelete = new Button();
            label6 = new Label();
            tbxCYear = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(209, 18);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Car List";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(553, 255);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(571, 36);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 2;
            label2.Text = "Car Price";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(571, 79);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Car Vin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(571, 112);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 4;
            label4.Text = "Car Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(571, 191);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 5;
            label5.Text = "Manufacturer";
            // 
            // tbxCPrice
            // 
            tbxCPrice.Location = new Point(710, 33);
            tbxCPrice.Name = "tbxCPrice";
            tbxCPrice.Size = new Size(100, 23);
            tbxCPrice.TabIndex = 6;
            // 
            // tbxCVin
            // 
            tbxCVin.Location = new Point(710, 79);
            tbxCVin.Name = "tbxCVin";
            tbxCVin.Size = new Size(100, 23);
            tbxCVin.TabIndex = 7;
            // 
            // tbxCModel
            // 
            tbxCModel.Location = new Point(710, 112);
            tbxCModel.Name = "tbxCModel";
            tbxCModel.Size = new Size(100, 23);
            tbxCModel.TabIndex = 8;
            // 
            // cbxManufacturer
            // 
            cbxManufacturer.FormattingEnabled = true;
            cbxManufacturer.Location = new Point(710, 188);
            cbxManufacturer.Name = "cbxManufacturer";
            cbxManufacturer.Size = new Size(121, 23);
            cbxManufacturer.TabIndex = 9;
            // 
            // bntAdd
            // 
            bntAdd.Location = new Point(73, 320);
            bntAdd.Name = "bntAdd";
            bntAdd.Size = new Size(75, 32);
            bntAdd.TabIndex = 10;
            bntAdd.Text = "Add";
            bntAdd.UseVisualStyleBackColor = true;
            bntAdd.Click += bntAdd_Click;
            // 
            // bntSubmit
            // 
            bntSubmit.Location = new Point(73, 369);
            bntSubmit.Name = "bntSubmit";
            bntSubmit.Size = new Size(75, 36);
            bntSubmit.TabIndex = 11;
            bntSubmit.Text = "Submit";
            bntSubmit.UseVisualStyleBackColor = true;
            bntSubmit.Click += bntSubmit_Click;
            // 
            // bntUpdateSelect
            // 
            bntUpdateSelect.Location = new Point(183, 320);
            bntUpdateSelect.Name = "bntUpdateSelect";
            bntUpdateSelect.Size = new Size(106, 32);
            bntUpdateSelect.TabIndex = 12;
            bntUpdateSelect.Text = "Select to Update";
            bntUpdateSelect.UseVisualStyleBackColor = true;
            bntUpdateSelect.Click += bntUpdateSelect_Click;
            // 
            // bntUpdate
            // 
            bntUpdate.Location = new Point(183, 369);
            bntUpdate.Name = "bntUpdate";
            bntUpdate.Size = new Size(89, 36);
            bntUpdate.TabIndex = 13;
            bntUpdate.Text = "Update";
            bntUpdate.UseVisualStyleBackColor = true;
            bntUpdate.Click += bntUpdate_Click;
            // 
            // bntDelete
            // 
            bntDelete.Location = new Point(306, 339);
            bntDelete.Name = "bntDelete";
            bntDelete.Size = new Size(81, 33);
            bntDelete.TabIndex = 14;
            bntDelete.Text = "Delete";
            bntDelete.UseVisualStyleBackColor = true;
            bntDelete.Click += bntDelete_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(571, 151);
            label6.Name = "label6";
            label6.Size = new Size(50, 15);
            label6.TabIndex = 15;
            label6.Text = "Car Year";
            // 
            // tbxCYear
            // 
            tbxCYear.Location = new Point(710, 151);
            tbxCYear.Name = "tbxCYear";
            tbxCYear.Size = new Size(100, 23);
            tbxCYear.TabIndex = 16;
            // 
            // MainUi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(tbxCYear);
            Controls.Add(label6);
            Controls.Add(bntDelete);
            Controls.Add(bntUpdate);
            Controls.Add(bntUpdateSelect);
            Controls.Add(bntSubmit);
            Controls.Add(bntAdd);
            Controls.Add(cbxManufacturer);
            Controls.Add(tbxCModel);
            Controls.Add(tbxCVin);
            Controls.Add(tbxCPrice);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "MainUi";
            Text = "Main UI";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbxCPrice;
        private TextBox tbxCVin;
        private TextBox tbxCModel;
        private ComboBox cbxManufacturer;
        private Button bntAdd;
        private Button bntSubmit;
        private Button bntUpdateSelect;
        private Button bntUpdate;
        private Button bntDelete;
        private Label label6;
        private TextBox tbxCYear;
    }
}
