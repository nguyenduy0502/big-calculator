using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigCaculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            string input = "";
            input = txtInput.Text;
            InputCheck inputCheck=new InputCheck();
          


            if (inputCheck.CheckBracket(input) == false)
            {
                MessageBox.Show("loi thieu dau ngoac ", " thong bao ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (inputCheck.CheckString(input) == false)
            {

                MessageBox.Show(" Error String input ", "ERROR ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                inputCheck.NoNormalString(input);
                input = inputCheck.GetInputString();
                txtPolish.Enabled = true;
                txtPolish.Text = input;

            }

          



        }
    }
}
