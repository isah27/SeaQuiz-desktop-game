
namespace LibraryApplication
{
    partial class PlayPage
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
            this.questionLabel = new System.Windows.Forms.Label();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.backPageBtn = new System.Windows.Forms.Button();
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.questionLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.questionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(31, 31);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(451, 210);
            this.questionLabel.TabIndex = 14;
            this.questionLabel.Text = "WELCOME TO A SEA QIUZ";
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonB.Location = new System.Drawing.Point(31, 303);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(14, 13);
            this.radioButtonB.TabIndex = 17;
            this.radioButtonB.UseVisualStyleBackColor = true;
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonC.Location = new System.Drawing.Point(31, 354);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(14, 13);
            this.radioButtonC.TabIndex = 16;
            this.radioButtonC.UseVisualStyleBackColor = true;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA.Location = new System.Drawing.Point(31, 244);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(14, 13);
            this.radioButtonA.TabIndex = 15;
            this.radioButtonA.UseVisualStyleBackColor = true;
            // 
            // backPageBtn
            // 
            this.backPageBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.backPageBtn.BackgroundImage = global::LibraryApplication.Properties.Resources.icons8_double_left_30px_1;
            this.backPageBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backPageBtn.FlatAppearance.BorderSize = 0;
            this.backPageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backPageBtn.Location = new System.Drawing.Point(2, 2);
            this.backPageBtn.Name = "backPageBtn";
            this.backPageBtn.Size = new System.Drawing.Size(43, 26);
            this.backPageBtn.TabIndex = 20;
            this.backPageBtn.UseVisualStyleBackColor = false;
            this.backPageBtn.Click += new System.EventHandler(this.backPageBtn_Click);
            // 
            // previousBtn
            // 
            this.previousBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.previousBtn.BackgroundImage = global::LibraryApplication.Properties.Resources.image;
            this.previousBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.previousBtn.FlatAppearance.BorderSize = 0;
            this.previousBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousBtn.Location = new System.Drawing.Point(149, 379);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(75, 36);
            this.previousBtn.TabIndex = 19;
            this.previousBtn.UseVisualStyleBackColor = false;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.BackColor = System.Drawing.Color.PeachPuff;
            this.nextBtn.BackgroundImage = global::LibraryApplication.Properties.Resources.image_1_;
            this.nextBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextBtn.FlatAppearance.BorderSize = 0;
            this.nextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextBtn.Location = new System.Drawing.Point(266, 379);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(75, 36);
            this.nextBtn.TabIndex = 18;
            this.nextBtn.UseVisualStyleBackColor = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // PlayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(511, 419);
            this.Controls.Add(this.backPageBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.radioButtonB);
            this.Controls.Add(this.radioButtonC);
            this.Controls.Add(this.radioButtonA);
            this.Controls.Add(this.questionLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PlayPage";
            this.Text = "PlayPage";
            this.Load += new System.EventHandler(this.PlayPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button backPageBtn;
    }
}