namespace CarCareServiceCenter
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSaveProgress = new System.Windows.Forms.Button();
            this.textBoxAdditionalRepairs = new System.Windows.Forms.TextBox();
            this.dateTimePickerCollectionTime = new System.Windows.Forms.DateTimePicker();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.dataGridViewInventory = new System.Windows.Forms.TabPage();
            this.btnRequestPart = new System.Windows.Forms.Button();
            this.comboBoxPartName = new System.Windows.Forms.ComboBox();
            this.textBoxPartQuantity = new System.Windows.Forms.TextBox();
            this.dataGridViewInventoryList = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.headerPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.dataGridViewInventory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryList)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();

            // headerPanel
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Location = new System.Drawing.Point(0, 1);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 50);
            this.headerPanel.TabIndex = 0;

            // label1
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(44, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(711, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "CarCare Service Center - Mechanic - ABISH";

            // tabControl1
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.dataGridViewInventory);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 57);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(788, 381);
            this.tabControl1.TabIndex = 1;

            // tabPage1 - View Tasks
            this.tabPage1.Controls.Add(this.btnRefresh);
            this.tabPage1.Controls.Add(this.dataGridViewTasks);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(780, 352);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "View Tasks";
            this.tabPage1.UseVisualStyleBackColor = true;

            // btnRefresh
            this.btnRefresh.Location = new System.Drawing.Point(72, 193);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;

            // dataGridViewTasks
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Location = new System.Drawing.Point(6, 6);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            this.dataGridViewTasks.RowHeadersWidth = 51;
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewTasks.TabIndex = 0;

            // tabPage2 - Record Progress
            this.tabPage2.Controls.Add(this.btnSaveProgress);
            this.tabPage2.Controls.Add(this.textBoxAdditionalRepairs);
            this.tabPage2.Controls.Add(this.dateTimePickerCollectionTime);
            this.tabPage2.Controls.Add(this.comboBoxStatus);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(780, 352);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Record Progress";
            this.tabPage2.UseVisualStyleBackColor = true;

            // btnSaveProgress
            this.btnSaveProgress.Location = new System.Drawing.Point(34, 291);
            this.btnSaveProgress.Name = "btnSaveProgress";
            this.btnSaveProgress.Size = new System.Drawing.Size(117, 32);
            this.btnSaveProgress.TabIndex = 3;
            this.btnSaveProgress.Text = "Save Progress";
            this.btnSaveProgress.UseVisualStyleBackColor = true;

            // textBoxAdditionalRepairs
            this.textBoxAdditionalRepairs.Location = new System.Drawing.Point(165, 194);
            this.textBoxAdditionalRepairs.Name = "textBoxAdditionalRepairs";
            this.textBoxAdditionalRepairs.Size = new System.Drawing.Size(100, 22);
            this.textBoxAdditionalRepairs.TabIndex = 2;

            // dateTimePickerCollectionTime
            this.dateTimePickerCollectionTime.Location = new System.Drawing.Point(15, 15);
            this.dateTimePickerCollectionTime.Name = "dateTimePickerCollectionTime";
            this.dateTimePickerCollectionTime.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerCollectionTime.TabIndex = 1;

            // comboBoxStatus
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "In Progress",
            "Completed",
            "Pending"});
            this.comboBoxStatus.Location = new System.Drawing.Point(15, 192);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(121, 24);
            this.comboBoxStatus.TabIndex = 0;

            // dataGridViewInventory - Manage Inventory
            this.dataGridViewInventory.Controls.Add(this.btnRequestPart);
            this.dataGridViewInventory.Controls.Add(this.comboBoxPartName);
            this.dataGridViewInventory.Controls.Add(this.textBoxPartQuantity);
            this.dataGridViewInventory.Controls.Add(this.dataGridViewInventoryList);
            this.dataGridViewInventory.Location = new System.Drawing.Point(4, 25);
            this.dataGridViewInventory.Name = "dataGridViewInventory";
            this.dataGridViewInventory.Padding = new System.Windows.Forms.Padding(3);
            this.dataGridViewInventory.Size = new System.Drawing.Size(780, 352);
            this.dataGridViewInventory.TabIndex = 2;
            this.dataGridViewInventory.Text = "Manage Inventory";
            this.dataGridViewInventory.UseVisualStyleBackColor = true;

            // btnRequestPart
            this.btnRequestPart.Location = new System.Drawing.Point(298, 248);
            this.btnRequestPart.Name = "btnRequestPart";
            this.btnRequestPart.Size = new System.Drawing.Size(98, 32);
            this.btnRequestPart.TabIndex = 3;
            this.btnRequestPart.Text = "Request Part";
            this.btnRequestPart.UseVisualStyleBackColor = true;

            // comboBoxPartName
            this.comboBoxPartName.FormattingEnabled = true;
            this.comboBoxPartName.Items.AddRange(new object[] {
            "Oil Filter",
            "Brake Pad",
            "Air Filter"});
            this.comboBoxPartName.Location = new System.Drawing.Point(275, 132);
            this.comboBoxPartName.Name = "comboBoxPartName";
            this.comboBoxPartName.Size = new System.Drawing.Size(121, 24);
            this.comboBoxPartName.TabIndex = 2;

            // textBoxPartQuantity
            this.textBoxPartQuantity.Location = new System.Drawing.Point(275, 49);
            this.textBoxPartQuantity.Name = "textBoxPartQuantity";
            this.textBoxPartQuantity.Size = new System.Drawing.Size(100, 22);
            this.textBoxPartQuantity.TabIndex = 1;

            // dataGridViewInventoryList
            this.dataGridViewInventoryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInventoryList.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewInventoryList.Name = "dataGridViewInventoryList";
            this.dataGridViewInventoryList.RowHeadersWidth = 51;
            this.dataGridViewInventoryList.RowTemplate.Height = 24;
            this.dataGridViewInventoryList.Size = new System.Drawing.Size(240, 150);
            this.dataGridViewInventoryList.TabIndex = 0;

            // tabPage4 - Update Profile
            this.tabPage4.Controls.Add(this.btnSaveProfile);
            this.tabPage4.Controls.Add(this.textBoxPhone);
            this.tabPage4.Controls.Add(this.textBoxEmail);
            this.tabPage4.Controls.Add(this.textBoxName);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(780, 352);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Update Profile";
            this.tabPage4.UseVisualStyleBackColor = true;

            // btnSaveProfile
            this.btnSaveProfile.Location = new System.Drawing.Point(79, 244);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(101, 34);
            this.btnSaveProfile.TabIndex = 3;
            this.btnSaveProfile.Text = "Save Profile";
            this.btnSaveProfile.UseVisualStyleBackColor = true;

            // textBoxPhone
            this.textBoxPhone.Location = new System.Drawing.Point(53, 159);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(100, 22);
            this.textBoxPhone.TabIndex = 2;

            // textBoxEmail
            this.textBoxEmail.Location = new System.Drawing.Point(53, 94);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(100, 22);
            this.textBoxEmail.TabIndex = 1;

            // textBoxName
            this.textBoxName.Location = new System.Drawing.Point(53, 34);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 0;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Mechanic";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.dataGridViewInventory.ResumeLayout(false);
            this.dataGridViewInventory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInventoryList)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.TabPage dataGridViewInventory;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBoxAdditionalRepairs;
        private System.Windows.Forms.DateTimePicker dateTimePickerCollectionTime;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnSaveProgress;
        private System.Windows.Forms.DataGridView dataGridViewInventoryList;
        private System.Windows.Forms.TextBox textBoxPartQuantity;
        private System.Windows.Forms.ComboBox comboBoxPartName;
        private System.Windows.Forms.Button btnRequestPart;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.TextBox textBoxPhone;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxName;
    }
}
