namespace Yunos_Aifa_02_Lab
{
    partial class NowServingForm
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
            this.lblNowServing = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNowServing
            // 
            this.lblNowServing.AutoSize = true;
            this.lblNowServing.Font = new System.Drawing.Font("Calisto MT", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowServing.Location = new System.Drawing.Point(67, 105);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(296, 50);
            this.lblNowServing.TabIndex = 0;
            this.lblNowServing.Text = "*Now Serving";
            this.lblNowServing.Click += new System.EventHandler(this.lblNowServing_Click);
            // 
            // NowServingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNowServing);
            this.Name = "NowServingForm";
            this.Text = "NowServingForm";
            this.Load += new System.EventHandler(this.NowServingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowServing;
    }
}