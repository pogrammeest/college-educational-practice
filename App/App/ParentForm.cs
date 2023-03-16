using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public class ParentForm : Form
    {
        protected Form Creator { get; set; }
        internal void SetCreator(Form creator) => Creator = creator;
        protected override void OnFormClosing(FormClosingEventArgs e) => Creator?.Close();
        protected void Back()
        {
            Creator?.Show();
            Creator = null;
            Close();
        }

        protected void NewForm(ParentForm form)
        {
            form.SetCreator(this);
            form.Show();
            Hide();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ParentForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.MinimumSize = new System.Drawing.Size(300, 300);
            this.Name = "ParentForm";
            this.Load += new System.EventHandler(this.ParentForm_Load);
            this.ResumeLayout(false);

        }

        private void ParentForm_Load(object sender, EventArgs e)
        {

        }
    }
}
