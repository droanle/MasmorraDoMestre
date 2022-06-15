using MasmorraDoMestre.Controller;
using MasmorraDoMestre.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasmorraDoMestre.View
{
    public partial class CreateSheet : Form
    {
        Utilities utilities = new Utilities();
        Conection con = new Conection();
        PrivateFontCollection pf = null;
        int IdGame;
        int image = 1;
        Boolean player = false;

        public CreateSheet(int IdGame, PrivateFontCollection pf)
        {
            this.IdGame = IdGame;
            this.pf = pf;
            InitializeComponent();
            utilities.FontSet(changePanel, pf);
        }

        private void backToSystemForm_Click(object sender, EventArgs e) { utilities.GoMenu(this, (object obj) => { Application.Run(new SystemForm(IdGame, pf)); }); }

        private void borderChangePanel_Paint(object sender, PaintEventArgs e) { utilities.FontSet(changePanel, pf); }

        private void alterLabel_Paint(object sender, PaintEventArgs e) { utilities.FontSet(addButton, pf); }

        private void cancelLabel_Paint(object sender, PaintEventArgs e) { utilities.FontSet(cancelButton, pf); }

        private void openSelect_Click(object sender, EventArgs e)
        {
            if (selectPanel.Visible)
            {
                selectPanel.Visible = false;
                openSelect.Image = MasmorraDoMestre.Properties.Resources.setaBaixo;
            }
            else
            {
                selectPanel.Visible = true;
                openSelect.Image = MasmorraDoMestre.Properties.Resources.setaCima;
            }
        }

        private void chengeImage(int i, Label e)
        {
            image = i;
            profilePhoto.Image = utilities.getImagePrefile(i);
            selectPanel.Visible = false;
            selectOptionLabel.Text = e.Text;
            openSelect.Image = Properties.Resources.setaBaixo;
        }

        private void foto1_Click(object sender, EventArgs e) { chengeImage(1, foto1); }

        private void foto2_Click(object sender, EventArgs e) { chengeImage(2, foto2); }

        private void foto3_Click(object sender, EventArgs e) { chengeImage(3, foto3); }

        private void foto4_Click(object sender, EventArgs e) { chengeImage(4, foto4); }

        private void foto5_Click(object sender, EventArgs e) { chengeImage(5, foto5); }

        private void playerRadioButton_CheckedChanged(object sender, EventArgs e) { player = true; }

        private void npcRadioButton_CheckedChanged(object sender, EventArgs e) { player = false; }

        private void addButton_Click(object sender, EventArgs e)
        {
            if(con.createSheet(
                this.nameTextBox.Text,
                this.descriptionTextBox.Text,
                this.typeTextBox.Text,
                image,
                player,
                IdGame
                ))
            {utilities.GoMenu(this, (object obj) => { Application.Run(new SystemForm(IdGame, pf)); });}
        }
    }
}
