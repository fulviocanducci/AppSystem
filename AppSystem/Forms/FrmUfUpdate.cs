using AppSystem.Data;
using AppSystem.Models;
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
        }

        public Database Database { get; }
        public int Id { get; }

        private void ButEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmUfUpdate_Load(object sender, EventArgs e)
        {
            TxtName.Text = "";
            BtnSave.Tag = "Add";
            if (Id > 0)
            {
                Uf uf = Database.Uf.AsNoTracking().FirstOrDefault(x => x.Id == Id);
                if (uf != null)
                {
                    TxtName.Text = uf.Name;
                    BtnSave.Tag = "Update";
                }
                else
                {
                    ButEnd.PerformClick();
                }
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            bool exits = Database.Uf.AsNoTracking().Where(w => w.Name == TxtName.Text).Any();
            if (exits)
            {
                MessageBox.Show("Unidade Federativa já cadastrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Uf uf = new Uf
                {
                    Id = Id,
                    Name = TxtName.Text
                };
                switch (BtnSave.Tag)
                {
                    case "Add":
                        Database.Uf.Add(uf);
                        break;
                    case "Update":
                        Database.Entry(uf).State = System.Data.Entity.EntityState.Modified;
                        break;
                }
                Database.SaveChanges();
                Database.Entry(uf).State = System.Data.Entity.EntityState.Detached;
                ButEnd.PerformClick();
            }
        }
    }
}
