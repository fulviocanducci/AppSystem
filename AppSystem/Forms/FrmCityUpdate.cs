using AppSystem.Data;
using AppSystem.Extensions;
using AppSystem.Models;
using AppSystem.Validators;
using FluentValidation.Results;
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
            Validator = new CityValidator(database);
        }

        public Database Database { get; }
        public CityValidator Validator { get; }
        public int Id { get; }

        private void FrmCityUpdate_Load(object sender, EventArgs e)
        {
            AcceptButton = ButSalve.ButtonReference;
            CancelButton = ButClose.ButtonReference;
            TxtName.Text = "";
            CmbUf.DataSource = Database
                        .Uf
                        .AsNoTracking()
                        .OrderBy(o => o.Name)
                        .ToList();
            CmbUf.ValueMember = "Id";
            CmbUf.DisplayMember = "Name";
            ButClose.Tag = "Add";
            if (Id > 0)
            {
                City city = Database.City.AsNoTracking().FirstOrDefault(x => x.Id == Id);
                if (city != null)
                {
                    CmbUf.SelectedValue = city.UfId;
                    TxtName.Text = city.Name;
                    ButClose.Tag = "Update";
                }
                else
                {
                    Close();
                }
            }
        }

        private void Save()
        {
            if (int.TryParse(CmbUf.SelectedValue.ToString(), out int ufId))
            {
                City city = new City
                {
                    Id = Id,
                    UfId = ufId,
                    Name = TxtName.Text
                };

                ValidationResult result = Validator.Validate(city);

                if (result.IsValid)
                {

                    switch (ButClose.Tag)
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
                    Close();
                }
                else
                {
                    MessageBox.Show(
                        result.Errors.Messages(),
                        "Validação",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
        }

        private void ButClose_ButtonOnClick(object sender, EventArgs e)
        {
            Close();
        }

        private void ButSalve_ButtonOnClick(object sender, EventArgs e)
        {
            Save();
        }
    }
}
