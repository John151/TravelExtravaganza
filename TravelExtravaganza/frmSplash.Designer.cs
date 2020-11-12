namespace TravelExtravaganza
{
    partial class frmSplash
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
            this.btnCaribbean = new System.Windows.Forms.Button();
            this.btnNorway = new System.Windows.Forms.Button();
            this.btnLakeMinnetonka = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCaribbean
            // 
            this.btnCaribbean.Location = new System.Drawing.Point(12, 150);
            this.btnCaribbean.Name = "btnCaribbean";
            this.btnCaribbean.Size = new System.Drawing.Size(393, 87);
            this.btnCaribbean.TabIndex = 0;
            this.btnCaribbean.Text = "Caribbean";
            this.btnCaribbean.UseVisualStyleBackColor = true;
            this.btnCaribbean.Click += new System.EventHandler(this.btnCaribbean_Click);
            // 
            // btnNorway
            // 
            this.btnNorway.Location = new System.Drawing.Point(12, 243);
            this.btnNorway.Name = "btnNorway";
            this.btnNorway.Size = new System.Drawing.Size(393, 87);
            this.btnNorway.TabIndex = 1;
            this.btnNorway.Text = "Norway";
            this.btnNorway.UseVisualStyleBackColor = true;
            // 
            // btnLakeMinnetonka
            // 
            this.btnLakeMinnetonka.Location = new System.Drawing.Point(12, 336);
            this.btnLakeMinnetonka.Name = "btnLakeMinnetonka";
            this.btnLakeMinnetonka.Size = new System.Drawing.Size(393, 87);
            this.btnLakeMinnetonka.TabIndex = 2;
            this.btnLakeMinnetonka.Text = "Lake Minnetonka";
            this.btnLakeMinnetonka.UseVisualStyleBackColor = true;
            // 
            // picLogo
            // 
            this.picLogo.Location = new System.Drawing.Point(12, 12);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(393, 132);
            this.picLogo.TabIndex = 3;
            this.picLogo.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(13, 430);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(392, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(417, 482);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picLogo);
            this.Controls.Add(this.btnLakeMinnetonka);
            this.Controls.Add(this.btnNorway);
            this.Controls.Add(this.btnCaribbean);
            this.Name = "frmSplash";
            this.Text = "Travel Extravaganza!";
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaribbean;
        private System.Windows.Forms.Button btnNorway;
        private System.Windows.Forms.Button btnLakeMinnetonka;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button btnExit;
    }
}

