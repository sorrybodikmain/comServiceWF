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
            this.CreateOrders = new System.Windows.Forms.TabPage();
            this.typeComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.Orders = new System.Windows.Forms.TabPage();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InfoEdit = new System.Windows.Forms.TabPage();
            this.loginBox = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.buttonSaveChanges = new MaterialSkin.Controls.MaterialButton();
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
            this.changePass = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.passConfButton = new MaterialSkin.Controls.MaterialButton();
            this.passBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.passBox2 = new MaterialSkin.Controls.MaterialTextBox();
            this.passBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialCheckbox1 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox2 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox3 = new MaterialSkin.Controls.MaterialCheckbox();
            this.TabControl.SuspendLayout();
            this.CreateOrders.SuspendLayout();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.InfoEdit.SuspendLayout();
            this.changePass.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.CreateOrders);
            this.TabControl.Controls.Add(this.Orders);
            this.TabControl.Controls.Add(this.InfoEdit);
            this.TabControl.Controls.Add(this.changePass);
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
            // CreateOrders
            // 
            this.CreateOrders.BackColor = System.Drawing.Color.White;
            this.CreateOrders.Controls.Add(this.typeComboBox);
            this.CreateOrders.Controls.Add(this.materialButton1);
            this.CreateOrders.Controls.Add(this.DatePicker);
            this.CreateOrders.Controls.Add(this.materialLabel7);
            this.CreateOrders.ImageKey = "plus-box.png";
            this.CreateOrders.Location = new System.Drawing.Point(4, 24);
            this.CreateOrders.Name = "CreateOrders";
            this.CreateOrders.Size = new System.Drawing.Size(786, 395);
            this.CreateOrders.TabIndex = 2;
            this.CreateOrders.Text = "Create order";
            // 
            // typeComboBox
            // 
            this.typeComboBox.AutoResize = false;
            this.typeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.typeComboBox.Depth = 0;
            this.typeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.typeComboBox.DropDownHeight = 174;
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.DropDownWidth = 121;
            this.typeComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.typeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.IntegralHeight = false;
            this.typeComboBox.ItemHeight = 43;
            this.typeComboBox.Items.AddRange(new object[] {
            "Restoration",
            "Repair",
            "Construction",
            "Assistance"});
            this.typeComboBox.Location = new System.Drawing.Point(253, 181);
            this.typeComboBox.MaxDropDownItems = 4;
            this.typeComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(260, 49);
            this.typeComboBox.StartIndex = 0;
            this.typeComboBox.TabIndex = 3;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(253, 239);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(260, 36);
            this.materialButton1.TabIndex = 2;
            this.materialButton1.Text = "Confirm";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Outlined;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePicker.CustomFormat = "";
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DatePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatePicker.Location = new System.Drawing.Point(253, 148);
            this.DatePicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.DatePicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(260, 27);
            this.DatePicker.TabIndex = 1;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.Transparent;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel7.Location = new System.Drawing.Point(253, 95);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(260, 41);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Create new order";
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.White;
            this.Orders.Controls.Add(this.ordersGridView);
            this.Orders.ImageKey = "table-account.png";
            this.Orders.Location = new System.Drawing.Point(4, 24);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(3);
            this.Orders.Size = new System.Drawing.Size(786, 395);
            this.Orders.TabIndex = 0;
            this.Orders.Text = "Current orders";
            // 
            // ordersGridView
            // 
            this.ordersGridView.BackgroundColor = System.Drawing.Color.White;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.fullName,
            this.typeOfWork,
            this.status,
            this.dateOfWork,
            this.createDate,
            this.toComplete});
            this.ordersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ordersGridView.Location = new System.Drawing.Point(3, 3);
            this.ordersGridView.Margin = new System.Windows.Forms.Padding(1);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.RowTemplate.Height = 25;
            this.ordersGridView.Size = new System.Drawing.Size(780, 389);
            this.ordersGridView.TabIndex = 0;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "ID";
            this.OrderId.Name = "OrderId";
            this.OrderId.Width = 50;
            // 
            // fullName
            // 
            this.fullName.HeaderText = "Full Name";
            this.fullName.Name = "fullName";
            this.fullName.Width = 130;
            // 
            // typeOfWork
            // 
            this.typeOfWork.HeaderText = "Type";
            this.typeOfWork.Name = "typeOfWork";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // dateOfWork
            // 
            this.dateOfWork.HeaderText = "Date Of Work";
            this.dateOfWork.Name = "dateOfWork";
            this.dateOfWork.Width = 120;
            // 
            // createDate
            // 
            this.createDate.HeaderText = "Create Date";
            this.createDate.Name = "createDate";
            // 
            // toComplete
            // 
            this.toComplete.HeaderText = "To Complete";
            this.toComplete.Name = "toComplete";
            this.toComplete.Width = 115;
            // 
            // InfoEdit
            // 
            this.InfoEdit.BackColor = System.Drawing.Color.White;
            this.InfoEdit.Controls.Add(this.loginBox);
            this.InfoEdit.Controls.Add(this.materialLabel6);
            this.InfoEdit.Controls.Add(this.materialLabel5);
            this.InfoEdit.Controls.Add(this.buttonSaveChanges);
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
            // loginBox
            // 
            this.loginBox.AnimateReadOnly = false;
            this.loginBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loginBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.loginBox.Depth = 0;
            this.loginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.loginBox.HideSelection = true;
            this.loginBox.Hint = "Login";
            this.loginBox.LeadingIcon = null;
            this.loginBox.Location = new System.Drawing.Point(18, 281);
            this.loginBox.MaxLength = 32767;
            this.loginBox.MouseState = MaterialSkin.MouseState.OUT;
            this.loginBox.Name = "loginBox";
            this.loginBox.PasswordChar = '\0';
            this.loginBox.PrefixSuffixText = null;
            this.loginBox.ReadOnly = false;
            this.loginBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.loginBox.SelectedText = "";
            this.loginBox.SelectionLength = 0;
            this.loginBox.SelectionStart = 0;
            this.loginBox.ShortcutsEnabled = true;
            this.loginBox.Size = new System.Drawing.Size(212, 48);
            this.loginBox.TabIndex = 29;
            this.loginBox.TabStop = false;
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.loginBox.TrailingIcon = null;
            this.loginBox.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel6.Location = new System.Drawing.Point(505, 14);
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
            this.materialLabel5.Location = new System.Drawing.Point(18, 357);
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
            this.buttonSaveChanges.Location = new System.Drawing.Point(582, 340);
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
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1;
            this.materialLabel4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.materialLabel4.Location = new System.Drawing.Point(18, 241);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(52, 19);
            this.materialLabel4.TabIndex = 24;
            this.materialLabel4.Text = "Login *";
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
            this.textBoxRegion.Location = new System.Drawing.Point(498, 175);
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
            this.textBoxCity.Location = new System.Drawing.Point(284, 175);
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
            this.textBoxFullAdress.Location = new System.Drawing.Point(284, 121);
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
            this.materialLabel3.Location = new System.Drawing.Point(284, 80);
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
            this.textBoxPhone.Location = new System.Drawing.Point(284, 281);
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
            this.textBoxPhone.Size = new System.Drawing.Size(426, 48);
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
            this.materialLabel2.Location = new System.Drawing.Point(284, 241);
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
            this.materialLabel1.Location = new System.Drawing.Point(18, 80);
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
            this.textBoxLastName.Location = new System.Drawing.Point(17, 175);
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
            this.textBoxFirstName.Location = new System.Drawing.Point(17, 121);
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
            // changePass
            // 
            this.changePass.BackColor = System.Drawing.Color.White;
            this.changePass.Controls.Add(this.label1);
            this.changePass.Controls.Add(this.passConfButton);
            this.changePass.Controls.Add(this.passBox3);
            this.changePass.Controls.Add(this.passBox2);
            this.changePass.Controls.Add(this.passBox1);
            this.changePass.ImageKey = "lockIcon.png";
            this.changePass.Location = new System.Drawing.Point(4, 24);
            this.changePass.Name = "changePass";
            this.changePass.Size = new System.Drawing.Size(786, 395);
            this.changePass.TabIndex = 3;
            this.changePass.Text = "Change Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Change password:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passConfButton
            // 
            this.passConfButton.AutoSize = false;
            this.passConfButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.passConfButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.passConfButton.Depth = 0;
            this.passConfButton.HighEmphasis = true;
            this.passConfButton.Icon = null;
            this.passConfButton.Location = new System.Drawing.Point(260, 307);
            this.passConfButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.passConfButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.passConfButton.Name = "passConfButton";
            this.passConfButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.passConfButton.Size = new System.Drawing.Size(219, 36);
            this.passConfButton.TabIndex = 3;
            this.passConfButton.Text = "Confirm Password";
            this.passConfButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.passConfButton.UseAccentColor = false;
            this.passConfButton.UseVisualStyleBackColor = true;
            this.passConfButton.Click += new System.EventHandler(this.passConfButton_Click);
            // 
            // passBox3
            // 
            this.passBox3.AnimateReadOnly = false;
            this.passBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox3.Depth = 0;
            this.passBox3.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passBox3.Hint = "Repeat password";
            this.passBox3.LeadingIcon = null;
            this.passBox3.Location = new System.Drawing.Point(260, 238);
            this.passBox3.MaxLength = 50;
            this.passBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.passBox3.Multiline = false;
            this.passBox3.Name = "passBox3";
            this.passBox3.Size = new System.Drawing.Size(219, 50);
            this.passBox3.TabIndex = 2;
            this.passBox3.Text = "";
            this.passBox3.TrailingIcon = null;
            // 
            // passBox2
            // 
            this.passBox2.AnimateReadOnly = false;
            this.passBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox2.Depth = 0;
            this.passBox2.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passBox2.Hint = "Enter new password";
            this.passBox2.LeadingIcon = null;
            this.passBox2.Location = new System.Drawing.Point(260, 165);
            this.passBox2.MaxLength = 50;
            this.passBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.passBox2.Multiline = false;
            this.passBox2.Name = "passBox2";
            this.passBox2.Size = new System.Drawing.Size(219, 50);
            this.passBox2.TabIndex = 1;
            this.passBox2.Text = "";
            this.passBox2.TrailingIcon = null;
            // 
            // passBox1
            // 
            this.passBox1.AnimateReadOnly = false;
            this.passBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passBox1.Depth = 0;
            this.passBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passBox1.Hint = "Enter current password";
            this.passBox1.LeadingIcon = null;
            this.passBox1.Location = new System.Drawing.Point(260, 96);
            this.passBox1.MaxLength = 50;
            this.passBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.passBox1.Multiline = false;
            this.passBox1.Name = "passBox1";
            this.passBox1.Size = new System.Drawing.Size(219, 50);
            this.passBox1.TabIndex = 0;
            this.passBox1.Text = "";
            this.passBox1.TrailingIcon = null;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "account (1).png");
            this.imageList1.Images.SetKeyName(1, "table-account.png");
            this.imageList1.Images.SetKeyName(2, "plus-box.png");
            this.imageList1.Images.SetKeyName(3, "lockIcon.png");
            // 
            // materialCheckbox1
            // 
            this.materialCheckbox1.AutoSize = true;
            this.materialCheckbox1.Depth = 0;
            this.materialCheckbox1.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox1.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox1.Name = "materialCheckbox1";
            this.materialCheckbox1.ReadOnly = false;
            this.materialCheckbox1.Ripple = true;
            this.materialCheckbox1.Size = new System.Drawing.Size(10, 10);
            this.materialCheckbox1.TabIndex = 0;
            this.materialCheckbox1.Text = "materialCheckbox1";
            this.materialCheckbox1.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox2
            // 
            this.materialCheckbox2.AutoSize = true;
            this.materialCheckbox2.Depth = 0;
            this.materialCheckbox2.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox2.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox2.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox2.Name = "materialCheckbox2";
            this.materialCheckbox2.ReadOnly = false;
            this.materialCheckbox2.Ripple = true;
            this.materialCheckbox2.Size = new System.Drawing.Size(10, 10);
            this.materialCheckbox2.TabIndex = 0;
            this.materialCheckbox2.Text = "materialCheckbox2";
            this.materialCheckbox2.UseVisualStyleBackColor = true;
            // 
            // materialCheckbox3
            // 
            this.materialCheckbox3.AutoSize = true;
            this.materialCheckbox3.Depth = 0;
            this.materialCheckbox3.Location = new System.Drawing.Point(0, 0);
            this.materialCheckbox3.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox3.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox3.Name = "materialCheckbox3";
            this.materialCheckbox3.ReadOnly = false;
            this.materialCheckbox3.Ripple = true;
            this.materialCheckbox3.Size = new System.Drawing.Size(10, 10);
            this.materialCheckbox3.TabIndex = 0;
            this.materialCheckbox3.Text = "materialCheckbox3";
            this.materialCheckbox3.UseVisualStyleBackColor = true;
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
            this.CreateOrders.ResumeLayout(false);
            this.CreateOrders.PerformLayout();
            this.Orders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.InfoEdit.ResumeLayout(false);
            this.InfoEdit.PerformLayout();
            this.changePass.ResumeLayout(false);
            this.changePass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage Orders;
        private System.Windows.Forms.TabPage InfoEdit;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton buttonSaveChanges;
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
        private System.Windows.Forms.TabPage CreateOrders;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox1;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox2;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox3;
        private MaterialSkin.Controls.MaterialComboBox typeComboBox;
        private System.Windows.Forms.ColumnHeader orderId;
        private System.Windows.Forms.ColumnHeader typeOfWorks;
        private System.Windows.Forms.ColumnHeader dateCreate;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.TabPage changePass;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toComplete;
        private MaterialSkin.Controls.MaterialTextBox2 loginBox;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton passConfButton;
        private MaterialSkin.Controls.MaterialTextBox passBox3;
        private MaterialSkin.Controls.MaterialTextBox passBox2;
        private MaterialSkin.Controls.MaterialTextBox passBox1;
    }
}