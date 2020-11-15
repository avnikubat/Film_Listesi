using Film_Listesi.DataAccess.Repositories.Concrete;
using Film_Listesi.Entity.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.UI.AdminPages
{
    public partial class AdminFilm : Form
    {
        public AdminFilm()
        {
            InitializeComponent();
        }
        string FileName;
        EfDilmRepository efDilmRepository = new EfDilmRepository();

        private void AdminFilm_Load(object sender, EventArgs e)
        {
            cmbAddFilmCategory.DataSource = efDilmRepository.GetActiveCategory();
            cmbAddFilmCategory.ValueMember = "Id";
            cmbAddFilmCategory.DisplayMember = "Name";
            cmbAddFilmCategory.SelectedIndex = -1;

            cmbAddFilmDirector.DataSource = efDilmRepository.GetActiveUser();
            cmbAddFilmDirector.ValueMember = "Id";
            cmbAddFilmDirector.DisplayMember = "UserName";
            cmbAddFilmDirector.SelectedIndex = -1;
            dataGridView1.DataSource = efDilmRepository.GetActiveFilms();
        }

        private void btnAddFilmPictureUrl_Click(object sender, EventArgs e)
        {
            ofdAddPicture.Filter = "JPG | *jpg";
            if (ofdAddPicture.ShowDialog() == DialogResult.OK)
            {
                txtAddFilmPictureUrl.Text = ofdAddPicture.FileName;
                FileName = ofdAddPicture.FileName;
            }
        }

        private void btnAddFilmAdd_Click(object sender, EventArgs e)
        {
            efDilmRepository.AddFilm(txtAddFilmName.Text, txtAddFilmYear.Text, txtAddFilmIMDBPoint.Text, txtAddFilmCountry.Text, FileName, (int)(cmbAddFilmCategory.SelectedValue), (int)(cmbAddFilmDirector.SelectedValue));
            dataGridView1.DataSource = efDilmRepository.GetActiveFilms();
            efDilmRepository.Eraser(grpAddFilm);

        }

        private void btnUpdateFindById_Click(object sender, EventArgs e)
        {
            efDilmRepository.FindById(int.Parse(txtUpdateFilmId.Text),txtUpdateFimName, txtUpdateFimYear, txtUpdateFilmImdbPoint, txtUpdateFimCountry, txtUpdateFimImageUrl);
            cmbUpdateFilmCategory.DataSource = efDilmRepository.GetActiveCategory();
            cmbUpdateFilmCategory.ValueMember = "Id";
            cmbUpdateFilmCategory.DisplayMember = "Name";
            cmbUpdateFilmCategory.SelectedIndex = -1;

            cmbUpdateFilmDirector.DataSource = efDilmRepository.GetActiveUser();
            cmbUpdateFilmDirector.ValueMember = "Id";
            cmbUpdateFilmDirector.DisplayMember = "UserName";
            cmbUpdateFilmDirector.SelectedIndex = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ofdAddPicture.Filter = "JPG | *jpg";
            if (ofdAddPicture.ShowDialog() == DialogResult.OK)
            {
                txtUpdateFimImageUrl.Text = ofdAddPicture.FileName;
                FileName = ofdAddPicture.FileName;
            }
        }

        private void btnUpdateFilm_Click(object sender, EventArgs e)
        {
            efDilmRepository.UpdateFilm(int.Parse(txtUpdateFilmId.Text), txtUpdateFimName.Text,txtUpdateFimYear.Text,txtUpdateFilmImdbPoint.Text,txtUpdateFimCountry.Text,FileName,(int)(cmbUpdateFilmCategory.SelectedValue), (int)(cmbUpdateFilmDirector.SelectedValue));
            dataGridView1.DataSource = efDilmRepository.GetActiveFilms();
            efDilmRepository.Eraser(grpUpdateFilm);
        }

        public static int id;
        private void btnFimDetails_Click(object sender, EventArgs e)
        {
            id = int.Parse(dataGridView1.CurrentRow.Cells["Id"].Value.ToString());
            FilmDetails filmDetails = new FilmDetails();
            filmDetails.Show();
        }

        private void btnDeleteFilmDelete_Click(object sender, EventArgs e)
        {
            int selected_film = int.Parse(txtDeleteFilmId.Text);
            
            
            DialogResult dialogResult = new DialogResult();
            dialogResult = MessageBox.Show("Do you want to delete the selected movie? ", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult==DialogResult.Yes)
            {
                efDilmRepository.DeleteDate(selected_film);
            }
            else if (dialogResult==DialogResult.No)
            {
                MessageBox.Show("This film is not deleted...");
            }
            dataGridView1.DataSource = efDilmRepository.GetActiveFilms();
            efDilmRepository.Eraser(grpDeleteFilm);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            this.Hide();
            adminMenu.Show();
        }
    }
}
