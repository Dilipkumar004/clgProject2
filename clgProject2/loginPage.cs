using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace clgProject2
{
    public partial class loginPage : Form
    {
         public loginPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DepositDetails dd = new DepositDetails();
            dd.Show();
        }

        private void loginPage_Load(object sender, EventArgs e)
        {
            using (PersonDetailsEntities1 pd = new PersonDetailsEntities1())
            {
                var person = pd.Persondatas.Where(a => a.name == "kumar").FirstOrDefault();
                textBox1.Text = person.name;
                textBox2.Text = person.aadharNo;
                textBox3.Text = person.accountNo;
                textBox4.Text = person.branch;
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            WithdrawDetails wdd = new WithdrawDetails();
            wdd.Show();
            this.Hide();
        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
        }

        public void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            DDdetails ddd = new DDdetails();
            ddd.Show();
        }
    }
}

