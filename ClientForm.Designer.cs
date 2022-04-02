namespace comServiceWF
{
    partial class ClientForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientForm));
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.Orders = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeamId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateOrders = new System.Windows.Forms.TabPage();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.InfoEdit = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSaveChanges = new MaterialSkin.Controls.MaterialButton();
            this.textBoxPassword = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxRegion = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxCity = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxFullAdress = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.textBoxLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.textBoxFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabControl.SuspendLayout();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CreateOrders.SuspendLayout();
            this.InfoEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Orders);
            this.TabControl.Controls.Add(this.CreateOrders);
            this.TabControl.Controls.Add(this.InfoEdit);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.imageList1;
            this.TabControl.Location = new System.Drawing.Point(3, 24);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(794, 423);
            this.TabControl.TabIndex = 0;
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.White;
            this.Orders.Controls.Add(this.dataGridView1);
            this.Orders.ImageKey = "table-account.png";
            this.Orders.Location = new System.Drawing.Point(4, 24);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(786, 395);
            this.Orders.TabIndex = 0;
            this.Orders.Text = "Current orders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.TeamId,
            this.FullName,
            this.Date,
            this.Status});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(780, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "OrderId";
            this.OrderID.Name = "OrderID";
            // 
            // TeamId
            // 
            this.TeamId.HeaderText = "TeamId";
            this.TeamId.Name = "TeamId";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.Name = "FullName";
            this.FullName.Width = 180;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 200;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // CreateOrders
            // 
            this.CreateOrders.BackColor = System.Drawing.Color.White;
            this.CreateOrders.Controls.Add(this.materialButton1);
            this.CreateOrders.Controls.Add(this.dateTimePicker1);
            this.CreateOrders.Controls.Add(this.materialLabel7);
            this.CreateOrders.ImageIndex = 2;
            this.CreateOrders.Location = new System.Drawing.Point(4, 24);
            this.CreateOrders.Name = "CreateOrders";
            this.CreateOrders.Size = new System.Drawing.Size(786, 395);
            this.CreateOrders.TabIndex = 2;
            this.CreateOrders.Text = "Create order";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(294, 213);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(127, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Confirm date";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateTimePicker1.Location = new System.Drawing.Point(267, 172);
            this.dateTimePicker1.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(242, 111);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(260, 41);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Create new order";
            // 
            // InfoEdit
            // 
            this.InfoEdit.BackColor = System.Drawing.Color.White;
            this.InfoEdit.Controls.Add(this.materialLabel6);
            this.InfoEdit.Controls.Add(this.materialLabel5);
            this.InfoEdit.Controls.Add(this.buttonSaveChanges);
            this.InfoEdit.Controls.Add(this.textBoxPassword);
            this.InfoEdit.Controls.Add(this.materialLabel4);
            this.InfoEdit.Controls.Add(this.textBoxRegion);
            this.InfoEdit.Controls.Add(this.textBoxCity);
            this.InfoEdit.Controls.Add(this.textBoxFullAdress);
            this.InfoEdit.Controls.Add(this.materialLabel3);
            this.InfoEdit.Controls.Add(this.textBoxPhone);
            this.InfoEdit.Controls.Add(this.materialLabel2);
            this.InfoEdit.Controls.Add(this.materialLabel1);
            this.InfoEdit.Controls.Add(this.textBoxLastName);
            this.InfoEdit.Controls.Add(this.textBoxFirstName);
            this.InfoEdit.ImageKey = "account (1).png";
            this.InfoEdit.Location = new System.Drawing.Point(4, 24);
            this.InfoEdit.Name = "InfoEdit";
            this.InfoEdit.Padding = new System.Windows.Forms.Padding(3);
            this.InfoEdit.Size = new System.Drawing.Size(786, 395);
            this.InfoEdit.TabIndex = 1;
            this.InfoEdit.Text = "About me";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(510, 3);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(205, 29);
            this.materialLabel6.TabIndex = 28;
            this.materialLabel6.Text = "Editing information";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel5.Location = new System.Drawing.Point(22, 357);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(267, 19);
            this.materialLabel5.TabIndex = 27;
            this.materialLabel5.Text = "* (asterisk) - marked mandatory fields";
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSaveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSaveChanges.Depth = 0;
            this.buttonSaveChanges.HighEmphasis = true;
            this.buttonSaveChanges.Icon = null;
            this.buttonSaveChanges.Location = new System.Drawing.Point(586, 340);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSaveChanges.Size = new System.Drawing.Size(129, 36);
            this.buttonSaveChanges.TabIndex = 26;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSaveChanges.UseAccentColor = false;
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
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
            this.textBoxPassword.Location = new System.Drawing.Point(289, 283);
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
            this.textBoxPassword.TabIndex = 25;
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
            this.materialLabel4.Location = new System.Drawing.Point(289, 245);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(82, 19);
            this.materialLabel4.TabIndex = 24;
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
            this.textBoxRegion.Location = new System.Drawing.Point(502, 175);
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
            this.textBoxRegion.TabIndex = 23;
            this.textBoxRegion.TabStop = false;
            this.textBoxRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxRegion.TrailingIcon = null;
            this.textBoxRegion.UseSystemPasswordChar = false;
            // 
            // textBoxCity
            // 
            this.textBoxCity.AnimateReadOnly = false;
            this.textBoxCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBoxCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.textBoxCity.Depth = 0;
            this.textBoxCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.textBoxCity.HideSelection = true;
            this.textBoxCity.Hint = "City";
            this.textBoxCity.LeadingIcon = null;
            this.textBoxCity.Location = new System.Drawing.Point(288, 175);
            this.textBoxCity.MaxLength = 32767;
            this.textBoxCity.MouseState = MaterialSkin.MouseState.OUT;
            this.textBoxCity.Name = "textBoxCity";
            this.textBoxCity.PasswordChar = '\0';
            this.textBoxCity.PrefixSuffixText = null;
            this.textBoxCity.ReadOnly = false;
            this.textBoxCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBoxCity.SelectedText = "";
            this.textBoxCity.SelectionLength = 0;
            this.textBoxCity.SelectionStart = 0;
            this.textBoxCity.ShortcutsEnabled = true;
            this.textBoxCity.Size = new System.Drawing.Size(202, 48);
            this.textBoxCity.TabIndex = 22;
            this.textBoxCity.TabStop = false;
            this.textBoxCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxCity.TrailingIcon = null;
            this.textBoxCity.UseSystemPasswordChar = false;
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
            this.textBoxFullAdress.Location = new System.Drawing.Point(288, 121);
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
            this.textBoxFullAdress.TabIndex = 21;
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
            this.materialLabel3.Location = new System.Drawing.Point(288, 80);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(69, 19);
            this.materialLabel3.TabIndex = 20;
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
            this.textBoxPhone.Location = new System.Drawing.Point(21, 283);
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
            this.textBoxPhone.TabIndex = 19;
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
            this.materialLabel2.Location = new System.Drawing.Point(22, 245);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(117, 19);
            this.materialLabel2.TabIndex = 18;
            this.materialLabel2.Text = "Phone Number *";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel1.Location = new System.Drawing.Point(22, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(84, 19);
            this.materialLabel1.TabIndex = 17;
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
            this.textBoxLastName.Location = new System.Drawing.Point(21, 175);
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
            this.textBoxLastName.TabIndex = 16;
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
            this.textBoxFirstName.Location = new System.Drawing.Point(21, 121);
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
            this.textBoxFirstName.TabIndex = 15;
            this.textBoxFirstName.TabStop = false;
            this.textBoxFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBoxFirstName.TrailingIcon = null;
            this.textBoxFirstName.UseSystemPasswordChar = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "account (1).png");
            this.imageList1.Images.SetKeyName(1, "table-account.png");
            this.imageList1.Images.SetKeyName(2, "plus-box.png");
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ClientForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ClientForm";
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.TabControl.ResumeLayout(false);
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CreateOrders.ResumeLayout(false);
            this.CreateOrders.PerformLayout();
            this.InfoEdit.ResumeLayout(false);
            this.InfoEdit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.TabPage InfoEdit;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton buttonSaveChanges;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPassword;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxRegion;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxCity;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxFullAdress;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxPhone;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxLastName;
        private MaterialSkin.Controls.MaterialTextBox2 textBoxFirstName;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeamId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.TabPage CreateOrders;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}