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

namespace App
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBox2.PasswordChar = '•';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection MyConnection = new SqlConnection(Global.CONNECTION);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();

            SqlCommand command =
            new SqlCommand("SELECT * FROM Tenant WHERE personal_account = @personal_account and pass_hash =  HASHBYTES('sha1',@pass_hash)", MyConnection);
            command.Parameters.Add("@personal_account", SqlDbType.VarChar).Value = textBox1.Text;
            command.Parameters.Add("@pass_hash", SqlDbType.VarChar).Value = textBox2.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                Global.Login = textBox1.Text;

                Main m = new Main();
                Hide();
                m.Show();
            }
            else
            {
                MessageBox.Show("Проверьте логин или пароль!");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = PasswordPropertyTextAttribute.Yes.Password;
            }
            else
            {
                textBox2.UseSystemPasswordChar = PasswordPropertyTextAttribute.No.Password;
            }
        }
    }
}
