using AppSystem.Data;
using AppSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppSystem.Forms
{
    public partial class FrmCityList : Form
    {
        public FrmCityList(Database database)
        {
            InitializeComponent();
            Database = database;
        }

        public Database Database { get; }
        private void LoadDataGridView(string name)
        {
            IQueryable<City> query = Database.City.AsNoTracking();
            var select = query.OrderBy(o => o.Name).Select(x => new
            {
                x.Id,
                x.Name,
                Uf = x.Uf.Name
            });
            DataGridViewCity.DataSource =
                string.IsNullOrEmpty(name)
                ? select.ToList()
                : select.Where(x => x.Name.Contains(name)).ToList();
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmCityList_Load(object sender, EventArgs e)
        {
            DataGridViewCity.AutoGenerateColumns = false;
            LoadDataGridView("");
        }

        private void ButFind_Click(object sender, EventArgs e)
        {
            LoadDataGridView(TxtFind.Text);
        }

        private void ButNew_Click(object sender, EventArgs e)
        {
            FrmCityUpdate form = new FrmCityUpdate(Database);
            form.ShowDialog();
            LoadDataGridView("");
        }

        private void DataGridViewCity_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            object value = ((DataGridView)sender)?.Rows[e.RowIndex]?.Cells[0].Value;
            if (int.TryParse(value.ToString(), out int id))
            {
                FrmCityUpdate form = new FrmCityUpdate(Database, id);
                form.ShowDialog();
                LoadDataGridView("");
            }
        }
    }
}
