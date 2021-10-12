using Be.Timvw.Framework.ComponentModel;
using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
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
            var sortable = new SortableBindingList<MsiInfo>(products.OrderBy(p => p.ProductName));

            msiInfoBindingSource.DataSource = sortable;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Debug.WriteLine(e.RowIndex.ToString());
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