namespace LibraryApplication
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
            this.label1 = new System.Windows.Forms.Label();
            this.addQuestion = new System.Windows.Forms.Button();
            this.playQuizBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Buxton Sketch", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(462, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sea Quiz Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addQuestion
            // 
            this.addQuestion.BackColor = System.Drawing.Color.BurlyWood;
            this.addQuestion.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addQuestion.Location = new System.Drawing.Point(251, 129);
            this.addQuestion.Name = "addQuestion";
            this.addQuestion.Size = new System.Drawing.Size(165, 114);
            this.addQuestion.TabIndex = 2;
            this.addQuestion.Text = "ADD QUESTION";
            this.addQuestion.UseVisualStyleBackColor = false;
            this.addQuestion.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // playQuizBtn
            // 
            this.playQuizBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.playQuizBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playQuizBtn.Location = new System.Drawing.Point(25, 129);
            this.playQuizBtn.Name = "playQuizBtn";
            this.playQuizBtn.Size = new System.Drawing.Size(165, 114);
            this.playQuizBtn.TabIndex = 1;
            this.playQuizBtn.Text = "PLAY QUIZ";
            this.playQuizBtn.UseVisualStyleBackColor = false;
            this.playQuizBtn.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.BurlyWood;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(142, 309);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(165, 56);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.BackgroundImage = global::LibraryApplication.Properties.Resources.sea_animal2;
            this.ClientSize = new System.Drawing.Size(462, 367);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.playQuizBtn);
            this.Controls.Add(this.addQuestion);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addQuestion;
        private System.Windows.Forms.Button playQuizBtn;
        private System.Windows.Forms.Button ExitBtn;
    }
}

