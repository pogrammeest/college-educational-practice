using Lib1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class TenantForm : ParentForm
    {
        User user;
        public TenantForm(User user)
        {
            InitializeComponent();
            this.user = user;
            this.userRole.Text = user.Role;
            this.nameUserName.Text = user.Name;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }

        private void booksBtn_Click(object sender, EventArgs e)
        {
            Otchet win = new Otchet();
            NewForm(win);
        }
    }
}
