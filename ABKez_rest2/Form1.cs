using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;

namespace ABKez_rest2
{
    public partial class Form1 : Form
    {

        static readonly HttpClient client = new HttpClient();

        private IniFile Ini;
        class ApiResponse
        {
            public int id { get; set; }
            public int intdata { get; set; }
            public double floatdata { get; set; }
            public int booldata { get; set; }
            public string datedata { get; set; }
            public string comment { get; set; }
        }

        class IniFile   // revision 11
        {
            public string Path;
            public string EXE = Assembly.GetExecutingAssembly().GetName().Name;

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern long WritePrivateProfileString(string Section, string Key, string Value, string FilePath);

            [DllImport("kernel32", CharSet = CharSet.Unicode)]
            static extern int GetPrivateProfileString(string Section, string Key, string Default, StringBuilder RetVal, int Size, string FilePath);

            public IniFile(string IniPath = null)
            {
                Path = new FileInfo(IniPath ?? EXE + ".ini").FullName;
            }

            public string Read(string Key, string Section = null)
            {
                var RetVal = new StringBuilder(255);
                GetPrivateProfileString(Section ?? EXE, Key, "", RetVal, 255, Path);
                return RetVal.ToString();
            }

            public void Write(string Key, string Value, string Section = null)
            {
                WritePrivateProfileString(Section ?? EXE, Key, Value, Path);
            }

            public void DeleteKey(string Key, string Section = null)
            {
                Write(Key, null, Section ?? EXE);
            }

            public void DeleteSection(string Section = null)
            {
                Write(null, null, Section ?? EXE);
            }

            public bool KeyExists(string Key, string Section = null)
            {
                return Read(Key, Section).Length > 0;
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_getall_Click(object sender, EventArgs e)
        {
            this.getRest("getall/");
        }

        private void btn_getlast_Click(object sender, EventArgs e)
        {
            this.getRest("getlast/");
        }

        private void btn_getone_Click(object sender, EventArgs e)
        {
            this.getRest("getone/" + num_id.Value.ToString());
        }

        private void btn_deleteone_Click(object sender, EventArgs e)
        {
            this.deleteOne();
        }

        private void btn_writeone_Click(object sender, EventArgs e)
        {
            this.writeOne();
        }

        private void updateone_Click(object sender, EventArgs e)
        {
            this.updateOne();
        }

        private void lv_datas_Click(object sender, EventArgs e)
        {
            if (lv_datas.SelectedItems.Count > 0)
            {
                num_id.Value = Convert.ToInt32(lv_datas.SelectedItems[0].Text);
                num_intdata.Value = Convert.ToInt32(lv_datas.SelectedItems[0].SubItems[1].Text);
                num_floatdata.Value = Convert.ToDecimal(lv_datas.SelectedItems[0].SubItems[2].Text);
                num_booldata.Value = Convert.ToInt32(lv_datas.SelectedItems[0].SubItems[3].Text);
                tb_comment.Text = lv_datas.SelectedItems[0].SubItems[5].Text;
            }
            //memo.ScrollToCaret();

        }

        static string ByteArrayToString(byte[] arrInput)
        {
            int i;
            StringBuilder sOutput = new StringBuilder(arrInput.Length);
            for (i = 0; i < arrInput.Length; i++)
            {
                sOutput.Append(arrInput[i].ToString("X2"));
            }
            return sOutput.ToString();
        }



        /* -------------------------------------------------------------------------------- */

        private void getRest(string ALink)
        {
            memo.AppendText(cbLinks.Text + ALink + "\n");
            client.DefaultRequestHeaders.Clear();
            if (cbWithApiKey.Checked)
            {
                byte[] bytehash = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(tb_APIKey.Text));
                client.DefaultRequestHeaders.Add("Apikey", ByteArrayToString(bytehash).ToLower());
            }

            HttpResponseMessage response = client.GetAsync(cbLinks.Text + ALink).Result;
            ss_Status.Items[1].Text = response.ReasonPhrase; //.EnsureSuccessStatusCode().ToString();
            ss_Status.Items[0].Text = ((int)response.StatusCode).ToString();
            var responseStream = response.Content.ReadAsStreamAsync().Result;
            memo.AppendText(response.Content.ReadAsStringAsync().Result.ToString() + "\n");
            if (responseStream.Length > 0)
            {
                try
                {
                    var responseData = JsonSerializer.DeserializeAsync<List<ApiResponse>>(responseStream).Result;
                    lv_datas.Items.Clear();
                    foreach (var post in responseData)
                    {
                        ListViewItem lvi = lv_datas.Items.Add(post.id.ToString());
                        //memo.AppendText(post.id.ToString() + "\n");
                        lvi.SubItems.Add(post.intdata.ToString());
                        lvi.SubItems.Add(post.floatdata.ToString());
                        lvi.SubItems.Add(post.booldata.ToString());
                        lvi.SubItems.Add(post.datedata);
                        lvi.SubItems.Add(post.comment);
                    }
                    if (((int)response.StatusCode < 300) && (cbLinks.Items.IndexOf(cbLinks.Text) < 0))
                    {
                        cbLinks.Items.Add(cbLinks.Text);
                    }

                }
                catch (Exception ex)
                {
                    memo.AppendText(ex.Message);
                }
            }
        }

        private void getAll()
        {
            this.getRest("getall/");
        }
        private void getLast()
        {
            this.getRest("getlast/");
        }
        private void getOne()
        {
            this.getRest("getone/" + num_id.Value.ToString());
        }

        private void deleteRest(string ALink)
        {
            client.DefaultRequestHeaders.Clear();
            if (cbWithApiKey.Checked)
            {
                byte[] bytehash = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(tb_APIKey.Text));
                client.DefaultRequestHeaders.Add("Apikey", ByteArrayToString(bytehash).ToLower());
            }

            HttpResponseMessage response = client.DeleteAsync(cbLinks.Text + ALink).Result;
            ss_Status.Items[1].Text = response.ReasonPhrase; //.EnsureSuccessStatusCode().ToString();
            ss_Status.Items[0].Text = ((int)response.StatusCode).ToString();
            if (((int)response.StatusCode < 300) && (cbLinks.Items.IndexOf(cbLinks.Text) < 0))
            {
                cbLinks.Items.Add(cbLinks.Text);
            }

        }
        private void deleteAll()
        {
            this.deleteRest("deleteall/");
        }

        private void deleteOne()
        {
            this.deleteRest("deleteone/" + num_id.Value.ToString());
        }

        private void writeRest(string writeMode, string ALink)
        {
            client.DefaultRequestHeaders.Clear();
            if (cbWithApiKey.Checked)
            {
                byte[] bytehash = new MD5CryptoServiceProvider().ComputeHash(ASCIIEncoding.ASCII.GetBytes(tb_APIKey.Text));
                client.DefaultRequestHeaders.Add("Apikey", ByteArrayToString(bytehash).ToLower());
            }
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            string DATA = "{ \"intdata\": " + num_intdata.Value.ToString() +
                         //-----------------------------HIBA
                         ", \"floatdata\": " + num_floatdata.Value.ToString().Replace(',', '.') +
                         ", \"booldata\": " + num_booldata.Value.ToString() +
                         ", \"comment\": \"" + tb_comment.Text + "\" }";
            memo.AppendText(DATA);
            HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
            HttpResponseMessage response;

            if (writeMode == "POST")
            {
                response = client.PostAsync(cbLinks.Text + ALink, content).Result;
            }
            else
            {
                response = client.PutAsync(cbLinks.Text + ALink, content).Result;
            }
            ss_Status.Items[1].Text = response.ReasonPhrase; //.EnsureSuccessStatusCode().ToString();
            ss_Status.Items[0].Text = ((int)response.StatusCode).ToString();
            if (((int)response.StatusCode < 300) && (cbLinks.Items.IndexOf(cbLinks.Text) < 0))
            {
                cbLinks.Items.Add(cbLinks.Text);
            }

        }

        private void writeOne()
        {
            this.writeRest("POST", "writeone/");
        }

        private void updateOne()
        {
            this.writeRest("PUT", "updateone/" + num_id.Value.ToString());
        }
        private void saveSettings()
        {
            this.Ini.Write("Apikey", tb_APIKey.Text, "Main");
            this.Ini.Write("WithApikey", cbWithApiKey.Checked.ToString(), "Main");
            this.Ini.Write("NumLinks", cbLinks.Items.Count.ToString(), "Main");
            this.Ini.Write("NumDefault", cbLinks.SelectedIndex.ToString(), "Main");
            for (int i = 0; i < cbLinks.Items.Count; i++)
            {
                this.Ini.Write("Link" + i.ToString(), cbLinks.Items[i].ToString(), "Links");
            }
        }

        private void readSettings()
        {
            tb_APIKey.Text = this.Ini.Read("Apikey", "Main");
            cbWithApiKey.Checked = Convert.ToBoolean(this.Ini.Read("WithApikey", "Main"));
            int db = Convert.ToInt32(this.Ini.Read("NumLinks", "Main"));
            cbLinks.Items.Clear();
            for (int i = 0; i < db; i++)
            {
                cbLinks.Items.Add(this.Ini.Read("Link" + i.ToString(), "Links"));
            }
            cbLinks.SelectedIndex = Convert.ToInt32(this.Ini.Read("NumDefault", "Main"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Elvileg itt indul!
            memo.AppendText("Starting...\n");
            cbLinks.SelectedIndex = 0;
            Ini = new IniFile();
            if (!File.Exists(Ini.Path))
            {
                this.saveSettings();
            }
            this.readSettings();
            //memo.AppendText(cbLinks.Text + "\n");

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            memo.AppendText("FormClose...");
            this.saveSettings();

        }
    }
}
