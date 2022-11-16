using Simple_Form.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simple_Form
{
    public partial class Form1 : Form
    {   
       public string ConnectedUser { get; set; }
        public Form1()
        {
            InitializeComponent();
        }
        static private string GetConnectionString()
        {
            // To avoid storing the connection string in your code,
            // you can retrieve it from a configuration file.
            return "Data Source=.;Initial Catalog=SimpleForm;"
                + "Integrated Security=true;";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Thoughts.Text = "Enter text here...";
            SignInObjects.Visible = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Thoughts.PasswordChar = checkBox1.CheckState == CheckState.Checked ? '\0' : '*';
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            ConnectedUser = usernameTxt.Text.Trim();

            InsertDataLayer dataLayer = new InsertDataLayer();
            dataLayer.InsertData(GetConnectionString(),
               usernameTxt.Text.Trim(),
                passwordTxt.Text.Trim());
            SignInObjects.Visible = true;

        }

      
public void RemoveText(object sender, EventArgs e)
        {
            if (Thoughts.Text == "Enter text here...")
            {
                Thoughts.Text = "";
            }
        }

        public void AddText(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Thoughts.Text))
                Thoughts.Text = "Enter text here...";
        }

      

        private void SubmitYourThoughts_Click(object sender, EventArgs e)
        {
            InsertDataLayer dataLayer = new InsertDataLayer();
            dataLayer.InsertThought(GetConnectionString(),
               usernameTxt.Text.Trim(),
                Thoughts.Text.Trim());
            MessageBox.Show("Thought inserted! Thank you");
            SignInObjects.Visible = false;
        }

        private void Thoughts_MouseClick(object sender, MouseEventArgs e)
        {
            //Thoughts.Text = "Enter text here...";

            Thoughts.GotFocus += (RemoveText);
            Thoughts.LostFocus += (AddText);
        }
    }
}
