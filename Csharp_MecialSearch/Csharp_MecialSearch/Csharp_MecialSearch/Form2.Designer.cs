namespace Csharp_MecialSearch
{
    partial class Form2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.general = new System.Windows.Forms.TabPage();
            this.genNumCallsBox = new System.Windows.Forms.TextBox();
            this.genNumMemBox = new System.Windows.Forms.TextBox();
            this.genDescBox = new System.Windows.Forms.TextBox();
            this.genEmailBox = new System.Windows.Forms.TextBox();
            this.genWebBox = new System.Windows.Forms.TextBox();
            this.genNameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.TabPage();
            this.locFaxChange = new System.Windows.Forms.Label();
            this.locLongChange = new System.Windows.Forms.Label();
            this.locLatChange = new System.Windows.Forms.Label();
            this.locTTYChange = new System.Windows.Forms.Label();
            this.locPhoneChange = new System.Windows.Forms.Label();
            this.locZipChange = new System.Windows.Forms.Label();
            this.locStateChange = new System.Windows.Forms.Label();
            this.locCityChange = new System.Windows.Forms.Label();
            this.locAddress2Change = new System.Windows.Forms.Label();
            this.locAddress1Change = new System.Windows.Forms.Label();
            this.locFax = new System.Windows.Forms.Label();
            this.locLong = new System.Windows.Forms.Label();
            this.locLat = new System.Windows.Forms.Label();
            this.locTTYPhone = new System.Windows.Forms.Label();
            this.locPhone = new System.Windows.Forms.Label();
            this.locZip = new System.Windows.Forms.Label();
            this.locState = new System.Windows.Forms.Label();
            this.locCity = new System.Windows.Forms.Label();
            this.locAddress2 = new System.Windows.Forms.Label();
            this.locAddress1 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.ComboBox();
            this.treatment = new System.Windows.Forms.TabPage();
            this.treatGrid = new System.Windows.Forms.DataGridView();
            this.training = new System.Windows.Forms.TabPage();
            this.trainGrid = new System.Windows.Forms.DataGridView();
            this.facilities = new System.Windows.Forms.TabPage();
            this.facGrid = new System.Windows.Forms.DataGridView();
            this.equipment = new System.Windows.Forms.TabPage();
            this.equipGrid = new System.Windows.Forms.DataGridView();
            this.physician = new System.Windows.Forms.TabPage();
            this.phyGrid = new System.Windows.Forms.DataGridView();
            this.people = new System.Windows.Forms.TabPage();
            this.addressBox = new System.Windows.Forms.ComboBox();
            this.peopleGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.general.SuspendLayout();
            this.location.SuspendLayout();
            this.treatment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.treatGrid)).BeginInit();
            this.training.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trainGrid)).BeginInit();
            this.facilities.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.facGrid)).BeginInit();
            this.equipment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipGrid)).BeginInit();
            this.physician.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phyGrid)).BeginInit();
            this.people.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peopleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.general);
            this.tabControl1.Controls.Add(this.location);
            this.tabControl1.Controls.Add(this.treatment);
            this.tabControl1.Controls.Add(this.training);
            this.tabControl1.Controls.Add(this.facilities);
            this.tabControl1.Controls.Add(this.equipment);
            this.tabControl1.Controls.Add(this.physician);
            this.tabControl1.Controls.Add(this.people);
            this.tabControl1.Location = new System.Drawing.Point(43, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(575, 302);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // general
            // 
            this.general.Controls.Add(this.genNumCallsBox);
            this.general.Controls.Add(this.genNumMemBox);
            this.general.Controls.Add(this.genDescBox);
            this.general.Controls.Add(this.genEmailBox);
            this.general.Controls.Add(this.genWebBox);
            this.general.Controls.Add(this.genNameBox);
            this.general.Controls.Add(this.label6);
            this.general.Controls.Add(this.label5);
            this.general.Controls.Add(this.label4);
            this.general.Controls.Add(this.label3);
            this.general.Controls.Add(this.label2);
            this.general.Controls.Add(this.label1);
            this.general.Location = new System.Drawing.Point(4, 22);
            this.general.Name = "general";
            this.general.Padding = new System.Windows.Forms.Padding(3);
            this.general.Size = new System.Drawing.Size(567, 276);
            this.general.TabIndex = 0;
            this.general.Text = "General";
            this.general.UseVisualStyleBackColor = true;
            // 
            // genNumCallsBox
            // 
            this.genNumCallsBox.Location = new System.Drawing.Point(111, 139);
            this.genNumCallsBox.Name = "genNumCallsBox";
            this.genNumCallsBox.ReadOnly = true;
            this.genNumCallsBox.Size = new System.Drawing.Size(171, 20);
            this.genNumCallsBox.TabIndex = 12;
            // 
            // genNumMemBox
            // 
            this.genNumMemBox.Location = new System.Drawing.Point(111, 115);
            this.genNumMemBox.Name = "genNumMemBox";
            this.genNumMemBox.ReadOnly = true;
            this.genNumMemBox.Size = new System.Drawing.Size(171, 20);
            this.genNumMemBox.TabIndex = 11;
            // 
            // genDescBox
            // 
            this.genDescBox.Location = new System.Drawing.Point(111, 94);
            this.genDescBox.Name = "genDescBox";
            this.genDescBox.ReadOnly = true;
            this.genDescBox.Size = new System.Drawing.Size(171, 20);
            this.genDescBox.TabIndex = 10;
            // 
            // genEmailBox
            // 
            this.genEmailBox.Location = new System.Drawing.Point(111, 47);
            this.genEmailBox.Name = "genEmailBox";
            this.genEmailBox.ReadOnly = true;
            this.genEmailBox.Size = new System.Drawing.Size(171, 20);
            this.genEmailBox.TabIndex = 9;
            // 
            // genWebBox
            // 
            this.genWebBox.Location = new System.Drawing.Point(111, 70);
            this.genWebBox.Name = "genWebBox";
            this.genWebBox.ReadOnly = true;
            this.genWebBox.Size = new System.Drawing.Size(171, 20);
            this.genWebBox.TabIndex = 8;
            // 
            // genNameBox
            // 
            this.genNameBox.Location = new System.Drawing.Point(111, 24);
            this.genNameBox.Name = "genNameBox";
            this.genNameBox.ReadOnly = true;
            this.genNameBox.Size = new System.Drawing.Size(171, 20);
            this.genNameBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "NumCalls:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "NumMembers:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Website:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // location
            // 
            this.location.Controls.Add(this.locFaxChange);
            this.location.Controls.Add(this.locLongChange);
            this.location.Controls.Add(this.locLatChange);
            this.location.Controls.Add(this.locTTYChange);
            this.location.Controls.Add(this.locPhoneChange);
            this.location.Controls.Add(this.locZipChange);
            this.location.Controls.Add(this.locStateChange);
            this.location.Controls.Add(this.locCityChange);
            this.location.Controls.Add(this.locAddress2Change);
            this.location.Controls.Add(this.locAddress1Change);
            this.location.Controls.Add(this.locFax);
            this.location.Controls.Add(this.locLong);
            this.location.Controls.Add(this.locLat);
            this.location.Controls.Add(this.locTTYPhone);
            this.location.Controls.Add(this.locPhone);
            this.location.Controls.Add(this.locZip);
            this.location.Controls.Add(this.locState);
            this.location.Controls.Add(this.locCity);
            this.location.Controls.Add(this.locAddress2);
            this.location.Controls.Add(this.locAddress1);
            this.location.Controls.Add(this.locationBox);
            this.location.Location = new System.Drawing.Point(4, 22);
            this.location.Name = "location";
            this.location.Padding = new System.Windows.Forms.Padding(3);
            this.location.Size = new System.Drawing.Size(567, 276);
            this.location.TabIndex = 1;
            this.location.Text = "Location";
            this.location.UseVisualStyleBackColor = true;
            // 
            // locFaxChange
            // 
            this.locFaxChange.AutoSize = true;
            this.locFaxChange.Location = new System.Drawing.Point(322, 138);
            this.locFaxChange.Name = "locFaxChange";
            this.locFaxChange.Size = new System.Drawing.Size(27, 13);
            this.locFaxChange.TabIndex = 20;
            this.locFaxChange.Text = "Fax:";
            // 
            // locLongChange
            // 
            this.locLongChange.AutoSize = true;
            this.locLongChange.Location = new System.Drawing.Point(322, 164);
            this.locLongChange.Name = "locLongChange";
            this.locLongChange.Size = new System.Drawing.Size(57, 13);
            this.locLongChange.TabIndex = 19;
            this.locLongChange.Text = "Longitude:";
            // 
            // locLatChange
            // 
            this.locLatChange.AutoSize = true;
            this.locLatChange.Location = new System.Drawing.Point(322, 151);
            this.locLatChange.Name = "locLatChange";
            this.locLatChange.Size = new System.Drawing.Size(48, 13);
            this.locLatChange.TabIndex = 18;
            this.locLatChange.Text = "Latitude:";
            // 
            // locTTYChange
            // 
            this.locTTYChange.AutoSize = true;
            this.locTTYChange.Location = new System.Drawing.Point(322, 125);
            this.locTTYChange.Name = "locTTYChange";
            this.locTTYChange.Size = new System.Drawing.Size(31, 13);
            this.locTTYChange.TabIndex = 17;
            this.locTTYChange.Text = "TTY:";
            // 
            // locPhoneChange
            // 
            this.locPhoneChange.AutoSize = true;
            this.locPhoneChange.Location = new System.Drawing.Point(322, 112);
            this.locPhoneChange.Name = "locPhoneChange";
            this.locPhoneChange.Size = new System.Drawing.Size(41, 13);
            this.locPhoneChange.TabIndex = 16;
            this.locPhoneChange.Text = "Phone:";
            // 
            // locZipChange
            // 
            this.locZipChange.AutoSize = true;
            this.locZipChange.Location = new System.Drawing.Point(322, 99);
            this.locZipChange.Name = "locZipChange";
            this.locZipChange.Size = new System.Drawing.Size(53, 13);
            this.locZipChange.TabIndex = 15;
            this.locZipChange.Text = "Zip Code:";
            // 
            // locStateChange
            // 
            this.locStateChange.AutoSize = true;
            this.locStateChange.Location = new System.Drawing.Point(322, 86);
            this.locStateChange.Name = "locStateChange";
            this.locStateChange.Size = new System.Drawing.Size(35, 13);
            this.locStateChange.TabIndex = 14;
            this.locStateChange.Text = "State:";
            // 
            // locCityChange
            // 
            this.locCityChange.AutoSize = true;
            this.locCityChange.Location = new System.Drawing.Point(322, 73);
            this.locCityChange.Name = "locCityChange";
            this.locCityChange.Size = new System.Drawing.Size(27, 13);
            this.locCityChange.TabIndex = 13;
            this.locCityChange.Text = "City:";
            // 
            // locAddress2Change
            // 
            this.locAddress2Change.AutoSize = true;
            this.locAddress2Change.Location = new System.Drawing.Point(322, 60);
            this.locAddress2Change.Name = "locAddress2Change";
            this.locAddress2Change.Size = new System.Drawing.Size(54, 13);
            this.locAddress2Change.TabIndex = 12;
            this.locAddress2Change.Text = "Address2:";
            // 
            // locAddress1Change
            // 
            this.locAddress1Change.AutoSize = true;
            this.locAddress1Change.Location = new System.Drawing.Point(322, 47);
            this.locAddress1Change.Name = "locAddress1Change";
            this.locAddress1Change.Size = new System.Drawing.Size(54, 13);
            this.locAddress1Change.TabIndex = 11;
            this.locAddress1Change.Text = "Address1:";
            // 
            // locFax
            // 
            this.locFax.AutoSize = true;
            this.locFax.Location = new System.Drawing.Point(262, 138);
            this.locFax.Name = "locFax";
            this.locFax.Size = new System.Drawing.Size(27, 13);
            this.locFax.TabIndex = 10;
            this.locFax.Text = "Fax:";
            // 
            // locLong
            // 
            this.locLong.AutoSize = true;
            this.locLong.Location = new System.Drawing.Point(262, 164);
            this.locLong.Name = "locLong";
            this.locLong.Size = new System.Drawing.Size(57, 13);
            this.locLong.TabIndex = 9;
            this.locLong.Text = "Longitude:";
            // 
            // locLat
            // 
            this.locLat.AutoSize = true;
            this.locLat.Location = new System.Drawing.Point(262, 151);
            this.locLat.Name = "locLat";
            this.locLat.Size = new System.Drawing.Size(48, 13);
            this.locLat.TabIndex = 8;
            this.locLat.Text = "Latitude:";
            // 
            // locTTYPhone
            // 
            this.locTTYPhone.AutoSize = true;
            this.locTTYPhone.Location = new System.Drawing.Point(262, 125);
            this.locTTYPhone.Name = "locTTYPhone";
            this.locTTYPhone.Size = new System.Drawing.Size(31, 13);
            this.locTTYPhone.TabIndex = 7;
            this.locTTYPhone.Text = "TTY:";
            // 
            // locPhone
            // 
            this.locPhone.AutoSize = true;
            this.locPhone.Location = new System.Drawing.Point(262, 112);
            this.locPhone.Name = "locPhone";
            this.locPhone.Size = new System.Drawing.Size(41, 13);
            this.locPhone.TabIndex = 6;
            this.locPhone.Text = "Phone:";
            // 
            // locZip
            // 
            this.locZip.AutoSize = true;
            this.locZip.Location = new System.Drawing.Point(262, 99);
            this.locZip.Name = "locZip";
            this.locZip.Size = new System.Drawing.Size(53, 13);
            this.locZip.TabIndex = 5;
            this.locZip.Text = "Zip Code:";
            // 
            // locState
            // 
            this.locState.AutoSize = true;
            this.locState.Location = new System.Drawing.Point(262, 86);
            this.locState.Name = "locState";
            this.locState.Size = new System.Drawing.Size(35, 13);
            this.locState.TabIndex = 4;
            this.locState.Text = "State:";
            // 
            // locCity
            // 
            this.locCity.AutoSize = true;
            this.locCity.Location = new System.Drawing.Point(262, 73);
            this.locCity.Name = "locCity";
            this.locCity.Size = new System.Drawing.Size(27, 13);
            this.locCity.TabIndex = 3;
            this.locCity.Text = "City:";
            // 
            // locAddress2
            // 
            this.locAddress2.AutoSize = true;
            this.locAddress2.Location = new System.Drawing.Point(262, 60);
            this.locAddress2.Name = "locAddress2";
            this.locAddress2.Size = new System.Drawing.Size(54, 13);
            this.locAddress2.TabIndex = 2;
            this.locAddress2.Text = "Address2:";
            // 
            // locAddress1
            // 
            this.locAddress1.AutoSize = true;
            this.locAddress1.Location = new System.Drawing.Point(262, 47);
            this.locAddress1.Name = "locAddress1";
            this.locAddress1.Size = new System.Drawing.Size(54, 13);
            this.locAddress1.TabIndex = 1;
            this.locAddress1.Text = "Address1:";
            // 
            // locationBox
            // 
            this.locationBox.FormattingEnabled = true;
            this.locationBox.Location = new System.Drawing.Point(395, 19);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(121, 21);
            this.locationBox.TabIndex = 0;
            this.locationBox.SelectedIndexChanged += new System.EventHandler(this.locationBox_SelectedIndexChanged);
            // 
            // treatment
            // 
            this.treatment.Controls.Add(this.treatGrid);
            this.treatment.Location = new System.Drawing.Point(4, 22);
            this.treatment.Name = "treatment";
            this.treatment.Padding = new System.Windows.Forms.Padding(3);
            this.treatment.Size = new System.Drawing.Size(567, 276);
            this.treatment.TabIndex = 2;
            this.treatment.Text = "Treatment";
            this.treatment.UseVisualStyleBackColor = true;
            // 
            // treatGrid
            // 
            this.treatGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.treatGrid.Location = new System.Drawing.Point(3, 3);
            this.treatGrid.Name = "treatGrid";
            this.treatGrid.Size = new System.Drawing.Size(561, 270);
            this.treatGrid.TabIndex = 0;
            // 
            // training
            // 
            this.training.Controls.Add(this.trainGrid);
            this.training.Location = new System.Drawing.Point(4, 22);
            this.training.Name = "training";
            this.training.Padding = new System.Windows.Forms.Padding(3);
            this.training.Size = new System.Drawing.Size(567, 276);
            this.training.TabIndex = 3;
            this.training.Text = "Training";
            this.training.UseVisualStyleBackColor = true;
            // 
            // trainGrid
            // 
            this.trainGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.trainGrid.Location = new System.Drawing.Point(3, 3);
            this.trainGrid.Name = "trainGrid";
            this.trainGrid.Size = new System.Drawing.Size(561, 270);
            this.trainGrid.TabIndex = 1;
            // 
            // facilities
            // 
            this.facilities.Controls.Add(this.facGrid);
            this.facilities.Location = new System.Drawing.Point(4, 22);
            this.facilities.Name = "facilities";
            this.facilities.Padding = new System.Windows.Forms.Padding(3);
            this.facilities.Size = new System.Drawing.Size(567, 276);
            this.facilities.TabIndex = 4;
            this.facilities.Text = "Facilities";
            this.facilities.UseVisualStyleBackColor = true;
            // 
            // facGrid
            // 
            this.facGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facGrid.Location = new System.Drawing.Point(3, 3);
            this.facGrid.Name = "facGrid";
            this.facGrid.Size = new System.Drawing.Size(561, 270);
            this.facGrid.TabIndex = 1;
            // 
            // equipment
            // 
            this.equipment.Controls.Add(this.equipGrid);
            this.equipment.Location = new System.Drawing.Point(4, 22);
            this.equipment.Name = "equipment";
            this.equipment.Padding = new System.Windows.Forms.Padding(3);
            this.equipment.Size = new System.Drawing.Size(567, 276);
            this.equipment.TabIndex = 5;
            this.equipment.Text = "Equipment";
            this.equipment.UseVisualStyleBackColor = true;
            // 
            // equipGrid
            // 
            this.equipGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipGrid.Location = new System.Drawing.Point(3, 3);
            this.equipGrid.Name = "equipGrid";
            this.equipGrid.Size = new System.Drawing.Size(561, 270);
            this.equipGrid.TabIndex = 1;
            // 
            // physician
            // 
            this.physician.Controls.Add(this.phyGrid);
            this.physician.Location = new System.Drawing.Point(4, 22);
            this.physician.Name = "physician";
            this.physician.Padding = new System.Windows.Forms.Padding(3);
            this.physician.Size = new System.Drawing.Size(567, 276);
            this.physician.TabIndex = 6;
            this.physician.Text = "Physician";
            this.physician.UseVisualStyleBackColor = true;
            // 
            // phyGrid
            // 
            this.phyGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.phyGrid.Location = new System.Drawing.Point(3, 3);
            this.phyGrid.Name = "phyGrid";
            this.phyGrid.Size = new System.Drawing.Size(561, 270);
            this.phyGrid.TabIndex = 1;
            // 
            // people
            // 
            this.people.Controls.Add(this.peopleGrid);
            this.people.Controls.Add(this.addressBox);
            this.people.Location = new System.Drawing.Point(4, 22);
            this.people.Name = "people";
            this.people.Padding = new System.Windows.Forms.Padding(3);
            this.people.Size = new System.Drawing.Size(567, 276);
            this.people.TabIndex = 7;
            this.people.Text = "People";
            this.people.UseVisualStyleBackColor = true;
            // 
            // addressBox
            // 
            this.addressBox.FormattingEnabled = true;
            this.addressBox.Location = new System.Drawing.Point(26, 27);
            this.addressBox.Name = "addressBox";
            this.addressBox.Size = new System.Drawing.Size(121, 21);
            this.addressBox.TabIndex = 0;
            // 
            // peopleGrid
            // 
            this.peopleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.peopleGrid.Location = new System.Drawing.Point(0, 79);
            this.peopleGrid.Name = "peopleGrid";
            this.peopleGrid.Size = new System.Drawing.Size(567, 197);
            this.peopleGrid.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 358);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.tabControl1.ResumeLayout(false);
            this.general.ResumeLayout(false);
            this.general.PerformLayout();
            this.location.ResumeLayout(false);
            this.location.PerformLayout();
            this.treatment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.treatGrid)).EndInit();
            this.training.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trainGrid)).EndInit();
            this.facilities.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.facGrid)).EndInit();
            this.equipment.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipGrid)).EndInit();
            this.physician.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phyGrid)).EndInit();
            this.people.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peopleGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage general;
        private System.Windows.Forms.TabPage location;
        private System.Windows.Forms.TabPage treatment;
        private System.Windows.Forms.TabPage training;
        private System.Windows.Forms.TabPage facilities;
        private System.Windows.Forms.TabPage equipment;
        private System.Windows.Forms.TabPage physician;
        private System.Windows.Forms.TabPage people;
        private System.Windows.Forms.TextBox genNumCallsBox;
        private System.Windows.Forms.TextBox genNumMemBox;
        private System.Windows.Forms.TextBox genDescBox;
        private System.Windows.Forms.TextBox genEmailBox;
        private System.Windows.Forms.TextBox genWebBox;
        private System.Windows.Forms.TextBox genNameBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox locationBox;
        private System.Windows.Forms.Label locFax;
        private System.Windows.Forms.Label locLong;
        private System.Windows.Forms.Label locLat;
        private System.Windows.Forms.Label locTTYPhone;
        private System.Windows.Forms.Label locPhone;
        private System.Windows.Forms.Label locZip;
        private System.Windows.Forms.Label locState;
        private System.Windows.Forms.Label locCity;
        private System.Windows.Forms.Label locAddress2;
        private System.Windows.Forms.Label locAddress1;
        private System.Windows.Forms.Label locFaxChange;
        private System.Windows.Forms.Label locLongChange;
        private System.Windows.Forms.Label locLatChange;
        private System.Windows.Forms.Label locTTYChange;
        private System.Windows.Forms.Label locPhoneChange;
        private System.Windows.Forms.Label locZipChange;
        private System.Windows.Forms.Label locStateChange;
        private System.Windows.Forms.Label locCityChange;
        private System.Windows.Forms.Label locAddress2Change;
        private System.Windows.Forms.Label locAddress1Change;
        private System.Windows.Forms.DataGridView treatGrid;
        private System.Windows.Forms.DataGridView trainGrid;
        private System.Windows.Forms.DataGridView facGrid;
        private System.Windows.Forms.DataGridView equipGrid;
        private System.Windows.Forms.DataGridView phyGrid;
        private System.Windows.Forms.DataGridView peopleGrid;
        private System.Windows.Forms.ComboBox addressBox;
    }
}