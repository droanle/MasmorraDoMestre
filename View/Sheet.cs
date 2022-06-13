using MasmorraDoMestre.Controller;
using MasmorraDoMestre.Model;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Text.RegularExpressions;

namespace MasmorraDoMestre.View
{
    public partial class Sheet : Form
    {
        Utilities utilities = new Utilities();
        Conection con = new Conection();
        PrivateFontCollection pf = null;
        int IdGame, IdSheet;

        public Sheet(int IdGame, int IdSheet, PrivateFontCollection pf)
        {
            this.IdGame = IdGame; 
            this.IdSheet = IdSheet;
            this.pf = pf;

            InitializeComponent();
            InitializeList();
        }

        private void Sheet_Load(object sender, EventArgs e)
        {
            utilities.FontSet(this, pf);
            utilities.FontSet(content, pf);
            utilities.FontSet(SecAttributes, pf);

            DataRow table = con.getSheetTarget(IdSheet);

            this.Text = table["Name"].ToString();
            this.profilePhoto.Image = utilities.getImagePrefile(int.Parse(table["Image"].ToString()));
            this.nameLabel.Text = table["Name"].ToString();
            this.descriptionLabel.Text = table["Description"].ToString();
            this.typeLabel.Text = table["Type"].ToString();
            this.ifPlayerLabel.Text = Convert.ToBoolean(table["Player"].ToString()) ? "Esta ficha é de um player" : "Esta ficha é de um NPC";

        }

        private void InitializeList()
        {
            DataTable table = con.getAttributes(IdSheet);

            int locationY = 37;
            int size = table.Rows.Count ;

            for (int i = 0; i < size; i++)
            {
                createListSecAttributes(locationY, table.Rows[i]);

                locationY += 55;
            }

            PropertiesList Properties_List = new PropertiesList();
            int locationX = 3;
            locationY = 191;

            Properties_List = JsonConvert.DeserializeObject<PropertiesList>(con.getProperties_List(IdGame));

            foreach(ListValues propertieType in Properties_List.List)
            {
                table = con.getProperties(IdSheet, propertieType.abbreviation);

                createListTypeProperties(locationX, locationY, propertieType, table);

                if (locationX == 374)
                {
                    locationX = 3;
                    locationY += 231;
                }
                else
                {
                    locationX = 374;
                }

            }

            Console.WriteLine(JsonConvert.SerializeObject(Properties_List));
        }

        private void createListSecAttributes(int Y, DataRow Data)
        {
            Panel attributePanel = new Panel();
            Panel attributeRenge = new Panel();
            Panel attributeIscore = new Panel();
            Label attributeIscoreLabel = new Label();
            Label attributeLabel = new Label();
            Label attributeRengeLabel = new Label();

            String DescriptionMassage = "Abreviação: " + Data["Id"].ToString() + "  Descrição: " + Data["Description"].ToString();

            int Red = int.Parse(Data["Color"].ToString().Split('-')[0]),
                   Green = int.Parse(Data["Color"].ToString().Split('-')[1]),
                   Blue = int.Parse(Data["Color"].ToString().Split('-')[2]),
                   CurrentValue = 0,
                   MaxValue = 0,
                   IscoreSize = 0;

            try { CurrentValue = int.Parse(Data["Value"].ToString().Split('/')[0]); } catch { CurrentValue = 0; }
            try { MaxValue = int.Parse(Data["Value"].ToString().Split('/')[1]); } catch { MaxValue = 0; }
            try { IscoreSize = (519 * ((100 * CurrentValue) / MaxValue)) / 100; } catch { IscoreSize = 0; }

            if (IscoreSize < 100)
            {
                attributeIscoreLabel.Hide();
                attributeRengeLabel.Show();
            }
            else
            {
                attributeRengeLabel.Hide();
                attributeIscoreLabel.Show();
            }

            EventHandler editValueBox = new System.EventHandler((object sender, EventArgs e) => {
                Panel borderChangePanel = new Panel();
                Panel changePanel = new Panel();
                Panel cancelButton = new Panel();
                Panel alterButton = new Panel();
                Label alterLabel = new Label();
                Panel campoPanel = new Panel();
                TextBox eValueTextBox = new TextBox();
                Label barraTextBox = new Label();
                TextBox dValueTextBox = new TextBox();
                Label itemTitleLabel = new Label();
                Label cancelLabel = new Label();


                int InternalCurrentValue = int.Parse(attributeIscoreLabel.Text.Split('/')[0]),
                       InternalMaxValue = int.Parse(attributeIscoreLabel.Text.Split('/')[1]);

                EventHandler Close = new System.EventHandler((object senderC, EventArgs eC) => { this.Controls.Remove(borderChangePanel); });

                EventHandler eOnChange = new System.EventHandler((object senderC, EventArgs eC) => {
                    try
                    {
                        int value = int.Parse(Regex.Replace(eValueTextBox.Text, @"[^\d]", "")),
                               dValue = int.Parse(dValueTextBox.Text);

                        if (value > dValue) eValueTextBox.Text = dValueTextBox.Text;
                        else if (value < 0) eValueTextBox.Text = "0";
                        else eValueTextBox.Text = value.ToString();
                    }
                    catch
                    {
                        if(eValueTextBox.Text != "") eValueTextBox.Text = "0";
                    }
                });

                EventHandler dOnChange = new System.EventHandler((object senderC, EventArgs eC) => {
                    try
                    {
                        int eValue = int.Parse(Regex.Replace(eValueTextBox.Text, @"[^\d]", "")),
                               dValue = int.Parse(Regex.Replace(dValueTextBox.Text, @"[^\d]", ""));


                        if (dValue < 0) dValueTextBox.Text = "0";
                        else dValueTextBox.Text = dValue.ToString();

                        if (eValue > dValue) eValueTextBox.Text = dValueTextBox.Text;
                        else if (eValue < 0) eValueTextBox.Text = "0";
                        else eValueTextBox.Text = eValue.ToString();
                    }
                    catch
                    {
                        if (eValueTextBox.Text != "") eValueTextBox.Text = "0";
                        if (dValueTextBox.Text != "") dValueTextBox.Text = "0";
                    }

                });

                EventHandler Save = new System.EventHandler((object senderC, EventArgs eC) => {
                    int eValue, dValue;

                    eValue = dValue = 0;

                    try
                    {
                        eValue = int.Parse(Regex.Replace(eValueTextBox.Text, @"[^\d]", ""));
                    }
                    catch
                    {
                        if (eValueTextBox.Text != "") eValue = 0;
                    }

                    try
                    {
                        dValue = int.Parse(Regex.Replace(dValueTextBox.Text, @"[^\d]", ""));
                    }
                    catch
                    {
                        if (dValueTextBox.Text != "") dValue = 0;
                    }


                    if (con.setSecAttributesValue((eValue + "/" + dValue), IdSheet, Data["Id"].ToString()))
                    {
                        attributeRengeLabel.Text = attributeIscoreLabel.Text = eValue + "/" + dValue;

                        try { IscoreSize = (519 * ((100 * eValue) / dValue)) / 100; } catch { IscoreSize = 0; }
                        
                        if(IscoreSize < 100) {
                            attributeIscoreLabel.Hide();
                            attributeRengeLabel.Show();
                        }else
                        {
                            attributeRengeLabel.Hide();
                            attributeIscoreLabel.Show();
                        }
                        attributeIscore.Size = new Size(IscoreSize, 33);
                    }

                    this.Controls.Remove(borderChangePanel);
                });

                // 
                // borderChangePanel
                // 
                borderChangePanel.BackColor = SystemColors.ControlText;
                borderChangePanel.Controls.Add(changePanel);
                borderChangePanel.Location = new Point(271, 221);
                borderChangePanel.Name = "borderChangePanel";
                borderChangePanel.Padding = new Padding(1);
                borderChangePanel.Size = new Size(258, 158);
                borderChangePanel.TabIndex = 3;

                // 
                // changePanel
                // 
                changePanel.BackColor = SystemColors.ControlDarkDark;
                changePanel.BorderStyle = BorderStyle.FixedSingle;
                changePanel.Controls.Add(campoPanel);
                changePanel.Controls.Add(alterButton);
                changePanel.Controls.Add(cancelButton);
                changePanel.Controls.Add(itemTitleLabel);
                changePanel.Location = new Point(4, 4);
                changePanel.Name = "changePanel";
                changePanel.Size = new Size(250, 150);
                changePanel.TabIndex = 11;
                changePanel.Paint += new PaintEventHandler((a, z) => { utilities.FontSet(changePanel, pf); });

                // 
                // cancelButton
                // 
                cancelButton.BackColor = Color.Transparent;
                cancelButton.BackgroundImage = Properties.Resources.botão_1_png;
                cancelButton.BackgroundImageLayout = ImageLayout.Stretch;
                cancelButton.Controls.Add(cancelLabel);
                cancelButton.Cursor = Cursors.Hand;
                cancelButton.Location = new Point(3, 110);
                cancelButton.Name = "cancelButton";
                cancelButton.Padding = new Padding(10);
                cancelButton.Size = new Size(90, 35);
                cancelButton.TabIndex = 10;
                cancelButton.Click += Close;
                cancelButton.Paint += new PaintEventHandler((a, z) => { utilities.FontSet(cancelButton, pf); });

                // 
                // cancelLabel
                // 
                cancelLabel.BackColor = Color.Transparent;
                cancelLabel.Cursor = Cursors.Hand;
                cancelLabel.Dock = DockStyle.Fill;
                cancelLabel.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
                cancelLabel.ForeColor = Color.White;
                cancelLabel.Location = new Point(10, 10);
                cancelLabel.Margin = new Padding(0);
                cancelLabel.Name = "cancelLabel";
                cancelLabel.Padding = new Padding(0, 2, 0, 0);
                cancelLabel.Size = new Size(70, 15);
                cancelLabel.TabIndex = 4;
                cancelLabel.Text = "CANCELAR";
                cancelLabel.TextAlign = ContentAlignment.MiddleCenter;
                cancelLabel.Click += Close;

                // 
                // alterButton
                // 
                alterButton.BackColor = Color.Transparent;
                alterButton.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
                alterButton.BackgroundImageLayout = ImageLayout.Stretch;
                alterButton.Controls.Add(alterLabel);
                alterButton.Cursor = Cursors.Hand;
                alterButton.Location = new Point(155, 110);
                alterButton.Name = "alterButton";
                alterButton.Padding = new Padding(10);
                alterButton.Size = new Size(90, 35);
                alterButton.TabIndex = 9;
                alterButton.Click += Save;
                alterButton.Paint += new PaintEventHandler((a, z) => { utilities.FontSet(alterButton, pf); });

                // 
                // alterLabel
                // 
                alterLabel.BackColor = Color.Transparent;
                alterLabel.Cursor = Cursors.Hand;
                alterLabel.Dock = DockStyle.Fill;
                alterLabel.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
                alterLabel.ForeColor = Color.White;
                alterLabel.Location = new Point(10, 10);
                alterLabel.Margin = new Padding(0);
                alterLabel.Name = "alterLabel";
                alterLabel.Padding = new Padding(0, 2, 0, 0);
                alterLabel.Size = new Size(70, 15);
                alterLabel.TabIndex = 4;
                alterLabel.Text = "ALTERAR";
                alterLabel.TextAlign = ContentAlignment.MiddleCenter;
                alterLabel.Click += Save;

                // 
                // campoPanel
                // 
                campoPanel.BackColor = Color.WhiteSmoke;
                campoPanel.BorderStyle = BorderStyle.FixedSingle;
                campoPanel.Controls.Add(eValueTextBox);
                campoPanel.Controls.Add(dValueTextBox);
                campoPanel.Controls.Add(barraTextBox);
                campoPanel.Location = new Point(77, 47);
                campoPanel.Name = "campoPanel";
                campoPanel.Padding = new Padding(0, 0, 2, 2);
                campoPanel.Size = new Size(102, 38);
                campoPanel.TabIndex = 14;
                
                // 
                // barraTextBox
                // 
                barraTextBox.BackColor = Color.WhiteSmoke;
                barraTextBox.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                barraTextBox.Location = new Point(41, 2);
                barraTextBox.Name = "barraTextBox";
                barraTextBox.Size = new Size(19, 34);
                barraTextBox.TabIndex = 12;
                barraTextBox.Text = "/";

                // 
                // eValueTextBox
                // 
                eValueTextBox.BackColor = Color.WhiteSmoke;
                eValueTextBox.BorderStyle = BorderStyle.None;
                eValueTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                eValueTextBox.Location = new Point(3, 9);
                eValueTextBox.Name = "eValueTextBox";
                eValueTextBox.Size = new Size(40, 23);
                eValueTextBox.TabIndex = 13;
                eValueTextBox.Text = InternalCurrentValue.ToString();
                eValueTextBox.TextAlign = HorizontalAlignment.Right;
                eValueTextBox.TextChanged += eOnChange;
                eValueTextBox.KeyUp += new KeyEventHandler((object keySender, KeyEventArgs keyE) =>
                {
                    if (keyE.KeyCode == Keys.Enter)
                    {
                        int eValue, dValue;

                        eValue = dValue = 0;

                        try
                        {
                            eValue = int.Parse(Regex.Replace(eValueTextBox.Text, @"[^\d]", ""));
                        }
                        catch
                        {
                            if (eValueTextBox.Text != "") eValue = 0;
                        }

                        try
                        {
                            dValue = int.Parse(Regex.Replace(dValueTextBox.Text, @"[^\d]", ""));
                        }
                        catch
                        {
                            if (dValueTextBox.Text != "") dValue = 0;
                        }


                        if (con.setSecAttributesValue((eValue + "/" + dValue), IdSheet, Data["Id"].ToString()))
                        {
                            attributeRengeLabel.Text = attributeIscoreLabel.Text = eValue + "/" + dValue;

                            try { IscoreSize = (519 * ((100 * eValue) / dValue)) / 100; } catch { IscoreSize = 0; }

                            if (IscoreSize < 100)
                            {
                                attributeIscoreLabel.Hide();
                                attributeRengeLabel.Show();
                            }
                            else
                            {
                                attributeRengeLabel.Hide();
                                attributeIscoreLabel.Show();
                            }
                            attributeIscore.Size = new Size(IscoreSize, 33);
                        }

                        this.Controls.Remove(borderChangePanel);
                    }
                });

                // 
                // dValueTextBox
                // 
                dValueTextBox.BackColor = Color.WhiteSmoke;
                dValueTextBox.BorderStyle = BorderStyle.None;
                dValueTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                dValueTextBox.Location = new Point(58, 9);
                dValueTextBox.Name = "dValueTextBox";
                dValueTextBox.Size = new Size(37, 23);
                dValueTextBox.TabIndex = 11;
                dValueTextBox.Text = InternalMaxValue.ToString();
                
                // 
                // itemTitleLabel
                // 
                itemTitleLabel.Dock = DockStyle.Top;
                itemTitleLabel.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                itemTitleLabel.Location = new Point(0, 0);
                itemTitleLabel.Name = "itemTitleLabel";
                itemTitleLabel.Size = new Size(248, 47);
                itemTitleLabel.TabIndex = 0;
                itemTitleLabel.Text = Data["Name"].ToString();
                itemTitleLabel.TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Add(borderChangePanel);

                this.Controls.SetChildIndex(borderChangePanel, 0);
            });

            // 
            // SecAttributes
            // 
            SecAttributes.Controls.Add(attributePanel);

            // 
            // attributePanel
            // 
            attributePanel.BackColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            attributePanel.Controls.Add(attributeRenge);
            attributePanel.Controls.Add(attributeLabel);
            attributePanel.Location = new Point(4, Y);
            attributePanel.Name = "attributePanel";
            attributePanel.Padding = new Padding(5);
            attributePanel.Size = new Size(705, 50);
            attributePanel.TabIndex = 13;
            attributePanel.Paint += new PaintEventHandler((sender, EventArgs) => { utilities.FontSet(attributePanel, pf); });
            attributePanel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(attributePanel, DescriptionMassage);
            });

            // 
            // attributeRenge
            // 
            attributeRenge.BackColor = Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            attributeRenge.BorderStyle = BorderStyle.FixedSingle;
            attributeRenge.Controls.Add(attributeIscore); 
            attributeRenge.Controls.Add(attributeRengeLabel);
            attributeRenge.Location = new Point(178, 7);
            attributeRenge.Name = "attributeRenge";
            attributeRenge.Size = new Size(519, 35);
            attributeRenge.TabIndex = 12;
            attributeRenge.DoubleClick += editValueBox;
            attributeRenge.Paint += new PaintEventHandler((a, z) => { utilities.FontSet(attributeRenge, pf); });
            attributeRenge.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(attributeRenge, DescriptionMassage + "\n Click duas vezes para editar.");
            });

            // 
            // attributeIscore
            // 
            attributeIscore.BackColor = Color.FromArgb(Red, Green, Blue);
            attributeIscore.Controls.Add(attributeIscoreLabel);
            attributeIscore.Location = new Point(0, 0);
            attributeIscore.Name = "attributeIscore";
            attributeIscore.Padding = new Padding(9);
            attributeIscore.Size = new Size(IscoreSize, 33);
            attributeIscore.TabIndex = 0;
            attributeIscore.Paint += new PaintEventHandler((sender, EventArgs) => { utilities.FontSet(attributeIscore, pf); });
            attributeIscore.DoubleClick += editValueBox;
            attributeIscore.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(attributeIscore, DescriptionMassage + "\n Click duas vezes para editar.");
            });

            // 
            // attributeIscoreLabel
            // 
            attributeIscoreLabel.BackColor = Color.Transparent;
            attributeIscoreLabel.Dock = DockStyle.Fill;
            attributeIscoreLabel.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            attributeIscoreLabel.ForeColor = Color.WhiteSmoke;
            attributeIscoreLabel.Location = new Point(9, 9);
            attributeIscoreLabel.Margin = new Padding(0, 10, 0, 10);
            attributeIscoreLabel.Name = "attributeIscoreLabel";
            attributeIscoreLabel.Padding = new Padding(5, 0, 0, 0);
            attributeIscoreLabel.Size = new Size((IscoreSize - 18), 15);
            attributeIscoreLabel.TabIndex = 13;
            attributeIscoreLabel.Text = CurrentValue.ToString() + " / " + MaxValue.ToString();
            attributeIscoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            attributeIscoreLabel.DoubleClick += editValueBox;
            attributeIscoreLabel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(attributeIscoreLabel, DescriptionMassage + "\n Click duas vezes para editar.");
            });

            // 
            // attributeRengeLabel
            // 
            attributeRengeLabel.BackColor = Color.Transparent;
            attributeRengeLabel.Dock = DockStyle.Fill;
            attributeRengeLabel.Font = new Font("Microsoft Tai Le", 11F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            attributeRengeLabel.ForeColor = Color.WhiteSmoke;
            attributeRengeLabel.Location = new Point(9, 9);
            attributeRengeLabel.Margin = new Padding(0, 10, 0, 10);
            attributeRengeLabel.Name = "attributeIscoreLabel";
            attributeRengeLabel.Padding = new Padding(5, 0, 0, 0);
            attributeRengeLabel.Size = new Size((IscoreSize - 18), 15);
            attributeRengeLabel.TabIndex = 13;
            attributeRengeLabel.Text = CurrentValue.ToString() + " / " + MaxValue.ToString();
            attributeRengeLabel.TextAlign = ContentAlignment.MiddleCenter;
            attributeRengeLabel.DoubleClick += editValueBox;
            attributeRengeLabel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(attributeRengeLabel, DescriptionMassage + "\n Click duas vezes para editar.");
            });

            // 
            // attributeLabel
            // 
            attributeLabel.BackColor = Color.Transparent;
            attributeLabel.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            attributeLabel.ForeColor = Color.WhiteSmoke;
            attributeLabel.Location = new Point(9, 7);
            attributeLabel.Margin = new Padding(0, 10, 0, 10);
            attributeLabel.Name = "attributeLabel";
            attributeLabel.Padding = new Padding(5, 0, 0, 0);
            attributeLabel.Size = new Size(166, 35);
            attributeLabel.TabIndex = 11;
            attributeLabel.Text = Data["Name"].ToString() + ":";
            attributeLabel.TextAlign = ContentAlignment.MiddleLeft;
            attributeLabel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(attributeLabel, DescriptionMassage);
            });

        }

        private void createListTypeProperties(int X, int Y, ListValues propertieType, DataTable Data)
        {
            Panel propertiesPanel = new Panel();
            Label propertiesTypeNameLabel = new Label();
            Panel space = new Panel();

            String DescriptionMassage = "Abreviação: " + propertieType.abbreviation + "  Descrição: " + propertieType.description;

            content.Controls.Add(propertiesPanel);

            // 
            // propertiesPanel
            // 
            propertiesPanel.AutoScroll = true;
            propertiesPanel.BackColor = Color.Gray;
            propertiesPanel.BorderStyle = BorderStyle.FixedSingle;
            propertiesPanel.Controls.Add(propertiesTypeNameLabel);
            propertiesPanel.Controls.Add(space);
            propertiesPanel.Location = new Point(X, Y);
            propertiesPanel.Name = "propertiesPanel";
            propertiesPanel.Padding = new Padding(0, 8, 0, 0);
            propertiesPanel.Size = new Size(365, 228);
            propertiesPanel.TabIndex = 15;

            // 
            // propertiesTypeNameLabel
            // 
            propertiesTypeNameLabel.Dock = DockStyle.Top;
            propertiesTypeNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            propertiesTypeNameLabel.ForeColor = Color.Black;
            propertiesTypeNameLabel.Location = new Point(8, 8);
            propertiesTypeNameLabel.Margin = new Padding(0);
            propertiesTypeNameLabel.Name = "propertiesTypeNameLabel";
            propertiesTypeNameLabel.Size = new Size(347, 43);
            propertiesTypeNameLabel.TabIndex = 11;
            propertiesTypeNameLabel.Text = propertieType.name;
            propertiesTypeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            propertiesTypeNameLabel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(propertiesTypeNameLabel, DescriptionMassage);
            });

            int locationX = 4, locationY = 56;

            foreach (DataRow dataRow in Data.Rows)
            {

                propertiesPanel.Controls.Add(createListProperties(locationX, locationY, propertieType , dataRow));

                if (locationX == 176)
                {
                    locationX = 4;
                    locationY += 136;
                }
                else
                {
                    locationX = 176;
                }
            }

            // 
            // space
            // 
            space.Dock = DockStyle.Bottom;
            space.Location = new Point(0, 220);
            space.Name = "space";
            space.Size = new Size(365, 4);
            space.TabIndex = 12;

        }

        private Panel createListProperties(int X, int Y, ListValues propertieType, DataRow Data)
        {
            Panel ItemPropertiePanel = new Panel();
            Label propertieNameLabel = new Label();
            Label propertieValueLabel = new Label();

            String DescriptionMassage = "Parte do grupo: \"" + propertieType.name + "\"  Abreviação: " + Data["Id"].ToString();

            EventHandler editValueBox = new System.EventHandler((object sender, EventArgs e) => {
                Panel borderChangePanel = new Panel();
                Panel changePanel = new Panel();
                Panel cancelButton = new Panel();
                Panel alterButton = new Panel();
                Label alterLabel = new Label();
                Label itemTextBox = new Label();
                Label itemTitleLabel = new Label();
                Label cancelLabel = new Label();

                EventHandler Close = new System.EventHandler((object senderC, EventArgs eC) => { this.Controls.Remove(borderChangePanel); });

                // 
                // borderChangePanel
                // 
                borderChangePanel.BackColor = SystemColors.ControlText;
                borderChangePanel.Controls.Add(changePanel);
                borderChangePanel.Location = new Point(271, 221);
                borderChangePanel.Name = "borderChangePanel";
                borderChangePanel.Padding = new Padding(1);
                borderChangePanel.Size = new Size(258, 158);
                borderChangePanel.TabIndex = 3;

                // 
                // changePanel
                // 
                changePanel.BackColor = SystemColors.ControlDarkDark;
                changePanel.BorderStyle = BorderStyle.FixedSingle;
                changePanel.Controls.Add(cancelButton);
                changePanel.Controls.Add(alterButton);
                changePanel.Controls.Add(itemTextBox);
                changePanel.Controls.Add(itemTitleLabel);
                changePanel.Location = new Point(4, 4);
                changePanel.Name = "changePanel";
                changePanel.Size = new Size(250, 150);
                changePanel.TabIndex = 11;

                // 
                // cancelButton
                // 
                cancelButton.BackColor = Color.Transparent;
                cancelButton.BackgroundImage = Properties.Resources.botão_1_png;
                cancelButton.BackgroundImageLayout = ImageLayout.Stretch;
                cancelButton.Controls.Add(cancelLabel);
                cancelButton.Cursor = Cursors.Hand;
                cancelButton.Location = new Point(3, 110);
                cancelButton.Name = "cancelButton";
                cancelButton.Padding = new Padding(10);
                cancelButton.Size = new Size(90, 35);
                cancelButton.TabIndex = 10;
                cancelButton.Click += Close;

                // 
                // cancelLabel
                // 
                cancelLabel.BackColor = Color.Transparent;
                cancelLabel.Cursor = Cursors.Hand;
                cancelLabel.Dock = DockStyle.Fill;
                cancelLabel.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
                cancelLabel.ForeColor = Color.White;
                cancelLabel.Location = new Point(10, 10);
                cancelLabel.Margin = new Padding(0);
                cancelLabel.Name = "cancelLabel";
                cancelLabel.Padding = new Padding(0, 2, 0, 0);
                cancelLabel.Size = new Size(70, 15);
                cancelLabel.TabIndex = 4;
                cancelLabel.Text = "CANCELAR";
                cancelLabel.TextAlign = ContentAlignment.MiddleCenter;
                cancelLabel.Click += Close;

                // 
                // alterButton
                // 
                alterButton.BackColor = Color.Transparent;
                alterButton.BackgroundImage = global::MasmorraDoMestre.Properties.Resources.botão_1_png;
                alterButton.BackgroundImageLayout = ImageLayout.Stretch;
                alterButton.Controls.Add(alterLabel);
                alterButton.Cursor = Cursors.Hand;
                alterButton.Location = new Point(155, 110);
                alterButton.Name = "alterButton";
                alterButton.Padding = new Padding(10);
                alterButton.Size = new Size(90, 35);
                alterButton.TabIndex = 9;

                // 
                // alterLabel
                // 
                alterLabel.BackColor = Color.Transparent;
                alterLabel.Cursor = Cursors.Hand;
                alterLabel.Dock = DockStyle.Fill;
                alterLabel.Font = new Font("Microsoft Sans Serif", 6F, FontStyle.Bold);
                alterLabel.ForeColor = Color.White;
                alterLabel.Location = new Point(10, 10);
                alterLabel.Margin = new Padding(0);
                alterLabel.Name = "alterLabel";
                alterLabel.Padding = new Padding(0, 2, 0, 0);
                alterLabel.Size = new Size(70, 15);
                alterLabel.TabIndex = 4;
                alterLabel.Text = "ALTERAR";
                alterLabel.TextAlign = ContentAlignment.MiddleCenter;

                // 
                // itemTextBox
                // 
                itemTextBox.BorderStyle = BorderStyle.FixedSingle;
                itemTextBox.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                itemTextBox.Location = new Point(110, 60);
                itemTextBox.Name = "itemTextBox";
                itemTextBox.Size = new Size(30, 30);
                itemTextBox.TabIndex = 1;
                itemTextBox.Text = "1";
                itemTextBox.TextAlign = (ContentAlignment)HorizontalAlignment.Center;

                // 
                // itemTitleLabel
                // 
                itemTitleLabel.Dock = DockStyle.Top;
                itemTitleLabel.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                itemTitleLabel.Location = new Point(0, 0);
                itemTitleLabel.Name = "itemTitleLabel";
                itemTitleLabel.Size = new Size(248, 47);
                itemTitleLabel.TabIndex = 0;
                itemTitleLabel.Text = "[Titulo da alteração]";
                itemTitleLabel.TextAlign = ContentAlignment.MiddleCenter;

                this.Controls.Add(borderChangePanel);

                this.Controls.SetChildIndex(borderChangePanel, 0);
            });

            // 
            // ItemPropertiesPanel
            // 
            ItemPropertiePanel.BackColor = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            ItemPropertiePanel.Controls.Add(propertieValueLabel);
            ItemPropertiePanel.Controls.Add(propertieNameLabel);
            ItemPropertiePanel.Location = new Point(X, Y);
            ItemPropertiePanel.Name = "ItemPropertiesPanel";
            ItemPropertiePanel.Padding = new Padding(5);
            ItemPropertiePanel.Size = new Size(165, 133);
            ItemPropertiePanel.TabIndex = 1;
            ItemPropertiePanel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(ItemPropertiePanel, DescriptionMassage);
            });

            // 
            // propertiesNameLabel
            // 
            propertieNameLabel.BackColor = Color.Transparent;
            propertieNameLabel.Dock = DockStyle.Top;
            propertieNameLabel.Font = new Font("Microsoft Tai Le", 12F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            propertieNameLabel.ForeColor = Color.WhiteSmoke;
            propertieNameLabel.Location = new Point(5, 5);
            propertieNameLabel.Margin = new Padding(0, 10, 0, 10);
            propertieNameLabel.Name = "propertiesNameLabel";
            propertieNameLabel.Padding = new Padding(5, 0, 0, 0);
            propertieNameLabel.Size = new Size(155, 49);
            propertieNameLabel.TabIndex = 13;
            propertieNameLabel.Text = Data["Name"].ToString();
            propertieNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            propertieNameLabel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(propertieNameLabel, DescriptionMassage);
            });

            // 
            // propertiesValueLabel
            // 
            propertieValueLabel.BackColor = Color.Transparent;
            propertieValueLabel.Font = new Font("Microsoft Tai Le", 20F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
            propertieValueLabel.ForeColor = Color.WhiteSmoke;
            propertieValueLabel.Location = new Point(5, 60);
            propertieValueLabel.Margin = new Padding(0, 10, 0, 10);
            propertieValueLabel.Name = "propertiesValueLabel";
            propertieValueLabel.Padding = new Padding(5, 0, 0, 0);
            propertieValueLabel.Size = new Size(155, 58);
            propertieValueLabel.TabIndex = 14;
            propertieValueLabel.Text = Data["Value"].ToString();
            propertieValueLabel.TextAlign = ContentAlignment.MiddleCenter;
            propertieValueLabel.MouseEnter += new EventHandler((sender, EventArgs) => {
                ToolTip toolTip1 = new ToolTip();
                toolTip1.ShowAlways = true;
                toolTip1.SetToolTip(propertieValueLabel, DescriptionMassage);
            });

            return ItemPropertiePanel;
        }
    }
}
