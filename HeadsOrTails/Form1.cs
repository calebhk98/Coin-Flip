using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HeadsOrTails
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void headBtn_Click(object sender, EventArgs e)
        {
            tailPic.Visible = false;
            headPic.Visible = true;
            randPic.Image = HeadsOrTails.Properties.Resources.Heads1;

        }

        private void tailBtn_Click(object sender, EventArgs e)
        {
            headPic.Visible = false;
            tailPic.Visible = true;
            randPic.Image = HeadsOrTails.Properties.Resources.Tails1;
        }

        private void randBtn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 2);
            
            if (randomNumber >= 1)
            {
                tailPic.Visible = false;
                headPic.Visible = true;
                randPic.Image = HeadsOrTails.Properties.Resources.Heads1;
                

            }
            else {
                headPic.Visible = false;
                tailPic.Visible = true;
                randPic.Image = HeadsOrTails.Properties.Resources.Tails1;
            }
            
        }
    }
}
