namespace Admin_Weather
{
    partial class ViewAndEdit
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
            this.grbEdit = new System.Windows.Forms.GroupBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.txt_Position = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtWind = new System.Windows.Forms.TextBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtPrecipitation = new System.Windows.Forms.TextBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.lblWind = new System.Windows.Forms.Label();
            this.lblHumidity = new System.Windows.Forms.Label();
            this.lblPrecipitation = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel_DataHolder = new System.Windows.Forms.Panel();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.lblMax = new System.Windows.Forms.Label();
            this.btnEditor = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblCityName = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnViewEdited = new System.Windows.Forms.Button();
            this.btnEditData = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.web_Dataholder = new System.Windows.Forms.WebBrowser();
            this.label1 = new System.Windows.Forms.Label();
            this.grbEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.btnEditData.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbEdit
            // 
            this.grbEdit.Controls.Add(this.btn_reset);
            this.grbEdit.Controls.Add(this.txt_Position);
            this.grbEdit.Controls.Add(this.lblCity);
            this.grbEdit.Controls.Add(this.btnSearch);
            this.grbEdit.Location = new System.Drawing.Point(853, 133);
            this.grbEdit.Name = "grbEdit";
            this.grbEdit.Size = new System.Drawing.Size(341, 99);
            this.grbEdit.TabIndex = 23;
            this.grbEdit.TabStop = false;
            this.grbEdit.Text = "Select City using position:";
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(86, 55);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(86, 38);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // txt_Position
            // 
            this.txt_Position.Location = new System.Drawing.Point(169, 29);
            this.txt_Position.Name = "txt_Position";
            this.txt_Position.Size = new System.Drawing.Size(145, 20);
            this.txt_Position.TabIndex = 8;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(83, 36);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(64, 13);
            this.lblCity.TabIndex = 7;
            this.lblCity.Text = "City Position";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(224, 55);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 38);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search City";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(169, 64);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(145, 20);
            this.dtpDate.TabIndex = 13;
            // 
            // txtWind
            // 
            this.txtWind.Location = new System.Drawing.Point(169, 209);
            this.txtWind.Name = "txtWind";
            this.txtWind.Size = new System.Drawing.Size(145, 20);
            this.txtWind.TabIndex = 12;
            // 
            // txtMax
            // 
            this.txtMax.Location = new System.Drawing.Point(169, 125);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(145, 20);
            this.txtMax.TabIndex = 11;
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(169, 97);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(145, 20);
            this.txtMin.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(169, 31);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(145, 20);
            this.txtCity.TabIndex = 9;
            // 
            // txtPrecipitation
            // 
            this.txtPrecipitation.Location = new System.Drawing.Point(169, 158);
            this.txtPrecipitation.Name = "txtPrecipitation";
            this.txtPrecipitation.Size = new System.Drawing.Size(145, 20);
            this.txtPrecipitation.TabIndex = 8;
            // 
            // txtHumidity
            // 
            this.txtHumidity.Location = new System.Drawing.Point(169, 184);
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(145, 20);
            this.txtHumidity.TabIndex = 7;
            // 
            // lblWind
            // 
            this.lblWind.AutoSize = true;
            this.lblWind.Location = new System.Drawing.Point(55, 209);
            this.lblWind.Name = "lblWind";
            this.lblWind.Size = new System.Drawing.Size(69, 13);
            this.lblWind.TabIndex = 6;
            this.lblWind.Text = "Wind Speed ";
            // 
            // lblHumidity
            // 
            this.lblHumidity.AutoSize = true;
            this.lblHumidity.Location = new System.Drawing.Point(55, 184);
            this.lblHumidity.Name = "lblHumidity";
            this.lblHumidity.Size = new System.Drawing.Size(47, 13);
            this.lblHumidity.TabIndex = 5;
            this.lblHumidity.Text = "Humidity";
            // 
            // lblPrecipitation
            // 
            this.lblPrecipitation.AutoSize = true;
            this.lblPrecipitation.Location = new System.Drawing.Point(55, 158);
            this.lblPrecipitation.Name = "lblPrecipitation";
            this.lblPrecipitation.Size = new System.Drawing.Size(65, 13);
            this.lblPrecipitation.TabIndex = 4;
            this.lblPrecipitation.Text = "Precipitation";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 130);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(816, 348);
            this.dataGridView1.TabIndex = 19;
            // 
            // panel_DataHolder
            // 
            this.panel_DataHolder.Location = new System.Drawing.Point(12, 130);
            this.panel_DataHolder.Name = "panel_DataHolder";
            this.panel_DataHolder.Size = new System.Drawing.Size(822, 348);
            this.panel_DataHolder.TabIndex = 28;
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(714, 84);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 40);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Clear";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(356, 84);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(120, 40);
            this.btn_refresh.TabIndex = 30;
            this.btn_refresh.Text = "Refresh Data";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(55, 125);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(117, 13);
            this.lblMax.TabIndex = 3;
            this.lblMax.Text = "Maximum Temperature ";
            // 
            // btnEditor
            // 
            this.btnEditor.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditor.Location = new System.Drawing.Point(853, 484);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(110, 40);
            this.btnEditor.TabIndex = 24;
            this.btnEditor.Text = "Update Data";
            this.btnEditor.UseVisualStyleBackColor = true;
            this.btnEditor.Click += new System.EventHandler(this.btnEditor_Click);
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(55, 97);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(114, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minimum Temperature ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(55, 64);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "Date";
            // 
            // lblCityName
            // 
            this.lblCityName.AutoSize = true;
            this.lblCityName.Location = new System.Drawing.Point(55, 31);
            this.lblCityName.Name = "lblCityName";
            this.lblCityName.Size = new System.Drawing.Size(24, 13);
            this.lblCityName.TabIndex = 0;
            this.lblCityName.Text = "City";
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(12, 484);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(120, 40);
            this.btn_back.TabIndex = 29;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Location = new System.Drawing.Point(1106, 84);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(88, 40);
            this.btnLogOut.TabIndex = 27;
            this.btnLogOut.Text = "LogOut";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnViewEdited
            // 
            this.btnViewEdited.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewEdited.Location = new System.Drawing.Point(1083, 484);
            this.btnViewEdited.Name = "btnViewEdited";
            this.btnViewEdited.Size = new System.Drawing.Size(111, 40);
            this.btnViewEdited.TabIndex = 26;
            this.btnViewEdited.Text = "Clear Data";
            this.btnViewEdited.UseVisualStyleBackColor = true;
            this.btnViewEdited.Click += new System.EventHandler(this.btnViewEdited_Click);
            // 
            // btnEditData
            // 
            this.btnEditData.Controls.Add(this.dtpDate);
            this.btnEditData.Controls.Add(this.txtWind);
            this.btnEditData.Controls.Add(this.txtMax);
            this.btnEditData.Controls.Add(this.txtMin);
            this.btnEditData.Controls.Add(this.txtCity);
            this.btnEditData.Controls.Add(this.txtPrecipitation);
            this.btnEditData.Controls.Add(this.txtHumidity);
            this.btnEditData.Controls.Add(this.lblWind);
            this.btnEditData.Controls.Add(this.lblHumidity);
            this.btnEditData.Controls.Add(this.lblPrecipitation);
            this.btnEditData.Controls.Add(this.lblMax);
            this.btnEditData.Controls.Add(this.lblMin);
            this.btnEditData.Controls.Add(this.lblDate);
            this.btnEditData.Controls.Add(this.lblCityName);
            this.btnEditData.Location = new System.Drawing.Point(853, 238);
            this.btnEditData.Name = "btnEditData";
            this.btnEditData.Size = new System.Drawing.Size(341, 240);
            this.btnEditData.TabIndex = 25;
            this.btnEditData.TabStop = false;
            this.btnEditData.Text = "Edit Below:";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(12, 84);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(120, 40);
            this.btnView.TabIndex = 21;
            this.btnView.Text = "View all Data";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // web_Dataholder
            // 
            this.web_Dataholder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_Dataholder.Location = new System.Drawing.Point(0, 0);
            this.web_Dataholder.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_Dataholder.Name = "web_Dataholder";
            this.web_Dataholder.Size = new System.Drawing.Size(1213, 550);
            this.web_Dataholder.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(626, 42);
            this.label1.TabIndex = 31;
            this.label1.Text = "View And Edit Captured Data Here";
            // 
            // ViewAndEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1213, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel_DataHolder);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnViewEdited);
            this.Controls.Add(this.btnEditData);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.web_Dataholder);
            this.Name = "ViewAndEdit";
            this.Text = "ViewAndEdit";
            this.Load += new System.EventHandler(this.ViewAndEdit_Load);
            this.grbEdit.ResumeLayout(false);
            this.grbEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.btnEditData.ResumeLayout(false);
            this.btnEditData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbEdit;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.TextBox txt_Position;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtWind;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtPrecipitation;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.Label lblWind;
        private System.Windows.Forms.Label lblHumidity;
        private System.Windows.Forms.Label lblPrecipitation;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel_DataHolder;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblCityName;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnViewEdited;
        private System.Windows.Forms.GroupBox btnEditData;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.WebBrowser web_Dataholder;
        private System.Windows.Forms.Label label1;
    }
}