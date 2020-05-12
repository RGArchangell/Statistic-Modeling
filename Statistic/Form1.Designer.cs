namespace Statistic
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericExperiments = new System.Windows.Forms.NumericUpDown();
            this.numericProb1 = new System.Windows.Forms.NumericUpDown();
            this.numericProb2 = new System.Windows.Forms.NumericUpDown();
            this.numericProb3 = new System.Windows.Forms.NumericUpDown();
            this.numericProb4 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExperiments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prob 1 = 0,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prob 2 = 0,";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prob 3 = 0,";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prob 4 = 0.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Prob 5  =  auto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Num of experiments";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Launch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(221, 42);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(658, 420);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            // 
            // numericExperiments
            // 
            this.numericExperiments.Location = new System.Drawing.Point(118, 215);
            this.numericExperiments.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numericExperiments.Name = "numericExperiments";
            this.numericExperiments.Size = new System.Drawing.Size(76, 20);
            this.numericExperiments.TabIndex = 8;
            // 
            // numericProb1
            // 
            this.numericProb1.Location = new System.Drawing.Point(67, 40);
            this.numericProb1.Name = "numericProb1";
            this.numericProb1.Size = new System.Drawing.Size(64, 20);
            this.numericProb1.TabIndex = 9;
            // 
            // numericProb2
            // 
            this.numericProb2.Location = new System.Drawing.Point(67, 67);
            this.numericProb2.Name = "numericProb2";
            this.numericProb2.Size = new System.Drawing.Size(64, 20);
            this.numericProb2.TabIndex = 10;
            // 
            // numericProb3
            // 
            this.numericProb3.Location = new System.Drawing.Point(67, 95);
            this.numericProb3.Name = "numericProb3";
            this.numericProb3.Size = new System.Drawing.Size(64, 20);
            this.numericProb3.TabIndex = 11;
            // 
            // numericProb4
            // 
            this.numericProb4.Location = new System.Drawing.Point(67, 122);
            this.numericProb4.Name = "numericProb4";
            this.numericProb4.Size = new System.Drawing.Size(64, 20);
            this.numericProb4.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 588);
            this.Controls.Add(this.numericProb4);
            this.Controls.Add(this.numericProb3);
            this.Controls.Add(this.numericProb2);
            this.Controls.Add(this.numericProb1);
            this.Controls.Add(this.numericExperiments);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericExperiments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericProb4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.NumericUpDown numericExperiments;
        private System.Windows.Forms.NumericUpDown numericProb1;
        private System.Windows.Forms.NumericUpDown numericProb2;
        private System.Windows.Forms.NumericUpDown numericProb3;
        private System.Windows.Forms.NumericUpDown numericProb4;
    }
}

