using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Statistic
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            double prob1 = (double) numericProb1.Value * 0.01;
            double prob2 = (double)numericProb2.Value * 0.01;
            double prob3 = (double)numericProb3.Value * 0.01;
            double prob4 = (double)numericProb4.Value * 0.01;
            int experiments = (int) numericExperiments.Value;

            List<int> data = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                data.Add(0);
            }

            for (int i = 0; i < experiments; i++)
            {
                data[GenerateEvent(prob1, prob2, prob3, prob4)]++;
            }

            for (int i = 0; i < 5; i++)
            {
                double h = (double)data[i] / experiments;
                chart1.Series[0].Points.AddXY(i + 1, h);
            }
        }

        private int GenerateEvent(double prob1, double prob2, double prob3, double prob4)
        {
            double x = rand.NextDouble();

            x -= prob1;
            if (x <= 0)
                return 0;

            x -= prob2;
            if (x <= 0)
                return 1;

            x -= prob3;
            if (x <= 0)
                return 2;

            x -= prob4;
            if (x <= 0)
                return 3;

            return 4;
        }
    }
}
