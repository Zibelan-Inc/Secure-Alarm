
namespace KosmoSecure
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.PanelTop = new Guna.UI2.WinForms.Guna2Panel();
            this.MiniBox = new Guna.UI2.WinForms.Guna2Button();
            this.CloseBox = new Guna.UI2.WinForms.Guna2Button();
            this.lblTittle = new System.Windows.Forms.Label();
            this.PanelButton = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.PanelNotifi = new Guna.UI2.WinForms.Guna2Panel();
            this.GunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.GunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.PanelContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.PlseaseWait = new Guna.UI2.WinForms.Guna2Panel();
            this.uI_LabelMaterial1 = new UIDC.UI_LabelMaterial();
            this.guna2WinProgressIndicator1 = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelTop.SuspendLayout();
            this.PanelButton.SuspendLayout();
            this.PanelNotifi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).BeginInit();
            this.PlseaseWait.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.Transparent;
            this.PanelTop.Controls.Add(this.MiniBox);
            this.PanelTop.Controls.Add(this.CloseBox);
            this.PanelTop.Controls.Add(this.lblTittle);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.FillColor = System.Drawing.Color.Transparent;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.ShadowDecoration.Parent = this.PanelTop;
            this.PanelTop.Size = new System.Drawing.Size(1335, 39);
            this.PanelTop.TabIndex = 1;
            // 
            // MiniBox
            // 
            this.MiniBox.Animated = true;
            this.MiniBox.BackColor = System.Drawing.Color.Transparent;
            this.MiniBox.CheckedState.Parent = this.MiniBox;
            this.MiniBox.CustomImages.Parent = this.MiniBox;
            this.MiniBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.MiniBox.FillColor = System.Drawing.Color.Transparent;
            this.MiniBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MiniBox.ForeColor = System.Drawing.Color.White;
            this.MiniBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.MiniBox.HoverState.Image = global::KosmoSecure.Properties.Resources._8530586_window_minimize_icon;
            this.MiniBox.HoverState.Parent = this.MiniBox;
            this.MiniBox.Image = global::KosmoSecure.Properties.Resources._8530586_window_minimize_icon_1_;
            this.MiniBox.Location = new System.Drawing.Point(1245, 0);
            this.MiniBox.Name = "MiniBox";
            this.MiniBox.ShadowDecoration.Parent = this.MiniBox;
            this.MiniBox.Size = new System.Drawing.Size(45, 39);
            this.MiniBox.TabIndex = 28;
            this.MiniBox.Click += new System.EventHandler(this.MiniBox_Click);
            // 
            // CloseBox
            // 
            this.CloseBox.Animated = true;
            this.CloseBox.BackColor = System.Drawing.Color.Transparent;
            this.CloseBox.CheckedState.Parent = this.CloseBox;
            this.CloseBox.CustomImages.Parent = this.CloseBox;
            this.CloseBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseBox.FillColor = System.Drawing.Color.Transparent;
            this.CloseBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CloseBox.ForeColor = System.Drawing.Color.White;
            this.CloseBox.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            this.CloseBox.HoverState.Image = global::KosmoSecure.Properties.Resources._211651_close_round_icon;
            this.CloseBox.HoverState.Parent = this.CloseBox;
            this.CloseBox.Image = global::KosmoSecure.Properties.Resources._211651_close_round_icon_1_;
            this.CloseBox.Location = new System.Drawing.Point(1290, 0);
            this.CloseBox.Name = "CloseBox";
            this.CloseBox.ShadowDecoration.Parent = this.CloseBox;
            this.CloseBox.Size = new System.Drawing.Size(45, 39);
            this.CloseBox.TabIndex = 26;
            this.CloseBox.Click += new System.EventHandler(this.CloseBox_Click);
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.BackColor = System.Drawing.Color.Transparent;
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTittle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.White;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(105, 21);
            this.lblTittle.TabIndex = 25;
            this.lblTittle.Text = "KosmoSecure";
            // 
            // PanelButton
            // 
            this.PanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.PanelButton.Controls.Add(this.iconButton5);
            this.PanelButton.Controls.Add(this.iconButton4);
            this.PanelButton.Controls.Add(this.iconButton3);
            this.PanelButton.Controls.Add(this.iconButton2);
            this.PanelButton.Controls.Add(this.iconButton1);
            this.PanelButton.Controls.Add(this.guna2Panel1);
            this.PanelButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.PanelButton.Location = new System.Drawing.Point(0, 39);
            this.PanelButton.Name = "PanelButton";
            this.PanelButton.ShadowDecoration.Parent = this.PanelButton;
            this.PanelButton.Size = new System.Drawing.Size(108, 577);
            this.PanelButton.TabIndex = 4;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.iconButton5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(0, 530);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(108, 47);
            this.iconButton5.TabIndex = 8;
            this.iconButton5.UseVisualStyleBackColor = false;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            this.iconButton5.MouseEnter += new System.EventHandler(this.iconButton5_MouseEnter);
            this.iconButton5.MouseLeave += new System.EventHandler(this.iconButton5_MouseLeave);
            // 
            // iconButton4
            // 
            this.iconButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatAppearance.BorderSize = 0;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.Location = new System.Drawing.Point(0, 272);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(108, 47);
            this.iconButton4.TabIndex = 7;
            this.iconButton4.UseVisualStyleBackColor = false;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.Location = new System.Drawing.Point(0, 225);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(108, 47);
            this.iconButton3.TabIndex = 6;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.iconButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(0, 178);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(108, 47);
            this.iconButton2.TabIndex = 5;
            this.iconButton2.UseVisualStyleBackColor = false;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(0, 131);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(108, 47);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(108, 131);
            this.guna2Panel1.TabIndex = 0;
            // 
            // PanelNotifi
            // 
            this.PanelNotifi.Controls.Add(this.GunaLabel1);
            this.PanelNotifi.Controls.Add(this.GunaPictureBox1);
            this.PanelNotifi.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelNotifi.Location = new System.Drawing.Point(108, 39);
            this.PanelNotifi.Name = "PanelNotifi";
            this.PanelNotifi.ShadowDecoration.Parent = this.PanelNotifi;
            this.PanelNotifi.Size = new System.Drawing.Size(1227, 47);
            this.PanelNotifi.TabIndex = 5;
            // 
            // GunaLabel1
            // 
            this.GunaLabel1.AutoSize = true;
            this.GunaLabel1.BackColor = System.Drawing.Color.Transparent;
            this.GunaLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GunaLabel1.Location = new System.Drawing.Point(43, 13);
            this.GunaLabel1.Name = "GunaLabel1";
            this.GunaLabel1.Size = new System.Drawing.Size(93, 21);
            this.GunaLabel1.TabIndex = 6;
            this.GunaLabel1.Text = "GunaLabel1";
            // 
            // GunaPictureBox1
            // 
            this.GunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.GunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.GunaPictureBox1.Image = global::KosmoSecure.Properties.Resources.warning;
            this.GunaPictureBox1.Location = new System.Drawing.Point(9, 10);
            this.GunaPictureBox1.Name = "GunaPictureBox1";
            this.GunaPictureBox1.Size = new System.Drawing.Size(28, 28);
            this.GunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GunaPictureBox1.TabIndex = 5;
            this.GunaPictureBox1.TabStop = false;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(108, 86);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.ShadowDecoration.Parent = this.PanelContainer;
            this.PanelContainer.Size = new System.Drawing.Size(1227, 530);
            this.PanelContainer.TabIndex = 6;
            // 
            // PlseaseWait
            // 
            this.PlseaseWait.Controls.Add(this.uI_LabelMaterial1);
            this.PlseaseWait.Controls.Add(this.guna2WinProgressIndicator1);
            this.PlseaseWait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlseaseWait.Location = new System.Drawing.Point(108, 86);
            this.PlseaseWait.Name = "PlseaseWait";
            this.PlseaseWait.ShadowDecoration.Parent = this.PlseaseWait;
            this.PlseaseWait.Size = new System.Drawing.Size(1227, 530);
            this.PlseaseWait.TabIndex = 8;
            this.PlseaseWait.Visible = false;
            // 
            // uI_LabelMaterial1
            // 
            this.uI_LabelMaterial1.BackColor = System.Drawing.Color.Transparent;
            this.uI_LabelMaterial1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.uI_LabelMaterial1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.uI_LabelMaterial1.Location = new System.Drawing.Point(0, 312);
            this.uI_LabelMaterial1.Name = "uI_LabelMaterial1";
            this.uI_LabelMaterial1.Size = new System.Drawing.Size(1227, 23);
            this.uI_LabelMaterial1.TabIndex = 4;
            this.uI_LabelMaterial1.Text = "Please Wait";
            this.uI_LabelMaterial1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2WinProgressIndicator1
            // 
            this.guna2WinProgressIndicator1.AutoStart = true;
            this.guna2WinProgressIndicator1.CircleSize = 1F;
            this.guna2WinProgressIndicator1.Location = new System.Drawing.Point(568, 196);
            this.guna2WinProgressIndicator1.Name = "guna2WinProgressIndicator1";
            this.guna2WinProgressIndicator1.Size = new System.Drawing.Size(90, 90);
            this.guna2WinProgressIndicator1.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 24;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.PanelTop;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "KosmoSecure";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(1335, 616);
            this.Controls.Add(this.PlseaseWait);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.PanelNotifi);
            this.Controls.Add(this.PanelButton);
            this.Controls.Add(this.PanelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelTop.PerformLayout();
            this.PanelButton.ResumeLayout(false);
            this.PanelNotifi.ResumeLayout(false);
            this.PanelNotifi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GunaPictureBox1)).EndInit();
            this.PlseaseWait.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelTop;
        public Guna.UI2.WinForms.Guna2Button MiniBox;
        public Guna.UI2.WinForms.Guna2Button CloseBox;
        public System.Windows.Forms.Label lblTittle;
        public Guna.UI2.WinForms.Guna2Panel PanelButton;
        public Guna.UI2.WinForms.Guna2Panel PanelContainer;
        public Guna.UI2.WinForms.Guna2Panel PlseaseWait;
        private UIDC.UI_LabelMaterial uI_LabelMaterial1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator guna2WinProgressIndicator1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        internal Guna.UI.WinForms.GunaLabel GunaLabel1;
        internal Guna.UI.WinForms.GunaPictureBox GunaPictureBox1;
        public Guna.UI2.WinForms.Guna2Panel PanelNotifi;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

