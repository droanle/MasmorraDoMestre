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

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            utilities.FontDefine(this);
        }

        private void joinPanel_Paint(object sender, PaintEventArgs e)
        {
            utilities.FontDefine(joinPanel);
        }

        private void joinPanel_Click(object sender, EventArgs e) { utilities.GoMenu(this, (object obj) => { Application.Run(new GameList()); }); }

    }
}
