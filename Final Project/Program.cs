using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Final_Project
{
    class Killer
    {
        public const uint COUNTRY_LEN = 60;
        const uint MEMBERS_LEN = 600;
        public const string BASE_DIR = @"C:\Users\T5\Desktop\Data\";   /* Specify the correct path where to make Data directory for instance
                                                                 * @"C:\Data\"
                                                                 */
        public string[] dna_row = new string[600];
        public string[] digit_row = new string[600];
        public string[] count_row = new string[600];
        public string[] enc_dna_row = new string[600];
        FileInfo[,] digit_files = new FileInfo[COUNTRY_LEN, 10];
        public void add_to_digit_files(FileInfo file,int country, int id)
        {
            digit_files[country, id] = file;
        }
        public string get_id(string raw_id)
        {
            int index = 0;
            for (int i = 0; i < raw_id.Length; i++)
            {
                if (raw_id[i] == '\\')
                {
                    index = i + 1;
                }
            }
            int size = raw_id.Length - index;
            char[] id = new char[size];
            for (int i = 0; index < raw_id.Length; i++, index++)
            {
                id[i] = raw_id[index];
            }
            return new string(id);
        }
        
        private string prepare_id(string id)
        {
            int size = id.Length - 1;
            char[] new_id = new char[size];
            for(int i = 1; i < id.Length; i++)
            {
                new_id[i - 1] = id[i];
            }
            return new string(new_id);
        }
        public void set_up_data(FileInfo source)
        {
            uint line_num = 1;
            string id;
            string dna;
            uint current_country = 1;
            for (int i = 1; i <= COUNTRY_LEN; i++)
            {
                Directory.CreateDirectory(BASE_DIR + $"{i}");
            }
            Directory.CreateDirectory(BASE_DIR + "killer");
            StreamReader sr = new StreamReader(source.FullName);
            while ((id = sr.ReadLine()) != null)
            {
                if (line_num > MEMBERS_LEN)
                {
                    break;
                }
                id = this.prepare_id(id);
                Directory.CreateDirectory(BASE_DIR + $@"{current_country}\{id}");
                dna = sr.ReadLine();
                StreamWriter sw = new StreamWriter(BASE_DIR + $@"{current_country}\{id}\{id}_DNA.txt");
                sw.WriteLine(dna);
                sw.Close();
                if (line_num % 10 == 0)
                {
                    current_country++;
                }
                line_num++;
            }
            sr.Close();
        }

        public void count_characters(FileInfo file, bool is_killer=false)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();
            char[] letters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J',
                              'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
                              'U', 'V', 'W', 'X', 'Y', 'Z'};
            for (int i = 0; i < letters.Length; i++)
            {
                counter.Add(letters[i], 0);
            }
            StreamReader sr = new StreamReader(file.FullName);
            string dna = sr.ReadLine();
            for (int i = 0; i < dna.Length; i++)
            {
                counter[dna[i]]++;
            }
            sr.Close();
            StreamWriter sw;
            if (!is_killer)
            {
                string id = this.get_id(file.DirectoryName);
                sw = new StreamWriter(file.DirectoryName + $@"\{id}_info.txt");
            }
            else
            {
                sw = new StreamWriter(BASE_DIR + @"killer\killer_info.txt");
            }
            foreach (KeyValuePair<char, int> element in counter)
            {
                sw.WriteLine($"{element.Key}={element.Value};");
            }
            sw.Close();
        }

        public FileInfo digit_dna(FileInfo file, bool is_killer=false)
        {
            StreamReader sr = new StreamReader(file.FullName);
            string dna = sr.ReadLine();
            sr.Close();
            string digit_dna = "";
            for ( int i = 0; i < dna.Length; i++)
            {
                int digit = dna[i];
                if (i == dna.Length - 1)
                {
                    digit_dna += Convert.ToString(digit);
                    continue;
                }
                digit_dna += Convert.ToString(digit) + '-';
            }
            StreamWriter sw;
            string id;
            if (!is_killer)
            {
                id = this.get_id(file.DirectoryName);
                sw = new StreamWriter(file.DirectoryName + $@"\{id}_digit.txt");
            }
            else
            {
                id = "killer";
                sw = new StreamWriter(BASE_DIR + @"killer\killer_digit.txt");
            }
            sw.WriteLine(digit_dna);
            sw.Close();
            return new FileInfo(file.DirectoryName + $@"\{id}_digit.txt");
        }
        public string killer_file(FileInfo file)
        {
            StreamReader sr = new StreamReader(file.FullName);
            string line;
            for (int i = 0; (line = sr.ReadLine()) != null; i++)
            {
                if (i == 2)
                {
                    StreamWriter sw = new StreamWriter(BASE_DIR + @"killer\killer_dna.txt");
                    sw.Write(line);
                    sw.Close();
                }
                else
                {
                    continue;
                }
            }
            sr.Close();
            return BASE_DIR + @"killer\killer_dna.txt";
        }
        public void encrypt_dna_file(FileInfo file)
        {
            StreamReader sr = new StreamReader(file.FullName);
            string dna = sr.ReadToEnd();
            sr.Close();
            char[] enc_dna = new char[25];
            for (int i = 0; i < 25; i++)
            {
                int x;
                int num = Convert.ToInt32(dna[i]);
                if (num >=86)
                {
                    x = num + 5 - 25;
                }
                else
                {
                    x = num + 5;
                }
                enc_dna[i] = Convert.ToChar(x);
            }
            string id = this.get_id(file.DirectoryName);
            StreamWriter sw = new StreamWriter(file.DirectoryName + $@"\{id}_enc_dna.txt");
            string Enc_DNA = new string(enc_dna);
            sw.Write(Enc_DNA);
            sw.Close();
        }
        public string[] decrypt_dna_file(FileInfo file)
        {
            StreamReader sr = new StreamReader(file.FullName);
            string dna = sr.ReadToEnd();
            sr.Close();
            char[] dec_dna = new char[25];
            for (int i = 0; i < 25; i++)
            {
                int x;
                int num = Convert.ToInt32(dna[i]);
                if (num <= 69)
                {
                    x = num - 5 + 25;
                }
                else
                {
                    x = num - 5;
                }
                dec_dna[i] = Convert.ToChar(x);
            }
            string Dec_DNA = new string(dec_dna);
            return new string[] { dna, Dec_DNA };
        }
        private void get_all_dna()
        {
            for (int i = 1; i <= COUNTRY_LEN; i++)
            {
                DirectoryInfo di = new DirectoryInfo(BASE_DIR + Convert.ToString(i));
                DirectoryInfo[] ppl = di.GetDirectories();
                for (int j = 0; j < 10; j++)
                {
                    FileInfo[] files = ppl[j].GetFiles();
                    string id = get_id(ppl[j].FullName);
                    foreach (FileInfo file in files)
                    {
                        if (file.Name == id + "_DNA.txt")
                        {
                            StreamReader dna_sr = new StreamReader(file.FullName);
                            dna_row[Convert.ToInt32(id) - 1] = dna_sr.ReadToEnd();
                        }
                    }
                }
            }
        }
        private void get_all_digit()
        {
            for (int i = 1; i <= COUNTRY_LEN; i++)
            {
                DirectoryInfo di = new DirectoryInfo(BASE_DIR + Convert.ToString(i));
                DirectoryInfo[] ppl = di.GetDirectories();
                for (int j = 0; j < 10; j++)
                {
                    FileInfo[] files = ppl[j].GetFiles();
                    string id = get_id(ppl[j].FullName);
                    foreach (FileInfo file in files)
                    {
                        if (file.Name == id + "_digit.txt")
                        {
                            StreamReader digit_sr = new StreamReader(file.FullName);
                            digit_row[Convert.ToInt32(id) - 1] = digit_sr.ReadToEnd();
                        }
                    }
                }
            }
        }
        private void get_all_count()
        {
            for (int i = 1; i <= COUNTRY_LEN; i++)
            {
                DirectoryInfo di = new DirectoryInfo(BASE_DIR + Convert.ToString(i));
                DirectoryInfo[] ppl = di.GetDirectories();
                for (int j = 0; j < 10; j++)
                {
                    FileInfo[] files = ppl[j].GetFiles();
                    string id = get_id(ppl[j].FullName);
                    foreach (FileInfo file in files)
                    {
                        if (file.Name == id + "_info.txt")
                        {
                            StreamReader count_sr = new StreamReader(file.FullName);
                            count_row[Convert.ToInt32(id) - 1] = count_sr.ReadToEnd();
                        }
                    }
                }
            }
        }
        private void get_all_enc_dna()
        {
            for (int i = 1; i <= COUNTRY_LEN; i++)
            {
                DirectoryInfo di = new DirectoryInfo(BASE_DIR + Convert.ToString(i));
                DirectoryInfo[] ppl = di.GetDirectories();
                for (int j = 0; j < 10; j++)
                {
                    FileInfo[] files = ppl[j].GetFiles();
                    string id = get_id(ppl[j].FullName);
                    foreach (FileInfo file in files)
                    {
                        if (file.Name == id + "_enc_dna.txt")
                        {
                            StreamReader enc_dna_sr = new StreamReader(file.FullName);
                            enc_dna_row[Convert.ToInt32(id) - 1] = enc_dna_sr.ReadToEnd();
                        }
                    }
                }
            }
        }
        public void get_all_data()
        {
            Thread get_dna = new Thread(new ThreadStart(this.get_all_dna));
            Thread get_digit = new Thread(new ThreadStart(this.get_all_digit));
            Thread get_count = new Thread(new ThreadStart(this.get_all_count));
            Thread get_enc_dna = new Thread(new ThreadStart(this.get_all_enc_dna));
            get_dna.Start();
            get_digit.Start();
            get_count.Start();
            get_enc_dna.Start();
        }
    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Killer killer = new Killer();
            FileInfo source = new FileInfo(@"C:\Users\T5\Downloads\final_source\Data.txt");
            killer.set_up_data(source);
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
