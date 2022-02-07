
namespace CovidStatistics
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
            this.btnLoadCSV = new System.Windows.Forms.Button();
            this.cmbCountries = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMean = new System.Windows.Forms.Button();
            this.btnStdDeviation = new System.Windows.Forms.Button();
            this.txtMean = new System.Windows.Forms.TextBox();
            this.txtStdDeviation = new System.Windows.Forms.TextBox();
            this.btnFreqByComm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtFrequency = new System.Windows.Forms.TextBox();
            this.btnFreByYear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadCSV
            // 
            this.btnLoadCSV.Location = new System.Drawing.Point(39, 73);
            this.btnLoadCSV.Name = "btnLoadCSV";
            this.btnLoadCSV.Size = new System.Drawing.Size(94, 41);
            this.btnLoadCSV.TabIndex = 0;
            this.btnLoadCSV.Text = "Carica CSV";
            this.btnLoadCSV.UseVisualStyleBackColor = true;
            this.btnLoadCSV.Click += new System.EventHandler(this.btnLoadCSV_Click);
            // 
            // cmbCountries
            // 
            this.cmbCountries.FormattingEnabled = true;
            this.cmbCountries.Location = new System.Drawing.Point(151, 93);
            this.cmbCountries.Name = "cmbCountries";
            this.cmbCountries.Size = new System.Drawing.Size(202, 21);
            this.cmbCountries.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(148, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Countries";
            // 
            // btnMean
            // 
            this.btnMean.Location = new System.Drawing.Point(151, 133);
            this.btnMean.Name = "btnMean";
            this.btnMean.Size = new System.Drawing.Size(94, 27);
            this.btnMean.TabIndex = 7;
            this.btnMean.Text = "Mean";
            this.btnMean.UseVisualStyleBackColor = true;
            this.btnMean.Click += new System.EventHandler(this.btnMean_Click);
            // 
            // btnStdDeviation
            // 
            this.btnStdDeviation.Location = new System.Drawing.Point(151, 166);
            this.btnStdDeviation.Name = "btnStdDeviation";
            this.btnStdDeviation.Size = new System.Drawing.Size(94, 28);
            this.btnStdDeviation.TabIndex = 8;
            this.btnStdDeviation.Text = "Std Deviation";
            this.btnStdDeviation.UseVisualStyleBackColor = true;
            this.btnStdDeviation.Click += new System.EventHandler(this.btnStdDeviation_Click);
            // 
            // txtMean
            // 
            this.txtMean.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMean.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMean.Location = new System.Drawing.Point(263, 133);
            this.txtMean.Name = "txtMean";
            this.txtMean.Size = new System.Drawing.Size(202, 26);
            this.txtMean.TabIndex = 9;
            // 
            // txtStdDeviation
            // 
            this.txtStdDeviation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtStdDeviation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStdDeviation.Location = new System.Drawing.Point(263, 168);
            this.txtStdDeviation.Name = "txtStdDeviation";
            this.txtStdDeviation.Size = new System.Drawing.Size(202, 26);
            this.txtStdDeviation.TabIndex = 10;
            // 
            // btnFreqByComm
            // 
            this.btnFreqByComm.Location = new System.Drawing.Point(38, 200);
            this.btnFreqByComm.Name = "btnFreqByComm";
            this.btnFreqByComm.Size = new System.Drawing.Size(94, 43);
            this.btnFreqByComm.TabIndex = 11;
            this.btnFreqByComm.Text = "Frequency by Commodity";
            this.btnFreqByComm.UseVisualStyleBackColor = true;
            this.btnFreqByComm.Click += new System.EventHandler(this.btnFreqByComm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Firebrick;
            this.label4.Location = new System.Drawing.Point(32, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(608, 31);
            this.label4.TabIndex = 14;
            this.label4.Text = "Effetti del Covid-19 sulle contrattazioni finanziarie";
            // 
            // txtFrequency
            // 
            this.txtFrequency.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFrequency.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFrequency.Location = new System.Drawing.Point(151, 200);
            this.txtFrequency.Multiline = true;
            this.txtFrequency.Name = "txtFrequency";
            this.txtFrequency.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFrequency.Size = new System.Drawing.Size(478, 222);
            this.txtFrequency.TabIndex = 12;
            // 
            // btnFreByYear
            // 
            this.btnFreByYear.Location = new System.Drawing.Point(38, 249);
            this.btnFreByYear.Name = "btnFreByYear";
            this.btnFreByYear.Size = new System.Drawing.Size(94, 42);
            this.btnFreByYear.TabIndex = 15;
            this.btnFreByYear.Text = "Frequency By Year";
            this.btnFreByYear.UseVisualStyleBackColor = true;
            this.btnFreByYear.Click += new System.EventHandler(this.btnFreByYear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 434);
            this.Controls.Add(this.btnFreByYear);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFrequency);
            this.Controls.Add(this.btnFreqByComm);
            this.Controls.Add(this.txtStdDeviation);
            this.Controls.Add(this.txtMean);
            this.Controls.Add(this.btnStdDeviation);
            this.Controls.Add(this.btnMean);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCountries);
            this.Controls.Add(this.btnLoadCSV);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoadCSV;
        private System.Windows.Forms.ComboBox cmbCountries;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMean;
        private System.Windows.Forms.Button btnStdDeviation;
        private System.Windows.Forms.TextBox txtMean;
        private System.Windows.Forms.TextBox txtStdDeviation;
        private System.Windows.Forms.Button btnFreqByComm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFrequency;
        private System.Windows.Forms.Button btnFreByYear;
    }
}

