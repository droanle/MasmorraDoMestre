using MasmorraDoMestre.Controller;
using MasmorraDoMestre.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        int idSystem;

        public SystemForm(int idSystem)
        {
            this.idSystem = idSystem;
            InitializeComponent();
            InitializeList();
        }

        private void SystemForm_Load(object sender, EventArgs e)
        {
            utilities.FontDefine(this);
            utilities.FontDefine(sheetsList);
            utilities.FontDefine(addSheet);
            utilities.FontDefine(systemInfos);
            utilities.FontDefine(backPanel);

            DataRow table = con.getGame(idSystem).Rows[0];

            Console.WriteLine(JsonConvert.SerializeObject(table));

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
            PictureBox editPicture = new PictureBox();

            Image img = utilities.getImagePrefile(int.Parse(Data["Image"].ToString()));

            // 
            // itemSheet
            // 
            itemSheet.BackColor = Color.FromArgb(20,20,20);
            itemSheet.BorderStyle = BorderStyle.FixedSingle;
            itemSheet.Controls.Add(editPicture);
            itemSheet.Controls.Add(viewPicture);
            itemSheet.Controls.Add(deletePicture);
            itemSheet.Controls.Add(name);
            itemSheet.Controls.Add(profilePhoto);
            itemSheet.Location = new Point(X, Y);
            itemSheet.Name = "itemSheet";
            itemSheet.Size = new Size(190, 190);
            itemSheet.TabIndex = 1;
            itemSheet.Paint += new PaintEventHandler((sender, EventArgs) => {
                utilities.FontDefine(itemSheet);
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
            viewPicture.Location = new Point(74, 161);
            viewPicture.Name = "viewPicture";
            viewPicture.Size = new Size(35, 20);
            viewPicture.SizeMode = PictureBoxSizeMode.Zoom;
            viewPicture.TabIndex = 6;
            viewPicture.TabStop = false;

            // 
            // editPicture
            // 
            editPicture.Cursor = Cursors.Hand;
            editPicture.Image = global::MasmorraDoMestre.Properties.Resources.edit;
            editPicture.Location = new Point(150, 161);
            editPicture.Name = "editPicture";
            editPicture.Size = new Size(35, 20);
            editPicture.SizeMode = PictureBoxSizeMode.Zoom;
            editPicture.TabIndex = 7;
            editPicture.TabStop = false;

            this.sheetsList.Controls.Add(itemSheet);
        }

        private void InitializeList()
        {
            DataTable table = con.getSheet(idSystem);
            int locationX = 198, locationY = 3;


            Console.WriteLine(JsonConvert.SerializeObject(table));

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
        }

        private void addSheet_Click(object sender, EventArgs e)
        {
        }

        private void backToGameList_Click(object sender, EventArgs e) { utilities.GoMenu(this, (object obj) => { Application.Run(new GameList()); }); }
    }
}
