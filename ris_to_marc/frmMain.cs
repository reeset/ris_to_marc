using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ris_to_marc

{
    public partial class frmMain : Form
    {
        System.Collections.Hashtable hash_assoc = new System.Collections.Hashtable();
        System.Collections.Hashtable hash_leaders = new System.Collections.Hashtable();
        public frmMain()
        {
            InitializeComponent();
        }





        private void lnkTemplates_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contextMenuStrip1.Show(lnkTemplates, new System.Drawing.Point(95, 10));
        }

        private void cmdProcess_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(txt_ris.Text) == false)
            {
                System.Windows.Forms.MessageBox.Show("RIS file not found");
                return;
            }


            LoadAssocs();
            System.IO.StreamReader rd = new System.IO.StreamReader(txt_ris.Text, true);
            System.IO.StreamWriter rw = new System.IO.StreamWriter(txt_save.Text, false, rd.CurrentEncoding);

            string record = "";
            string tmp = "";
            while (rd.Peek() > -1)
            {
                tmp = rd.ReadLine().Trim();
                if (tmp.Trim().Length > 0)
                {
                    if (tmp.StartsWith("TY"))
                    {
                        record += tmp + "\n";
                    }
                    else if (tmp.StartsWith("ER"))
                    {
                        record = processRecord(record);
                        rw.WriteLine(record + System.Environment.NewLine);
                        record = "";
                    }
                    else
                    {
                        record += tmp + "\n";
                    }
                }
            }
            rw.Close();
            rd.Close();
            System.Windows.Forms.MessageBox.Show("File has finished Processing");
        }

        private void cmdClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

        private string processRecord(string s)
        {
            //We need to determine the leader
            string leader = ""; // @"=LDR  00000nam  2200000Ia 4500" + "\n" + @"=008  YYMMDDsDAT1\\\\CNT\\\\\\\\\\\000\0\und\d" + "\n";
            string record = "";
            string year = "";
            string date = "";
            string start_page = "";
            string end_page = "";
            string ssn = "";
            string vol = "";
            string issue = "";
            string publisher = "";
            string city = "";
            string type = "";
            string title2 = "";
            string pub_year = "";
            string jtitle = "";

            //Processing fields
            string[] lines = s.Split("\n".ToCharArray());
            foreach (string l in lines)
            {
                if (l.Trim().Length > 0)
                {
                    switch (l.Substring(0, 2))
                    {
                        case "Y1":
                            pub_year = l.Substring(l.IndexOf("-") + 1).Replace("/", "").Trim();
                            break;
                        case "TY":
                            type = l.Substring(l.IndexOf("-") + 1).Trim();
                            break;
                        case "AV":
                            record += @"=535  \\$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "CN":
                            //call number
                            record += @"=099  \\$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "T1":
                        case "TI":
                        case "CT":
                        case "BT":
                            if (record.IndexOf("=245") > -1)
                            {
                                record += "=246  10$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            }
                            else
                            {
                                record += "=245  10$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            }
                            break;
                        case "T2":
                            if (type == "JOUR" || type == "CHAP" || type == "RPRT" || type == "PAMP")
                            {
                                jtitle = l.Substring(l.IndexOf("-") + 1).Trim();

                            }
                            else
                            {
                                title2 = l.Substring(l.IndexOf("-") + 1).Trim();
                            }
                            break;
                        case "T3":
                            record += @"=490  \\$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "A1":
                            record += @"=100  1\$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "A2":
                        case "AU":
                            record += @"=700  1\$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "N1":
                        case "N2":
                        case "N3":
                        case "N4":
                        case "N5":
                        case "N6":
                        case "N7":
                        case "N8":
                        case "N9":
                        case "N10":
                        case "RN":
                            record += @"=500  \\$a" + l.Substring(l.IndexOf("-"), +1).Trim() + "\n";
                            break;
                        case "AB":
                            record += @"=520  3\$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "PY":
                            year = l.Substring(l.IndexOf("-") + 1).Trim().Substring(0, 4);
                            date = l.Substring(l.IndexOf("-") + 1).Trim();
                            break;
                        case "KW":
                            record += @"=690  \\$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "SP":
                            start_page = l.Substring(l.IndexOf("-") + 1).Trim();
                            //record += @"=300  \\$a" + start_page + "\n";
                            break;
                        case "EP":
                            end_page = l.Substring(l.IndexOf("-") + 1).Trim();
                            break;
                        case "UR":                       
                            record += @"=856  41$a" + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "L1":
                            {
                                string[] links = l.Substring(l.IndexOf("-") + 1).Trim().Split(";".ToCharArray());
                                foreach (string lnk in links)
                                {
                                    record += @"=856  41" + "$3PDF" + "$a" + lnk.Trim() + "\n";
                                }
                            }
                            break;
                        case "L2":
                            {
                                string[] links = l.Substring(l.IndexOf("-") + 1).Trim().Split(";".ToCharArray());
                                foreach (string lnk in links)
                                {
                                    record += @"=856  41" + "$3Full-text" + "$a" + lnk.Trim() + "\n";
                                }
                            }
                            break;
                        case "DO":
                            record += @"=500  \\$aDOI: " + l.Substring(l.IndexOf("-") + 1).Trim() + "\n";
                            break;
                        case "SN":                            
                            ssn = l.Substring(l.IndexOf("-") + 1).Trim();
                            if (ssn.Length>=10)
                            {
                                record += @"=020  \\$a" + ssn + "\n";
                            } else
                            {
                                record += @"=020  \\$a" + ssn + "\n";
                            }
                            break;
                        case "VL":
                            vol = l.Substring(l.IndexOf("-") + 1).Trim();
                            break;
                        case "IS":
                            issue = l.Substring(l.IndexOf("-") + 1).Trim();
                            break;
                        case "PB":
                            publisher = l.Substring(l.IndexOf("-") + 1).Trim();
                            break;
                        case "CY":
                            city = l.Substring(l.IndexOf("-") + 1).Trim();
                            break;
                        case "JF":
                        case "JO":
                        case "JA":
                            if (jtitle.Trim().Length == 0)
                            {
                                jtitle = l.Substring(l.IndexOf("-") + 1).Trim();
                            } else {
                                title2 = jtitle;
                                record += @"=246  10$a" + title2 + "\n";                                
                                jtitle = l.Substring(l.IndexOf("-") + 1).Trim();                         
                            }

                            break;
                        default:
                            break;
                    }

                }
            }

            if (publisher != "")
            {
                if (city != "")
                {
                    record += @"=264  \0$a" + city + " : " + "$b" + publisher;
                }
                else
                {
                    record += @"=264  \0$b" + publisher;
                }

                if (pub_year != "")
                {
                    record += "$c" + pub_year + "\n";
                }
                else
                {
                    if (year != "")
                    {
                        record += "$c" + year + "\n";
                    }

                    else
                    {
                        record += "\n";
                    }
                }
            }

            if (start_page.Trim().Length > 0 &&
                end_page.Trim().Length > 0)
            {
                if (IsNumeric(start_page) && IsNumeric(end_page))
                {
                    record += @"=300  \\$a" + (System.Convert.ToInt32(end_page) - System.Convert.ToInt32(start_page) + 1).ToString() + "\n";
                }

            }

            if (type == "JOUR" || type == "CHAP" || type == "RPRT" || type == "PAMP")
            {
                
                if (jtitle != "" && jtitle.Length > 1)
                {
                    record += @"=773  \\$t" + jtitle;
                    if (ssn != "")
                    {
                        record += "$x" + ssn;
                    }


                    if (vol != "")
                    {
                        record += "$g" + vol;
                    }

                    if (issue != "")
                    {
                        record += " " + issue;
                    }

                    if (start_page != "")
                    {
                        record += ", " + start_page;
                        if (end_page != "")
                        {
                            record += "-" + end_page;
                        }
                    }

                }
            }



            string[] arr_keys = new string[hash_leaders.Keys.Count];
            hash_assoc.Keys.CopyTo(arr_keys, 0);

            for (int x = 0; x < arr_keys.Length; x++)
            {

                if (((string)hash_assoc[arr_keys[x]]).IndexOf(type) > -1)
                {
                    leader = (string)hash_leaders[arr_keys[x]];
                    break;
                }
            }

            if (leader == "")
            {
                leader = (string)hash_leaders["books"];
            }

            if (year != "" && year.Length == 4)
            {
                leader = leader.Replace("DAT1", year);
            }
            else
            {
                leader = leader.Replace("DAT1", "9999");
            }

            string tmpy = System.DateTime.Now.Year.ToString().Substring(2, 2) + System.DateTime.Now.Month.ToString().PadLeft(2, '0') +
                System.DateTime.Now.Day.ToString().PadLeft(2, '0');

            leader = leader.Replace("YYMMDD", tmpy);

            record = record.TrimEnd("\n".ToCharArray());
            string[] tlines = record.Split("\n".ToCharArray());
            Array.Sort(tlines);
            record = string.Join(System.Environment.NewLine, tlines);

            leader = leader.TrimEnd() + System.Environment.NewLine;
            return leader + record + System.Environment.NewLine;
        }

        private void LoadAssocs()
        {

            string path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().Location);

            if (hash_leaders != null && hash_leaders.Count > 0)
            {
                hash_leaders.Clear();
            }

            if (hash_assoc != null && hash_assoc.Count > 0)
            {
                hash_assoc.Clear();
            }
            

            //System.Windows.Forms.MessageBox.Show(path);
            if (path.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) == false)
            {
                path += System.IO.Path.DirectorySeparatorChar.ToString();
            }

            path += "ris_templates" + System.IO.Path.DirectorySeparatorChar.ToString();

            System.IO.StreamReader reader = new System.IO.StreamReader(path + "assoc.txt");
            string tmp = "";

            while (reader.Peek() > -1)
            {
                tmp = reader.ReadLine();
                if (tmp.Trim().Length > 0)
                {
                    string[] tarr = tmp.Split("=".ToCharArray());
                    hash_assoc.Add(tarr[0], tarr[1]);

                }
            }

            reader.Close();

            string[] sfiles = new string[8];
            sfiles[0] = "books.txt";
            sfiles[1] = "serials.txt";
            sfiles[2] = "visual_mat.txt";
            sfiles[3] = "maps.txt";
            sfiles[4] = "sound_rec.txt";
            sfiles[5] = "scores.txt";
            sfiles[6] = "electronic_resources.txt";
            sfiles[7] = "mixed_mat.txt";

            string tmp_line = "";
            foreach (string ts in sfiles)
            {
                reader = new System.IO.StreamReader(path + ts);
                tmp_line = reader.ReadToEnd();
                hash_leaders.Add(ts.Replace(".txt", ""), tmp_line);
                reader.Close();
            }

        }


        private void OpenTemplate(string name)
        {

            string path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().Location);



            if (path.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) == false)
            {
                path += System.IO.Path.DirectorySeparatorChar.ToString();
            }

            path += "ris_templates" + System.IO.Path.DirectorySeparatorChar.ToString();

            string filename = "";
            switch (name.ToLower())
            {
                case "book":
                    filename = path + "books.txt";
                    break;
                case "serial":
                    filename = path + "serials.txt";
                    break;
                case "visual materials":
                    filename = path + "visual_mat.txt";
                    break;
                case "cartographic resource":
                    filename = path + "maps.txt";
                    break;
                case "sound recording":
                    filename = path + "sound_rec.txt";
                    break;
                case "score":
                    filename = path + "scores.txt";
                    break;
                case "electronic resource":
                    filename = path + "electronic_resources.txt";
                    break;
                case "mix material":
                    filename = path + "mixed_mat.txt";
                    break;
                default:
                    break;
            }

            ExecuteFile(filename);
        }

        private void ExecuteFile(string s)
        {

            System.Diagnostics.Process.Start(s);
        }

        private void lnkAssoc_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            string path = System.IO.Path.GetDirectoryName(
                 System.Reflection.Assembly.GetExecutingAssembly().Location);


            if (path.EndsWith(System.IO.Path.DirectorySeparatorChar.ToString()) == false)
            {
                path += System.IO.Path.DirectorySeparatorChar.ToString();
            }

            path += "ris_templates" + System.IO.Path.DirectorySeparatorChar.ToString();

            path += "assoc.txt";

            ExecuteFile(path);
        }

        private bool IsNumeric(string s, string allowed = "")
        {
            if (String.IsNullOrEmpty(s)) return false;
            for (int x = 0; x < s.Length; x++)
            {
                if (Char.IsNumber(s[x]) == false)
                {
                    if (allowed.Trim().Length != 0)
                    {
                        if (allowed.IndexOf(s[x]) == -1)
                        {
                            return false;

                        }
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog od = new OpenFileDialog();
            od.Filter = "RIS Files (*.ris)|*.ris|All Files (*.*)|*.*";
            od.FilterIndex = 0;
            od.ShowDialog();
            if (od.FileName != "")
            {
                txt_ris.Text = od.FileName;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.SaveFileDialog sd = new SaveFileDialog();
            sd.Filter = "Mnemonic File (*.mrk)|*.mrk|All Files (*.*)|*.*";
            sd.FilterIndex = 0;
            sd.ShowDialog();
            if (sd.FileName != "")
            {
                txt_save.Text = sd.FileName;
            }
        }

        private void serialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

        private void visualMaterialsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

        private void cartographicResourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

        private void soundRecordingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

        private void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

        private void electronicResourceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

        private void mixMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenTemplate(((System.Windows.Forms.ToolStripMenuItem)sender).Text.ToLower());
        }

    }
}
