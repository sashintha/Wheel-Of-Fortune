using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wheel_Of_Fortune
{
    public partial class Form1 : Form
    {
        //Character Variable ( Bob = 1, Sarah = 2, Gilbert = 3, Emma = 4 )
        int character = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //Changes to second form
        private void changeform()
        {
            Form2 mainform = new Form2(character);
            mainform.Show();
            this.Hide();
        }

        private void picBob_Click(object sender, EventArgs e)
        {
            character = 1;
            changeform();
        }

        private void picSarah_Click(object sender, EventArgs e)
        {
            character = 2;
            changeform();
        }

        private void picGilbert_Click(object sender, EventArgs e)
        {
            character = 3;
            changeform();
        }

        private void picEmma_Click(object sender, EventArgs e)
        {
            character = 4;
            changeform();
        }

    }
}
