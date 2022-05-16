namespace comServiceWF.Forms
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.TabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.tabDeleteClients = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabEditTeams = new System.Windows.Forms.TabPage();
            this.addTeamButton = new MaterialSkin.Controls.MaterialButton();
            this.addWorkerButton = new MaterialSkin.Controls.MaterialButton();
            this.boxSalary = new MaterialSkin.Controls.MaterialTextBox();
            this.boxPhone = new MaterialSkin.Controls.MaterialTextBox();
            this.boxLastName = new MaterialSkin.Controls.MaterialTextBox();
            this.boxFirstName = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.deleteTeamButton = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabEditClients = new System.Windows.Forms.TabPage();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.boxClientId = new MaterialSkin.Controls.MaterialTextBox2();
            this.buttonSaveChanges = new MaterialSkin.Controls.MaterialButton();
            this.boxClientRegion = new MaterialSkin.Controls.MaterialTextBox2();
            this.boxClientCity = new MaterialSkin.Controls.MaterialTextBox2();
            this.boxClientFullAdress = new MaterialSkin.Controls.MaterialTextBox2();
            this.boxClientPhone = new MaterialSkin.Controls.MaterialTextBox2();
            this.boxClientLastName = new MaterialSkin.Controls.MaterialTextBox2();
            this.boxClientFirstName = new MaterialSkin.Controls.MaterialTextBox2();
            this.tabEditOrders = new System.Windows.Forms.TabPage();
            this.buttonEditOrders = new MaterialSkin.Controls.MaterialButton();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.OrderId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toComplete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.TabControl.SuspendLayout();
            this.tabDeleteClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabEditTeams.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabEditClients.SuspendLayout();
            this.tabEditOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabEditOrders);
            this.TabControl.Controls.Add(this.tabEditTeams);
            this.TabControl.Controls.Add(this.tabEditClients);
            this.TabControl.Controls.Add(this.tabDeleteClients);
            this.TabControl.Depth = 0;
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.imageList1;
            this.TabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TabControl.Location = new System.Drawing.Point(3, 24);
            this.TabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabControl.Multiline = true;
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(794, 423);
            this.TabControl.TabIndex = 0;
            // 
            // tabDeleteClients
            // 
            this.tabDeleteClients.BackColor = System.Drawing.Color.White;
            this.tabDeleteClients.Controls.Add(this.dataGridView1);
            this.tabDeleteClients.Controls.Add(this.materialButton1);
            this.tabDeleteClients.ImageKey = "account-group.png";
            this.tabDeleteClients.Location = new System.Drawing.Point(4, 27);
            this.tabDeleteClients.Name = "tabDeleteClients";
            this.tabDeleteClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabDeleteClients.Size = new System.Drawing.Size(786, 392);
            this.tabDeleteClients.TabIndex = 0;
            this.tabDeleteClients.Text = "Delete Clients";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientId,
            this.FullName,
            this.Phone,
            this.FullAddress});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(780, 350);
            this.dataGridView1.TabIndex = 1;
            // 
            // ClientId
            // 
            this.ClientId.HeaderText = "Id";
            this.ClientId.Name = "ClientId";
            this.ClientId.Width = 50;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            this.FullName.Width = 150;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.Width = 150;
            // 
            // FullAddress
            // 
            this.FullAddress.HeaderText = "Full Address";
            this.FullAddress.Name = "FullAddress";
            this.FullAddress.Width = 300;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(3, 353);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(780, 36);
            this.materialButton1.TabIndex = 0;
            this.materialButton1.Text = "Cascade Delete client";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // tabEditTeams
            // 
            this.tabEditTeams.BackColor = System.Drawing.Color.White;
            this.tabEditTeams.Controls.Add(this.addTeamButton);
            this.tabEditTeams.Controls.Add(this.addWorkerButton);
            this.tabEditTeams.Controls.Add(this.boxSalary);
            this.tabEditTeams.Controls.Add(this.boxPhone);
            this.tabEditTeams.Controls.Add(this.boxLastName);
            this.tabEditTeams.Controls.Add(this.boxFirstName);
            this.tabEditTeams.Controls.Add(this.materialLabel1);
            this.tabEditTeams.Controls.Add(this.deleteTeamButton);
            this.tabEditTeams.Controls.Add(this.dataGridView2);
            this.tabEditTeams.ImageKey = "account-hard-hat.png";
            this.tabEditTeams.Location = new System.Drawing.Point(4, 27);
            this.tabEditTeams.Name = "tabEditTeams";
            this.tabEditTeams.Size = new System.Drawing.Size(786, 392);
            this.tabEditTeams.TabIndex = 2;
            this.tabEditTeams.Text = "Teams";
            // 
            // addTeamButton
            // 
            this.addTeamButton.AutoSize = false;
            this.addTeamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addTeamButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addTeamButton.Depth = 0;
            this.addTeamButton.HighEmphasis = true;
            this.addTeamButton.Icon = null;
            this.addTeamButton.Location = new System.Drawing.Point(44, 358);
            this.addTeamButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addTeamButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addTeamButton.Name = "addTeamButton";
            this.addTeamButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addTeamButton.Size = new System.Drawing.Size(268, 28);
            this.addTeamButton.TabIndex = 8;
            this.addTeamButton.Text = "Add Team";
            this.addTeamButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addTeamButton.UseAccentColor = false;
            this.addTeamButton.UseVisualStyleBackColor = true;
            this.addTeamButton.Click += new System.EventHandler(this.addTeamButton_Click);
            // 
            // addWorkerButton
            // 
            this.addWorkerButton.AutoSize = false;
            this.addWorkerButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.addWorkerButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.addWorkerButton.Depth = 0;
            this.addWorkerButton.HighEmphasis = true;
            this.addWorkerButton.Icon = null;
            this.addWorkerButton.Location = new System.Drawing.Point(430, 343);
            this.addWorkerButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.addWorkerButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.addWorkerButton.Name = "addWorkerButton";
            this.addWorkerButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.addWorkerButton.Size = new System.Drawing.Size(261, 36);
            this.addWorkerButton.TabIndex = 7;
            this.addWorkerButton.Text = "Add Worker";
            this.addWorkerButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.addWorkerButton.UseAccentColor = false;
            this.addWorkerButton.UseVisualStyleBackColor = true;
            this.addWorkerButton.Click += new System.EventHandler(this.addWorkerButton_Click);
            // 
            // boxSalary
            // 
            this.boxSalary.AnimateReadOnly = false;
            this.boxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxSalary.Depth = 0;
            this.boxSalary.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxSalary.Hint = "Salary";
            this.boxSalary.LeadingIcon = null;
            this.boxSalary.Location = new System.Drawing.Point(430, 274);
            this.boxSalary.MaxLength = 50;
            this.boxSalary.MouseState = MaterialSkin.MouseState.OUT;
            this.boxSalary.Multiline = false;
            this.boxSalary.Name = "boxSalary";
            this.boxSalary.Size = new System.Drawing.Size(263, 50);
            this.boxSalary.TabIndex = 6;
            this.boxSalary.Text = "";
            this.boxSalary.TrailingIcon = null;
            // 
            // boxPhone
            // 
            this.boxPhone.AnimateReadOnly = false;
            this.boxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxPhone.Depth = 0;
            this.boxPhone.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxPhone.Hint = "Phone Number";
            this.boxPhone.LeadingIcon = null;
            this.boxPhone.Location = new System.Drawing.Point(430, 202);
            this.boxPhone.MaxLength = 50;
            this.boxPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.boxPhone.Multiline = false;
            this.boxPhone.Name = "boxPhone";
            this.boxPhone.Size = new System.Drawing.Size(263, 50);
            this.boxPhone.TabIndex = 5;
            this.boxPhone.Text = "";
            this.boxPhone.TrailingIcon = null;
            // 
            // boxLastName
            // 
            this.boxLastName.AnimateReadOnly = false;
            this.boxLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxLastName.Depth = 0;
            this.boxLastName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxLastName.Hint = "Last Name";
            this.boxLastName.LeadingIcon = null;
            this.boxLastName.Location = new System.Drawing.Point(430, 134);
            this.boxLastName.MaxLength = 50;
            this.boxLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.boxLastName.Multiline = false;
            this.boxLastName.Name = "boxLastName";
            this.boxLastName.Size = new System.Drawing.Size(263, 50);
            this.boxLastName.TabIndex = 4;
            this.boxLastName.Text = "";
            this.boxLastName.TrailingIcon = null;
            // 
            // boxFirstName
            // 
            this.boxFirstName.AnimateReadOnly = false;
            this.boxFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.boxFirstName.Depth = 0;
            this.boxFirstName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxFirstName.Hint = "First Name";
            this.boxFirstName.LeadingIcon = null;
            this.boxFirstName.Location = new System.Drawing.Point(430, 69);
            this.boxFirstName.MaxLength = 50;
            this.boxFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.boxFirstName.Multiline = false;
            this.boxFirstName.Name = "boxFirstName";
            this.boxFirstName.Size = new System.Drawing.Size(263, 50);
            this.boxFirstName.TabIndex = 3;
            this.boxFirstName.Text = "";
            this.boxFirstName.TrailingIcon = null;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel1.Location = new System.Drawing.Point(432, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(261, 41);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Add New Worker:";
            // 
            // deleteTeamButton
            // 
            this.deleteTeamButton.AutoSize = false;
            this.deleteTeamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deleteTeamButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.deleteTeamButton.Depth = 0;
            this.deleteTeamButton.HighEmphasis = true;
            this.deleteTeamButton.Icon = null;
            this.deleteTeamButton.Location = new System.Drawing.Point(44, 324);
            this.deleteTeamButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.deleteTeamButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.deleteTeamButton.Name = "deleteTeamButton";
            this.deleteTeamButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.deleteTeamButton.Size = new System.Drawing.Size(268, 28);
            this.deleteTeamButton.TabIndex = 1;
            this.deleteTeamButton.Text = "Team Delete";
            this.deleteTeamButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.deleteTeamButton.UseAccentColor = false;
            this.deleteTeamButton.UseVisualStyleBackColor = true;
            this.deleteTeamButton.Click += new System.EventHandler(this.deleteTeamButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Status});
            this.dataGridView2.Location = new System.Drawing.Point(44, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(268, 301);
            this.dataGridView2.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Team Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 75;
            // 
            // Status
            // 
            this.Status.FillWeight = 150F;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 140;
            // 
            // tabEditClients
            // 
            this.tabEditClients.BackColor = System.Drawing.Color.White;
            this.tabEditClients.Controls.Add(this.materialButton2);
            this.tabEditClients.Controls.Add(this.boxClientId);
            this.tabEditClients.Controls.Add(this.buttonSaveChanges);
            this.tabEditClients.Controls.Add(this.boxClientRegion);
            this.tabEditClients.Controls.Add(this.boxClientCity);
            this.tabEditClients.Controls.Add(this.boxClientFullAdress);
            this.tabEditClients.Controls.Add(this.boxClientPhone);
            this.tabEditClients.Controls.Add(this.boxClientLastName);
            this.tabEditClients.Controls.Add(this.boxClientFirstName);
            this.tabEditClients.ImageKey = "account-star.png";
            this.tabEditClients.Location = new System.Drawing.Point(4, 27);
            this.tabEditClients.Name = "tabEditClients";
            this.tabEditClients.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditClients.Size = new System.Drawing.Size(786, 392);
            this.tabEditClients.TabIndex = 1;
            this.tabEditClients.Text = "Edit Clients";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(492, 37);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(99, 48);
            this.materialButton2.TabIndex = 42;
            this.materialButton2.Text = "Find";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // boxClientId
            // 
            this.boxClientId.AnimateReadOnly = false;
            this.boxClientId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxClientId.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxClientId.Depth = 0;
            this.boxClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxClientId.HideSelection = true;
            this.boxClientId.Hint = "Enter client ID";
            this.boxClientId.LeadingIcon = null;
            this.boxClientId.Location = new System.Drawing.Point(165, 37);
            this.boxClientId.MaxLength = 32767;
            this.boxClientId.MouseState = MaterialSkin.MouseState.OUT;
            this.boxClientId.Name = "boxClientId";
            this.boxClientId.PasswordChar = '\0';
            this.boxClientId.PrefixSuffixText = null;
            this.boxClientId.ReadOnly = false;
            this.boxClientId.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClientId.SelectedText = "";
            this.boxClientId.SelectionLength = 0;
            this.boxClientId.SelectionStart = 0;
            this.boxClientId.ShortcutsEnabled = true;
            this.boxClientId.Size = new System.Drawing.Size(320, 48);
            this.boxClientId.TabIndex = 41;
            this.boxClientId.TabStop = false;
            this.boxClientId.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxClientId.TrailingIcon = null;
            this.boxClientId.UseSystemPasswordChar = false;
            // 
            // buttonSaveChanges
            // 
            this.buttonSaveChanges.AutoSize = false;
            this.buttonSaveChanges.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonSaveChanges.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonSaveChanges.Depth = 0;
            this.buttonSaveChanges.HighEmphasis = true;
            this.buttonSaveChanges.Icon = null;
            this.buttonSaveChanges.Location = new System.Drawing.Point(165, 320);
            this.buttonSaveChanges.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonSaveChanges.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonSaveChanges.Name = "buttonSaveChanges";
            this.buttonSaveChanges.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonSaveChanges.Size = new System.Drawing.Size(426, 36);
            this.buttonSaveChanges.TabIndex = 40;
            this.buttonSaveChanges.Text = "Save changes";
            this.buttonSaveChanges.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonSaveChanges.UseAccentColor = false;
            this.buttonSaveChanges.UseVisualStyleBackColor = true;
            this.buttonSaveChanges.Click += new System.EventHandler(this.buttonSaveChanges_Click);
            // 
            // boxClientRegion
            // 
            this.boxClientRegion.AnimateReadOnly = false;
            this.boxClientRegion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxClientRegion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxClientRegion.Depth = 0;
            this.boxClientRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxClientRegion.HideSelection = true;
            this.boxClientRegion.Hint = "Region";
            this.boxClientRegion.LeadingIcon = null;
            this.boxClientRegion.Location = new System.Drawing.Point(379, 202);
            this.boxClientRegion.MaxLength = 32767;
            this.boxClientRegion.MouseState = MaterialSkin.MouseState.OUT;
            this.boxClientRegion.Name = "boxClientRegion";
            this.boxClientRegion.PasswordChar = '\0';
            this.boxClientRegion.PrefixSuffixText = null;
            this.boxClientRegion.ReadOnly = false;
            this.boxClientRegion.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClientRegion.SelectedText = "";
            this.boxClientRegion.SelectionLength = 0;
            this.boxClientRegion.SelectionStart = 0;
            this.boxClientRegion.ShortcutsEnabled = true;
            this.boxClientRegion.Size = new System.Drawing.Size(212, 48);
            this.boxClientRegion.TabIndex = 38;
            this.boxClientRegion.TabStop = false;
            this.boxClientRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxClientRegion.TrailingIcon = null;
            this.boxClientRegion.UseSystemPasswordChar = false;
            // 
            // boxClientCity
            // 
            this.boxClientCity.AnimateReadOnly = false;
            this.boxClientCity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxClientCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxClientCity.Depth = 0;
            this.boxClientCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxClientCity.HideSelection = true;
            this.boxClientCity.Hint = "City";
            this.boxClientCity.LeadingIcon = null;
            this.boxClientCity.Location = new System.Drawing.Point(165, 202);
            this.boxClientCity.MaxLength = 32767;
            this.boxClientCity.MouseState = MaterialSkin.MouseState.OUT;
            this.boxClientCity.Name = "boxClientCity";
            this.boxClientCity.PasswordChar = '\0';
            this.boxClientCity.PrefixSuffixText = null;
            this.boxClientCity.ReadOnly = false;
            this.boxClientCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClientCity.SelectedText = "";
            this.boxClientCity.SelectionLength = 0;
            this.boxClientCity.SelectionStart = 0;
            this.boxClientCity.ShortcutsEnabled = true;
            this.boxClientCity.Size = new System.Drawing.Size(202, 48);
            this.boxClientCity.TabIndex = 37;
            this.boxClientCity.TabStop = false;
            this.boxClientCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxClientCity.TrailingIcon = null;
            this.boxClientCity.UseSystemPasswordChar = false;
            // 
            // boxClientFullAdress
            // 
            this.boxClientFullAdress.AnimateReadOnly = false;
            this.boxClientFullAdress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxClientFullAdress.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxClientFullAdress.Depth = 0;
            this.boxClientFullAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxClientFullAdress.HideSelection = true;
            this.boxClientFullAdress.Hint = "Street Address";
            this.boxClientFullAdress.LeadingIcon = null;
            this.boxClientFullAdress.Location = new System.Drawing.Point(165, 148);
            this.boxClientFullAdress.MaxLength = 32767;
            this.boxClientFullAdress.MouseState = MaterialSkin.MouseState.OUT;
            this.boxClientFullAdress.Name = "boxClientFullAdress";
            this.boxClientFullAdress.PasswordChar = '\0';
            this.boxClientFullAdress.PrefixSuffixText = null;
            this.boxClientFullAdress.ReadOnly = false;
            this.boxClientFullAdress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClientFullAdress.SelectedText = "";
            this.boxClientFullAdress.SelectionLength = 0;
            this.boxClientFullAdress.SelectionStart = 0;
            this.boxClientFullAdress.ShortcutsEnabled = true;
            this.boxClientFullAdress.Size = new System.Drawing.Size(426, 48);
            this.boxClientFullAdress.TabIndex = 36;
            this.boxClientFullAdress.TabStop = false;
            this.boxClientFullAdress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxClientFullAdress.TrailingIcon = null;
            this.boxClientFullAdress.UseSystemPasswordChar = false;
            // 
            // boxClientPhone
            // 
            this.boxClientPhone.AnimateReadOnly = false;
            this.boxClientPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxClientPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxClientPhone.Depth = 0;
            this.boxClientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxClientPhone.HideSelection = true;
            this.boxClientPhone.Hint = "Phone Number";
            this.boxClientPhone.LeadingIcon = null;
            this.boxClientPhone.Location = new System.Drawing.Point(165, 263);
            this.boxClientPhone.MaxLength = 32767;
            this.boxClientPhone.MouseState = MaterialSkin.MouseState.OUT;
            this.boxClientPhone.Name = "boxClientPhone";
            this.boxClientPhone.PasswordChar = '\0';
            this.boxClientPhone.PrefixSuffixText = null;
            this.boxClientPhone.ReadOnly = false;
            this.boxClientPhone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClientPhone.SelectedText = "";
            this.boxClientPhone.SelectionLength = 0;
            this.boxClientPhone.SelectionStart = 0;
            this.boxClientPhone.ShortcutsEnabled = true;
            this.boxClientPhone.Size = new System.Drawing.Size(426, 48);
            this.boxClientPhone.TabIndex = 34;
            this.boxClientPhone.TabStop = false;
            this.boxClientPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxClientPhone.TrailingIcon = null;
            this.boxClientPhone.UseSystemPasswordChar = false;
            // 
            // boxClientLastName
            // 
            this.boxClientLastName.AnimateReadOnly = false;
            this.boxClientLastName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxClientLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxClientLastName.Depth = 0;
            this.boxClientLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxClientLastName.HideSelection = true;
            this.boxClientLastName.Hint = "Last Name";
            this.boxClientLastName.LeadingIcon = null;
            this.boxClientLastName.Location = new System.Drawing.Point(379, 91);
            this.boxClientLastName.MaxLength = 32767;
            this.boxClientLastName.MouseState = MaterialSkin.MouseState.OUT;
            this.boxClientLastName.Name = "boxClientLastName";
            this.boxClientLastName.PasswordChar = '\0';
            this.boxClientLastName.PrefixSuffixText = null;
            this.boxClientLastName.ReadOnly = false;
            this.boxClientLastName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClientLastName.SelectedText = "";
            this.boxClientLastName.SelectionLength = 0;
            this.boxClientLastName.SelectionStart = 0;
            this.boxClientLastName.ShortcutsEnabled = true;
            this.boxClientLastName.Size = new System.Drawing.Size(212, 48);
            this.boxClientLastName.TabIndex = 31;
            this.boxClientLastName.TabStop = false;
            this.boxClientLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxClientLastName.TrailingIcon = null;
            this.boxClientLastName.UseSystemPasswordChar = false;
            // 
            // boxClientFirstName
            // 
            this.boxClientFirstName.AnimateReadOnly = false;
            this.boxClientFirstName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.boxClientFirstName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.boxClientFirstName.Depth = 0;
            this.boxClientFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.boxClientFirstName.HideSelection = true;
            this.boxClientFirstName.Hint = "First Name";
            this.boxClientFirstName.LeadingIcon = null;
            this.boxClientFirstName.Location = new System.Drawing.Point(165, 91);
            this.boxClientFirstName.MaxLength = 32767;
            this.boxClientFirstName.MouseState = MaterialSkin.MouseState.OUT;
            this.boxClientFirstName.Name = "boxClientFirstName";
            this.boxClientFirstName.PasswordChar = '\0';
            this.boxClientFirstName.PrefixSuffixText = null;
            this.boxClientFirstName.ReadOnly = false;
            this.boxClientFirstName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxClientFirstName.SelectedText = "";
            this.boxClientFirstName.SelectionLength = 0;
            this.boxClientFirstName.SelectionStart = 0;
            this.boxClientFirstName.ShortcutsEnabled = true;
            this.boxClientFirstName.Size = new System.Drawing.Size(202, 48);
            this.boxClientFirstName.TabIndex = 30;
            this.boxClientFirstName.TabStop = false;
            this.boxClientFirstName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.boxClientFirstName.TrailingIcon = null;
            this.boxClientFirstName.UseSystemPasswordChar = false;
            // 
            // tabEditOrders
            // 
            this.tabEditOrders.BackColor = System.Drawing.Color.White;
            this.tabEditOrders.Controls.Add(this.buttonEditOrders);
            this.tabEditOrders.Controls.Add(this.dataGridView3);
            this.tabEditOrders.ImageKey = "listIcon.png";
            this.tabEditOrders.Location = new System.Drawing.Point(4, 27);
            this.tabEditOrders.Name = "tabEditOrders";
            this.tabEditOrders.Size = new System.Drawing.Size(786, 392);
            this.tabEditOrders.TabIndex = 3;
            this.tabEditOrders.Text = "Edit Orders";
            // 
            // buttonEditOrders
            // 
            this.buttonEditOrders.AutoSize = false;
            this.buttonEditOrders.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEditOrders.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.buttonEditOrders.Depth = 0;
            this.buttonEditOrders.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEditOrders.HighEmphasis = true;
            this.buttonEditOrders.Icon = null;
            this.buttonEditOrders.Location = new System.Drawing.Point(0, 360);
            this.buttonEditOrders.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.buttonEditOrders.MouseState = MaterialSkin.MouseState.HOVER;
            this.buttonEditOrders.Name = "buttonEditOrders";
            this.buttonEditOrders.NoAccentTextColor = System.Drawing.Color.Empty;
            this.buttonEditOrders.Size = new System.Drawing.Size(786, 32);
            this.buttonEditOrders.TabIndex = 2;
            this.buttonEditOrders.Text = "Edit Order";
            this.buttonEditOrders.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.buttonEditOrders.UseAccentColor = false;
            this.buttonEditOrders.UseVisualStyleBackColor = true;
            this.buttonEditOrders.Click += new System.EventHandler(this.buttonEditOrders_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderId,
            this.dataGridViewTextBoxColumn1,
            this.typeOfWork,
            this.dataGridViewTextBoxColumn2,
            this.dateOfWork,
            this.createDate,
            this.toComplete});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(1);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(786, 360);
            this.dataGridView3.TabIndex = 1;
            // 
            // OrderId
            // 
            this.OrderId.HeaderText = "ID";
            this.OrderId.Name = "OrderId";
            this.OrderId.Width = 50;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // typeOfWork
            // 
            this.typeOfWork.HeaderText = "Type";
            this.typeOfWork.Name = "typeOfWork";
            this.typeOfWork.Width = 95;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Status";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 70;
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
            this.createDate.Width = 120;
            // 
            // toComplete
            // 
            this.toComplete.HeaderText = "To Complete";
            this.toComplete.Name = "toComplete";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "account-group.png");
            this.imageList1.Images.SetKeyName(1, "account-hard-hat.png");
            this.imageList1.Images.SetKeyName(2, "account-star.png");
            this.imageList1.Images.SetKeyName(3, "listIcon.png");
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TabControl);
            this.DrawerAutoShow = true;
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabControl;
            this.FormStyle = MaterialSkin.Controls.MaterialForm.FormStyles.ActionBar_None;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.Padding = new System.Windows.Forms.Padding(3, 24, 3, 3);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.TabControl.ResumeLayout(false);
            this.tabDeleteClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabEditTeams.ResumeLayout(false);
            this.tabEditTeams.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabEditClients.ResumeLayout(false);
            this.tabEditOrders.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabControl;
        private System.Windows.Forms.TabPage tabDeleteClients;
        private System.Windows.Forms.TabPage tabEditClients;
        private System.Windows.Forms.TabPage tabEditTeams;
        private System.Windows.Forms.TabPage tabEditOrders;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullAddress;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialButton deleteTeamButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialButton addWorkerButton;
        private MaterialSkin.Controls.MaterialTextBox boxSalary;
        private MaterialSkin.Controls.MaterialTextBox boxPhone;
        private MaterialSkin.Controls.MaterialTextBox boxLastName;
        private MaterialSkin.Controls.MaterialTextBox boxFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private MaterialSkin.Controls.MaterialButton buttonSaveChanges;
        private MaterialSkin.Controls.MaterialTextBox2 boxClientRegion;
        private MaterialSkin.Controls.MaterialTextBox2 boxClientCity;
        private MaterialSkin.Controls.MaterialTextBox2 boxClientFullAdress;
        private MaterialSkin.Controls.MaterialTextBox2 boxClientPhone;
        private MaterialSkin.Controls.MaterialTextBox2 boxClientLastName;
        private MaterialSkin.Controls.MaterialTextBox2 boxClientFirstName;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox2 boxClientId;
        private System.Windows.Forms.DataGridView dataGridView3;
        private MaterialSkin.Controls.MaterialButton buttonEditOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn createDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn toComplete;
        private MaterialSkin.Controls.MaterialButton addTeamButton;
    }
}