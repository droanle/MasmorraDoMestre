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
    
    public partial class NewSystem : Form
    {
        Utilities utilities = new Utilities();
        Conection con = new Conection();
        PrivateFontCollection pf = null;
        SystemFormatter systemFormatter = new SystemFormatter();
        int atributeCount = 1;
        int periciaCount = 0;

        public NewSystem(PrivateFontCollection pf)
        {
            this.pf = pf;
            InitializeComponent();
            utilities.FontSet(this, pf);
        }

        private void addButton_Paint(object sender, PaintEventArgs e) {utilities.FontSet(addButton, pf);}

        private void cancelButton_Paint(object sender, PaintEventArgs e) { utilities.FontSet(cancelButton, pf); }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Panel borderChangePanel = new System.Windows.Forms.Panel();
            Panel changePanel = new System.Windows.Forms.Panel();
            RichTextBox  richTextBox1 = new System.Windows.Forms.RichTextBox();
            Label label17 = new System.Windows.Forms.Label();
            Panel panel15 = new System.Windows.Forms.Panel();
            TextBox textBox2 = new System.Windows.Forms.TextBox();
            Label label16 = new System.Windows.Forms.Label();
            Panel panel14 = new System.Windows.Forms.Panel();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            Label label15 = new System.Windows.Forms.Label();
            Panel panel7 = new System.Windows.Forms.Panel();
            Label label8 = new System.Windows.Forms.Label();
            TrackBar trackBar3 = new System.Windows.Forms.TrackBar();
            TrackBar trackBar2 = new System.Windows.Forms.TrackBar();
            TrackBar trackBar1 = new System.Windows.Forms.TrackBar();
            Panel panel5 = new System.Windows.Forms.Panel();
            Label label4 = new System.Windows.Forms.Label();
            Panel alterButton = new System.Windows.Forms.Panel();
            Label alterLabel = new System.Windows.Forms.Label();
            Label label6 = new System.Windows.Forms.Label();


            AtribultiColor atribultiColor = new AtribultiColor();

            this.Controls.Add(borderChangePanel);
            this.Controls.SetChildIndex(borderChangePanel, 0);
            
            trackBar1.Scroll += new EventHandler((s, EventArgs) => {
                atribultiColor.R = trackBar1.Value;
                panel7.BackColor = Color.FromArgb(atribultiColor.R, atribultiColor.G, atribultiColor.B);
            });

            trackBar2.Scroll += new EventHandler((s, EventArgs) => {
                atribultiColor.G = trackBar2.Value;
                panel7.BackColor = Color.FromArgb(atribultiColor.R, atribultiColor.G, atribultiColor.B);
            });

            trackBar3.Scroll += new EventHandler((s, EventArgs) => {
                atribultiColor.B = trackBar3.Value;
                panel7.BackColor = Color.FromArgb(atribultiColor.R, atribultiColor.G, atribultiColor.B);
            });

            EventHandler cancel = new EventHandler((s, EventArgs) => {

                this.Controls.Remove(borderChangePanel);
            });

            EventHandler save = new EventHandler((s, EventArgs) => {
                Panel atributePanel = new Panel();
                Label atributeIdLabel = new Label();
                Label atributeLabel = new Label();

                systemFormatter.setAttributes(
                    textBox2.Text,
                    textBox1.Text,
                    richTextBox1.Text,
                    atribultiColor.getColor()
                    );
                

                // 
                // atributePanel
                // 
                atributePanel.Controls.Add(atributeIdLabel);
                atributePanel.Controls.Add(atributeLabel);
                atributePanel.Location = new System.Drawing.Point(5, atributeCount* 55);
                atributePanel.Name = "atributePanel";
                atributePanel.Padding = new System.Windows.Forms.Padding(3);
                atributePanel.Size = new System.Drawing.Size(347, 64);
                atributePanel.TabIndex = 29;
                atributeCount++;
                // 
                // atributeIdLabel
                // 
                atributeIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                atributeIdLabel.Location = new System.Drawing.Point(185, 28);
                atributeIdLabel.Name = "atributeIdLabel";
                atributeIdLabel.Size = new System.Drawing.Size(156, 33);
                atributeIdLabel.TabIndex = 29;
                atributeIdLabel.Text = "Abreviação: " + textBox2.Text;
                atributeIdLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight;
                // 
                // atributeLabel
                // 
                atributeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                atributeLabel.Location = new System.Drawing.Point(5, 3);
                atributeLabel.Name = "atributeLabel";
                atributeLabel.Size = new System.Drawing.Size(336, 58);
                atributeLabel.TabIndex = 28;
                atributeLabel.Text = textBox1.Text;
                atributeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                panel2.Controls.Add(atributePanel);

                this.Controls.Remove(borderChangePanel);
            });

            // 
            // borderChangePanel
            // 
            borderChangePanel.BackColor = System.Drawing.SystemColors.ControlText;
            borderChangePanel.Controls.Add(changePanel);
            borderChangePanel.Location = new System.Drawing.Point(146, 144);
            borderChangePanel.Name = "borderChangePanel";
            borderChangePanel.Padding = new System.Windows.Forms.Padding(1);
            borderChangePanel.Size = new System.Drawing.Size(508, 312);
            borderChangePanel.TabIndex = 31;
            // 
            // changePanel
            // 
            changePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            changePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            changePanel.Controls.Add(richTextBox1);
            changePanel.Controls.Add(label17);
            changePanel.Controls.Add(panel15);
            changePanel.Controls.Add(label16);
            changePanel.Controls.Add(panel14);
            changePanel.Controls.Add(label15);
            changePanel.Controls.Add(panel7);
            changePanel.Controls.Add(label8);
            changePanel.Controls.Add(trackBar3);
            changePanel.Controls.Add(trackBar2);
            changePanel.Controls.Add(trackBar1);
            changePanel.Controls.Add(panel5);
            changePanel.Controls.Add(alterButton);
            changePanel.Controls.Add(label6);
            changePanel.Location = new System.Drawing.Point(4, 4);
            changePanel.Name = "changePanel";
            changePanel.Size = new System.Drawing.Size(500, 304);
            changePanel.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextBox1.Location = new System.Drawing.Point(99, 141);
            richTextBox1.MaxLength = 500;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(173, 115);
            richTextBox1.TabIndex = 39;
            richTextBox1.Text = "";
            // 
            // label17
            // 
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label17.Location = new System.Drawing.Point(3, 143);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(90, 29);
            label17.TabIndex = 37;
            label17.Text = "Descrição:";
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.Color.White;
            panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel15.Controls.Add(textBox2);
            panel15.Location = new System.Drawing.Point(99, 97);
            panel15.Name = "panel15";
            panel15.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            panel15.Size = new System.Drawing.Size(173, 37);
            panel15.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.Location = new System.Drawing.Point(0, 8);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(169, 23);
            textBox2.TabIndex = 0;
            // 
            // label16
            // 
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label16.Location = new System.Drawing.Point(3, 97);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(92, 37);
            label16.TabIndex = 35;
            label16.Text = "Abreviação:";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.BackColor = System.Drawing.Color.White;
            panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel14.Controls.Add(textBox1);
            panel14.Location = new System.Drawing.Point(99, 50);
            panel14.Name = "panel14";
            panel14.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            panel14.Size = new System.Drawing.Size(173, 37);
            panel14.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new System.Drawing.Point(0, 8);
            textBox1.MaxLength = 150;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(169, 23);
            textBox1.TabIndex = 0;
            // 
            // label15
            // 
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label15.Location = new System.Drawing.Point(3, 50);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(92, 37);
            label15.TabIndex = 33;
            label15.Text = "Nome:";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            panel7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            panel7.Location = new System.Drawing.Point(417, 86);
            panel7.Name = "panel7";
            panel7.Size = new System.Drawing.Size(49, 131);
            panel7.TabIndex = 32;
            // 
            // label8
            // 
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label8.Location = new System.Drawing.Point(295, 86);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(105, 37);
            label8.TabIndex = 31;
            label8.Text = "Cor da barra:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBar3
            // 
            trackBar3.Location = new System.Drawing.Point(307, 172);
            trackBar3.Maximum = 255;
            trackBar3.Name = "trackBar3";
            trackBar3.Size = new System.Drawing.Size(104, 45);
            trackBar3.TabIndex = 13;
            // 
            // trackBar2
            // 
            trackBar2.Location = new System.Drawing.Point(307, 147);
            trackBar2.Maximum = 255;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new System.Drawing.Size(104, 45);
            trackBar2.TabIndex = 12;
            // 
            // trackBar1
            // 
            trackBar1.Location = new System.Drawing.Point(307, 121);
            trackBar1.Maximum = 255;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new System.Drawing.Size(104, 45);
            trackBar1.TabIndex = 11;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel5.Controls.Add(label4);
            panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            panel5.Location = new System.Drawing.Point(3, 264);
            panel5.Name = "panel5";
            panel5.Padding = new System.Windows.Forms.Padding(10);
            panel5.Size = new System.Drawing.Size(90, 35);
            panel5.TabIndex = 10;
            panel5.Click += cancel;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Cursor = System.Windows.Forms.Cursors.Hand;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(10, 10);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "CANCELAR";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            label4.Click += cancel;
            // 
            // alterButton
            // 
            alterButton.BackColor = System.Drawing.Color.Transparent;
            alterButton.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            alterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            alterButton.Controls.Add(alterLabel);
            alterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            alterButton.Location = new System.Drawing.Point(405, 264);
            alterButton.Name = "alterButton";
            alterButton.Padding = new System.Windows.Forms.Padding(10);
            alterButton.Size = new System.Drawing.Size(90, 35);
            alterButton.TabIndex = 9;
            alterButton.Click += save;
            // 
            // alterLabel
            // 
            alterLabel.BackColor = System.Drawing.Color.Transparent;
            alterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            alterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            alterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            alterLabel.ForeColor = System.Drawing.Color.White;
            alterLabel.Location = new System.Drawing.Point(10, 10);
            alterLabel.Margin = new System.Windows.Forms.Padding(0);
            alterLabel.Name = "alterLabel";
            alterLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            alterLabel.Size = new System.Drawing.Size(70, 15);
            alterLabel.TabIndex = 4;
            alterLabel.Text = "ALTERAR";
            alterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            alterLabel.Click += save;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(498, 47);
            label6.TabIndex = 0;
            label6.Text = "Novo Atributo";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            

            
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Panel borderChangePanel = new System.Windows.Forms.Panel();
            Panel changePanel = new System.Windows.Forms.Panel();
            RichTextBox richTextBox1 = new System.Windows.Forms.RichTextBox();
            Label label17 = new System.Windows.Forms.Label();
            Panel panel15 = new System.Windows.Forms.Panel();
            TextBox textBox2 = new System.Windows.Forms.TextBox();
            Label label16 = new System.Windows.Forms.Label();
            Panel panel14 = new System.Windows.Forms.Panel();
            TextBox textBox1 = new System.Windows.Forms.TextBox();
            Label label15 = new System.Windows.Forms.Label();
            Panel panel5 = new System.Windows.Forms.Panel();
            Label label4 = new System.Windows.Forms.Label();
            Panel alterButton = new System.Windows.Forms.Panel();
            Label alterLabel = new System.Windows.Forms.Label();
            Label label6 = new System.Windows.Forms.Label();


            this.Controls.Add(borderChangePanel);
            this.Controls.SetChildIndex(borderChangePanel, 0);

            EventHandler cancel = new EventHandler((s, EventArgs) => {

                this.Controls.Remove(borderChangePanel);
            });

            EventHandler save = new EventHandler((s, EventArgs) => {
                Panel panel10 = new System.Windows.Forms.Panel();
                Panel panel11 = new System.Windows.Forms.Panel();
                Label label11 = new System.Windows.Forms.Label();
                Label label12 = new System.Windows.Forms.Label();
                Panel panel12 = new System.Windows.Forms.Panel();
                Label label7 = new System.Windows.Forms.Label();
                Panel panel13 = new System.Windows.Forms.Panel();
                Label label13 = new System.Windows.Forms.Label();
                Label label14 = new System.Windows.Forms.Label();

                systemFormatter.setPropertie(
                    textBox2.Text,
                    textBox1.Text,
                    richTextBox1.Text
                    );

                EventHandler onClick = new EventHandler((eq, sa) => {
                    Panel panel1 = new System.Windows.Forms.Panel();
                    Panel panel2 = new System.Windows.Forms.Panel();
                    Panel panel3 = new System.Windows.Forms.Panel();
                    TextBox textBox3 = new System.Windows.Forms.TextBox();
                    Label label1 = new System.Windows.Forms.Label();
                    Panel panel4 = new System.Windows.Forms.Panel();
                    TextBox textBox4 = new System.Windows.Forms.TextBox();
                    Label label2 = new System.Windows.Forms.Label();
                    Panel panel6 = new System.Windows.Forms.Panel();
                    Label label3 = new System.Windows.Forms.Label();
                    Panel panel7 = new System.Windows.Forms.Panel();
                    Label label5 = new System.Windows.Forms.Label();
                    Label label8 = new System.Windows.Forms.Label();

                    // 
                    // panel1
                    // 
                    panel1.BackColor = System.Drawing.SystemColors.ControlText;
                    panel1.Controls.Add(panel2);
                    panel1.Location = new System.Drawing.Point(294, 61);
                    panel1.Name = "panel1";
                    panel1.Padding = new System.Windows.Forms.Padding(1);
                    panel1.Size = new System.Drawing.Size(325, 201);
                    panel1.TabIndex = 32;
                    // 
                    // panel2
                    // 
                    panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
                    panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    panel2.Controls.Add(panel3);
                    panel2.Controls.Add(label1);
                    panel2.Controls.Add(panel4);
                    panel2.Controls.Add(label2);
                    panel2.Controls.Add(panel6);
                    panel2.Controls.Add(panel7);
                    panel2.Controls.Add(label7);
                    panel2.Location = new System.Drawing.Point(4, 4);
                    panel2.Name = "panel2";
                    panel2.Size = new System.Drawing.Size(317, 193);
                    panel2.TabIndex = 11;
                    // 
                    // panel3
                    // 
                    panel3.BackColor = System.Drawing.Color.White;
                    panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    panel3.Controls.Add(textBox3);
                    panel3.Location = new System.Drawing.Point(99, 97);
                    panel3.Name = "panel3";
                    panel3.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
                    panel3.Size = new System.Drawing.Size(211, 37);
                    panel3.TabIndex = 36;
                    // 
                    // textBox3
                    // 
                    textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
                    textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    textBox3.Location = new System.Drawing.Point(0, 8);
                    textBox3.MaxLength = 50;
                    textBox3.Name = "textBox3";
                    textBox3.Size = new System.Drawing.Size(207, 23);
                    textBox3.TabIndex = 0;
                    // 
                    // label1
                    // 
                    label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    label1.Location = new System.Drawing.Point(3, 97);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(92, 37);
                    label1.TabIndex = 35;
                    label1.Text = "Abreviação:";
                    label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // panel4
                    // 
                    panel4.BackColor = System.Drawing.Color.White;
                    panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    panel4.Controls.Add(textBox4);
                    panel4.Location = new System.Drawing.Point(99, 50);
                    panel4.Name = "panel4";
                    panel4.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
                    panel4.Size = new System.Drawing.Size(211, 37);
                    panel4.TabIndex = 34;
                    // 
                    // textBox4
                    // 
                    textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
                    textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    textBox4.Location = new System.Drawing.Point(0, 8);
                    textBox4.MaxLength = 150;
                    textBox4.Name = "textBox4";
                    textBox4.Size = new System.Drawing.Size(207, 23);
                    textBox4.TabIndex = 0;
                    // 
                    // label2
                    // 
                    label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                    label2.Location = new System.Drawing.Point(3, 50);
                    label2.Name = "label2";
                    label2.Size = new System.Drawing.Size(92, 37);
                    label2.TabIndex = 33;
                    label2.Text = "Nome:";
                    label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // panel6
                    // 
                    panel6.BackColor = System.Drawing.Color.Transparent;
                    panel6.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
                    panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    panel6.Controls.Add(label3);
                    panel6.Cursor = System.Windows.Forms.Cursors.Hand;
                    panel6.Location = new System.Drawing.Point(4, 151);
                    panel6.Name = "panel6";
                    panel6.Padding = new System.Windows.Forms.Padding(10);
                    panel6.Size = new System.Drawing.Size(90, 35);
                    panel6.TabIndex = 10;
                    // 
                    // label3
                    // 
                    label3.BackColor = System.Drawing.Color.Transparent;
                    label3.Cursor = System.Windows.Forms.Cursors.Hand;
                    label3.Dock = System.Windows.Forms.DockStyle.Fill;
                    label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
                    label3.ForeColor = System.Drawing.Color.White;
                    label3.Location = new System.Drawing.Point(10, 10);
                    label3.Margin = new System.Windows.Forms.Padding(0);
                    label3.Name = "label3";
                    label3.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
                    label3.Size = new System.Drawing.Size(70, 15);
                    label3.TabIndex = 4;
                    label3.Text = "CANCELAR";
                    label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // panel7
                    // 
                    panel7.BackColor = System.Drawing.Color.Transparent;
                    panel7.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
                    panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                    panel7.Controls.Add(label5);
                    panel7.Cursor = System.Windows.Forms.Cursors.Hand;
                    panel7.Location = new System.Drawing.Point(220, 151);
                    panel7.Name = "panel7";
                    panel7.Padding = new System.Windows.Forms.Padding(10);
                    panel7.Size = new System.Drawing.Size(90, 35);
                    panel7.TabIndex = 9;
                    // 
                    // label5
                    // 
                    label5.BackColor = System.Drawing.Color.Transparent;
                    label5.Cursor = System.Windows.Forms.Cursors.Hand;
                    label5.Dock = System.Windows.Forms.DockStyle.Fill;
                    label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
                    label5.ForeColor = System.Drawing.Color.White;
                    label5.Location = new System.Drawing.Point(10, 10);
                    label5.Margin = new System.Windows.Forms.Padding(0);
                    label5.Name = "label5";
                    label5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
                    label5.Size = new System.Drawing.Size(70, 15);
                    label5.TabIndex = 4;
                    label5.Text = "ALTERAR";
                    label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    // 
                    // label7
                    // 
                    label7.Dock = System.Windows.Forms.DockStyle.Top;
                    label7.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    label7.Location = new System.Drawing.Point(0, 0);
                    label7.Name = "label7";
                    label7.Size = new System.Drawing.Size(315, 47);
                    label7.TabIndex = 0;
                    label7.Text = "Novo Atributo";
                    label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                    panel10.Controls.Add(panel1);
                });

                // 
                // panel10
                // 
                panel10.AutoScroll = true;
                panel10.BackColor = System.Drawing.Color.DarkGray;
                panel10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                panel10.Controls.Add(panel11);
                panel10.Controls.Add(panel12);
                panel10.Location = new System.Drawing.Point(199, 141);
                panel10.Name = "panel10";
                panel10.Size = new System.Drawing.Size(403, 168);
                panel10.TabIndex = 30;

                // 
                // panel11
                // 
                panel11.Controls.Add(label11);
                panel11.Controls.Add(label12);
                panel11.Location = new System.Drawing.Point(3, 55);
                panel11.Name = "panel11";
                panel11.Padding = new System.Windows.Forms.Padding(3);
                panel11.Size = new System.Drawing.Size(392, 64);
                panel11.TabIndex = 28;
                // 
                // label11
                // 
                label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label11.Location = new System.Drawing.Point(239, 28);
                label11.Name = "label11";
                label11.Size = new System.Drawing.Size(149, 33);
                label11.TabIndex = 29;
                label11.Text = "Abreviação: PV";
                label11.TextAlign = System.Drawing.ContentAlignment.BottomRight;
                // 
                // label12
                // 
                label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label12.Location = new System.Drawing.Point(5, 3);
                label12.Name = "label12";
                label12.Size = new System.Drawing.Size(380, 58);
                label12.TabIndex = 28;
                label12.Text = "Força de vontade";
                label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                // 
                // panel12
                // 
                panel12.BackColor = System.Drawing.Color.Gray;
                panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                panel12.Controls.Add(label7);
                panel12.Controls.Add(panel13);
                panel12.Controls.Add(label14);
                panel12.Dock = System.Windows.Forms.DockStyle.Top;
                panel12.Location = new System.Drawing.Point(0, 0);
                panel12.Name = "panel12";
                panel12.Padding = new System.Windows.Forms.Padding(5);
                panel12.Size = new System.Drawing.Size(399, 53);
                panel12.TabIndex = 27;
                // 
                // label7
                // 
                label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label7.Location = new System.Drawing.Point(8, 27);
                label7.Name = "label7";
                label7.Size = new System.Drawing.Size(265, 19);
                label7.TabIndex = 28;
                label7.Text = "Lista De Pericias Da Coleção";
                label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // panel13
                // 
                panel13.BackColor = System.Drawing.Color.Transparent;
                panel13.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
                panel13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                panel13.Controls.Add(label13);
                panel13.Cursor = System.Windows.Forms.Cursors.Hand;
                panel13.Location = new System.Drawing.Point(279, 3);
                panel13.Name = "panel13";
                panel13.Padding = new System.Windows.Forms.Padding(10);
                panel13.Size = new System.Drawing.Size(118, 45);
                panel13.TabIndex = 12;
                panel13.Click += onClick;
                // 
                // label13
                // 
                label13.BackColor = System.Drawing.Color.Transparent;
                label13.Cursor = System.Windows.Forms.Cursors.Hand;
                label13.Dock = System.Windows.Forms.DockStyle.Fill;
                label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
                label13.ForeColor = System.Drawing.Color.White;
                label13.Location = new System.Drawing.Point(10, 10);
                label13.Margin = new System.Windows.Forms.Padding(0);
                label13.Name = "label13";
                label13.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
                label13.Size = new System.Drawing.Size(98, 25);
                label13.TabIndex = 4;
                label13.Text = "NOVA PERICIA";
                label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // label14
                // 
                label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                label14.Location = new System.Drawing.Point(8, 5);
                label14.Name = "label14";
                label14.Size = new System.Drawing.Size(265, 19);
                label14.TabIndex = 27;
                label14.Text = "[Atributos]";
                label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

                Controls.Remove(borderChangePanel);
            });

            // 
            // borderChangePanel
            // 
            borderChangePanel.BackColor = System.Drawing.SystemColors.ControlText;
            borderChangePanel.Controls.Add(changePanel);
            borderChangePanel.Location = new System.Drawing.Point(257, 56);
            borderChangePanel.Name = "borderChangePanel";
            borderChangePanel.Padding = new System.Windows.Forms.Padding(1);
            borderChangePanel.Size = new System.Drawing.Size(325, 312);
            borderChangePanel.TabIndex = 31;
            // 
            // changePanel
            // 
            changePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            changePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            changePanel.Controls.Add(richTextBox1);
            changePanel.Controls.Add(label17);
            changePanel.Controls.Add(panel15);
            changePanel.Controls.Add(label16);
            changePanel.Controls.Add(panel14);
            changePanel.Controls.Add(label15);
            changePanel.Controls.Add(panel5);
            changePanel.Controls.Add(alterButton);
            changePanel.Controls.Add(label6);
            changePanel.Location = new System.Drawing.Point(4, 4);
            changePanel.Name = "changePanel";
            changePanel.Size = new System.Drawing.Size(317, 304);
            changePanel.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            richTextBox1.Location = new System.Drawing.Point(99, 141);
            richTextBox1.MaxLength = 500;
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new System.Drawing.Size(211, 115);
            richTextBox1.TabIndex = 39;
            richTextBox1.Text = "";
            // 
            // label17
            // 
            label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label17.Location = new System.Drawing.Point(3, 143);
            label17.Name = "label17";
            label17.Size = new System.Drawing.Size(90, 29);
            label17.TabIndex = 37;
            label17.Text = "Descrição:";
            // 
            // panel15
            // 
            panel15.BackColor = System.Drawing.Color.White;
            panel15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel15.Controls.Add(textBox2);
            panel15.Location = new System.Drawing.Point(99, 97);
            panel15.Name = "panel15";
            panel15.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            panel15.Size = new System.Drawing.Size(211, 37);
            panel15.TabIndex = 36;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox2.Location = new System.Drawing.Point(0, 8);
            textBox2.MaxLength = 50;
            textBox2.Name = "textBox2";
            textBox2.Size = new System.Drawing.Size(207, 23);
            textBox2.TabIndex = 0;
            // 
            // label16
            // 
            label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label16.Location = new System.Drawing.Point(3, 97);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(92, 37);
            label16.TabIndex = 35;
            label16.Text = "Abreviação:";
            label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel14
            // 
            panel14.BackColor = System.Drawing.Color.White;
            panel14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            panel14.Controls.Add(textBox1);
            panel14.Location = new System.Drawing.Point(99, 50);
            panel14.Name = "panel14";
            panel14.Padding = new System.Windows.Forms.Padding(0, 8, 0, 0);
            panel14.Size = new System.Drawing.Size(211, 37);
            panel14.TabIndex = 34;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            textBox1.Location = new System.Drawing.Point(0, 8);
            textBox1.MaxLength = 150;
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(207, 23);
            textBox1.TabIndex = 0;
            // 
            // label15
            // 
            label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label15.Location = new System.Drawing.Point(3, 50);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(92, 37);
            label15.TabIndex = 33;
            label15.Text = "Nome:";
            label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.BackColor = System.Drawing.Color.Transparent;
            panel5.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panel5.Controls.Add(label4);
            panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            panel5.Location = new System.Drawing.Point(3, 264);
            panel5.Name = "panel5";
            panel5.Padding = new System.Windows.Forms.Padding(10);
            panel5.Size = new System.Drawing.Size(90, 35);
            panel5.TabIndex = 10;
            // 
            // label4
            // 
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Cursor = System.Windows.Forms.Cursors.Hand;
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(10, 10);
            label4.Margin = new System.Windows.Forms.Padding(0);
            label4.Name = "label4";
            label4.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            label4.Size = new System.Drawing.Size(70, 15);
            label4.TabIndex = 4;
            label4.Text = "CANCELAR";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // alterButton
            // 
            alterButton.BackColor = System.Drawing.Color.Transparent;
            alterButton.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
            alterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            alterButton.Controls.Add(alterLabel);
            alterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            alterButton.Location = new System.Drawing.Point(220, 262);
            alterButton.Name = "alterButton";
            alterButton.Padding = new System.Windows.Forms.Padding(10);
            alterButton.Size = new System.Drawing.Size(90, 35);
            alterButton.TabIndex = 9;
            // 
            // alterLabel
            // 
            alterLabel.BackColor = System.Drawing.Color.Transparent;
            alterLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            alterLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            alterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Bold);
            alterLabel.ForeColor = System.Drawing.Color.White;
            alterLabel.Location = new System.Drawing.Point(10, 10);
            alterLabel.Margin = new System.Windows.Forms.Padding(0);
            alterLabel.Name = "alterLabel";
            alterLabel.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            alterLabel.Size = new System.Drawing.Size(70, 15);
            alterLabel.TabIndex = 4;
            alterLabel.Text = "ALTERAR";
            alterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Top;
            label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(0, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(315, 47);
            label6.TabIndex = 0;
            label6.Text = "Novo Atributo";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }
    }
}
