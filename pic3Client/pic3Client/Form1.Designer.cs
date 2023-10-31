
namespace pic3Client
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
            this.showAll = new System.Windows.Forms.RadioButton();
            this.add = new System.Windows.Forms.RadioButton();
            this.delete = new System.Windows.Forms.RadioButton();
            this.update = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.quantity = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.output = new System.Windows.Forms.ListBox();
            this.statusOutput = new System.Windows.Forms.ListBox();
            this.doBtn = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showAll
            // 
            this.showAll.AutoSize = true;
            this.showAll.Location = new System.Drawing.Point(690, 164);
            this.showAll.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.showAll.Name = "showAll";
            this.showAll.Size = new System.Drawing.Size(146, 26);
            this.showAll.TabIndex = 0;
            this.showAll.TabStop = true;
            this.showAll.Text = "Show all";
            this.showAll.UseVisualStyleBackColor = true;
            this.showAll.CheckedChanged += new System.EventHandler(this.showAll_CheckedChanged);
            // 
            // add
            // 
            this.add.AutoSize = true;
            this.add.Location = new System.Drawing.Point(479, 121);
            this.add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(81, 26);
            this.add.TabIndex = 1;
            this.add.TabStop = true;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.CheckedChanged += new System.EventHandler(this.add_CheckedChanged);
            // 
            // delete
            // 
            this.delete.AutoSize = true;
            this.delete.Location = new System.Drawing.Point(479, 164);
            this.delete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(124, 26);
            this.delete.TabIndex = 2;
            this.delete.TabStop = true;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // update
            // 
            this.update.AutoSize = true;
            this.update.Location = new System.Drawing.Point(479, 207);
            this.update.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(128, 26);
            this.update.TabIndex = 3;
            this.update.TabStop = true;
            this.update.Text = "Update";
            this.update.UseVisualStyleBackColor = true;
            this.update.CheckedChanged += new System.EventHandler(this.update_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(479, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the command:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // name
            // 
            this.name.ForeColor = System.Drawing.Color.Navy;
            this.name.Location = new System.Drawing.Point(1063, 118);
            this.name.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(253, 29);
            this.name.TabIndex = 5;
            // 
            // quantity
            // 
            this.quantity.ForeColor = System.Drawing.Color.Navy;
            this.quantity.Location = new System.Drawing.Point(1063, 161);
            this.quantity.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(253, 29);
            this.quantity.TabIndex = 6;
            // 
            // color
            // 
            this.color.ForeColor = System.Drawing.Color.Navy;
            this.color.Location = new System.Drawing.Point(1063, 204);
            this.color.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(253, 29);
            this.color.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(878, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Enter the parameters:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(878, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(878, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Quantity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(878, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Color";
            // 
            // output
            // 
            this.output.BackColor = System.Drawing.SystemColors.Window;
            this.output.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.output.ForeColor = System.Drawing.Color.Navy;
            this.output.FormattingEnabled = true;
            this.output.ItemHeight = 22;
            this.output.Location = new System.Drawing.Point(13, 429);
            this.output.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(1303, 268);
            this.output.TabIndex = 13;
            // 
            // statusOutput
            // 
            this.statusOutput.BackColor = System.Drawing.SystemColors.Info;
            this.statusOutput.ForeColor = System.Drawing.Color.Navy;
            this.statusOutput.FormattingEnabled = true;
            this.statusOutput.ItemHeight = 22;
            this.statusOutput.Location = new System.Drawing.Point(13, 67);
            this.statusOutput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statusOutput.Name = "statusOutput";
            this.statusOutput.Size = new System.Drawing.Size(444, 356);
            this.statusOutput.TabIndex = 14;
            this.statusOutput.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // doBtn
            // 
            this.doBtn.BackColor = System.Drawing.Color.Navy;
            this.doBtn.ForeColor = System.Drawing.Color.Moccasin;
            this.doBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.doBtn.Location = new System.Drawing.Point(1133, 369);
            this.doBtn.Name = "doBtn";
            this.doBtn.Size = new System.Drawing.Size(183, 34);
            this.doBtn.TabIndex = 15;
            this.doBtn.Text = "do";
            this.doBtn.UseVisualStyleBackColor = false;
            this.doBtn.Click += new System.EventHandler(this.doBtn_Click);
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(690, 121);
            this.search.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(128, 26);
            this.search.TabIndex = 17;
            this.search.TabStop = true;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(258, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Connection status";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // number
            // 
            this.number.ForeColor = System.Drawing.Color.Navy;
            this.number.Location = new System.Drawing.Point(1063, 251);
            this.number.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(253, 29);
            this.number.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(878, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 22);
            this.label7.TabIndex = 20;
            this.label7.Text = "number";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1333, 709);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.number);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.search);
            this.Controls.Add(this.doBtn);
            this.Controls.Add(this.statusOutput);
            this.Controls.Add(this.output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.color);
            this.Controls.Add(this.quantity);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.showAll);
            this.Font = new System.Drawing.Font("ROG Fonts", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Vegetable Base";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton showAll;
        private System.Windows.Forms.RadioButton add;
        private System.Windows.Forms.RadioButton delete;
        private System.Windows.Forms.RadioButton update;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.ListBox statusOutput;
        private System.Windows.Forms.Button doBtn;
        private System.Windows.Forms.RadioButton search;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label label7;
    }
}

