
namespace Final_Project
{
    partial class Form1
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
            this.file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.open_btn = new System.Windows.Forms.Button();
            this.file_label = new System.Windows.Forms.Label();
            this.make_info = new System.Windows.Forms.Button();
            this.make_digit = new System.Windows.Forms.Button();
            this.info_label = new System.Windows.Forms.Label();
            this.data_grid_view = new System.Windows.Forms.DataGridView();
            this.show_btn = new System.Windows.Forms.Button();
            this.open_show_btn = new System.Windows.Forms.Button();
            this.show_file_dialog = new System.Windows.Forms.OpenFileDialog();
            this.show_file_label = new System.Windows.Forms.Label();
            this.killer_btn = new System.Windows.Forms.Button();
            this.make_all_data_btn = new System.Windows.Forms.Button();
            this.enc_btn = new System.Windows.Forms.Button();
            this.decrypt_btn = new System.Windows.Forms.Button();
            this.dec_grid_view = new System.Windows.Forms.DataGridView();
            this.all_data_grid_view = new System.Windows.Forms.DataGridView();
            this.show_all_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec_grid_view)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_data_grid_view)).BeginInit();
            this.SuspendLayout();
            // 
            // file_dialog
            // 
            this.file_dialog.FileName = "openFileDialog1";
            this.file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.file_dialog_FileOk);
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(12, 12);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(75, 23);
            this.open_btn.TabIndex = 0;
            this.open_btn.Text = "Open";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // file_label
            // 
            this.file_label.AutoSize = true;
            this.file_label.Location = new System.Drawing.Point(93, 16);
            this.file_label.Name = "file_label";
            this.file_label.Size = new System.Drawing.Size(87, 15);
            this.file_label.TabIndex = 1;
            this.file_label.Text = "No File Chosen";
            // 
            // make_info
            // 
            this.make_info.Location = new System.Drawing.Point(12, 41);
            this.make_info.Name = "make_info";
            this.make_info.Size = new System.Drawing.Size(75, 23);
            this.make_info.TabIndex = 2;
            this.make_info.Text = "make info file";
            this.make_info.UseVisualStyleBackColor = true;
            this.make_info.Click += new System.EventHandler(this.make_info_Click);
            // 
            // make_digit
            // 
            this.make_digit.Location = new System.Drawing.Point(12, 70);
            this.make_digit.Name = "make_digit";
            this.make_digit.Size = new System.Drawing.Size(75, 23);
            this.make_digit.TabIndex = 3;
            this.make_digit.Text = "make digit";
            this.make_digit.UseVisualStyleBackColor = true;
            this.make_digit.Click += new System.EventHandler(this.make_digit_Click);
            // 
            // info_label
            // 
            this.info_label.AutoSize = true;
            this.info_label.Location = new System.Drawing.Point(192, 60);
            this.info_label.Name = "info_label";
            this.info_label.Size = new System.Drawing.Size(0, 15);
            this.info_label.TabIndex = 4;
            // 
            // data_grid_view
            // 
            this.data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_view.Location = new System.Drawing.Point(12, 245);
            this.data_grid_view.Name = "data_grid_view";
            this.data_grid_view.RowTemplate.Height = 25;
            this.data_grid_view.Size = new System.Drawing.Size(349, 193);
            this.data_grid_view.TabIndex = 5;
            // 
            // show_btn
            // 
            this.show_btn.Location = new System.Drawing.Point(12, 207);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(75, 23);
            this.show_btn.TabIndex = 6;
            this.show_btn.Text = "Show";
            this.show_btn.UseVisualStyleBackColor = true;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // open_show_btn
            // 
            this.open_show_btn.Location = new System.Drawing.Point(12, 178);
            this.open_show_btn.Name = "open_show_btn";
            this.open_show_btn.Size = new System.Drawing.Size(75, 23);
            this.open_show_btn.TabIndex = 7;
            this.open_show_btn.Text = "Open";
            this.open_show_btn.UseVisualStyleBackColor = true;
            this.open_show_btn.Click += new System.EventHandler(this.open_show_btn_Click);
            // 
            // show_file_dialog
            // 
            this.show_file_dialog.FileName = "openFileDialog1";
            this.show_file_dialog.FileOk += new System.ComponentModel.CancelEventHandler(this.show_file_dialog_FileOk);
            // 
            // show_file_label
            // 
            this.show_file_label.AutoSize = true;
            this.show_file_label.Location = new System.Drawing.Point(93, 182);
            this.show_file_label.Name = "show_file_label";
            this.show_file_label.Size = new System.Drawing.Size(87, 15);
            this.show_file_label.TabIndex = 8;
            this.show_file_label.Text = "No File Chosen";
            // 
            // killer_btn
            // 
            this.killer_btn.Location = new System.Drawing.Point(420, 16);
            this.killer_btn.Name = "killer_btn";
            this.killer_btn.Size = new System.Drawing.Size(96, 23);
            this.killer_btn.TabIndex = 9;
            this.killer_btn.Text = "make killer info";
            this.killer_btn.UseVisualStyleBackColor = true;
            this.killer_btn.Click += new System.EventHandler(this.killer_btn_Click);
            // 
            // make_all_data_btn
            // 
            this.make_all_data_btn.Location = new System.Drawing.Point(420, 52);
            this.make_all_data_btn.Name = "make_all_data_btn";
            this.make_all_data_btn.Size = new System.Drawing.Size(96, 23);
            this.make_all_data_btn.TabIndex = 10;
            this.make_all_data_btn.Text = "make all data";
            this.make_all_data_btn.UseVisualStyleBackColor = true;
            this.make_all_data_btn.Click += new System.EventHandler(this.make_all_data_btn_Click);
            // 
            // enc_btn
            // 
            this.enc_btn.Location = new System.Drawing.Point(12, 99);
            this.enc_btn.Name = "enc_btn";
            this.enc_btn.Size = new System.Drawing.Size(75, 23);
            this.enc_btn.TabIndex = 12;
            this.enc_btn.Text = "encrypt dna";
            this.enc_btn.UseVisualStyleBackColor = true;
            this.enc_btn.Click += new System.EventHandler(this.enc_btn_Click);
            // 
            // decrypt_btn
            // 
            this.decrypt_btn.Location = new System.Drawing.Point(12, 128);
            this.decrypt_btn.Name = "decrypt_btn";
            this.decrypt_btn.Size = new System.Drawing.Size(75, 23);
            this.decrypt_btn.TabIndex = 13;
            this.decrypt_btn.Text = "decrypt";
            this.decrypt_btn.UseVisualStyleBackColor = true;
            this.decrypt_btn.Click += new System.EventHandler(this.decrypt_btn_Click);
            // 
            // dec_grid_view
            // 
            this.dec_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dec_grid_view.Location = new System.Drawing.Point(367, 245);
            this.dec_grid_view.Name = "dec_grid_view";
            this.dec_grid_view.RowTemplate.Height = 25;
            this.dec_grid_view.Size = new System.Drawing.Size(349, 193);
            this.dec_grid_view.TabIndex = 14;
            // 
            // all_data_grid_view
            // 
            this.all_data_grid_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_data_grid_view.Location = new System.Drawing.Point(722, 245);
            this.all_data_grid_view.Name = "all_data_grid_view";
            this.all_data_grid_view.RowTemplate.Height = 25;
            this.all_data_grid_view.Size = new System.Drawing.Size(298, 193);
            this.all_data_grid_view.TabIndex = 15;
            // 
            // show_all_btn
            // 
            this.show_all_btn.Location = new System.Drawing.Point(420, 90);
            this.show_all_btn.Name = "show_all_btn";
            this.show_all_btn.Size = new System.Drawing.Size(96, 23);
            this.show_all_btn.TabIndex = 16;
            this.show_all_btn.Text = "show all data";
            this.show_all_btn.UseVisualStyleBackColor = true;
            this.show_all_btn.Click += new System.EventHandler(this.show_all_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 450);
            this.Controls.Add(this.show_all_btn);
            this.Controls.Add(this.all_data_grid_view);
            this.Controls.Add(this.dec_grid_view);
            this.Controls.Add(this.decrypt_btn);
            this.Controls.Add(this.enc_btn);
            this.Controls.Add(this.make_all_data_btn);
            this.Controls.Add(this.killer_btn);
            this.Controls.Add(this.show_file_label);
            this.Controls.Add(this.open_show_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.data_grid_view);
            this.Controls.Add(this.info_label);
            this.Controls.Add(this.make_digit);
            this.Controls.Add(this.make_info);
            this.Controls.Add(this.file_label);
            this.Controls.Add(this.open_btn);
            this.Name = "Form1";
            this.Text = "make all digits";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dec_grid_view)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_data_grid_view)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog file_dialog;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Label file_label;
        private System.Windows.Forms.Button make_info;
        private System.Windows.Forms.Button make_digit;
        private System.Windows.Forms.Label info_label;
        private System.Windows.Forms.DataGridView data_grid_view;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button open_show_btn;
        private System.Windows.Forms.OpenFileDialog show_file_dialog;
        private System.Windows.Forms.Label show_file_label;
        private System.Windows.Forms.Button killer_btn;
        private System.Windows.Forms.Button make_all_data_btn;
        private System.Windows.Forms.Button enc_btn;
        private System.Windows.Forms.Button decrypt_btn;
        private System.Windows.Forms.DataGridView dec_grid_view;
        private System.Windows.Forms.DataGridView all_data_grid_view;
        private System.Windows.Forms.Button show_all_btn;
    }
}

