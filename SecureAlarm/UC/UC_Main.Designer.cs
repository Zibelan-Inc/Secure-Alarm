
namespace KosmoSecure
{
    partial class UC_Main
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonStart = new Guna.UI.WinForms.GunaButton();
            this.GunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.GunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.TimePingText = new Guna.UI2.WinForms.Guna2TextBox();
            this.TimeLostText = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Animated = true;
            this.ButtonStart.AnimationHoverSpeed = 0.07F;
            this.ButtonStart.AnimationSpeed = 0.03F;
            this.ButtonStart.BackColor = System.Drawing.Color.Transparent;
            this.ButtonStart.BaseColor = System.Drawing.Color.Transparent;
            this.ButtonStart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.ButtonStart.BorderSize = 2;
            this.ButtonStart.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonStart.FocusedColor = System.Drawing.Color.Empty;
            this.ButtonStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.ButtonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.ButtonStart.Image = null;
            this.ButtonStart.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonStart.ImageSize = new System.Drawing.Size(20, 20);
            this.ButtonStart.Location = new System.Drawing.Point(544, 238);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.ButtonStart.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(171)))), ((int)(((byte)(160)))));
            this.ButtonStart.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(22)))), ((int)(((byte)(32)))));
            this.ButtonStart.OnHoverImage = null;
            this.ButtonStart.OnPressedColor = System.Drawing.Color.Black;
            this.ButtonStart.Radius = 26;
            this.ButtonStart.Size = new System.Drawing.Size(138, 55);
            this.ButtonStart.TabIndex = 5;
            this.ButtonStart.Text = "Enabled";
            this.ButtonStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // GunaLabel3
            // 
            this.GunaLabel3.AutoSize = true;
            this.GunaLabel3.BackColor = System.Drawing.Color.Transparent;
            this.GunaLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GunaLabel3.ForeColor = System.Drawing.Color.White;
            this.GunaLabel3.Location = new System.Drawing.Point(615, 334);
            this.GunaLabel3.Name = "GunaLabel3";
            this.GunaLabel3.Size = new System.Drawing.Size(79, 21);
            this.GunaLabel3.TabIndex = 60;
            this.GunaLabel3.Text = "Time Ping";
            // 
            // GunaLabel2
            // 
            this.GunaLabel2.AutoSize = true;
            this.GunaLabel2.BackColor = System.Drawing.Color.Transparent;
            this.GunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.GunaLabel2.ForeColor = System.Drawing.Color.White;
            this.GunaLabel2.Location = new System.Drawing.Point(533, 334);
            this.GunaLabel2.Name = "GunaLabel2";
            this.GunaLabel2.Size = new System.Drawing.Size(77, 21);
            this.GunaLabel2.TabIndex = 59;
            this.GunaLabel2.Text = "Time Lost";
            // 
            // TimePingText
            // 
            this.TimePingText.Animated = true;
            this.TimePingText.BackColor = System.Drawing.Color.Transparent;
            this.TimePingText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimePingText.BorderRadius = 13;
            this.TimePingText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimePingText.DefaultText = "15";
            this.TimePingText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimePingText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimePingText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimePingText.DisabledState.Parent = this.TimePingText;
            this.TimePingText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimePingText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TimePingText.FocusedState.Parent = this.TimePingText;
            this.TimePingText.ForeColor = System.Drawing.Color.White;
            this.TimePingText.HoverState.Parent = this.TimePingText;
            this.TimePingText.Location = new System.Drawing.Point(624, 369);
            this.TimePingText.Name = "TimePingText";
            this.TimePingText.PasswordChar = '\0';
            this.TimePingText.PlaceholderText = "";
            this.TimePingText.SelectedText = "";
            this.TimePingText.SelectionStart = 2;
            this.TimePingText.ShadowDecoration.Parent = this.TimePingText;
            this.TimePingText.Size = new System.Drawing.Size(58, 29);
            this.TimePingText.TabIndex = 58;
            this.TimePingText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TimeLostText
            // 
            this.TimeLostText.Animated = true;
            this.TimeLostText.BackColor = System.Drawing.Color.Transparent;
            this.TimeLostText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TimeLostText.BorderRadius = 13;
            this.TimeLostText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TimeLostText.DefaultText = "3";
            this.TimeLostText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TimeLostText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TimeLostText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeLostText.DisabledState.Parent = this.TimeLostText;
            this.TimeLostText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TimeLostText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TimeLostText.FocusedState.Parent = this.TimeLostText;
            this.TimeLostText.ForeColor = System.Drawing.Color.White;
            this.TimeLostText.HoverState.Parent = this.TimeLostText;
            this.TimeLostText.Location = new System.Drawing.Point(544, 369);
            this.TimeLostText.Name = "TimeLostText";
            this.TimeLostText.PasswordChar = '\0';
            this.TimeLostText.PlaceholderText = "";
            this.TimeLostText.SelectedText = "";
            this.TimeLostText.SelectionStart = 1;
            this.TimeLostText.ShadowDecoration.Parent = this.TimeLostText;
            this.TimeLostText.Size = new System.Drawing.Size(58, 29);
            this.TimeLostText.TabIndex = 57;
            this.TimeLostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UC_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.GunaLabel3);
            this.Controls.Add(this.GunaLabel2);
            this.Controls.Add(this.TimePingText);
            this.Controls.Add(this.TimeLostText);
            this.Controls.Add(this.ButtonStart);
            this.Name = "UC_Main";
            this.Size = new System.Drawing.Size(1227, 530);
            this.Load += new System.EventHandler(this.UC_Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Guna.UI.WinForms.GunaButton ButtonStart;
        internal Guna.UI.WinForms.GunaLabel GunaLabel3;
        internal Guna.UI.WinForms.GunaLabel GunaLabel2;
        public Guna.UI2.WinForms.Guna2TextBox TimePingText;
        public Guna.UI2.WinForms.Guna2TextBox TimeLostText;
    }
}
