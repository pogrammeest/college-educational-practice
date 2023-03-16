using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Lib1;

namespace App
{
    public partial class AdminForm : ParentForm
    {
        User user;
        public AdminForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.userRole.Text = user.Role;
            this.nameUserName.Text = user.Name;


        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            AdminTables form = new AdminTables();
            NewForm(form);
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
