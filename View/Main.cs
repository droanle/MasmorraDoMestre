using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using MasmorraDoMestre.Model;

namespace MasmorraDoMestre.View

{
    public partial class Main : Form
    {
        Utilities utilities = new Utilities();
        PrivateFontCollection pf = null;

        public Main(PrivateFontCollection pf)
        {
            this.pf = pf;
         
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            utilities.FontSet(this, pf);
        }

        private void joinPanel_Paint(object sender, PaintEventArgs e)
        {
            utilities.FontSet(joinPanel, pf);
        }

        private void joinPanel_Click(object sender, EventArgs e) { utilities.GoMenu(this, (object obj) => {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new GameList(pf)); 
            }); 
        }

    }
}
