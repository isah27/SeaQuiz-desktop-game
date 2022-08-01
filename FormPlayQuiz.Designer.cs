namespace LibraryApplication
{
    partial class FormSearchQuestion
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
            this.buttonSearchByCategory = new System.Windows.Forms.Button();
            this.buttonSearchByType = new System.Windows.Forms.Button();
            this.CBType = new System.Windows.Forms.ComboBox();
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.category = new System.Windows.Forms.Label();
            this.genQuizBtn = new System.Windows.Forms.Button();
            this.backPageBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play Games";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "type: ";
            // 
            // buttonSearchByCategory
            // 
            this.buttonSearchByCategory.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSearchByCategory.FlatAppearance.BorderSize = 0;
            this.buttonSearchByCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByCategory.Location = new System.Drawing.Point(316, 125);
            this.buttonSearchByCategory.Name = "buttonSearchByCategory";
            this.buttonSearchByCategory.Size = new System.Drawing.Size(143, 23);
            this.buttonSearchByCategory.TabIndex = 3;
            this.buttonSearchByCategory.Text = "Play By Category";
            this.buttonSearchByCategory.UseVisualStyleBackColor = false;
            this.buttonSearchByCategory.Click += new System.EventHandler(this.buttonSearchByCategory_Click);
            // 
            // buttonSearchByType
            // 
            this.buttonSearchByType.BackColor = System.Drawing.Color.PeachPuff;
            this.buttonSearchByType.FlatAppearance.BorderSize = 0;
            this.buttonSearchByType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearchByType.Location = new System.Drawing.Point(316, 76);
            this.buttonSearchByType.Name = "buttonSearchByType";
            this.buttonSearchByType.Size = new System.Drawing.Size(143, 23);
            this.buttonSearchByType.TabIndex = 4;
            this.buttonSearchByType.Text = "Play By Type";
            this.buttonSearchByType.UseVisualStyleBackColor = false;
            this.buttonSearchByType.Click += new System.EventHandler(this.buttonSearchByTypes_Click);
            // 
            // CBType
            // 
            this.CBType.FormattingEnabled = true;
            this.CBType.Location = new System.Drawing.Point(107, 77);
            this.CBType.Name = "CBType";
            this.CBType.Size = new System.Drawing.Size(190, 21);
            this.CBType.TabIndex = 5;
            // 
            // CBCategory
            // 
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(107, 126);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(190, 21);
            this.CBCategory.TabIndex = 6;
            // 
            // category
            // 
            this.category.AutoSize = true;
            this.category.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category.Location = new System.Drawing.Point(43, 128);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(62, 17);
            this.category.TabIndex = 7;
            this.category.Text = "category:";
            // 
            // genQuizBtn
            // 
            this.genQuizBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.genQuizBtn.FlatAppearance.BorderSize = 0;
            this.genQuizBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.genQuizBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genQuizBtn.Location = new System.Drawing.Point(107, 173);
            this.genQuizBtn.Name = "genQuizBtn";
            this.genQuizBtn.Size = new System.Drawing.Size(190, 55);
            this.genQuizBtn.TabIndex = 10;
            this.genQuizBtn.Text = "General Quiz";
            this.genQuizBtn.UseVisualStyleBackColor = false;
            this.genQuizBtn.Click += new System.EventHandler(this.genQuizBtn_Click_1);
            // 
            // backPageBtn
            // 
            this.backPageBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.backPageBtn.BackgroundImage = global::LibraryApplication.Properties.Resources.icons8_double_left_30px_1;
            this.backPageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPageBtn.FlatAppearance.BorderSize = 0;
            this.backPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backPageBtn.Location = new System.Drawing.Point(1, 0);
            this.backPageBtn.Name = "backPageBtn";
            this.backPageBtn.Size = new System.Drawing.Size(52, 26);
            this.backPageBtn.TabIndex = 21;
            this.backPageBtn.UseVisualStyleBackColor = false;
            this.backPageBtn.Click += new System.EventHandler(this.backPageBtn_Click);
            // 
            // FormSearchQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(489, 293);
            this.Controls.Add(this.backPageBtn);
            this.Controls.Add(this.genQuizBtn);
            this.Controls.Add(this.category);
            this.Controls.Add(this.CBCategory);
            this.Controls.Add(this.CBType);
            this.Controls.Add(this.buttonSearchByType);
            this.Controls.Add(this.buttonSearchByCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FormSearchQuestion";
            this.ShowIcon = false;
            this.Text = "FormSearchQuestion";
            this.Load += new System.EventHandler(this.FormSearchQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSearchByCategory;
        private System.Windows.Forms.Button buttonSearchByType;
        private System.Windows.Forms.ComboBox CBType;
        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.Label category;
        private System.Windows.Forms.Button genQuizBtn;
        private System.Windows.Forms.Button backPageBtn;
    }
}