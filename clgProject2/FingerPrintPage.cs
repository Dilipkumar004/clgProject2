using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Data.SqlClient;
using clgProject2.Properties;

namespace clgProject2
{
    public partial class FingerPrintPage : Form
    {
        public string _name ="";
        public string _bankAcc="";
        public string _aadharNo="";
        public string _branch="";
        public FingerPrintPage()
        {
            InitializeComponent();
        }


        private void FingerPrintPage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FingerPrintPage form1 = new FingerPrintPage();
            loginPage form2 = new loginPage();
            form2.Show();
            this.Hide();
           
            /*SqlConnection con = new SqlConnection("Data Source=DKS004-GD;Initial Catalog=AadharDetails;integrated security=SSPI");
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from User", con);
                SqlDataReader da = cmd.ExecuteReader(); 
                da.Read();                                                                                                                                                                                                                                           
                name = da.GetValue(0).ToString();
                bankAcc = da.GetValue(1).ToString();
                aadharNo = da.GetValue(2).ToString();
                branch = da.GetValue(3).ToString();
             con.Close();*/
        }
    }
}
