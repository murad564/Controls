namespace Ex_WinFormsApp2
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.SurnametextBox = new System.Windows.Forms.TextBox();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PatronymictextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TelephonetextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CitytextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CountrytextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.MaleRdbtn = new System.Windows.Forms.RadioButton();
            this.Femalerdbtn = new System.Windows.Forms.RadioButton();
            this.Savebutton = new System.Windows.Forms.Button();
            this.LoadtextBox = new System.Windows.Forms.TextBox();
            this.Loadbutton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // SurnametextBox
            // 
            this.SurnametextBox.Location = new System.Drawing.Point(94, 15);
            this.SurnametextBox.Name = "SurnametextBox";
            this.SurnametextBox.Size = new System.Drawing.Size(157, 23);
            this.SurnametextBox.TabIndex = 1;
            this.SurnametextBox.Enter += new System.EventHandler(this.SurnametextBox_Enter);
            this.SurnametextBox.Leave += new System.EventHandler(this.SurnametextBox_Leave);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(94, 44);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(157, 23);
            this.NametextBox.TabIndex = 3;
            this.NametextBox.Enter += new System.EventHandler(this.NametextBox_Enter);
            this.NametextBox.Leave += new System.EventHandler(this.NametextBox_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // PatronymictextBox
            // 
            this.PatronymictextBox.Location = new System.Drawing.Point(94, 73);
            this.PatronymictextBox.Name = "PatronymictextBox";
            this.PatronymictextBox.Size = new System.Drawing.Size(157, 23);
            this.PatronymictextBox.TabIndex = 5;
            this.PatronymictextBox.Enter += new System.EventHandler(this.PatronymictextBox_Enter);
            this.PatronymictextBox.Leave += new System.EventHandler(this.PatronymictextBox_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Patronymic";
            // 
            // TelephonetextBox
            // 
            this.TelephonetextBox.Location = new System.Drawing.Point(94, 195);
            this.TelephonetextBox.Name = "TelephonetextBox";
            this.TelephonetextBox.Size = new System.Drawing.Size(157, 23);
            this.TelephonetextBox.TabIndex = 11;
            this.TelephonetextBox.Enter += new System.EventHandler(this.TelephonetextBox_Enter);
            this.TelephonetextBox.Leave += new System.EventHandler(this.TelephonetextBox_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(16, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telephone";
            // 
            // CitytextBox
            // 
            this.CitytextBox.Location = new System.Drawing.Point(94, 166);
            this.CitytextBox.Name = "CitytextBox";
            this.CitytextBox.Size = new System.Drawing.Size(157, 23);
            this.CitytextBox.TabIndex = 9;
            this.CitytextBox.Enter += new System.EventHandler(this.CitytextBox_Enter);
            this.CitytextBox.Leave += new System.EventHandler(this.CitytextBox_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(16, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "City";
            // 
            // CountrytextBox
            // 
            this.CountrytextBox.Location = new System.Drawing.Point(94, 137);
            this.CountrytextBox.Name = "CountrytextBox";
            this.CountrytextBox.Size = new System.Drawing.Size(157, 23);
            this.CountrytextBox.TabIndex = 7;
            this.CountrytextBox.Enter += new System.EventHandler(this.CountrytextBox_Enter);
            this.CountrytextBox.Leave += new System.EventHandler(this.CountrytextBox_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(16, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Country";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(16, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Date Birthday";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(19, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 14;
            this.label8.Text = "Gender";
            // 
            // MaleRdbtn
            // 
            this.MaleRdbtn.AutoSize = true;
            this.MaleRdbtn.Location = new System.Drawing.Point(114, 304);
            this.MaleRdbtn.Name = "MaleRdbtn";
            this.MaleRdbtn.Size = new System.Drawing.Size(51, 19);
            this.MaleRdbtn.TabIndex = 15;
            this.MaleRdbtn.TabStop = true;
            this.MaleRdbtn.Text = "Male";
            this.MaleRdbtn.UseVisualStyleBackColor = true;
            // 
            // Femalerdbtn
            // 
            this.Femalerdbtn.AutoSize = true;
            this.Femalerdbtn.Location = new System.Drawing.Point(188, 304);
            this.Femalerdbtn.Name = "Femalerdbtn";
            this.Femalerdbtn.Size = new System.Drawing.Size(63, 19);
            this.Femalerdbtn.TabIndex = 16;
            this.Femalerdbtn.TabStop = true;
            this.Femalerdbtn.Text = "Female";
            this.Femalerdbtn.UseVisualStyleBackColor = true;
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(30, 342);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(259, 23);
            this.Savebutton.TabIndex = 17;
            this.Savebutton.Text = "Save";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click_1);
            // 
            // LoadtextBox
            // 
            this.LoadtextBox.Location = new System.Drawing.Point(111, 5);
            this.LoadtextBox.Name = "LoadtextBox";
            this.LoadtextBox.PlaceholderText = "Name";
            this.LoadtextBox.Size = new System.Drawing.Size(100, 23);
            this.LoadtextBox.TabIndex = 18;
            // 
            // Loadbutton
            // 
            this.Loadbutton.Location = new System.Drawing.Point(258, 5);
            this.Loadbutton.Name = "Loadbutton";
            this.Loadbutton.Size = new System.Drawing.Size(75, 23);
            this.Loadbutton.TabIndex = 19;
            this.Loadbutton.Text = "Load";
            this.Loadbutton.UseVisualStyleBackColor = true;
            this.Loadbutton.Click += new System.EventHandler(this.Loadbutton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.Savebutton);
            this.groupBox1.Controls.Add(this.Femalerdbtn);
            this.groupBox1.Controls.Add(this.MaleRdbtn);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TelephonetextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.CitytextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.CountrytextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PatronymictextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.NametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.SurnametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 388);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registr";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(116, 253);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 18;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Loadbutton);
            this.Controls.Add(this.LoadtextBox);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox SurnametextBox;
        private TextBox NametextBox;
        private Label label2;
        private TextBox PatronymictextBox;
        private Label label3;
        private TextBox TelephonetextBox;
        private Label label4;
        private TextBox CitytextBox;
        private Label label5;
        private TextBox CountrytextBox;
        private Label label6;
        private Label label7;
        private Label label8;
        private RadioButton MaleRdbtn;
        private RadioButton Femalerdbtn;
        private Button Savebutton;
        private TextBox LoadtextBox;
        private Button Loadbutton;
        private GroupBox groupBox1;
        private DateTimePicker dateTimePicker;
    }
}