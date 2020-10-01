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
    public partial class FrmUfUpdate : Form
    {
        public FrmUfUpdate(Database database, int id = 0)
        {
            InitializeComponent();
            Database = database;
            Id = id;
            Validator = new UfValidator(database);
        }

        public Database Database { get; }
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
                Uf uf = Database.Uf.AsNoTracking().FirstOrDefault(x => x.Id == Id);
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
                        Database.Uf.Add(uf);
                        break;
                    case "Update":
                        Database.Entry(uf).State = System.Data.Entity.EntityState.Modified;
                        break;
                }
                if (Database.SaveChanges() > 0)
                {
                    MessageBox.Show("Dados atualizados com êxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                Database.Entry(uf).State = System.Data.Entity.EntityState.Detached;
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
