using AppSystem.Data;
using AppSystem.Extensions;
using AppSystem.Models;
using AppSystem.Validators;
using FluentValidation.Results;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AppSystem.Forms
{
    public partial class FrmCityUpdate : Form
    {
        public CityValidator Validator { get; }
        public Database Database { get; }
        public int Id { get; }

        public FrmCityUpdate(Database database, int id = 0)
        {
            InitializeComponent();
            Database = database;
            Validator = new CityValidator(database);
            Id = id;
        }

        private void FrmCityUpdate_Load(object sender, EventArgs e)
        {
            AcceptButton = ButSalve.ButtonReference;
            CancelButton = ButClose.ButtonReference;
            TxtName.Text = "";
            CmbUf.DataSource = Database.Uf.AsNoTracking().OrderBy(x => x.Name).ToList();
            CmbUf.ValueMember = "Id";
            CmbUf.DisplayMember = "Name";
            ButClose.Tag = Operation.Insert;
            if (Id > 0)
            {
                City city = Database.City.AsNoTracking().FirstOrDefault(x => x.Id == Id);
                if (city != null)
                {
                    CmbUf.SelectedValue = city.UfId;
                    TxtName.Text = city.Name;
                    ButClose.Tag = Operation.Update;
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
                        case Operation.Insert:
                            Database.City.Add(city);
                            break;
                        case Operation.Update:
                            Database.Entry(city).State = System.Data.Entity.EntityState.Modified;
                            break;
                    }
                    if (Database.SaveChanges() > 0)
                    {
                        MessageBox.Show(
                            "Dados atualizados com êxito",
                            "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
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
            else
            {
                MessageBox.Show(
                    "Uf inválida",
                    "Validação",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
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
