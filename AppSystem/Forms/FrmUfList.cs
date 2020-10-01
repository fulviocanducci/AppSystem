using AppSystem.Data;
using AppSystem.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSystem.Forms
{
    public partial class FrmUfList : Form
    {
        public FrmUfList(Database database)
        {
            InitializeComponent();
            Database = database;
        }

        public Database Database { get; }

        private void FrmUfList_Load(object sender, EventArgs e)
        {
            DataGridViewUf.AutoGenerateColumns = false;
            LoadDataGridView("");
        }

        private void LoadDataGridView(string name)
        {
            IQueryable<Uf> query = Database.Uf.AsNoTracking();
            DataGridViewUf.DataSource =
                string.IsNullOrEmpty(name)
                ? query.OrderBy(o => o.Name).ToList()
                : query.Where(x => x.Name.Contains(name)).OrderBy(o => o.Name).ToList();
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButFind_Click(object sender, EventArgs e)
        {
            LoadDataGridView(TxtFind.Text);
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            FrmUfUpdate form = new FrmUfUpdate(Database);
            form.ShowDialog();
            LoadDataGridView("");
        }

        private void DataGridViewUf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = ((DataGridView)sender)?.Rows[e.RowIndex]?.Cells[0].Value;
            if (int.TryParse(value.ToString(), out int id))
            {
                FrmUfUpdate form = new FrmUfUpdate(Database, id);
                form.ShowDialog();
                LoadDataGridView("");
            }
        }
    }
}
