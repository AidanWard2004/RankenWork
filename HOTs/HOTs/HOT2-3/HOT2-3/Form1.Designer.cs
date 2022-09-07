namespace HOT2_3
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
            this.lblDrivewayLength = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtDrivewayLength = new System.Windows.Forms.TextBox();
            this.txtDrivewayFee = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDrivewayLength
            // 
            this.lblDrivewayLength.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivewayLength.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDrivewayLength.Location = new System.Drawing.Point(162, 65);
            this.lblDrivewayLength.Name = "lblDrivewayLength";
            this.lblDrivewayLength.Size = new System.Drawing.Size(189, 26);
            this.lblDrivewayLength.TabIndex = 0;
            this.lblDrivewayLength.Text = "Driveway Length (In Feet):";
            this.lblDrivewayLength.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(67, 238);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(149, 55);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtDrivewayLength
            // 
            this.txtDrivewayLength.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrivewayLength.Location = new System.Drawing.Point(357, 61);
            this.txtDrivewayLength.Name = "txtDrivewayLength";
            this.txtDrivewayLength.Size = new System.Drawing.Size(100, 26);
            this.txtDrivewayLength.TabIndex = 2;
            this.txtDrivewayLength.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDrivewayFee
            // 
            this.txtDrivewayFee.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDrivewayFee.Location = new System.Drawing.Point(67, 149);
            this.txtDrivewayFee.Name = "txtDrivewayFee";
            this.txtDrivewayFee.Size = new System.Drawing.Size(551, 29);
            this.txtDrivewayFee.TabIndex = 3;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(278, 238);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(149, 55);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(480, 238);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(149, 55);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 367);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtDrivewayFee);
            this.Controls.Add(this.txtDrivewayLength);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblDrivewayLength);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDrivewayLength;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtDrivewayLength;
        private System.Windows.Forms.TextBox txtDrivewayFee;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

