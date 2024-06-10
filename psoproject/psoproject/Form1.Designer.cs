
namespace psoproject
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.nud_parcacık = new System.Windows.Forms.NumericUpDown();
            this.nud_jenerasyon = new System.Windows.Forms.NumericUpDown();
            this.nud_gbest = new System.Windows.Forms.NumericUpDown();
            this.nud_pbest = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_parcacık)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_jenerasyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gbest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pbest)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Parçacık Sayısı(N)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenerasyon Sayısı(G)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "gbest için Fakt.(C1)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "pbest için Fact.(C2)";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(340, 23);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(675, 535);
            this.chart1.TabIndex = 5;
            this.chart1.Text = "chart1";
            // 
            // nud_parcacık
            // 
            this.nud_parcacık.Location = new System.Drawing.Point(214, 23);
            this.nud_parcacık.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_parcacık.Name = "nud_parcacık";
            this.nud_parcacık.Size = new System.Drawing.Size(120, 22);
            this.nud_parcacık.TabIndex = 6;
            // 
            // nud_jenerasyon
            // 
            this.nud_jenerasyon.Location = new System.Drawing.Point(214, 58);
            this.nud_jenerasyon.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_jenerasyon.Name = "nud_jenerasyon";
            this.nud_jenerasyon.Size = new System.Drawing.Size(120, 22);
            this.nud_jenerasyon.TabIndex = 7;
            // 
            // nud_gbest
            // 
            this.nud_gbest.Location = new System.Drawing.Point(214, 94);
            this.nud_gbest.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_gbest.Name = "nud_gbest";
            this.nud_gbest.Size = new System.Drawing.Size(120, 22);
            this.nud_gbest.TabIndex = 8;
            // 
            // nud_pbest
            // 
            this.nud_pbest.Location = new System.Drawing.Point(214, 141);
            this.nud_pbest.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.nud_pbest.Name = "nud_pbest";
            this.nud_pbest.Size = new System.Drawing.Size(120, 22);
            this.nud_pbest.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(269, 48);
            this.button1.TabIndex = 10;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 607);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nud_pbest);
            this.Controls.Add(this.nud_gbest);
            this.Controls.Add(this.nud_jenerasyon);
            this.Controls.Add(this.nud_parcacık);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_parcacık)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_jenerasyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_gbest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_pbest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown nud_parcacık;
        private System.Windows.Forms.NumericUpDown nud_jenerasyon;
        private System.Windows.Forms.NumericUpDown nud_gbest;
        private System.Windows.Forms.NumericUpDown nud_pbest;
        private System.Windows.Forms.Button button1;
    }
}

