namespace Inventory_mgmt
{
    partial class Users_page
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
            this.UsersTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OtherNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // UsersTable
            // 
            this.UsersTable.AllowUserToOrderColumns = true;
            this.UsersTable.AllowUserToResizeColumns = false;
            this.UsersTable.AllowUserToResizeRows = false;
            this.UsersTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.UsersTable.ColumnHeadersHeight = 70;
            this.UsersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirstName,
            this.OtherNames,
            this.Password,
            this.Phone,
            this.ActionUpdate});
            this.UsersTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsersTable.GridColor = System.Drawing.Color.Navy;
            this.UsersTable.Location = new System.Drawing.Point(0, 0);
            this.UsersTable.Name = "UsersTable";
            this.UsersTable.RowHeadersVisible = false;
            this.UsersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.UsersTable.RowTemplate.Height = 33;
            this.UsersTable.Size = new System.Drawing.Size(1017, 570);
            this.UsersTable.TabIndex = 0;
            this.UsersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersTable_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 8;
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.MinimumWidth = 8;
            this.FirstName.Name = "FirstName";
            this.FirstName.Width = 180;
            // 
            // OtherNames
            // 
            this.OtherNames.HeaderText = "Other Names";
            this.OtherNames.MinimumWidth = 8;
            this.OtherNames.Name = "OtherNames";
            this.OtherNames.Width = 250;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 8;
            this.Password.Name = "Password";
            this.Password.Width = 250;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone Number";
            this.Phone.MinimumWidth = 8;
            this.Phone.Name = "Phone";
            this.Phone.Width = 180;
            // 
            // ActionUpdate
            // 
            this.ActionUpdate.HeaderText = "Action";
            this.ActionUpdate.MinimumWidth = 8;
            this.ActionUpdate.Name = "ActionUpdate";
            this.ActionUpdate.Width = 150;
            // 
            // Users_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1017, 570);
            this.Controls.Add(this.UsersTable);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Users_page";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView UsersTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OtherNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionUpdate;
    }
}
