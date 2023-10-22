namespace DormAndMealPlan
{
    partial class frmChargesTotal
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
            this.textBoxForm2 = new System.Windows.Forms.TextBox();
            this.btnMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxForm2
            // 
            this.textBoxForm2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxForm2.Location = new System.Drawing.Point(35, 35);
            this.textBoxForm2.MaximumSize = new System.Drawing.Size(175, 150);
            this.textBoxForm2.MinimumSize = new System.Drawing.Size(200, 200);
            this.textBoxForm2.Multiline = true;
            this.textBoxForm2.Name = "textBoxForm2";
            this.textBoxForm2.Size = new System.Drawing.Size(200, 200);
            this.textBoxForm2.TabIndex = 0;
            this.textBoxForm2.TextChanged += new System.EventHandler(this.textBoxForm2_TextChanged);
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMain.Location = new System.Drawing.Point(271, 113);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(95, 49);
            this.btnMain.TabIndex = 1;
            this.btnMain.Text = "Main Form";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // frmChargesTotal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(413, 270);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.textBoxForm2);
            this.Name = "frmChargesTotal";
            this.Text = "Total Charges";
            this.Load += new System.EventHandler(this.frmChargesTotal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxForm2;
        private System.Windows.Forms.Button btnMain;
    }
}