using AppSystem.Data;
using AppSystem.Repository;
using System;
using System.Windows.Forms;

namespace AppSystem.Forms
{
    public partial class FrmCityList : Form
    {
        public AbstractRepositoryCity RepositoryCity { get; }
        
        public Database Database { get; }

        public FrmCityList(Database database)
        {
            InitializeComponent();
            RepositoryCity = new RepositoryCity(database);
            Database = database;
        }        

        private void LoadDataGridView(string name)
        {
            var result = RepositoryCity.Get(
                x => x.Name, 
                x => x.Name.Contains(name), 
                x => new { x.Id, x.Name, Uf = x.Uf.Name }
            );
            DataGridViewCity.DataSource = result;
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCityList_Load(object sender, EventArgs e)
        {
            CancelButton = ButClose.ButtonReference;
            DataGridViewCity.AutoGenerateColumns = false;
            LoadDataGridView("");
        }

        private void ButFind_Click(object sender, EventArgs e)
        {
            LoadDataGridView(TxtFind.Text);
        }

        private void DataGridViewCity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = ((DataGridView)sender)?.Rows[e.RowIndex]?.Cells[0].Value;
            if (int.TryParse(value.ToString(), out int id))
            {
                FrmCityUpdate form = new FrmCityUpdate(Database, RepositoryCity, id);
                form.ShowDialog();
                LoadDataGridView("");
            }
        }

        private void ButNew_ButtonOnClick(object sender, EventArgs e)
        {
            FrmCityUpdate form = new FrmCityUpdate(Database, RepositoryCity);
            form.ShowDialog();
            LoadDataGridView("");
        }


        private void ButClose_ButtonOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButFind_ButtonOnClick(object sender, EventArgs e)
        {
            LoadDataGridView(TxtFind.Text);
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
