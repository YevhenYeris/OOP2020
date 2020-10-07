using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifthAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ResetBoxes();
        }

        private void selectLayout_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void calculate_Click(object sender, EventArgs e)
        {
            List<TextBox> measurements = new List<TextBox>();
            measurements.Add(textBox1);
            measurements.Add(textBox2);
            measurements.Add(textBox3);

            try
            {
                List<double> mValues = new List<double>();
                
                foreach(var i in measurements)
                {
                    if (Double.Parse(i.Text) < 0)
                    {
                        throw new Exception("Введено неправильні значення.");
                    }
                    mValues.Add(Double.Parse(i.Text));         
                }
           
                FigureManager fM = new FigureManager(selectFigure.SelectedIndex, mValues);         

                switch (selectAction.SelectedIndex)
                {
                    case 0: resultBox.Text = fM.GetPerimeter().ToString();
                        break;
                    case 1: resultBox.Text = fM.GetArea().ToString();
                        break;
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Виникла помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
        

        private void ManageBoxes(int index)
        {
            switch(index)
            {
                case 0: SetTriangle();
                    break;
                case 1: SetCircle();
                    break;
                case 2: SetRectangle();
                    break;
                case 3: SetSquare();
                    break;
                case 4: SetRhombus();
                    break;
            }
        }

        private void SetCircle()
        {
            ResetBoxes();
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "радіус r";
        }

        private void SetTriangle()
        {
            ResetBoxes();
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "сторона a";
            textBox2.Visible = true;
            label2.Visible = true;
            label2.Text = "сторона b";
            textBox3.Visible = true;
            label3.Visible = true;
            label3.Text = "сторона c";
        }

        private void SetRectangle()
        {
            ResetBoxes();
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "сторона a";
            textBox2.Visible = true;
            label2.Visible = true;
            label2.Text = "сторона b";
        }

        private void SetSquare()
        {
            ResetBoxes();
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "сторона a";
        }

        private void SetRhombus()
        {
            ResetBoxes();
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "сторона a";
            textBox2.Visible = true;
            label2.Visible = true;
            label2.Text = "кут А";
        }

        private void ResetBoxes()
        {
            textBox1.Visible = false;
            textBox1.Text = "0";
            label1.Visible = false;
            label1.Text = "";
            textBox2.Visible = false;
            textBox2.Text = "0";
            label2.Visible = false;
            label2.Text = "";
            textBox3.Visible = false;
            textBox3.Text = "0";
            label3.Visible = false;
            label3.Text = "";
        }
        private void selectFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManageBoxes(selectFigure.SelectedIndex);
        }

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
