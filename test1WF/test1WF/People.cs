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
            HasAutism();
        }

        private void pbPerson1_Click_1(object sender, EventArgs e)
        {
            HasAutism();
        }

        private void pbPerson2_Click(object sender, EventArgs e)
        {
            HasAutism();
        }

        private void pbPerson3_Click(object sender, EventArgs e)
        {
            HasAutism();
        }

        private void pbPerson4_Click(object sender, EventArgs e)
        {
            HasAutism();
        }

        private void HasAutism()
        {
            Random rand = new Random();
            Random rd = new Random();

            int rand_num = rd.Next(1, 5);
            {

                if (rand_num == 1)
                {
                    string message = "Lmao that person is autistic as fuck too bad for you";
                    string title = "You failed";

                    MessageBox.Show(message, title);

                    var form = new test1WF();
                    form.ShowDialog();
                    this.Hide();
                }
                else
                {
                    string message = "That person doesn't have autism, good job";
                    string title = "Nice";

                    MessageBox.Show(message, title);
                    int result = int.Parse(textBox1.Text) + 1;
                    string strResult = (result).ToString();
                    textBox1.Text = strResult;
                    pbPerson1.Load("https://thispersondoesnotexist.com/image?a=37645734567");
                    System.Threading.Thread.Sleep(1002);
                    pbPerson2.Load("https://thispersondoesnotexist.com/image?a=67834562543");
                    System.Threading.Thread.Sleep(1002);
                    pbPerson3.Load("https://thispersondoesnotexist.com/image?a=33622434768");
                    System.Threading.Thread.Sleep(1002);
                    pbPerson4.Load("https://thispersondoesnotexist.com/image?a=34688707547");
                }
            }
        }
    }
}