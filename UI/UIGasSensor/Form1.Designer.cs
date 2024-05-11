namespace UI
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderEdges();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuGroupBox1 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpen = new Bunifu.UI.WinForms.BunifuButton.BunifuButton2();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.cbCom = new Bunifu.UI.WinForms.BunifuDropdown();
            this.Receiver = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.btnLed1 = new System.Windows.Forms.Button();
            this.btnLed2 = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.bunifuGroupBox2 = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbList = new Bunifu.UI.WinForms.BunifuDropdown();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.bunifuGroupBox1.SuspendLayout();
            this.Receiver.SuspendLayout();
            this.bunifuGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM2";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(533, 168);
            this.textBox1.TabIndex = 6;
            // 
            // bunifuGroupBox1
            // 
            this.bunifuGroupBox1.BackColor = System.Drawing.Color.SeaShell;
            this.bunifuGroupBox1.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox1.BorderRadius = 10;
            this.bunifuGroupBox1.BorderThickness = 1;
            this.bunifuGroupBox1.Controls.Add(this.btnClose);
            this.bunifuGroupBox1.Controls.Add(this.label1);
            this.bunifuGroupBox1.Controls.Add(this.btnOpen);
            this.bunifuGroupBox1.Controls.Add(this.bunifuLabel1);
            this.bunifuGroupBox1.Controls.Add(this.cbCom);
            this.bunifuGroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuGroupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuGroupBox1.ForeColor = System.Drawing.Color.SteelBlue;
            this.bunifuGroupBox1.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox1.LabelIndent = 10;
            this.bunifuGroupBox1.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Dash;
            this.bunifuGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.bunifuGroupBox1.Name = "bunifuGroupBox1";
            this.bunifuGroupBox1.Size = new System.Drawing.Size(246, 155);
            this.bunifuGroupBox1.TabIndex = 7;
            this.bunifuGroupBox1.TabStop = false;
            this.bunifuGroupBox1.Text = "Control";
            // 
            // btnClose
            // 
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowMouseEffects = true;
            this.btnClose.AllowToggling = true;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.AutoRoundBorders = false;
            this.btnClose.AutoSizeLeftIcon = true;
            this.btnClose.AutoSizeRightIcon = true;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.ButtonText = "Close";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.DisabledFillColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.DisabledForecolor = System.Drawing.Color.DimGray;
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnClose.IconSize = 25;
            this.btnClose.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnClose.IdleBorderRadius = 10;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = true;
            this.btnClose.Location = new System.Drawing.Point(158, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnClose.OnDisabledState.BorderRadius = 10;
            this.btnClose.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnDisabledState.BorderThickness = 0;
            this.btnClose.OnDisabledState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.OnDisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btnClose.OnDisabledState.IconLeftImage = null;
            this.btnClose.OnDisabledState.IconRightImage = null;
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnClose.onHoverState.BorderRadius = 10;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 0;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.SlateGray;
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnClose.OnIdleState.BorderRadius = 10;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 0;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnClose.OnIdleState.IconLeftImage = null;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnClose.OnPressedState.BorderRadius = 10;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 0;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(63, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoEllipsis = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "COM:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOpen
            // 
            this.btnOpen.AllowAnimations = true;
            this.btnOpen.AllowMouseEffects = true;
            this.btnOpen.AllowToggling = true;
            this.btnOpen.AnimationSpeed = 200;
            this.btnOpen.AutoGenerateColors = false;
            this.btnOpen.AutoRoundBorders = false;
            this.btnOpen.AutoSizeLeftIcon = true;
            this.btnOpen.AutoSizeRightIcon = true;
            this.btnOpen.BackColor = System.Drawing.Color.Transparent;
            this.btnOpen.BackColor1 = System.Drawing.Color.Transparent;
            this.btnOpen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOpen.BackgroundImage")));
            this.btnOpen.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnOpen.ButtonText = "Open";
            this.btnOpen.ButtonTextMarginLeft = 0;
            this.btnOpen.ColorContrastOnClick = 45;
            this.btnOpen.ColorContrastOnHover = 45;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnOpen.CustomizableEdges = borderEdges2;
            this.btnOpen.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOpen.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOpen.DisabledFillColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpen.DisabledForecolor = System.Drawing.Color.DimGray;
            this.btnOpen.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.ButtonStates.Pressed;
            this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOpen.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnOpen.IconMarginLeft = 11;
            this.btnOpen.IconPadding = 10;
            this.btnOpen.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpen.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnOpen.IconSize = 25;
            this.btnOpen.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnOpen.IdleBorderRadius = 10;
            this.btnOpen.IdleBorderThickness = 1;
            this.btnOpen.IdleFillColor = System.Drawing.Color.Transparent;
            this.btnOpen.IdleIconLeftImage = null;
            this.btnOpen.IdleIconRightImage = null;
            this.btnOpen.IndicateFocus = true;
            this.btnOpen.Location = new System.Drawing.Point(87, 83);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnOpen.OnDisabledState.BorderRadius = 10;
            this.btnOpen.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnOpen.OnDisabledState.BorderThickness = 0;
            this.btnOpen.OnDisabledState.FillColor = System.Drawing.SystemColors.ControlLight;
            this.btnOpen.OnDisabledState.ForeColor = System.Drawing.Color.DimGray;
            this.btnOpen.OnDisabledState.IconLeftImage = null;
            this.btnOpen.OnDisabledState.IconRightImage = null;
            this.btnOpen.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnOpen.onHoverState.BorderRadius = 10;
            this.btnOpen.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnOpen.onHoverState.BorderThickness = 0;
            this.btnOpen.onHoverState.FillColor = System.Drawing.Color.SlateGray;
            this.btnOpen.onHoverState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.onHoverState.IconLeftImage = null;
            this.btnOpen.onHoverState.IconRightImage = null;
            this.btnOpen.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnOpen.OnIdleState.BorderRadius = 10;
            this.btnOpen.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnOpen.OnIdleState.BorderThickness = 0;
            this.btnOpen.OnIdleState.FillColor = System.Drawing.Color.Transparent;
            this.btnOpen.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.btnOpen.OnIdleState.IconLeftImage = null;
            this.btnOpen.OnIdleState.IconRightImage = null;
            this.btnOpen.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(240)))), ((int)(((byte)(244)))));
            this.btnOpen.OnPressedState.BorderRadius = 10;
            this.btnOpen.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton2.BorderStyles.Solid;
            this.btnOpen.OnPressedState.BorderThickness = 0;
            this.btnOpen.OnPressedState.FillColor = System.Drawing.Color.Gray;
            this.btnOpen.OnPressedState.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpen.OnPressedState.IconLeftImage = null;
            this.btnOpen.OnPressedState.IconRightImage = null;
            this.btnOpen.Size = new System.Drawing.Size(63, 25);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnOpen.TextMarginLeft = 0;
            this.btnOpen.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnOpen.UseDefaultRadiusAndThickness = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = true;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Enabled = false;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuLabel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.bunifuLabel1.Location = new System.Drawing.Point(20, 37);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(61, 32);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.bunifuLabel1.Visible = false;
            // 
            // cbCom
            // 
            this.cbCom.BackColor = System.Drawing.Color.Transparent;
            this.cbCom.BackgroundColor = System.Drawing.Color.White;
            this.cbCom.BorderColor = System.Drawing.Color.Silver;
            this.cbCom.BorderRadius = 10;
            this.cbCom.Color = System.Drawing.Color.Silver;
            this.cbCom.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbCom.DisabledBackColor = System.Drawing.Color.Silver;
            this.cbCom.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbCom.DisabledColor = System.Drawing.Color.Silver;
            this.cbCom.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbCom.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbCom.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCom.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCom.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbCom.FillDropDown = true;
            this.cbCom.FillIndicator = true;
            this.cbCom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCom.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbCom.ForeColor = System.Drawing.Color.Black;
            this.cbCom.FormattingEnabled = true;
            this.cbCom.Icon = null;
            this.cbCom.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbCom.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbCom.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbCom.IndicatorThickness = 2;
            this.cbCom.IntegralHeight = false;
            this.cbCom.IsDropdownOpened = false;
            this.cbCom.ItemBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbCom.ItemBorderColor = System.Drawing.Color.White;
            this.cbCom.ItemForeColor = System.Drawing.Color.Black;
            this.cbCom.ItemHeight = 25;
            this.cbCom.ItemHighLightColor = System.Drawing.Color.WhiteSmoke;
            this.cbCom.ItemHighLightForeColor = System.Drawing.Color.Black;
            this.cbCom.ItemTopMargin = 3;
            this.cbCom.Location = new System.Drawing.Point(87, 37);
            this.cbCom.Name = "cbCom";
            this.cbCom.Size = new System.Drawing.Size(134, 31);
            this.cbCom.TabIndex = 0;
            this.cbCom.Text = null;
            this.cbCom.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbCom.TextLeftMargin = 15;
            // 
            // Receiver
            // 
            this.Receiver.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Receiver.BorderColor = System.Drawing.Color.LightGray;
            this.Receiver.BorderRadius = 10;
            this.Receiver.BorderThickness = 1;
            this.Receiver.Controls.Add(this.textBox1);
            this.Receiver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Receiver.ForeColor = System.Drawing.Color.SteelBlue;
            this.Receiver.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Receiver.LabelIndent = 10;
            this.Receiver.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Receiver.Location = new System.Drawing.Point(12, 218);
            this.Receiver.Name = "Receiver";
            this.Receiver.Size = new System.Drawing.Size(539, 201);
            this.Receiver.TabIndex = 9;
            this.Receiver.TabStop = false;
            this.Receiver.Text = "Status";
            // 
            // btnLed1
            // 
            this.btnLed1.Location = new System.Drawing.Point(69, 92);
            this.btnLed1.Name = "btnLed1";
            this.btnLed1.Size = new System.Drawing.Size(147, 57);
            this.btnLed1.TabIndex = 14;
            this.btnLed1.Text = "Choose";
            this.btnLed1.UseVisualStyleBackColor = true;
            this.btnLed1.Click += new System.EventHandler(this.btnLed1_Click);
            // 
            // btnLed2
            // 
            this.btnLed2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLed2.Location = new System.Drawing.Point(198, 425);
            this.btnLed2.Name = "btnLed2";
            this.btnLed2.Size = new System.Drawing.Size(30, 55);
            this.btnLed2.TabIndex = 15;
            this.btnLed2.UseVisualStyleBackColor = false;
            this.btnLed2.Click += new System.EventHandler(this.btnLed2_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(346, 423);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(121, 57);
            this.btnPause.TabIndex = 16;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(71, 425);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(121, 57);
            this.btnRestart.TabIndex = 17;
            this.btnRestart.Text = "Play";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // bunifuGroupBox2
            // 
            this.bunifuGroupBox2.BackColor = System.Drawing.Color.SeaShell;
            this.bunifuGroupBox2.BorderColor = System.Drawing.Color.LightGray;
            this.bunifuGroupBox2.BorderRadius = 10;
            this.bunifuGroupBox2.BorderThickness = 1;
            this.bunifuGroupBox2.Controls.Add(this.label2);
            this.bunifuGroupBox2.Controls.Add(this.cbList);
            this.bunifuGroupBox2.Controls.Add(this.btnLed1);
            this.bunifuGroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bunifuGroupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.bunifuGroupBox2.ForeColor = System.Drawing.Color.SteelBlue;
            this.bunifuGroupBox2.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuGroupBox2.LabelIndent = 10;
            this.bunifuGroupBox2.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Dash;
            this.bunifuGroupBox2.Location = new System.Drawing.Point(277, 12);
            this.bunifuGroupBox2.Name = "bunifuGroupBox2";
            this.bunifuGroupBox2.Size = new System.Drawing.Size(246, 155);
            this.bunifuGroupBox2.TabIndex = 10;
            this.bunifuGroupBox2.TabStop = false;
            this.bunifuGroupBox2.Text = "List ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Choose";
            // 
            // cbList
            // 
            this.cbList.BackColor = System.Drawing.Color.Transparent;
            this.cbList.BackgroundColor = System.Drawing.Color.White;
            this.cbList.BorderColor = System.Drawing.Color.Silver;
            this.cbList.BorderRadius = 10;
            this.cbList.Color = System.Drawing.Color.Silver;
            this.cbList.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.cbList.DisabledBackColor = System.Drawing.Color.Silver;
            this.cbList.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbList.DisabledColor = System.Drawing.Color.Silver;
            this.cbList.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.cbList.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.cbList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbList.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.cbList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbList.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbList.FillDropDown = true;
            this.cbList.FillIndicator = true;
            this.cbList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbList.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cbList.ForeColor = System.Drawing.Color.Black;
            this.cbList.FormattingEnabled = true;
            this.cbList.Icon = null;
            this.cbList.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbList.IndicatorColor = System.Drawing.Color.DarkGray;
            this.cbList.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.cbList.IndicatorThickness = 2;
            this.cbList.IntegralHeight = false;
            this.cbList.IsDropdownOpened = false;
            this.cbList.ItemBackColor = System.Drawing.Color.WhiteSmoke;
            this.cbList.ItemBorderColor = System.Drawing.Color.White;
            this.cbList.ItemForeColor = System.Drawing.Color.Black;
            this.cbList.ItemHeight = 25;
            this.cbList.ItemHighLightColor = System.Drawing.Color.WhiteSmoke;
            this.cbList.ItemHighLightForeColor = System.Drawing.Color.Black;
            this.cbList.ItemTopMargin = 3;
            this.cbList.Location = new System.Drawing.Point(82, 50);
            this.cbList.Name = "cbList";
            this.cbList.Size = new System.Drawing.Size(134, 31);
            this.cbList.TabIndex = 10;
            this.cbList.Text = null;
            this.cbList.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.cbList.TextLeftMargin = 15;
            this.cbList.SelectedIndexChanged += new System.EventHandler(this.cbList_SelectedIndexChanged);
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(22, 502);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(536, 22);
            this.textBoxFilePath.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 602);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Light 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 691);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.bunifuGroupBox2);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnLed2);
            this.Controls.Add(this.Receiver);
            this.Controls.Add(this.bunifuGroupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.bunifuGroupBox1.ResumeLayout(false);
            this.Receiver.ResumeLayout(false);
            this.Receiver.PerformLayout();
            this.bunifuGroupBox2.ResumeLayout(false);
            this.bunifuGroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuDropdown cbCom;
        private Bunifu.UI.WinForms.BunifuGroupBox Receiver;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnOpen;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btnClose;
        private System.Windows.Forms.Button btnLed1;
        private System.Windows.Forms.Button btnLed2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnRestart;
        private Bunifu.UI.WinForms.BunifuGroupBox bunifuGroupBox2;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForms.BunifuDropdown cbList;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

