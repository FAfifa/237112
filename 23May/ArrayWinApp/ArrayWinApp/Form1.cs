using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayWinApp
{
    
    public partial class ArrayForm : Form
    {
        int index = 0;
        const int size = 10;
        int[] number = new int[size];
        public ArrayForm()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ArrayForm_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            number[index] = Convert.ToInt32(AddTextBox.Text);
            index++;
            string message = " ";

            for (int index = 0; index < number.Length; index++)
            {
                if (number[index]!=0)
                message = message + "Value of Number [" + index + "] is" + " " + number[index] + "\n";
                ArrayRichTextBox.Text = message;
            }

        }

        private void ReverseButton_Click(object sender, EventArgs e)
        {
            string message = " ";

            for ( int index = (number.Length-1);index>=0; index--)
            {
                if (number[index] != 0)
                    message = message + "Value of Number [" + index + "] is" + " " + number[index] + "\n";
                ArrayRichTextBox.Text = message;
            }
        }

        private void SumButton_Click(object sender, EventArgs e)
        {

        }
    }
}
