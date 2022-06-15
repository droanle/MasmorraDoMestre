using MasmorraDoMestre.Controller;
using MasmorraDoMestre.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MasmorraDoMestre.View
{
    public partial class GameList : Form
    {
        Utilities utilities = new Utilities();
        Conection con = new Conection();
        PrivateFontCollection pf = null;

        int[] currentSystem;

        public GameList(PrivateFontCollection pf)
        {
            this.pf = pf;
            InitializeComponent();
            InitializeList();
        }

        private void GameList_Load(object sender, EventArgs e)
        {
            utilities.FontSet(this, pf);
            //utilities.FontSet(configPanel, pf);
            //utilities.FontSet(deletePanel, pf);
            utilities.FontSet(systemInfo, pf);
            utilities.FontSet(joinPanel, pf);
        }

        private int[] CurrentSystem
        {
            set{
                currentSystem = value;

                DataRow table = con.getGame(value[1]).Rows[0];

                this.nameSystem.Text = table["Name"].ToString();
                this.descriptionSystem.Text = table["Description"].ToString();
                this.dateSystem.Text = utilities.formatDate(
                    table["Date"].ToString(),
                    "/",
                    new int[] { 1, 2, 3 }
                );
            }
        }

        private void item_Click(int position, int Id)
        {
            int i = 0;
            foreach (Control c in this.lista.Controls)
            {
                c.BackColor = (position == i)? Color.FromArgb(200, 0, 0) : Color.FromArgb(20, 20, 20);
                c.ForeColor = (position == i) ? Color.Black : Color.White;
                i++;
            }

            CurrentSystem = new int[] { position, Id };
        }

        private void createList(int i, DataRow Data , int locationY, int width)
        {
            Panel item = new Panel();
            Label text = new Label();
            Label date = new Label();

            EventHandler onClickEvent = new EventHandler((sender, EventArgs) => { 
                item_Click(i, int.Parse(Data["Id"].ToString()) ); 
            });

            String dateText = utilities.formatDate(
                Data["Date"].ToString(),
                "/",
                new int[] { 1,2,3 }
            ) ;


            // 
            // item
            // 
            item.BackColor = Color.FromArgb(20,20,20);
            item.BorderStyle = BorderStyle.FixedSingle;
            item.Controls.Add(date);
            item.Controls.Add(text);
            item.Cursor = Cursors.Hand;
            item.ForeColor = SystemColors.ButtonFace;
            item.Location = new Point(3, locationY);
            item.Name = "item";
            item.Padding = new Padding(10);
            item.Size = new Size(width, 50);
            item.TabIndex = 0;
            item.Click += onClickEvent;
            item.Paint += new PaintEventHandler((sender, EventArgs) => {
                utilities.FontSet(item, pf);
            });

            // 
            // text
            // 
            text.Anchor = AnchorStyles.Left;
            text.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            text.Location = new Point(15, 10);
            text.Margin = new Padding(0);
            text.Name = "text";
            text.Size = new Size(width == 508? 334 : 315, 30);
            text.TabIndex = 0;
            text.Text = Data["Name"].ToString();
            text.TextAlign = ContentAlignment.MiddleLeft;
            text.Click += onClickEvent;

            // 
            // date
            // 
            date.Anchor = AnchorStyles.Left;
            date.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            date.Location = new Point(width == 508 ? 349 : 330, 10);
            date.Margin = new Padding(0);
            date.Name = "date";
            date.Size = new Size(149, 30);
            date.TabIndex = 1;
            date.Text = dateText;
            date.TextAlign = ContentAlignment.MiddleRight;
            date.Click += onClickEvent;

            this.lista.Controls.Add(item);
        }

        private void InitializeList()
        {
            DataTable table = con.getGame();
            int locationY = 3;
            int size = table.Rows.Count;
            int width = size > 8 ? 491 : 508;

            for (int i = 0; i < size; i++)
            {
                createList(i, table.Rows[i], locationY, width);

                locationY += 53;
            }

            if (size > 0) item_Click(0, int.Parse(table.Rows[0]["Id"].ToString()));
            else systemInfoHider();

        }

        private void systemInfoHider()
        {
            if (!joinPanel.Visible)
            {
                joinPanel.Hide();
                dateSystem.Hide();
                nameSystem.Hide();
                descriptionSystem.Hide();
            }
            else
            {
                joinPanel.Show();
                dateSystem.Show();
                nameSystem.Show();
                descriptionSystem.Show();
            }

        }

        private void joinInSystem_Click(object sender, EventArgs e) { 
            utilities.GoMenu(this, (object obj) => {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new SystemForm(currentSystem[1], pf)); 
            }); 
        }

        private void backToMain_Click(object sender, EventArgs e)
        {
            utilities.GoMenu(this, (object obj) => {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Main(pf));
            });
        }

        private void configPanel_Click(object sender, EventArgs e)
        {
            utilities.GoMenu(this, (object obj) => {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new NewSystem(pf));
            });
        }
    }
}
