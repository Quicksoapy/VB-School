using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test1WF
{
    public partial class People : Form
    {
        public People()
        {
            InitializeComponent();
        }

        private void People_Load(object sender, EventArgs e)
        {
            pbPerson1.Load("https://thispersondoesnotexist.com/image?a=37645734567");
            System.Threading.Thread.Sleep(1002);
            pbPerson2.Load("https://thispersondoesnotexist.com/image?a=67834562543");
            System.Threading.Thread.Sleep(1002);
            pbPerson3.Load("https://thispersondoesnotexist.com/image?a=33622434768");
            System.Threading.Thread.Sleep(1002);
            pbPerson4.Load("https://thispersondoesnotexist.com/image?a=34688707547");

            
            

        }
        private void pbPerson1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            Random rd = new Random();

            int rand_num = rd.Next(1, 5);
            { 

            if (rand_num == 1) 
            {
                string message = "Lmao that person had aids too bad for you";
                string title = "You failed";

                MessageBox.Show(message, title);
                this.Close();
            }
            else
            {
                this.Close();
            }

        }

        private void pbPerson2_Click(object sender, EventArgs e)
        {
            int Person2 = RandomNumber;


            if (Person2 == 1);
            {
                string message = "aaaaaaaaa";
                MessageBox.Show(message);
            }
        }

        private void pbPerson3_Click(object sender, EventArgs e)
        {
            int Person3 = RandomNumber;
        }

        private void pbPerson4_Click(object sender, EventArgs e)
        {
            int Person4 = RandomNumber;
        }
    }
}
