using AppSystem.Data;
using AppSystem.Extensions;
using AppSystem.Models;
using AppSystem.Repository;
using AppSystem.Validators;
using FluentValidation.Results;
using System;
using System.Windows.Forms;

namespace AppSystem.Forms
{
    public partial class FrmCityUpdate : Form
    {
        public AbstractRepositoryCity RepositoryCity { get; }
        public AbstractRepositoryUf RepositoryUf { get; }
        public CityValidator Validator { get; }
        public int Id { get; }

        public FrmCityUpdate(Database database, AbstractRepositoryCity repositoryCity, int id = 0)
        {
            InitializeComponent();
            Id = id;
            RepositoryCity = repositoryCity;
            RepositoryUf = new RepositoryUf(database);
            Validator = new CityValidator(database);
        }        

        private void FrmCityUpdate_Load(object sender, EventArgs e)
        {
            AcceptButton = ButSalve.ButtonReference;
            CancelButton = ButClose.ButtonReference;
            TxtName.Text = "";
            CmbUf.DataSource = RepositoryUf.Get(x => x.Name);
            CmbUf.ValueMember = "Id";
            CmbUf.DisplayMember = "Name";
            ButClose.Tag = "Add";
            if (Id > 0)
            {
                City city = RepositoryCity.GetOne(x => x.Id == Id);
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
                            RepositoryCity.Add(city);
                            break;
                        case "Update":
                            RepositoryCity.Update(city);
                            break;
                    }
                    MessageBox.Show(
                        "Dados atualizados com êxito",
                        "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
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
