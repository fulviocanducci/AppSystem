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
    public partial class FrmUfUpdate : Form
    {
        public FrmUfUpdate(Database database, AbstractRepositoryUf repositoryUf, int id = 0)
        {
            InitializeComponent();
            Id = id;
            RepositoryUf = repositoryUf;
            Validator = new UfValidator(database);
        }

        public AbstractRepositoryUf RepositoryUf { get; }
        public UfValidator Validator { get; }
        public int Id { get; }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUfUpdate_Load(object sender, EventArgs e)
        {
            AcceptButton = ButSalve.ButtonReference;
            CancelButton = ButClose.ButtonReference;
            TxtName.Text = "";
            ButSalve.Tag = "Add";
            if (Id > 0)
            {
                Uf uf = RepositoryUf.GetOne(x => x.Id == Id);
                if (uf != null)
                {
                    TxtName.Text = uf.Name;
                    ButSalve.Tag = "Update";
                }
                else
                {
                    Close();
                }
            }
        }

        private void Save()
        {
            Uf uf = new Uf
            {
                Id = Id,
                Name = TxtName.Text
            };
            ValidationResult result = Validator.Validate(uf);
            if (result.IsValid)
            {
                switch (ButSalve.Tag)
                {
                    case "Add":
                        RepositoryUf.Add(uf);
                        break;
                    case "Update":
                        RepositoryUf.Update(uf);
                        break;
                }
                MessageBox.Show(
                    "Dados atualizados com êxito", "Aviso",
                    MessageBoxButtons.OK,
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
