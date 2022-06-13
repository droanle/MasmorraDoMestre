using MasmorraDoMestre.Controller;
using MasmorraDoMestre.Model;
using Newtonsoft.Json;
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
    public partial class SystemForm : Form
    {

        Utilities utilities = new Utilities();
        Conection con = new Conection();
        PrivateFontCollection pf = null;
        int IdGame;

        public SystemForm(int IdGame, PrivateFontCollection pf)
        {
            this.IdGame = IdGame;
            this.pf = pf;
            InitializeComponent();
            InitializeList();
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            utilities.FontSet(this, pf);
            utilities.FontSet(sheetsList, pf);
            utilities.FontSet(addSheet, pf);
            utilities.FontSet(systemInfos, pf);
            utilities.FontSet(backPanel, pf);

            DataRow table = con.getGame(IdGame).Rows[0];

            this.nameSystem.Text = table["Name"].ToString();
            this.descriptionSystem.Text = table["Description"].ToString();
        }

        private void createList(int i, DataRow Data, int X, int Y)
        {
            Panel itemSheet = new Panel();
            Label name = new Label();
            PictureBox profilePhoto = new PictureBox();
            PictureBox deletePicture = new PictureBox();
            PictureBox viewPicture = new PictureBox();

            EventHandler onClickEvent = new EventHandler((sender, EventArgs) => {
                
            });

            EventHandler viewPictureOnClickEvent = new EventHandler((sender, EventArgs) => {
                try
                {
                    Sheet OpenSheet = new Sheet(IdGame, int.Parse(Data["Id"].ToString()), pf);
                    OpenSheet.Show();
                }
                catch { }
            });

            Image img = utilities.getImagePrefile(int.Parse(Data["Image"].ToString()));

            // 
            // itemSheet
            // 
            itemSheet.BackColor = Color.FromArgb(20,20,20);
            itemSheet.BorderStyle = BorderStyle.FixedSingle;
            itemSheet.Controls.Add(viewPicture);
            itemSheet.Controls.Add(deletePicture);
            itemSheet.Controls.Add(name);
            itemSheet.Controls.Add(profilePhoto);
            itemSheet.Location = new Point(X, Y);
            itemSheet.Name = "itemSheet";
            itemSheet.Size = new Size(190, 190);
            itemSheet.TabIndex = 1;
            itemSheet.Click += onClickEvent;
            itemSheet.Paint += new PaintEventHandler((sender, EventArgs) => {
                utilities.FontSet(itemSheet, pf);
            });

            // 
            // name
            // 
            name.Font = new Font("Microsoft Tai Le", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            name.ForeColor = SystemColors.ButtonFace;
            name.Location = new Point(7, 115);
            name.Margin = new Padding(0);
            name.Name = "name";
            name.Size = new Size(178, 34);
            name.TabIndex = 2;
            name.Text = Data["Name"].ToString();
            name.TextAlign = ContentAlignment.MiddleCenter;
            name.Click += onClickEvent;

            // 
            // profilePhoto
            // 
            profilePhoto.Image = img;
            profilePhoto.Location = new Point(3, 3);
            profilePhoto.Name = "profilePhoto";
            profilePhoto.Size = new Size(182, 109);
            profilePhoto.SizeMode = PictureBoxSizeMode.CenterImage;
            profilePhoto.TabIndex = 0;
            profilePhoto.TabStop = false;

            // 
            // deletePicture
            // 
            deletePicture.Cursor = Cursors.Hand;
            deletePicture.Image = global::MasmorraDoMestre.Properties.Resources.delete;
            deletePicture.Location = new Point(3, 161);
            deletePicture.Name = "deletePicture";
            deletePicture.Size = new Size(35, 20);
            deletePicture.SizeMode = PictureBoxSizeMode.Zoom;
            deletePicture.TabIndex = 3;
            deletePicture.TabStop = false;

            // 
            // viewPicture
            // 
            viewPicture.Cursor = Cursors.Hand;
            viewPicture.Image = global::MasmorraDoMestre.Properties.Resources.view;
            viewPicture.Location = new Point(150, 161);
            viewPicture.Name = "viewPicture";
            viewPicture.Size = new Size(35, 20);
            viewPicture.SizeMode = PictureBoxSizeMode.Zoom;
            viewPicture.TabIndex = 6;
            viewPicture.TabStop = false;
            viewPicture.Click += viewPictureOnClickEvent;

            this.sheetsList.Controls.Add(itemSheet);
        }

        private void InitializeList()
        {
            DataTable table = con.getSheet(IdGame);
            int locationX = 198, locationY = 3;

            for (int i = 0; i < table.Rows.Count; i++)
            {
                createList(i, table.Rows[i], locationX, locationY);

                if (locationX == 590)
                {
                    locationX = 2;
                    locationY += 193;
                }
                else
                {
                    locationX += 196;
                }

            }

            Console.WriteLine(JsonConvert.SerializeObject(table));
        }

        private void addSheet_Click(object sender, EventArgs e)
        {
        }

        private void backToGameList_Click(object sender, EventArgs e) { utilities.GoMenu(this, (object obj) => { Application.Run(new GameList(pf)); }); }
    }
}
