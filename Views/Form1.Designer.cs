namespace APIGen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxIMG = new System.Windows.Forms.PictureBox();
            this.buttonGEN = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxIMG
            // 
            this.pictureBoxIMG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxIMG.Location = new System.Drawing.Point(25, 65);
            this.pictureBoxIMG.Name = "pictureBoxIMG";
            this.pictureBoxIMG.Size = new System.Drawing.Size(814, 554);
            this.pictureBoxIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxIMG.TabIndex = 0;
            this.pictureBoxIMG.TabStop = false;
            // 
            // buttonGEN
            // 
            this.buttonGEN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGEN.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGEN.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonGEN.Location = new System.Drawing.Point(340, 631);
            this.buttonGEN.Name = "buttonGEN";
            this.buttonGEN.Size = new System.Drawing.Size(165, 38);
            this.buttonGEN.TabIndex = 1;
            this.buttonGEN.Text = "RANDOM";
            this.buttonGEN.UseVisualStyleBackColor = true;
            this.buttonGEN.Click += new System.EventHandler(this.buttonGEN_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(31, 30);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(142, 28);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "IMG RANDOM";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(863, 682);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.buttonGEN);
            this.Controls.Add(this.pictureBoxIMG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = " API Random IMG ";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxIMG;
        private System.Windows.Forms.Button buttonGEN;
        private System.Windows.Forms.Label labelTitle;
    }
}

