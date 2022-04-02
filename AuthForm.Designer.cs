namespace comServiceWF
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRegistration = new MaterialSkin.Controls.MaterialButton();
            this.buttonSignIn = new MaterialSkin.Controls.MaterialButton();
            this.textBoxAuthPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxAuthPass = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.panelNewClient = new System.Windows.Forms.Panel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonComRegistration = new MaterialSkin.Controls.MaterialButton();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxRegion = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxFirstCity = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxFullAdress = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelNewClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelNewClient);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonRegistration);
            this.panel1.Controls.Add(this.buttonSignIn);
            this.panel1.Controls.Add(this.textBoxAuthPhone);
            this.panel1.Controls.Add(this.textBoxAuthPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 423);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(274, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 43);
            this.label1.TabIndex = 5;
            this.label1.Text = "Authorization";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRegistration.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonRegistration.Depth = 0;
            this.buttonRegistration.HighEmphasis = true;
            this.buttonRegistration.Icon = null;
            this.buttonRegistration.Location = new System.Drawing.Point(400, 270);
            this.buttonRegistration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRegistration.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonRegistration.Size = new System.Drawing.Size(124, 36);
            this.buttonRegistration.TabIndex = 4;
            this.buttonRegistration.Text = "Registration";
            this.buttonRegistration.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonRegistration.UseAccentColor = false;
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSignIn.Depth = 0;
            this.buttonSignIn.HighEmphasis = true;
            this.buttonSignIn.Icon = null;
            this.buttonSignIn.Location = new System.Drawing.Point(274, 270);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSignIn.Size = new System.Drawing.Size(93, 36);
            this.buttonSignIn.TabIndex = 3;
            this.buttonSignIn.Text = "Continue";
            this.buttonSignIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSignIn.UseAccentColor = false;
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // textBoxAuthPhone
            // 
            this.textBoxAuthPhone.AnimateReadOnly = false;
            this.textBoxAuthPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxAuthPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxAuthPhone.Depth = 0;
            this.textBoxAuthPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxAuthPhone.HideSelection = true;
            this.textBoxAuthPhone.Hint = "Phone";
            this.textBoxAuthPhone.LeadingIcon = null;
            this.textBoxAuthPhone.Location = new System.Drawing.Point(274, 159);
            this.textBoxAuthPhone.MaxLength = 32767;
            this.textBoxAuthPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxAuthPhone.Name = "textBoxAuthPhone";
            this.textBoxAuthPhone.PasswordChar = '\0';
            this.textBoxAuthPhone.PrefixSuffixText = null;
            this.textBoxAuthPhone.ReadOnly = false;
            this.textBoxAuthPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAuthPhone.SelectedText = "";
            this.textBoxAuthPhone.SelectionLength = 0;
            this.textBoxAuthPhone.SelectionStart = 0;
            this.textBoxAuthPhone.ShortcutsEnabled = true;
            this.textBoxAuthPhone.Size = new System.Drawing.Size(250, 48);
            this.textBoxAuthPhone.TabIndex = 2;
            this.textBoxAuthPhone.TabStop = false;
            this.textBoxAuthPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAuthPhone.TrailingIcon = null;
            this.textBoxAuthPhone.UseSystemPasswordChar = false;
            // 
            // textBoxAuthPass
            // 
            this.textBoxAuthPass.AllowPromptAsInput = true;
            this.textBoxAuthPass.AnimateReadOnly = false;
            this.textBoxAuthPass.AsciiOnly = false;
            this.textBoxAuthPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxAuthPass.BeepOnError = false;
            this.textBoxAuthPass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.textBoxAuthPass.Depth = 0;
            this.textBoxAuthPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxAuthPass.HidePromptOnLeave = false;
            this.textBoxAuthPass.HideSelection = true;
            this.textBoxAuthPass.Hint = "Password";
            this.textBoxAuthPass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.textBoxAuthPass.LeadingIcon = null;
            this.textBoxAuthPass.Location = new System.Drawing.Point(274, 213);
            this.textBoxAuthPass.Mask = "";
            this.textBoxAuthPass.MaxLength = 32767;
            this.textBoxAuthPass.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxAuthPass.Name = "textBoxAuthPass";
            this.textBoxAuthPass.PasswordChar = '*';
            this.textBoxAuthPass.PrefixSuffixText = null;
            this.textBoxAuthPass.PromptChar = '_';
            this.textBoxAuthPass.ReadOnly = false;
            this.textBoxAuthPass.RejectInputOnFirstFailure = false;
            this.textBoxAuthPass.ResetOnPrompt = true;
            this.textBoxAuthPass.ResetOnSpace = true;
            this.textBoxAuthPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxAuthPass.SelectedText = "";
            this.textBoxAuthPass.SelectionLength = 0;
            this.textBoxAuthPass.SelectionStart = 0;
            this.textBoxAuthPass.ShortcutsEnabled = true;
            this.textBoxAuthPass.Size = new System.Drawing.Size(250, 48);
            this.textBoxAuthPass.SkipLiterals = true;
            this.textBoxAuthPass.TabIndex = 1;
            this.textBoxAuthPass.TabStop = false;
            this.textBoxAuthPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxAuthPass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.textBoxAuthPass.TrailingIcon = null;
            this.textBoxAuthPass.UseSystemPasswordChar = false;
            this.textBoxAuthPass.ValidatingType = null;
            // 
            // panelNewClient
            // 
            this.panelNewClient.Controls.Add(this.materialLabel5);
            this.panelNewClient.Controls.Add(this.buttonComRegistration);
            this.panelNewClient.Controls.Add(this.textBoxPassword);
            this.panelNewClient.Controls.Add(this.materialLabel4);
            this.panelNewClient.Controls.Add(this.textBoxRegion);
            this.panelNewClient.Controls.Add(this.textBoxFirstCity);
            this.panelNewClient.Controls.Add(this.textBoxFullAdress);
            this.panelNewClient.Controls.Add(this.materialLabel3);
            this.panelNewClient.Controls.Add(this.textBoxPhone);
            this.panelNewClient.Controls.Add(this.materialLabel2);
            this.panelNewClient.Controls.Add(this.materialLabel1);
            this.panelNewClient.Controls.Add(this.textBoxLastName);
            this.panelNewClient.Controls.Add(this.textBoxFirstName);
            this.panelNewClient.Controls.Add(this.label2);
            this.panelNewClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNewClient.Location = new System.Drawing.Point(0, 0);
            this.panelNewClient.Name = "panelNewClient";
            this.panelNewClient.Size = new System.Drawing.Size(794, 423);
            this.panelNewClient.TabIndex = 6;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel5.Location = new System.Drawing.Point(56, 354);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(267, 19);
            this.materialLabel5.TabIndex = 13;
            this.materialLabel5.Text = "* (asterisk) - marked mandatory fields";
            // 
            // buttonComRegistration
            // 
            this.buttonComRegistration.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonComRegistration.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonComRegistration.Depth = 0;
            this.buttonComRegistration.HighEmphasis = true;
            this.buttonComRegistration.Icon = null;
            this.buttonComRegistration.Location = new System.Drawing.Point(545, 337);
            this.buttonComRegistration.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonComRegistration.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonComRegistration.Name = "buttonComRegistration";
            this.buttonComRegistration.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonComRegistration.Size = new System.Drawing.Size(203, 36);
            this.buttonComRegistration.TabIndex = 12;
            this.buttonComRegistration.Text = "Complete registration";
            this.buttonComRegistration.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonComRegistration.UseAccentColor = false;
            this.buttonComRegistration.UseVisualStyleBackColor = true;
            this.buttonComRegistration.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.AnimateReadOnly = false;
            this.textBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPassword.Depth = 0;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPassword.HideSelection = true;
            this.textBoxPassword.Hint = "Password";
            this.textBoxPassword.LeadingIcon = null;
            this.textBoxPassword.Location = new System.Drawing.Point(323, 280);
            this.textBoxPassword.MaxLength = 32767;
            this.textBoxPassword.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '\0';
            this.textBoxPassword.PrefixSuffixText = null;
            this.textBoxPassword.ReadOnly = false;
            this.textBoxPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPassword.SelectedText = "";
            this.textBoxPassword.SelectionLength = 0;
            this.textBoxPassword.SelectionStart = 0;
            this.textBoxPassword.ShortcutsEnabled = true;
            this.textBoxPassword.Size = new System.Drawing.Size(426, 48);
            this.textBoxPassword.TabIndex = 11;
            this.textBoxPassword.TabStop = false;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPassword.TrailingIcon = null;
            this.textBoxPassword.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel4.Location = new System.Drawing.Point(323, 242);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 19);
            this.materialLabel4.TabIndex = 10;
            this.materialLabel4.Text = "Password *";
            // 
            // textBoxRegion
            // 
            this.textBoxRegion.AnimateReadOnly = false;
            this.textBoxRegion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxRegion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxRegion.Depth = 0;
            this.textBoxRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxRegion.HideSelection = true;
            this.textBoxRegion.Hint = "Region";
            this.textBoxRegion.LeadingIcon = null;
            this.textBoxRegion.Location = new System.Drawing.Point(536, 172);
            this.textBoxRegion.MaxLength = 32767;
            this.textBoxRegion.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxRegion.Name = "textBoxRegion";
            this.textBoxRegion.PasswordChar = '\0';
            this.textBoxRegion.PrefixSuffixText = null;
            this.textBoxRegion.ReadOnly = false;
            this.textBoxRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxRegion.SelectedText = "";
            this.textBoxRegion.SelectionLength = 0;
            this.textBoxRegion.SelectionStart = 0;
            this.textBoxRegion.ShortcutsEnabled = true;
            this.textBoxRegion.Size = new System.Drawing.Size(212, 48);
            this.textBoxRegion.TabIndex = 9;
            this.textBoxRegion.TabStop = false;
            this.textBoxRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxRegion.TrailingIcon = null;
            this.textBoxRegion.UseSystemPasswordChar = false;
            // 
            // textBoxFirstCity
            // 
            this.textBoxFirstCity.AnimateReadOnly = false;
            this.textBoxFirstCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxFirstCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFirstCity.Depth = 0;
            this.textBoxFirstCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxFirstCity.HideSelection = true;
            this.textBoxFirstCity.Hint = "City";
            this.textBoxFirstCity.LeadingIcon = null;
            this.textBoxFirstCity.Location = new System.Drawing.Point(322, 172);
            this.textBoxFirstCity.MaxLength = 32767;
            this.textBoxFirstCity.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxFirstCity.Name = "textBoxFirstCity";
            this.textBoxFirstCity.PasswordChar = '\0';
            this.textBoxFirstCity.PrefixSuffixText = null;
            this.textBoxFirstCity.ReadOnly = false;
            this.textBoxFirstCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFirstCity.SelectedText = "";
            this.textBoxFirstCity.SelectionLength = 0;
            this.textBoxFirstCity.SelectionStart = 0;
            this.textBoxFirstCity.ShortcutsEnabled = true;
            this.textBoxFirstCity.Size = new System.Drawing.Size(202, 48);
            this.textBoxFirstCity.TabIndex = 8;
            this.textBoxFirstCity.TabStop = false;
            this.textBoxFirstCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxFirstCity.TrailingIcon = null;
            this.textBoxFirstCity.UseSystemPasswordChar = false;
            // 
            // textBoxFullAdress
            // 
            this.textBoxFullAdress.AnimateReadOnly = false;
            this.textBoxFullAdress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxFullAdress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFullAdress.Depth = 0;
            this.textBoxFullAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxFullAdress.HideSelection = true;
            this.textBoxFullAdress.Hint = "Street Address";
            this.textBoxFullAdress.LeadingIcon = null;
            this.textBoxFullAdress.Location = new System.Drawing.Point(322, 118);
            this.textBoxFullAdress.MaxLength = 32767;
            this.textBoxFullAdress.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxFullAdress.Name = "textBoxFullAdress";
            this.textBoxFullAdress.PasswordChar = '\0';
            this.textBoxFullAdress.PrefixSuffixText = null;
            this.textBoxFullAdress.ReadOnly = false;
            this.textBoxFullAdress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFullAdress.SelectedText = "";
            this.textBoxFullAdress.SelectionLength = 0;
            this.textBoxFullAdress.SelectionStart = 0;
            this.textBoxFullAdress.ShortcutsEnabled = true;
            this.textBoxFullAdress.Size = new System.Drawing.Size(426, 48);
            this.textBoxFullAdress.TabIndex = 7;
            this.textBoxFullAdress.TabStop = false;
            this.textBoxFullAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxFullAdress.TrailingIcon = null;
            this.textBoxFullAdress.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.materialLabel3.Location = new System.Drawing.Point(322, 77);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Address *";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.AnimateReadOnly = false;
            this.textBoxPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxPhone.Depth = 0;
            this.textBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxPhone.HideSelection = true;
            this.textBoxPhone.Hint = "(***)***-****";
            this.textBoxPhone.LeadingIcon = null;
            this.textBoxPhone.Location = new System.Drawing.Point(55, 280);
            this.textBoxPhone.MaxLength = 32767;
            this.textBoxPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.PasswordChar = '\0';
            this.textBoxPhone.PrefixSuffixText = null;
            this.textBoxPhone.ReadOnly = false;
            this.textBoxPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxPhone.SelectedText = "";
            this.textBoxPhone.SelectionLength = 0;
            this.textBoxPhone.SelectionStart = 0;
            this.textBoxPhone.ShortcutsEnabled = true;
            this.textBoxPhone.Size = new System.Drawing.Size(212, 48);
            this.textBoxPhone.TabIndex = 5;
            this.textBoxPhone.TabStop = false;
            this.textBoxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxPhone.TrailingIcon = null;
            this.textBoxPhone.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel2.Location = new System.Drawing.Point(56, 242);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 4;
            this.materialLabel2.Text = "Phone Number *";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel1.Location = new System.Drawing.Point(56, 77);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 3;
            this.materialLabel1.Text = "Full Name *";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.AnimateReadOnly = false;
            this.textBoxLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxLastName.Depth = 0;
            this.textBoxLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxLastName.HideSelection = true;
            this.textBoxLastName.Hint = "Last Name";
            this.textBoxLastName.LeadingIcon = null;
            this.textBoxLastName.Location = new System.Drawing.Point(55, 172);
            this.textBoxLastName.MaxLength = 32767;
            this.textBoxLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.PasswordChar = '\0';
            this.textBoxLastName.PrefixSuffixText = null;
            this.textBoxLastName.ReadOnly = false;
            this.textBoxLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxLastName.SelectedText = "";
            this.textBoxLastName.SelectionLength = 0;
            this.textBoxLastName.SelectionStart = 0;
            this.textBoxLastName.ShortcutsEnabled = true;
            this.textBoxLastName.Size = new System.Drawing.Size(212, 48);
            this.textBoxLastName.TabIndex = 2;
            this.textBoxLastName.TabStop = false;
            this.textBoxLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxLastName.TrailingIcon = null;
            this.textBoxLastName.UseSystemPasswordChar = false;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.AnimateReadOnly = false;
            this.textBoxFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxFirstName.Depth = 0;
            this.textBoxFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxFirstName.HideSelection = true;
            this.textBoxFirstName.Hint = "First Name";
            this.textBoxFirstName.LeadingIcon = null;
            this.textBoxFirstName.Location = new System.Drawing.Point(55, 118);
            this.textBoxFirstName.MaxLength = 32767;
            this.textBoxFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.PasswordChar = '\0';
            this.textBoxFirstName.PrefixSuffixText = null;
            this.textBoxFirstName.ReadOnly = false;
            this.textBoxFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxFirstName.SelectedText = "";
            this.textBoxFirstName.SelectionLength = 0;
            this.textBoxFirstName.SelectionStart = 0;
            this.textBoxFirstName.ShortcutsEnabled = true;
            this.textBoxFirstName.Size = new System.Drawing.Size(212, 48);
            this.textBoxFirstName.TabIndex = 1;
            this.textBoxFirstName.TabStop = false;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxFirstName.TrailingIcon = null;
            this.textBoxFirstName.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(196, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(402, 40);
            this.label2.TabIndex = 0;
            this.label2.Text = "Client Registration Form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communical Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelNewClient.ResumeLayout(false);
            this.panelNewClient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialButton buttonRegistration;
        private MaterialSkin.Controls.MaterialButton buttonSignIn;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxAuthPhone;
        private MaterialSkin.Controls.MaterialMaskedTextBox textBoxAuthPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelNewClient;
        private System.Windows.Forms.Label label2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton buttonComRegistration;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxRegion;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxFirstCity;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxFullAdress;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxLastName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxFirstName;
    }
}
