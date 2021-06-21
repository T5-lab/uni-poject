using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        Killer killer = new Killer();
        const uint COLUMNS_COUNT = 26;
        public Form1()
        {
            InitializeComponent();
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            this.file_dialog.ShowDialog();
            this.info_label.Text = "";
        }

        private void file_dialog_FileOk(object sender, CancelEventArgs e)
        {
            this.file_label.Text = this.file_dialog.FileName;
            this.info_label.Text = "";
        }

        private void make_info_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.file_dialog.FileName);
            if (!file.Exists)
            {
                this.file_label.Text = "This file doesn\'t exist!";
                this.info_label.Text = "";
            }
            else
            {
                this.killer.count_characters(file);
                this.info_label.Text = "info file was created!";
            }
        }

        private void make_digit_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.file_dialog.FileName);
            if (!file.Exists)
            {
                this.file_label.Text = "This file doesn\'t exist!";
                this.info_label.Text = "";
            }
            else
            {
                this.killer.digit_dna(file);
                this.info_label.Text = "digit file was created!";
            }
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.show_file_dialog.FileName);
            if (!file.Exists)
            {
                this.show_file_label.Text = "This file doesn\'t exist!";
                this.info_label.Text = "";
            }
            else
            {
                data_grid_view.ColumnCount = Convert.ToInt32(COLUMNS_COUNT);
                char[] letters = new char[]
                {
                    'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                    'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                    'U', 'V', 'W', 'X', 'Y', 'Z'
                };
                string[] row = new string[COLUMNS_COUNT];
                for (int i =0; i < letters.Length; i++)
                {
                    data_grid_view.Columns[i].Name = Convert.ToString(letters[i]);
                }
                StreamReader sr = new StreamReader(file.FullName);
                string line;
                for (int i = 0; (line = sr.ReadLine()) != null; i++)
                {
                    int from = line.IndexOf('=') + 1;
                    int to = line.IndexOf(';');
                    for (int j = from; j < to; j++)
                    {
                        row[i] += line[j];
                    }
                }
                data_grid_view.Rows.Add(row);
                data_grid_view.ReadOnly = true;
                sr.Close();
            }
        }

        private void open_show_btn_Click(object sender, EventArgs e)
        {
            this.show_file_dialog.ShowDialog();
            this.info_label.Text = "";
        }

        private void show_file_dialog_FileOk(object sender, CancelEventArgs e)
        {
            this.show_file_label.Text = this.show_file_dialog.FileName;
            this.info_label.Text = "";
        }

        private void killer_btn_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(@"C:\Users\T5\Downloads\final_source\Killer.txt");
            FileInfo dna_file = new FileInfo(killer.killer_file(file));
            killer.count_characters(dna_file, true);
            killer.digit_dna(dna_file, true);
        }

        private void make_all_data_btn_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= Killer.COUNTRY_LEN; i++)
            {
                DirectoryInfo di = new DirectoryInfo(Killer.BASE_DIR + Convert.ToString(i));
                DirectoryInfo[] ppl = di.GetDirectories();
                for (int j = 0; j < 10; j++)
                {
                    FileInfo[] files = ppl[j].GetFiles();
                    string id = killer.get_id(ppl[j].FullName);
                    foreach(FileInfo file in files)
                    {
                        if (file.Name == id + "_DNA.txt")
                        {
                            killer.count_characters(file);
                            killer.encrypt_dna_file(file);
                            FileInfo digit_file = killer.digit_dna(file);
                            killer.add_to_digit_files(digit_file, i - 1, j) ;
                        }
                    }
                }
            }
        }

        private void enc_btn_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.file_dialog.FileName);
            if (!file.Exists)
            {
                this.file_label.Text = "This file doesn\'t exist!";
                this.info_label.Text = "";
            }
            else
            {
                this.killer.encrypt_dna_file(file);
                this.info_label.Text = "encrypted file was created!";
            }
        }

        private void decrypt_btn_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo(this.file_dialog.FileName);
            if (!file.Exists)
            {
                this.file_label.Text = "This file doesn\'t exist!";
                this.info_label.Text = "";
            }
            else
            {
                string[] dnas = this.killer.decrypt_dna_file(file);
                this.info_label.Text = "";
                string[] row = new string[25];
                dec_grid_view.ColumnCount = 25;
                for (int i = 0; i < 25; i ++)
                {
                    dec_grid_view.Columns[i].Name = Convert.ToString(dnas[0][i]);
                    row[i] = Convert.ToString(dnas[1][i]);
                }
                dec_grid_view.Rows.Add(row);
                dec_grid_view.ReadOnly = true;
            }
        }
        private void show_all_btn_Click(object sender, EventArgs e)
        {
            all_data_grid_view.ColumnCount = 600;
            killer.get_all_data();
            for (int i = 1; i <= 600; i++)
            {
                all_data_grid_view.Columns[i - 1].Name = Convert.ToString(i);
            }
            all_data_grid_view.Rows.Add(killer.dna_row);
            all_data_grid_view.Rows.Add(killer.digit_row);
            all_data_grid_view.Rows.Add(killer.count_row);
            all_data_grid_view.Rows.Add(killer.enc_dna_row);
            all_data_grid_view.ReadOnly = true;
        }
    }
}
