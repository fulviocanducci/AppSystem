using AppSystem.Data;
using AppSystem.Models;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AppSystem.Forms
{
    public partial class FrmCityUpdate : Form
    {
        public FrmCityUpdate(Database database, int id = 0)
        {
            InitializeComponent();
            Database = database;
            Id = id;
        }

        public Database Database { get; }
        public int Id { get; }

        private void FrmCityUpdate_Load(object sender, EventArgs e)
        {
            TxtName.Text = "";
            CmbUf.DataSource = Database
                        .Uf
                        .AsNoTracking()
                        .OrderBy(o => o.Name)
                        .ToList();
            CmbUf.ValueMember = "Id";
            CmbUf.DisplayMember = "Name";
            BtnSave.Tag = "Add";
            if (Id > 0)
            {
                City city = Database.City.AsNoTracking().FirstOrDefault(x => x.Id == Id);
                if (city != null)
                {                    
                    CmbUf.SelectedValue = city.UfId;
                    TxtName.Text = city.Name;
                    BtnSave.Tag = "Update";
                }
                else
                {
                    ButEnd.PerformClick();
                }
            }
        }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            int ufId = int.Parse(CmbUf.SelectedValue.ToString());
            City city = new City
            {
                Id = Id,
                UfId = ufId,
                Name = TxtName.Text
            };
            switch (BtnSave.Tag)
            {
                case "Add":
                    Database.City.Add(city);
                    break;
                case "Update":
                    Database.Entry(city).State = System.Data.Entity.EntityState.Modified;
                    break;
            }
            if (Database.SaveChanges() > 0)
            {
                MessageBox.Show("Dados atualizados com êxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Database.Entry(city).State = System.Data.Entity.EntityState.Detached;
            ButEnd.PerformClick();
        }
    }
}
