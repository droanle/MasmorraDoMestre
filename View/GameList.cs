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

        public GameList()
        {
            InitializeComponent();
            InitializeList();
        }

        private void GameList_Load(object sender, EventArgs e)
        {
            utilities.FontDefine(this);
            utilities.FontDefine(configPanel);
            utilities.FontDefine(selectPanel);
            utilities.FontDefine(deletePanel);
            utilities.FontDefine(systemInfo);
            utilities.FontDefine(joinPanel);
        }

        private void item_Click(int position, int Id)
        {
            Console.WriteLine(position.ToString() + Id.ToString());
        }

        private void teste(int i, DataRow Data , int locationY, int width)
        {
            Panel item = new Panel();
            Label text = new Label();
            Label date = new Label();
            PrivateFontCollection pf = new PrivateFontCollection();
            pf.AddFontFile((Path.GetFullPath(@"..\..\Resources\Fonts") + @"\Minecraftia-Regular.ttf"));

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

            // 
            // text
            // 
            text.Anchor = AnchorStyles.Left;
            text.Font = new Font(pf.Families[0], 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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
            date.Font = new Font(pf.Families[0], 6F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
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
            DataTable table = con.getAll();
            int locationY = 3;
            int size = table.Rows.Count;
            int width = size > 8 ? 491 : 508;


            for (int i = 0; i < size; i++)
            {

                teste(i, table.Rows[i], locationY, width);

                locationY += 53;
            }

            Console.WriteLine(JsonConvert.SerializeObject(con.getAll()));
            Console.WriteLine(con.getAll().Rows[0]["Properties_List"]);
        }

        private void terste(object sender, EventArgs e)
        {

            

            Console.WriteLine(JsonConvert.SerializeObject(con.getAll()));
            Console.WriteLine(con.getAll().Rows[0]["Properties_List"]) ;

        }
    }
}
