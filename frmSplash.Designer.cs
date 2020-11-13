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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
            this.btnCaribbean = new System.Windows.Forms.Button();
            this.btnNorway = new System.Windows.Forms.Button();
            this.btnLakeMinnetonka = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaribbean
            // 
            this.btnCaribbean.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCaribbean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCaribbean.BackgroundImage")));
            this.btnCaribbean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCaribbean.Location = new System.Drawing.Point(12, 12);
            this.btnCaribbean.Name = "btnCaribbean";
            this.btnCaribbean.Size = new System.Drawing.Size(360, 162);
            this.btnCaribbean.TabIndex = 0;
            this.btnCaribbean.UseVisualStyleBackColor = true;
            this.btnCaribbean.Click += new System.EventHandler(this.btnCaribbean_Click);
            // 
            // btnNorway
            // 
            this.btnNorway.BackColor = System.Drawing.SystemColors.Control;
            this.btnNorway.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNorway.BackgroundImage")));
            this.btnNorway.Location = new System.Drawing.Point(12, 180);
            this.btnNorway.Name = "btnNorway";
            this.btnNorway.Size = new System.Drawing.Size(360, 162);
            this.btnNorway.TabIndex = 1;
            this.btnNorway.UseVisualStyleBackColor = false;
            // 
            // btnLakeMinnetonka
            // 
            this.btnLakeMinnetonka.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLakeMinnetonka.BackgroundImage")));
            this.btnLakeMinnetonka.Location = new System.Drawing.Point(12, 348);
            this.btnLakeMinnetonka.Name = "btnLakeMinnetonka";
            this.btnLakeMinnetonka.Size = new System.Drawing.Size(360, 162);
            this.btnLakeMinnetonka.TabIndex = 2;
            this.btnLakeMinnetonka.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(12, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(360, 40);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(384, 564);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLakeMinnetonka);
            this.Controls.Add(this.btnNorway);
            this.Controls.Add(this.btnCaribbean);
            this.Name = "frmSplash";
            this.Text = "Travel Extravaganza!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaribbean;
        private System.Windows.Forms.Button btnNorway;
        private System.Windows.Forms.Button btnLakeMinnetonka;
        private System.Windows.Forms.Button btnExit;
    }
}

