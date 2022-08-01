namespace LibraryApplication
{
    partial class FormAddQuestion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.catdropdown = new System.Windows.Forms.ComboBox();
            this.typedropdown = new System.Windows.Forms.ComboBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.qusetiontxt = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.optionAtxt = new System.Windows.Forms.TextBox();
            this.optionBtxt = new System.Windows.Forms.TextBox();
            this.optionCtxt = new System.Windows.Forms.TextBox();
            this.answerdropdown = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Questions:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "category:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "type:";
            // 
            // catdropdown
            // 
            this.catdropdown.FormattingEnabled = true;
            this.catdropdown.Location = new System.Drawing.Point(129, 91);
            this.catdropdown.Margin = new System.Windows.Forms.Padding(4);
            this.catdropdown.Name = "catdropdown";
            this.catdropdown.Size = new System.Drawing.Size(265, 25);
            this.catdropdown.TabIndex = 1;
            // 
            // typedropdown
            // 
            this.typedropdown.FormattingEnabled = true;
            this.typedropdown.Location = new System.Drawing.Point(129, 146);
            this.typedropdown.Margin = new System.Windows.Forms.Padding(4);
            this.typedropdown.Name = "typedropdown";
            this.typedropdown.Size = new System.Drawing.Size(265, 25);
            this.typedropdown.TabIndex = 2;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(37, 201);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(59, 17);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "question:";
            // 
            // qusetiontxt
            // 
            this.qusetiontxt.Location = new System.Drawing.Point(129, 197);
            this.qusetiontxt.Margin = new System.Windows.Forms.Padding(4);
            this.qusetiontxt.Name = "qusetiontxt";
            this.qusetiontxt.Size = new System.Drawing.Size(265, 24);
            this.qusetiontxt.TabIndex = 3;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.BurlyWood;
            this.buttonSave.Location = new System.Drawing.Point(127, 480);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(267, 49);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save Question";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelOutput.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOutput.ForeColor = System.Drawing.Color.Maroon;
            this.LabelOutput.Location = new System.Drawing.Point(199, 436);
            this.LabelOutput.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(2, 21);
            this.LabelOutput.TabIndex = 8;
            this.LabelOutput.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LabelOutput.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 255);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "optionA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 311);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "optionB:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 360);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "optionC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 406);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "answer";
            // 
            // optionAtxt
            // 
            this.optionAtxt.Location = new System.Drawing.Point(129, 251);
            this.optionAtxt.Margin = new System.Windows.Forms.Padding(4);
            this.optionAtxt.Name = "optionAtxt";
            this.optionAtxt.Size = new System.Drawing.Size(265, 24);
            this.optionAtxt.TabIndex = 4;
            // 
            // optionBtxt
            // 
            this.optionBtxt.Location = new System.Drawing.Point(129, 307);
            this.optionBtxt.Margin = new System.Windows.Forms.Padding(4);
            this.optionBtxt.Name = "optionBtxt";
            this.optionBtxt.Size = new System.Drawing.Size(265, 24);
            this.optionBtxt.TabIndex = 5;
            // 
            // optionCtxt
            // 
            this.optionCtxt.Location = new System.Drawing.Point(129, 356);
            this.optionCtxt.Margin = new System.Windows.Forms.Padding(4);
            this.optionCtxt.Name = "optionCtxt";
            this.optionCtxt.Size = new System.Drawing.Size(265, 24);
            this.optionCtxt.TabIndex = 6;
            // 
            // answerdropdown
            // 
            this.answerdropdown.FormattingEnabled = true;
            this.answerdropdown.Location = new System.Drawing.Point(129, 402);
            this.answerdropdown.Margin = new System.Windows.Forms.Padding(4);
            this.answerdropdown.Name = "answerdropdown";
            this.answerdropdown.Size = new System.Drawing.Size(265, 25);
            this.answerdropdown.TabIndex = 7;
            this.answerdropdown.Click += new System.EventHandler(this.answerdropdown_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.BackgroundImage = global::LibraryApplication.Properties.Resources.icons8_double_left_30px_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 29);
            this.button1.TabIndex = 14;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(488, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.answerdropdown);
            this.Controls.Add(this.optionCtxt);
            this.Controls.Add(this.optionBtxt);
            this.Controls.Add(this.optionAtxt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.qusetiontxt);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.typedropdown);
            this.Controls.Add(this.catdropdown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormAddQuestion";
            this.ShowIcon = false;
            this.Text = "Add Question";
            this.Load += new System.EventHandler(this.FormAddQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox catdropdown;
        private System.Windows.Forms.ComboBox typedropdown;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox qusetiontxt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label LabelOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox optionAtxt;
        private System.Windows.Forms.TextBox optionBtxt;
        private System.Windows.Forms.TextBox optionCtxt;
        private System.Windows.Forms.ComboBox answerdropdown;
        private System.Windows.Forms.Button button1;
    }
}