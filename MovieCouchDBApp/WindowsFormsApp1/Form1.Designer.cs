namespace WindowsFormsApp1
{
    partial class Form1
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
            this.dataViewAll = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataSelectedMovie = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.reloadDatabase = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblDirector = new System.Windows.Forms.Label();
            this.lblProducer = new System.Windows.Forms.Label();
            this.lblComposer = new System.Windows.Forms.Label();
            this.lblRuntime = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblRev = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtRev = new System.Windows.Forms.TextBox();
            this.txtYr = new System.Windows.Forms.TextBox();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.txtProducer = new System.Windows.Forms.TextBox();
            this.txtComposer = new System.Windows.Forms.TextBox();
            this.txtRuntime = new System.Windows.Forms.TextBox();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtNoInStock = new System.Windows.Forms.TextBox();
            this.grdDataViewChoice = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDoc = new System.Windows.Forms.Label();
            this.txtDoc = new System.Windows.Forms.TextBox();
            this.radMapRedView = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedMovie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewChoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewAll
            // 
            this.dataViewAll.ColumnHeadersHeight = 60;
            this.dataViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataViewAll.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataViewAll.Location = new System.Drawing.Point(1, 12);
            this.dataViewAll.Name = "dataViewAll";
            this.dataViewAll.RowHeadersWidth = 60;
            this.dataViewAll.RowTemplate.Height = 24;
            this.dataViewAll.Size = new System.Drawing.Size(296, 494);
            this.dataViewAll.TabIndex = 0;
            this.dataViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataViewAll_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Film DocumentID Name";
            this.Column1.Name = "Column1";
            // 
            // dataSelectedMovie
            // 
            this.dataSelectedMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSelectedMovie.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column2});
            this.dataSelectedMovie.Location = new System.Drawing.Point(736, 12);
            this.dataSelectedMovie.Name = "dataSelectedMovie";
            this.dataSelectedMovie.RowTemplate.Height = 24;
            this.dataSelectedMovie.Size = new System.Drawing.Size(471, 518);
            this.dataSelectedMovie.TabIndex = 1;
            this.dataSelectedMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSelectedMovie_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Key";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Value";
            this.Column2.Name = "Column2";
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(1, 854);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(296, 46);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(372, 856);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(269, 44);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(674, 858);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(274, 43);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // reloadDatabase
            // 
            this.reloadDatabase.Location = new System.Drawing.Point(977, 856);
            this.reloadDatabase.Name = "reloadDatabase";
            this.reloadDatabase.Size = new System.Drawing.Size(230, 46);
            this.reloadDatabase.TabIndex = 5;
            this.reloadDatabase.Text = "Reload Database";
            this.reloadDatabase.UseVisualStyleBackColor = true;
            this.reloadDatabase.Click += new System.EventHandler(this.ReloadDatabase_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(376, 212);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(376, 263);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(369, 313);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(62, 17);
            this.lblDirector.TabIndex = 8;
            this.lblDirector.Text = "Director:";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(369, 366);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(70, 17);
            this.lblProducer.TabIndex = 9;
            this.lblProducer.Text = "Producer:";
            // 
            // lblComposer
            // 
            this.lblComposer.AutoSize = true;
            this.lblComposer.Location = new System.Drawing.Point(364, 421);
            this.lblComposer.Name = "lblComposer";
            this.lblComposer.Size = new System.Drawing.Size(76, 17);
            this.lblComposer.TabIndex = 10;
            this.lblComposer.Text = "Composer:";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(364, 476);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(93, 17);
            this.lblRuntime.TabIndex = 11;
            this.lblRuntime.Text = "Film Runtime:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(364, 537);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(71, 17);
            this.lblCompany.TabIndex = 12;
            this.lblCompany.Text = "Company:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(364, 594);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(356, 640);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(116, 17);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Number In Stock:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(437, 212);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(269, 22);
            this.txtTitle.TabIndex = 15;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(376, 53);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(27, 17);
            this.lblID.TabIndex = 16;
            this.lblID.Text = "_id";
            // 
            // lblRev
            // 
            this.lblRev.AutoSize = true;
            this.lblRev.Location = new System.Drawing.Point(376, 97);
            this.lblRev.Name = "lblRev";
            this.lblRev.Size = new System.Drawing.Size(36, 17);
            this.lblRev.TabIndex = 17;
            this.lblRev.Text = "_rev";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(437, 50);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(269, 22);
            this.txtID.TabIndex = 18;
            // 
            // txtRev
            // 
            this.txtRev.Location = new System.Drawing.Point(437, 97);
            this.txtRev.Name = "txtRev";
            this.txtRev.Size = new System.Drawing.Size(269, 22);
            this.txtRev.TabIndex = 19;
            // 
            // txtYr
            // 
            this.txtYr.Location = new System.Drawing.Point(437, 263);
            this.txtYr.Name = "txtYr";
            this.txtYr.Size = new System.Drawing.Size(97, 22);
            this.txtYr.TabIndex = 20;
            // 
            // txtDirector
            // 
            this.txtDirector.Location = new System.Drawing.Point(437, 313);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(269, 22);
            this.txtDirector.TabIndex = 21;
            // 
            // txtProducer
            // 
            this.txtProducer.Location = new System.Drawing.Point(437, 366);
            this.txtProducer.Name = "txtProducer";
            this.txtProducer.Size = new System.Drawing.Size(269, 22);
            this.txtProducer.TabIndex = 22;
            // 
            // txtComposer
            // 
            this.txtComposer.Location = new System.Drawing.Point(446, 421);
            this.txtComposer.Name = "txtComposer";
            this.txtComposer.Size = new System.Drawing.Size(260, 22);
            this.txtComposer.TabIndex = 23;
            // 
            // txtRuntime
            // 
            this.txtRuntime.Location = new System.Drawing.Point(464, 476);
            this.txtRuntime.Name = "txtRuntime";
            this.txtRuntime.Size = new System.Drawing.Size(88, 22);
            this.txtRuntime.TabIndex = 24;
            // 
            // txtCompany
            // 
            this.txtCompany.Location = new System.Drawing.Point(437, 537);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(269, 22);
            this.txtCompany.TabIndex = 25;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(424, 594);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(140, 22);
            this.txtPrice.TabIndex = 26;
            // 
            // txtNoInStock
            // 
            this.txtNoInStock.Location = new System.Drawing.Point(478, 640);
            this.txtNoInStock.Name = "txtNoInStock";
            this.txtNoInStock.Size = new System.Drawing.Size(165, 22);
            this.txtNoInStock.TabIndex = 27;
            // 
            // grdDataViewChoice
            // 
            this.grdDataViewChoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDataViewChoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4});
            this.grdDataViewChoice.Location = new System.Drawing.Point(1, 544);
            this.grdDataViewChoice.Name = "grdDataViewChoice";
            this.grdDataViewChoice.RowTemplate.Height = 24;
            this.grdDataViewChoice.Size = new System.Drawing.Size(349, 181);
            this.grdDataViewChoice.TabIndex = 28;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Key";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Value";
            this.Column4.Name = "Column4";
            // 
            // lblDoc
            // 
            this.lblDoc.AutoSize = true;
            this.lblDoc.Location = new System.Drawing.Point(356, 150);
            this.lblDoc.Name = "lblDoc";
            this.lblDoc.Size = new System.Drawing.Size(69, 17);
            this.lblDoc.TabIndex = 29;
            this.lblDoc.Text = "DocType:";
            // 
            // txtDoc
            // 
            this.txtDoc.Location = new System.Drawing.Point(437, 145);
            this.txtDoc.Name = "txtDoc";
            this.txtDoc.Size = new System.Drawing.Size(269, 22);
            this.txtDoc.TabIndex = 30;
            // 
            // radMapRedView
            // 
            this.radMapRedView.AutoSize = true;
            this.radMapRedView.Location = new System.Drawing.Point(82, 748);
            this.radMapRedView.Name = "radMapRedView";
            this.radMapRedView.Size = new System.Drawing.Size(142, 21);
            this.radMapRedView.TabIndex = 31;
            this.radMapRedView.TabStop = true;
            this.radMapRedView.Text = "View MapReduce ";
            this.radMapRedView.UseVisualStyleBackColor = true;
            this.radMapRedView.CheckedChanged += new System.EventHandler(this.radMapRedView_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 902);
            this.Controls.Add(this.radMapRedView);
            this.Controls.Add(this.txtDoc);
            this.Controls.Add(this.lblDoc);
            this.Controls.Add(this.grdDataViewChoice);
            this.Controls.Add(this.txtNoInStock);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.txtRuntime);
            this.Controls.Add(this.txtComposer);
            this.Controls.Add(this.txtProducer);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.txtYr);
            this.Controls.Add(this.txtRev);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblRev);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblCompany);
            this.Controls.Add(this.lblRuntime);
            this.Controls.Add(this.lblComposer);
            this.Controls.Add(this.lblProducer);
            this.Controls.Add(this.lblDirector);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.reloadDatabase);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.createButton);
            this.Controls.Add(this.dataSelectedMovie);
            this.Controls.Add(this.dataViewAll);
            this.Name = "Form1";
            this.Text = "MovieDatabase";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedMovie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdDataViewChoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataViewAll;
        private System.Windows.Forms.DataGridView dataSelectedMovie;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button reloadDatabase;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblDirector;
        private System.Windows.Forms.Label lblProducer;
        private System.Windows.Forms.Label lblComposer;
        private System.Windows.Forms.Label lblRuntime;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblRev;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtRev;
        private System.Windows.Forms.TextBox txtYr;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.TextBox txtProducer;
        private System.Windows.Forms.TextBox txtComposer;
        private System.Windows.Forms.TextBox txtRuntime;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtNoInStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView grdDataViewChoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Label lblDoc;
        private System.Windows.Forms.TextBox txtDoc;
        private System.Windows.Forms.RadioButton radMapRedView;
    }
}

