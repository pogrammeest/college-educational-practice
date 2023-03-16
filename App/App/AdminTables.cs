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
    public partial class AdminTables : ParentForm
    {
        public AdminTables()
        {
            InitializeComponent();
        }


        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praticeDataSet11.Roles". При необходимости она может быть перемещена или удалена.
            this.rolesTableAdapter.Fill(this.praticeDataSet11.Roles);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praticeDataSet.ServiceInvoice". При необходимости она может быть перемещена или удалена.
            this.serviceInvoiceTableAdapter.Fill(this.praticeDataSet.ServiceInvoice);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praticeDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.praticeDataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praticeDataSet.Tenant". При необходимости она может быть перемещена или удалена.
            this.tenantTableAdapter.Fill(this.praticeDataSet.Tenant);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "praticeDataSet.Flat". При необходимости она может быть перемещена или удалена.
            this.flatTableAdapter.Fill(this.praticeDataSet.Flat);

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            flatBindingSource.EndEdit();
            flatTableAdapter.Update(praticeDataSet);

            tenantBindingSource.EndEdit();
            tenantTableAdapter.Update(praticeDataSet);

            serviceBindingSource.EndEdit();
         
            serviceTableAdapter.Update(praticeDataSet);

            serviceInvoiceBindingSource.EndEdit();
            serviceInvoiceTableAdapter.Update(praticeDataSet);

        }

        private void flatBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void tenantBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Back();
        }
    }
}
