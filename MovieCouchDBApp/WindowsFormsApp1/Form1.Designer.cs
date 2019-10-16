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
            this.dataSelectedMovie = new System.Windows.Forms.DataGridView();
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
            ((System.ComponentModel.ISupportInitialize)(this.dataViewAll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // dataViewAll
            // 
            this.dataViewAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataViewAll.Location = new System.Drawing.Point(1, -1);
            this.dataViewAll.Name = "dataViewAll";
            this.dataViewAll.RowTemplate.Height = 24;
            this.dataViewAll.Size = new System.Drawing.Size(240, 624);
            this.dataViewAll.TabIndex = 0;
            this.dataViewAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataViewAll_CellContentClick);
            // 
            // dataSelectedMovie
            // 
            this.dataSelectedMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSelectedMovie.Location = new System.Drawing.Point(245, -1);
            this.dataSelectedMovie.Name = "dataSelectedMovie";
            this.dataSelectedMovie.RowTemplate.Height = 24;
            this.dataSelectedMovie.Size = new System.Drawing.Size(553, 175);
            this.dataSelectedMovie.TabIndex = 1;
            this.dataSelectedMovie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataSelectedMovie_CellContentClick);
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(1, 749);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(155, 60);
            this.createButton.TabIndex = 2;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(192, 749);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(175, 60);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(396, 749);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(175, 60);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // reloadDatabase
            // 
            this.reloadDatabase.Location = new System.Drawing.Point(613, 749);
            this.reloadDatabase.Name = "reloadDatabase";
            this.reloadDatabase.Size = new System.Drawing.Size(175, 60);
            this.reloadDatabase.TabIndex = 5;
            this.reloadDatabase.Text = "Reload Database";
            this.reloadDatabase.UseVisualStyleBackColor = true;
            this.reloadDatabase.Click += new System.EventHandler(this.reloadDatabase_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(261, 193);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(39, 17);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Title:";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(261, 244);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year:";
            // 
            // lblDirector
            // 
            this.lblDirector.AutoSize = true;
            this.lblDirector.Location = new System.Drawing.Point(261, 294);
            this.lblDirector.Name = "lblDirector";
            this.lblDirector.Size = new System.Drawing.Size(62, 17);
            this.lblDirector.TabIndex = 8;
            this.lblDirector.Text = "Director:";
            // 
            // lblProducer
            // 
            this.lblProducer.AutoSize = true;
            this.lblProducer.Location = new System.Drawing.Point(261, 346);
            this.lblProducer.Name = "lblProducer";
            this.lblProducer.Size = new System.Drawing.Size(70, 17);
            this.lblProducer.TabIndex = 9;
            this.lblProducer.Text = "Producer:";
            // 
            // lblComposer
            // 
            this.lblComposer.AutoSize = true;
            this.lblComposer.Location = new System.Drawing.Point(261, 401);
            this.lblComposer.Name = "lblComposer";
            this.lblComposer.Size = new System.Drawing.Size(76, 17);
            this.lblComposer.TabIndex = 10;
            this.lblComposer.Text = "Composer:";
            // 
            // lblRuntime
            // 
            this.lblRuntime.AutoSize = true;
            this.lblRuntime.Location = new System.Drawing.Point(261, 457);
            this.lblRuntime.Name = "lblRuntime";
            this.lblRuntime.Size = new System.Drawing.Size(93, 17);
            this.lblRuntime.TabIndex = 11;
            this.lblRuntime.Text = "Film Runtime:";
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Location = new System.Drawing.Point(261, 516);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(71, 17);
            this.lblCompany.TabIndex = 12;
            this.lblCompany.Text = "Company:";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(261, 579);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 17);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(261, 635);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(116, 17);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Number In Stock:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 811);
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
    }
}

