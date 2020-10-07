using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FourthAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Triangle triangle = Triangle.Create(sideA.Text, sideB.Text, sideC.Text);

                switch (selectAction.SelectedIndex)
                {
                    case 0: showResult("P = " + Convert.ToString(triangle.GetPerimeter()));
                        break;
                    case 1: showResult(triangle.GetAngles());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void showResult(string res)
        {
            result.Text = res;
            result.SelectAll();
            result.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sideA_TextChanged(object sender, EventArgs e)
        {
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void sideC_TextChanged(object sender, EventArgs e)
        {
        }

        private void sideB_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
