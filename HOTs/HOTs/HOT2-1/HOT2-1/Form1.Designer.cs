namespace HOT2_1
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
            this.lblValueYards = new System.Windows.Forms.Label();
            this.lblValueMeters = new System.Windows.Forms.Label();
            this.txtYards = new System.Windows.Forms.TextBox();
            this.txtMeters = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblValueYards
            // 
            this.lblValueYards.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueYards.Location = new System.Drawing.Point(-1, 50);
            this.lblValueYards.Name = "lblValueYards";
            this.lblValueYards.Size = new System.Drawing.Size(251, 37);
            this.lblValueYards.TabIndex = 0;
            this.lblValueYards.Text = "Enter Value for Yards:";
            this.lblValueYards.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValueYards.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblValueMeters
            // 
            this.lblValueMeters.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValueMeters.Location = new System.Drawing.Point(-1, 115);
            this.lblValueMeters.Name = "lblValueMeters";
            this.lblValueMeters.Size = new System.Drawing.Size(251, 37);
            this.lblValueMeters.TabIndex = 1;
            this.lblValueMeters.Text = "Value In Meters: ";
            this.lblValueMeters.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblValueMeters.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtYards
            // 
            this.txtYards.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYards.Location = new System.Drawing.Point(256, 54);
            this.txtYards.Name = "txtYards";
            this.txtYards.Size = new System.Drawing.Size(219, 29);
            this.txtYards.TabIndex = 2;
            this.txtYards.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtMeters
            // 
            this.txtMeters.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMeters.Location = new System.Drawing.Point(256, 119);
            this.txtMeters.Name = "txtMeters";
            this.txtMeters.ReadOnly = true;
            this.txtMeters.Size = new System.Drawing.Size(219, 29);
            this.txtMeters.TabIndex = 3;
            this.txtMeters.TextChanged += new System.EventHandler(this.txtMeters_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(37, 198);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 61);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(229, 198);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(129, 61);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(422, 198);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 61);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(601, 298);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtMeters);
            this.Controls.Add(this.txtYards);
            this.Controls.Add(this.lblValueMeters);
            this.Controls.Add(this.lblValueYards);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValueYards;
        private System.Windows.Forms.Label lblValueMeters;
        private System.Windows.Forms.TextBox txtYards;
        private System.Windows.Forms.TextBox txtMeters;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

