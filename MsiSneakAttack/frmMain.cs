using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MsiSneakAttack
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var products = Msi.GetProducts();

            msiInfoBindingSource.DataSource = products.OrderBy(p => p.ProductName);
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(e.RowIndex.ToString());
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is MsiInfo msi)
            {
                var p = new Process();
                p.StartInfo.FileName = "msiexec";
                p.StartInfo.Arguments = "/x " + msi.ProductCode + " IGNOREDEPENDENCIES=ALL ALLOWMSIUNINSTALL=1";
                p.Start();
                p.WaitForExit();

                if (p.ExitCode != 0)
                    e.Cancel = true;                
            }
        }
    }
}
