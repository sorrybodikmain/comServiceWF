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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.AuthPanel = new System.Windows.Forms.Panel();
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.BoxPass2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.PhoneBox = new MaterialSkin.Controls.MaterialTextBox();
            this.BoxPass1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.LoginBox = new MaterialSkin.Controls.MaterialTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignUp = new MaterialSkin.Controls.MaterialButton();
            this.NoPass = new System.Windows.Forms.LinkLabel();
            this.buttonSignIn = new MaterialSkin.Controls.MaterialButton();
            this.BoxAuthLogin = new MaterialSkin.Controls.MaterialTextBox2();
            this.BoxAuthPass = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.buttonRes1 = new MaterialSkin.Controls.MaterialButton();
            this.SignUpPanel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.LastNameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.regionBox = new MaterialSkin.Controls.MaterialTextBox();
            this.cityBox = new MaterialSkin.Controls.MaterialTextBox();
            this.addressBox = new MaterialSkin.Controls.MaterialTextBox();
            this.saveButton = new MaterialSkin.Controls.MaterialButton();
            this.AuthPanel.SuspendLayout();
            this.SignUpPanel.SuspendLayout();
            this.SignUpPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // AuthPanel
            // 
            this.AuthPanel.BackColor = System.Drawing.Color.White;
            this.AuthPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AuthPanel.BackgroundImage")));
            this.AuthPanel.Controls.Add(this.SignUpPanel);
            this.AuthPanel.Controls.Add(this.buttonSignUp);
            this.AuthPanel.Controls.Add(this.NoPass);
            this.AuthPanel.Controls.Add(this.buttonSignIn);
            this.AuthPanel.Controls.Add(this.BoxAuthLogin);
            this.AuthPanel.Controls.Add(this.BoxAuthPass);
            this.AuthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AuthPanel.Location = new System.Drawing.Point(3, 24);
            this.AuthPanel.Name = "AuthPanel";
            this.AuthPanel.Size = new System.Drawing.Size(310, 441);
            this.AuthPanel.TabIndex = 0;
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.Controls.Add(this.SignUpPanel2);
            this.SignUpPanel.Controls.Add(this.buttonRes1);
            this.SignUpPanel.Controls.Add(this.BoxPass2);
            this.SignUpPanel.Controls.Add(this.PhoneBox);
            this.SignUpPanel.Controls.Add(this.BoxPass1);
            this.SignUpPanel.Controls.Add(this.LoginBox);
            this.SignUpPanel.Controls.Add(this.label1);
            this.SignUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpPanel.Location = new System.Drawing.Point(0, 0);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(310, 441);
            this.SignUpPanel.TabIndex = 7;
            // 
            // BoxPass2
            // 
            this.BoxPass2.AllowPromptAsInput = true;
            this.BoxPass2.AnimateReadOnly = false;
            this.BoxPass2.AsciiOnly = false;
            this.BoxPass2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoxPass2.BeepOnError = false;
            this.BoxPass2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BoxPass2.Depth = 0;
            this.BoxPass2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxPass2.HidePromptOnLeave = false;
            this.BoxPass2.HideSelection = true;
            this.BoxPass2.Hint = "Repeat Password";
            this.BoxPass2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BoxPass2.LeadingIcon = null;
            this.BoxPass2.Location = new System.Drawing.Point(27, 305);
            this.BoxPass2.Mask = "";
            this.BoxPass2.MaxLength = 32767;
            this.BoxPass2.MouseState = MaterialSkin.MouseState.OUT;
            this.BoxPass2.Name = "BoxPass2";
            this.BoxPass2.PasswordChar = '*';
            this.BoxPass2.PrefixSuffixText = null;
            this.BoxPass2.PromptChar = '_';
            this.BoxPass2.ReadOnly = false;
            this.BoxPass2.RejectInputOnFirstFailure = false;
            this.BoxPass2.ResetOnPrompt = true;
            this.BoxPass2.ResetOnSpace = true;
            this.BoxPass2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxPass2.SelectedText = "";
            this.BoxPass2.SelectionLength = 0;
            this.BoxPass2.SelectionStart = 0;
            this.BoxPass2.ShortcutsEnabled = true;
            this.BoxPass2.Size = new System.Drawing.Size(256, 48);
            this.BoxPass2.SkipLiterals = true;
            this.BoxPass2.TabIndex = 4;
            this.BoxPass2.TabStop = false;
            this.BoxPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BoxPass2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BoxPass2.TrailingIcon = null;
            this.BoxPass2.UseSystemPasswordChar = false;
            this.BoxPass2.ValidatingType = null;
            // 
            // PhoneBox
            // 
            this.PhoneBox.AnimateReadOnly = false;
            this.PhoneBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneBox.Depth = 0;
            this.PhoneBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PhoneBox.Hint = "Your Phone";
            this.PhoneBox.LeadingIcon = null;
            this.PhoneBox.Location = new System.Drawing.Point(27, 108);
            this.PhoneBox.MaxLength = 50;
            this.PhoneBox.MouseState = MaterialSkin.MouseState.OUT;
            this.PhoneBox.Multiline = false;
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(256, 50);
            this.PhoneBox.TabIndex = 3;
            this.PhoneBox.Text = "";
            this.PhoneBox.TrailingIcon = null;
            // 
            // BoxPass1
            // 
            this.BoxPass1.AllowPromptAsInput = true;
            this.BoxPass1.AnimateReadOnly = false;
            this.BoxPass1.AsciiOnly = false;
            this.BoxPass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoxPass1.BeepOnError = false;
            this.BoxPass1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BoxPass1.Depth = 0;
            this.BoxPass1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxPass1.HidePromptOnLeave = false;
            this.BoxPass1.HideSelection = true;
            this.BoxPass1.Hint = "Password";
            this.BoxPass1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BoxPass1.LeadingIcon = null;
            this.BoxPass1.Location = new System.Drawing.Point(27, 241);
            this.BoxPass1.Mask = "";
            this.BoxPass1.MaxLength = 32767;
            this.BoxPass1.MouseState = MaterialSkin.MouseState.OUT;
            this.BoxPass1.Name = "BoxPass1";
            this.BoxPass1.PasswordChar = '*';
            this.BoxPass1.PrefixSuffixText = null;
            this.BoxPass1.PromptChar = '_';
            this.BoxPass1.ReadOnly = false;
            this.BoxPass1.RejectInputOnFirstFailure = false;
            this.BoxPass1.ResetOnPrompt = true;
            this.BoxPass1.ResetOnSpace = true;
            this.BoxPass1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxPass1.SelectedText = "";
            this.BoxPass1.SelectionLength = 0;
            this.BoxPass1.SelectionStart = 0;
            this.BoxPass1.ShortcutsEnabled = true;
            this.BoxPass1.Size = new System.Drawing.Size(256, 48);
            this.BoxPass1.SkipLiterals = true;
            this.BoxPass1.TabIndex = 2;
            this.BoxPass1.TabStop = false;
            this.BoxPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BoxPass1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BoxPass1.TrailingIcon = null;
            this.BoxPass1.UseSystemPasswordChar = false;
            this.BoxPass1.ValidatingType = null;
            // 
            // LoginBox
            // 
            this.LoginBox.AnimateReadOnly = false;
            this.LoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBox.Depth = 0;
            this.LoginBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LoginBox.Hint = "Your Login";
            this.LoginBox.LeadingIcon = null;
            this.LoginBox.Location = new System.Drawing.Point(27, 175);
            this.LoginBox.MaxLength = 50;
            this.LoginBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LoginBox.Multiline = false;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(256, 50);
            this.LoginBox.TabIndex = 1;
            this.LoginBox.Text = "";
            this.LoginBox.TrailingIcon = null;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Create new account:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.AutoSize = false;
            this.buttonSignUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSignUp.BackColor = System.Drawing.Color.White;
            this.buttonSignUp.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSignUp.Depth = 0;
            this.buttonSignUp.HighEmphasis = true;
            this.buttonSignUp.Icon = null;
            this.buttonSignUp.Location = new System.Drawing.Point(33, 357);
            this.buttonSignUp.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSignUp.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSignUp.Size = new System.Drawing.Size(250, 36);
            this.buttonSignUp.TabIndex = 6;
            this.buttonSignUp.Text = "Sign Up";
            this.buttonSignUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSignUp.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonSignUp.UseAccentColor = false;
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // NoPass
            // 
            this.NoPass.ActiveLinkColor = System.Drawing.SystemColors.Desktop;
            this.NoPass.AutoSize = true;
            this.NoPass.LinkColor = System.Drawing.SystemColors.GrayText;
            this.NoPass.Location = new System.Drawing.Point(68, 410);
            this.NoPass.Name = "NoPass";
            this.NoPass.Size = new System.Drawing.Size(172, 15);
            this.NoPass.TabIndex = 5;
            this.NoPass.TabStop = true;
            this.NoPass.Text = "Don\'t remember the password?";
            this.NoPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NoPass_LinkClicked);
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.AutoSize = false;
            this.buttonSignIn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSignIn.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSignIn.Depth = 0;
            this.buttonSignIn.HighEmphasis = true;
            this.buttonSignIn.Icon = null;
            this.buttonSignIn.Location = new System.Drawing.Point(33, 315);
            this.buttonSignIn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSignIn.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSignIn.Size = new System.Drawing.Size(250, 36);
            this.buttonSignIn.TabIndex = 3;
            this.buttonSignIn.Text = "Sign In";
            this.buttonSignIn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSignIn.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSignIn.UseAccentColor = false;
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // BoxAuthLogin
            // 
            this.BoxAuthLogin.AnimateReadOnly = false;
            this.BoxAuthLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoxAuthLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BoxAuthLogin.Depth = 0;
            this.BoxAuthLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxAuthLogin.HideSelection = true;
            this.BoxAuthLogin.Hint = "Enter your username";
            this.BoxAuthLogin.LeadingIcon = null;
            this.BoxAuthLogin.Location = new System.Drawing.Point(33, 194);
            this.BoxAuthLogin.MaxLength = 32767;
            this.BoxAuthLogin.MouseState = MaterialSkin.MouseState.OUT;
            this.BoxAuthLogin.Name = "BoxAuthLogin";
            this.BoxAuthLogin.PasswordChar = '\0';
            this.BoxAuthLogin.PrefixSuffixText = null;
            this.BoxAuthLogin.ReadOnly = false;
            this.BoxAuthLogin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxAuthLogin.SelectedText = "";
            this.BoxAuthLogin.SelectionLength = 0;
            this.BoxAuthLogin.SelectionStart = 0;
            this.BoxAuthLogin.ShortcutsEnabled = true;
            this.BoxAuthLogin.Size = new System.Drawing.Size(250, 48);
            this.BoxAuthLogin.TabIndex = 2;
            this.BoxAuthLogin.TabStop = false;
            this.BoxAuthLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BoxAuthLogin.TrailingIcon = null;
            this.BoxAuthLogin.UseSystemPasswordChar = false;
            // 
            // BoxAuthPass
            // 
            this.BoxAuthPass.AllowPromptAsInput = true;
            this.BoxAuthPass.AnimateReadOnly = false;
            this.BoxAuthPass.AsciiOnly = false;
            this.BoxAuthPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BoxAuthPass.BeepOnError = false;
            this.BoxAuthPass.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BoxAuthPass.Depth = 0;
            this.BoxAuthPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BoxAuthPass.HidePromptOnLeave = false;
            this.BoxAuthPass.HideSelection = true;
            this.BoxAuthPass.Hint = "Enter your password";
            this.BoxAuthPass.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.BoxAuthPass.LeadingIcon = null;
            this.BoxAuthPass.Location = new System.Drawing.Point(33, 258);
            this.BoxAuthPass.Mask = "";
            this.BoxAuthPass.MaxLength = 32767;
            this.BoxAuthPass.MouseState = MaterialSkin.MouseState.OUT;
            this.BoxAuthPass.Name = "BoxAuthPass";
            this.BoxAuthPass.PasswordChar = '*';
            this.BoxAuthPass.PrefixSuffixText = null;
            this.BoxAuthPass.PromptChar = '_';
            this.BoxAuthPass.ReadOnly = false;
            this.BoxAuthPass.RejectInputOnFirstFailure = false;
            this.BoxAuthPass.ResetOnPrompt = true;
            this.BoxAuthPass.ResetOnSpace = true;
            this.BoxAuthPass.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxAuthPass.SelectedText = "";
            this.BoxAuthPass.SelectionLength = 0;
            this.BoxAuthPass.SelectionStart = 0;
            this.BoxAuthPass.ShortcutsEnabled = true;
            this.BoxAuthPass.Size = new System.Drawing.Size(250, 48);
            this.BoxAuthPass.SkipLiterals = true;
            this.BoxAuthPass.TabIndex = 1;
            this.BoxAuthPass.TabStop = false;
            this.BoxAuthPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BoxAuthPass.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.BoxAuthPass.TrailingIcon = null;
            this.BoxAuthPass.UseSystemPasswordChar = false;
            this.BoxAuthPass.ValidatingType = null;
            // 
            // buttonRes1
            // 
            this.buttonRes1.AutoSize = false;
            this.buttonRes1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonRes1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonRes1.Depth = 0;
            this.buttonRes1.HighEmphasis = true;
            this.buttonRes1.Icon = null;
            this.buttonRes1.Location = new System.Drawing.Point(27, 368);
            this.buttonRes1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonRes1.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonRes1.Name = "buttonRes1";
            this.buttonRes1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonRes1.Size = new System.Drawing.Size(256, 36);
            this.buttonRes1.TabIndex = 5;
            this.buttonRes1.Text = "Continue";
            this.buttonRes1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.buttonRes1.UseAccentColor = false;
            this.buttonRes1.UseVisualStyleBackColor = true;
            this.buttonRes1.Click += new System.EventHandler(this.buttonRes1_Click);
            // 
            // SignUpPanel2
            // 
            this.SignUpPanel2.Controls.Add(this.saveButton);
            this.SignUpPanel2.Controls.Add(this.addressBox);
            this.SignUpPanel2.Controls.Add(this.cityBox);
            this.SignUpPanel2.Controls.Add(this.regionBox);
            this.SignUpPanel2.Controls.Add(this.LastNameBox);
            this.SignUpPanel2.Controls.Add(this.FirstNameBox);
            this.SignUpPanel2.Controls.Add(this.label2);
            this.SignUpPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SignUpPanel2.Location = new System.Drawing.Point(0, 0);
            this.SignUpPanel2.Name = "SignUpPanel2";
            this.SignUpPanel2.Size = new System.Drawing.Size(310, 441);
            this.SignUpPanel2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(0, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(310, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "Create new account:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstNameBox
            // 
            this.FirstNameBox.AnimateReadOnly = false;
            this.FirstNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FirstNameBox.Depth = 0;
            this.FirstNameBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.FirstNameBox.Hint = "First Name";
            this.FirstNameBox.LeadingIcon = null;
            this.FirstNameBox.Location = new System.Drawing.Point(27, 68);
            this.FirstNameBox.MaxLength = 50;
            this.FirstNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.FirstNameBox.Multiline = false;
            this.FirstNameBox.Name = "FirstNameBox";
            this.FirstNameBox.Size = new System.Drawing.Size(256, 50);
            this.FirstNameBox.TabIndex = 2;
            this.FirstNameBox.Text = "";
            this.FirstNameBox.TrailingIcon = null;
            // 
            // LastNameBox
            // 
            this.LastNameBox.AnimateReadOnly = false;
            this.LastNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LastNameBox.Depth = 0;
            this.LastNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LastNameBox.Hint = "Last Name";
            this.LastNameBox.LeadingIcon = null;
            this.LastNameBox.Location = new System.Drawing.Point(27, 130);
            this.LastNameBox.MaxLength = 50;
            this.LastNameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.LastNameBox.Multiline = false;
            this.LastNameBox.Name = "LastNameBox";
            this.LastNameBox.Size = new System.Drawing.Size(256, 50);
            this.LastNameBox.TabIndex = 3;
            this.LastNameBox.Text = "";
            this.LastNameBox.TrailingIcon = null;
            // 
            // regionBox
            // 
            this.regionBox.AnimateReadOnly = false;
            this.regionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.regionBox.Depth = 0;
            this.regionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.regionBox.Hint = "Your Region";
            this.regionBox.LeadingIcon = null;
            this.regionBox.Location = new System.Drawing.Point(27, 196);
            this.regionBox.MaxLength = 50;
            this.regionBox.MouseState = MaterialSkin.MouseState.OUT;
            this.regionBox.Multiline = false;
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(256, 50);
            this.regionBox.TabIndex = 4;
            this.regionBox.Text = "";
            this.regionBox.TrailingIcon = null;
            // 
            // cityBox
            // 
            this.cityBox.AnimateReadOnly = false;
            this.cityBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cityBox.Depth = 0;
            this.cityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.cityBox.Hint = "Your City";
            this.cityBox.LeadingIcon = null;
            this.cityBox.Location = new System.Drawing.Point(27, 259);
            this.cityBox.MaxLength = 50;
            this.cityBox.MouseState = MaterialSkin.MouseState.OUT;
            this.cityBox.Multiline = false;
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(256, 50);
            this.cityBox.TabIndex = 5;
            this.cityBox.Text = "";
            this.cityBox.TrailingIcon = null;
            // 
            // addressBox
            // 
            this.addressBox.AnimateReadOnly = false;
            this.addressBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressBox.Depth = 0;
            this.addressBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.addressBox.Hint = "Your Full Address";
            this.addressBox.LeadingIcon = null;
            this.addressBox.Location = new System.Drawing.Point(27, 320);
            this.addressBox.MaxLength = 50;
            this.addressBox.MouseState = MaterialSkin.MouseState.OUT;
            this.addressBox.Multiline = false;
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(256, 50);
            this.addressBox.TabIndex = 6;
            this.addressBox.Text = "";
            this.addressBox.TrailingIcon = null;
            // 
            // saveButton
            // 
            this.saveButton.AutoSize = false;
            this.saveButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.saveButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.saveButton.Depth = 0;
            this.saveButton.HighEmphasis = true;
            this.saveButton.Icon = null;
            this.saveButton.Location = new System.Drawing.Point(27, 390);
            this.saveButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.saveButton.Size = new System.Drawing.Size(256, 36);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save Data";
            this.saveButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.saveButton.UseAccentColor = false;
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 468);
            this.Controls.Add(this.AuthPanel);
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Communical Service";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AuthPanel.ResumeLayout(false);
            this.AuthPanel.PerformLayout();
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AuthPanel;
        private MaterialSkin.Controls.MaterialButton buttonSignIn;
        private MaterialSkin.Controls.MaterialTextBox2 BoxAuthLogin;
        private MaterialSkin.Controls.MaterialMaskedTextBox BoxAuthPass;
        private MaterialSkin.Controls.MaterialButton buttonSignUp;
        private System.Windows.Forms.LinkLabel NoPass;
        private System.Windows.Forms.Panel SignUpPanel;
        private MaterialSkin.Controls.MaterialMaskedTextBox BoxPass2;
        private MaterialSkin.Controls.MaterialTextBox PhoneBox;
        private MaterialSkin.Controls.MaterialMaskedTextBox BoxPass1;
        private MaterialSkin.Controls.MaterialTextBox LoginBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton buttonRes1;
        private System.Windows.Forms.Panel SignUpPanel2;
        private MaterialSkin.Controls.MaterialButton saveButton;
        private MaterialSkin.Controls.MaterialTextBox addressBox;
        private MaterialSkin.Controls.MaterialTextBox cityBox;
        private MaterialSkin.Controls.MaterialTextBox regionBox;
        private MaterialSkin.Controls.MaterialTextBox LastNameBox;
        private MaterialSkin.Controls.MaterialTextBox FirstNameBox;
        private System.Windows.Forms.Label label2;
    }
}
