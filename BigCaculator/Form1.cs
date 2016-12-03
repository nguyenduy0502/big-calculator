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

         InputCheck testInputCheck=new InputCheck();
            if (testInputCheck.CheckInput(txtInput.Text)==false || testInputCheck.CheckBracket(txtInput.Text)==false ||
                testInputCheck.ChekString(txtInput.Text)==false)
            {
                MessageBox.Show("loi roi ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
            }
            else
            {
                MessageBox.Show("ok ", " ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
          



        }
    }
}
