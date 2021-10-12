using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace MsiSneakAttack
{
    public partial class frmMain : Form
    {
        private Dictionary<string, MsiInfo>? products;

        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            products = Msi.GetProducts().ToDictionary(m => m.ProductCode, m => m);

            var table = new DataTable();

            var properties = typeof(MsiInfo).GetProperties();

            foreach (var prop in properties)
            {
                var type = prop.PropertyType.IsGenericType && prop.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>)
                    ? prop.PropertyType.GenericTypeArguments[0]
                    : prop.PropertyType;
                table.Columns.Add(prop.Name, type);
            }

            foreach (var msi in products.Values)
            {
                var row = table.NewRow();
                foreach (var prop in properties)
                    row[prop.Name] = prop.GetValue(msi) ?? DBNull.Value;

                table.Rows.Add(row);
            }

            msiInfoBindingSource.DataSource = table;
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            Debug.WriteLine(e.RowIndex.ToString());
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (e.Row.DataBoundItem is DataRowView row)
            {
                var productCode = row[nameof(MsiInfo.ProductCode)];

                var p = new Process();
                p.StartInfo.FileName = "msiexec";
                p.StartInfo.Arguments = $"/x {productCode} IGNOREDEPENDENCIES=ALL ALLOWMSIUNINSTALL=1";
                p.Start();
                p.WaitForExit();

                if (p.ExitCode != 0)
                    e.Cancel = true;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                msiInfoBindingSource.Filter = searchBox.Text;
                statusLabel.Text = string.Empty;
            }
            catch (Exception ex)
            {
                statusLabel.Text = ex.Message;
            }
        }
    }
}