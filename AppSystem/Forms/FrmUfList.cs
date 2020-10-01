using AppSystem.Data;
using AppSystem.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSystem.Forms
{
    public partial class FrmUfList : Form
    {
        public Database Database { get; }
        public AbstractRepositoryUf RepositoryUf { get; }

        public FrmUfList(Database database)
        {
            InitializeComponent();
            Database = database;
            RepositoryUf = new RepositoryUf(database);
        }

        private void FrmUfList_Load(object sender, EventArgs e)
        {
            CancelButton = ButClose.ButtonReference;
            DataGridViewUf.AutoGenerateColumns = false;
            LoadDataGridView("");
        }

        private void LoadDataGridView(string name)
        {
            var result = RepositoryUf.Get(
                x => x.Name,
                x => x.Name.Contains(name),
                x => new
                {
                    x.Id,
                    x.Name
                }
            )
            .ToList();
            DataGridViewUf.DataSource = result;
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DataGridViewUf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = ((DataGridView)sender)?.Rows[e.RowIndex]?.Cells[0].Value;
            if (int.TryParse(value.ToString(), out int id))
            {
                FrmUfUpdate form = new FrmUfUpdate(Database, RepositoryUf, id);
                form.ShowDialog();
                LoadDataGridView("");
            }
        }

        private void ButFind_ButtonOnClick(object sender, EventArgs e)
        {
            LoadDataGridView(TxtFind.Text);
        }

        private void ButClose_ButtonOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButNew_ButtonOnClick(object sender, EventArgs e)
        {
            FrmUfUpdate form = new FrmUfUpdate(Database, RepositoryUf);
            form.ShowDialog();
            LoadDataGridView("");
        }

        private void TxtFind_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButFind.ButtonReference.PerformClick();
            }
        }
    }
}
