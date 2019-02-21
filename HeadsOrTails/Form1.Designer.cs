namespace HeadsOrTails
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
            this.headPic = new System.Windows.Forms.PictureBox();
            this.randPic = new System.Windows.Forms.PictureBox();
            this.tailPic = new System.Windows.Forms.PictureBox();
            this.headBtn = new System.Windows.Forms.Button();
            this.randBtn = new System.Windows.Forms.Button();
            this.tailBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.headPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.randPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPic)).BeginInit();
            this.SuspendLayout();
            // 
            // headPic
            // 
            this.headPic.Image = global::HeadsOrTails.Properties.Resources.Heads1;
            this.headPic.Location = new System.Drawing.Point(12, 12);
            this.headPic.Name = "headPic";
            this.headPic.Size = new System.Drawing.Size(232, 189);
            this.headPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.headPic.TabIndex = 0;
            this.headPic.TabStop = false;
            this.headPic.Visible = false;
            // 
            // randPic
            // 
            this.randPic.Location = new System.Drawing.Point(292, 12);
            this.randPic.Name = "randPic";
            this.randPic.Size = new System.Drawing.Size(232, 189);
            this.randPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.randPic.TabIndex = 1;
            this.randPic.TabStop = false;
            // 
            // tailPic
            // 
            this.tailPic.Image = global::HeadsOrTails.Properties.Resources.Tails1;
            this.tailPic.Location = new System.Drawing.Point(568, 12);
            this.tailPic.Name = "tailPic";
            this.tailPic.Size = new System.Drawing.Size(232, 189);
            this.tailPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.tailPic.TabIndex = 2;
            this.tailPic.TabStop = false;
            this.tailPic.Visible = false;
            // 
            // headBtn
            // 
            this.headBtn.Location = new System.Drawing.Point(38, 232);
            this.headBtn.Name = "headBtn";
            this.headBtn.Size = new System.Drawing.Size(172, 47);
            this.headBtn.TabIndex = 3;
            this.headBtn.Text = "Show Heads";
            this.headBtn.UseVisualStyleBackColor = true;
            this.headBtn.Click += new System.EventHandler(this.headBtn_Click);
            // 
            // randBtn
            // 
            this.randBtn.Location = new System.Drawing.Point(307, 232);
            this.randBtn.Name = "randBtn";
            this.randBtn.Size = new System.Drawing.Size(172, 47);
            this.randBtn.TabIndex = 4;
            this.randBtn.Text = "Show Random";
            this.randBtn.UseVisualStyleBackColor = true;
            this.randBtn.Click += new System.EventHandler(this.randBtn_Click);
            // 
            // tailBtn
            // 
            this.tailBtn.Location = new System.Drawing.Point(602, 232);
            this.tailBtn.Name = "tailBtn";
            this.tailBtn.Size = new System.Drawing.Size(172, 47);
            this.tailBtn.TabIndex = 5;
            this.tailBtn.Text = "Show Tails";
            this.tailBtn.UseVisualStyleBackColor = true;
            this.tailBtn.Click += new System.EventHandler(this.tailBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 324);
            this.Controls.Add(this.tailBtn);
            this.Controls.Add(this.randBtn);
            this.Controls.Add(this.headBtn);
            this.Controls.Add(this.tailPic);
            this.Controls.Add(this.randPic);
            this.Controls.Add(this.headPic);
            this.Name = "Form1";
            this.Text = "Heads Or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.headPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.randPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tailPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox headPic;
        private System.Windows.Forms.PictureBox randPic;
        private System.Windows.Forms.PictureBox tailPic;
        private System.Windows.Forms.Button headBtn;
        private System.Windows.Forms.Button randBtn;
        private System.Windows.Forms.Button tailBtn;
    }
}

