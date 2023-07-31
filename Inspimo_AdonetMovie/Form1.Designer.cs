namespace Inspimo_AdonetMovie
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
            this.dtgCategory = new System.Windows.Forms.DataGridView();
            this.txtCategoryId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCategoryList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.btnCategorySave = new System.Windows.Forms.Button();
            this.btnCategoryDelete = new System.Windows.Forms.Button();
            this.btnCategoryUpdate = new System.Windows.Forms.Button();
            this.btnMovieUpdate = new System.Windows.Forms.Button();
            this.btnMovieDelete = new System.Windows.Forms.Button();
            this.btnMovieSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.btnMovieList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.dtgMovie = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMovieDuration = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMovieImdb = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCategoryCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnMovieProcedure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgCategory
            // 
            this.dtgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCategory.Location = new System.Drawing.Point(12, 12);
            this.dtgCategory.Name = "dtgCategory";
            this.dtgCategory.Size = new System.Drawing.Size(382, 170);
            this.dtgCategory.TabIndex = 0;
            // 
            // txtCategoryId
            // 
            this.txtCategoryId.Location = new System.Drawing.Point(120, 194);
            this.txtCategoryId.Name = "txtCategoryId";
            this.txtCategoryId.Size = new System.Drawing.Size(189, 20);
            this.txtCategoryId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(35, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori ID:";
            // 
            // btnCategoryList
            // 
            this.btnCategoryList.Location = new System.Drawing.Point(120, 246);
            this.btnCategoryList.Name = "btnCategoryList";
            this.btnCategoryList.Size = new System.Drawing.Size(95, 25);
            this.btnCategoryList.TabIndex = 3;
            this.btnCategoryList.Text = "Listele";
            this.btnCategoryList.UseVisualStyleBackColor = true;
            this.btnCategoryList.Click += new System.EventHandler(this.btnCategoryList_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(29, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kategori Adı:";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(120, 220);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(189, 20);
            this.txtCategoryName.TabIndex = 4;
            // 
            // btnCategorySave
            // 
            this.btnCategorySave.Location = new System.Drawing.Point(217, 246);
            this.btnCategorySave.Name = "btnCategorySave";
            this.btnCategorySave.Size = new System.Drawing.Size(95, 25);
            this.btnCategorySave.TabIndex = 6;
            this.btnCategorySave.Text = "Ekle";
            this.btnCategorySave.UseVisualStyleBackColor = true;
            this.btnCategorySave.Click += new System.EventHandler(this.btnCategorySave_Click);
            // 
            // btnCategoryDelete
            // 
            this.btnCategoryDelete.Location = new System.Drawing.Point(120, 277);
            this.btnCategoryDelete.Name = "btnCategoryDelete";
            this.btnCategoryDelete.Size = new System.Drawing.Size(95, 25);
            this.btnCategoryDelete.TabIndex = 7;
            this.btnCategoryDelete.Text = "Sil";
            this.btnCategoryDelete.UseVisualStyleBackColor = true;
            this.btnCategoryDelete.Click += new System.EventHandler(this.btnCategoryDelete_Click);
            // 
            // btnCategoryUpdate
            // 
            this.btnCategoryUpdate.Location = new System.Drawing.Point(217, 277);
            this.btnCategoryUpdate.Name = "btnCategoryUpdate";
            this.btnCategoryUpdate.Size = new System.Drawing.Size(95, 25);
            this.btnCategoryUpdate.TabIndex = 8;
            this.btnCategoryUpdate.Text = "Güncelle";
            this.btnCategoryUpdate.UseVisualStyleBackColor = true;
            this.btnCategoryUpdate.Click += new System.EventHandler(this.btnCategoryUpdate_Click);
            // 
            // btnMovieUpdate
            // 
            this.btnMovieUpdate.Location = new System.Drawing.Point(677, 357);
            this.btnMovieUpdate.Name = "btnMovieUpdate";
            this.btnMovieUpdate.Size = new System.Drawing.Size(95, 25);
            this.btnMovieUpdate.TabIndex = 17;
            this.btnMovieUpdate.Text = "Güncelle";
            this.btnMovieUpdate.UseVisualStyleBackColor = true;
            this.btnMovieUpdate.Click += new System.EventHandler(this.btnMovieUpdate_Click);
            // 
            // btnMovieDelete
            // 
            this.btnMovieDelete.Location = new System.Drawing.Point(580, 357);
            this.btnMovieDelete.Name = "btnMovieDelete";
            this.btnMovieDelete.Size = new System.Drawing.Size(95, 25);
            this.btnMovieDelete.TabIndex = 16;
            this.btnMovieDelete.Text = "Sil";
            this.btnMovieDelete.UseVisualStyleBackColor = true;
            this.btnMovieDelete.Click += new System.EventHandler(this.btnMovieDelete_Click);
            // 
            // btnMovieSave
            // 
            this.btnMovieSave.Location = new System.Drawing.Point(677, 326);
            this.btnMovieSave.Name = "btnMovieSave";
            this.btnMovieSave.Size = new System.Drawing.Size(95, 25);
            this.btnMovieSave.TabIndex = 15;
            this.btnMovieSave.Text = "Ekle";
            this.btnMovieSave.UseVisualStyleBackColor = true;
            this.btnMovieSave.Click += new System.EventHandler(this.btnMovieSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(510, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Film Adı:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Location = new System.Drawing.Point(580, 220);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(189, 20);
            this.txtMovieName.TabIndex = 13;
            // 
            // btnMovieList
            // 
            this.btnMovieList.Location = new System.Drawing.Point(580, 326);
            this.btnMovieList.Name = "btnMovieList";
            this.btnMovieList.Size = new System.Drawing.Size(95, 25);
            this.btnMovieList.TabIndex = 12;
            this.btnMovieList.Text = "Listele";
            this.btnMovieList.UseVisualStyleBackColor = true;
            this.btnMovieList.Click += new System.EventHandler(this.btnMovieList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(516, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Film ID:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Location = new System.Drawing.Point(580, 194);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(189, 20);
            this.txtMovieID.TabIndex = 10;
            // 
            // dtgMovie
            // 
            this.dtgMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMovie.Location = new System.Drawing.Point(400, 12);
            this.dtgMovie.Name = "dtgMovie";
            this.dtgMovie.Size = new System.Drawing.Size(527, 170);
            this.dtgMovie.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(531, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Süre:";
            // 
            // txtMovieDuration
            // 
            this.txtMovieDuration.Location = new System.Drawing.Point(580, 272);
            this.txtMovieDuration.Name = "txtMovieDuration";
            this.txtMovieDuration.Size = new System.Drawing.Size(189, 20);
            this.txtMovieDuration.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(528, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Puan:";
            // 
            // txtMovieImdb
            // 
            this.txtMovieImdb.Location = new System.Drawing.Point(580, 246);
            this.txtMovieImdb.Name = "txtMovieImdb";
            this.txtMovieImdb.Size = new System.Drawing.Size(189, 20);
            this.txtMovieImdb.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(507, 300);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 18);
            this.label7.TabIndex = 23;
            this.label7.Text = "Kategori:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblCategoryCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Location = new System.Drawing.Point(933, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 122);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(933, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 122);
            this.panel2.TabIndex = 25;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Location = new System.Drawing.Point(933, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(281, 122);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label15);
            this.panel4.Location = new System.Drawing.Point(933, 396);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(281, 122);
            this.panel4.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(93, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Kategori Sayısı";
            // 
            // lblCategoryCount
            // 
            this.lblCategoryCount.AutoSize = true;
            this.lblCategoryCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategoryCount.Location = new System.Drawing.Point(137, 61);
            this.lblCategoryCount.Name = "lblCategoryCount";
            this.lblCategoryCount.Size = new System.Drawing.Size(16, 18);
            this.lblCategoryCount.TabIndex = 28;
            this.lblCategoryCount.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(137, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 18);
            this.label10.TabIndex = 30;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(93, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 18);
            this.label11.TabIndex = 29;
            this.label11.Text = "Kategori Sayısı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(137, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 18);
            this.label12.TabIndex = 32;
            this.label12.Text = "0";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(93, 30);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 18);
            this.label13.TabIndex = 31;
            this.label13.Text = "Kategori Sayısı";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(137, 57);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(16, 18);
            this.label14.TabIndex = 34;
            this.label14.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(93, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 18);
            this.label15.TabIndex = 33;
            this.label15.Text = "Kategori Sayısı";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(581, 299);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(188, 21);
            this.cmbCategory.TabIndex = 27;
            // 
            // btnMovieProcedure
            // 
            this.btnMovieProcedure.Location = new System.Drawing.Point(580, 388);
            this.btnMovieProcedure.Name = "btnMovieProcedure";
            this.btnMovieProcedure.Size = new System.Drawing.Size(95, 25);
            this.btnMovieProcedure.TabIndex = 28;
            this.btnMovieProcedure.Text = "Prosedür";
            this.btnMovieProcedure.UseVisualStyleBackColor = true;
            this.btnMovieProcedure.Click += new System.EventHandler(this.btnMovieProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1226, 531);
            this.Controls.Add(this.btnMovieProcedure);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMovieDuration);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMovieImdb);
            this.Controls.Add(this.btnMovieUpdate);
            this.Controls.Add(this.btnMovieDelete);
            this.Controls.Add(this.btnMovieSave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMovieName);
            this.Controls.Add(this.btnMovieList);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.dtgMovie);
            this.Controls.Add(this.btnCategoryUpdate);
            this.Controls.Add(this.btnCategoryDelete);
            this.Controls.Add(this.btnCategorySave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.btnCategoryList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCategoryId);
            this.Controls.Add(this.dtgCategory);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMovie)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgCategory;
        private System.Windows.Forms.TextBox txtCategoryId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCategoryList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.Button btnCategorySave;
        private System.Windows.Forms.Button btnCategoryDelete;
        private System.Windows.Forms.Button btnCategoryUpdate;
        private System.Windows.Forms.Button btnMovieUpdate;
        private System.Windows.Forms.Button btnMovieDelete;
        private System.Windows.Forms.Button btnMovieSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Button btnMovieList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.DataGridView dtgMovie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMovieDuration;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMovieImdb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCategoryCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnMovieProcedure;
    }
}

