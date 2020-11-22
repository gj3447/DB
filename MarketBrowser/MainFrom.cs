using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketBrowser
{
    public partial class MainFrom : Form
    {
        public MainFrom()
        {
            InitializeComponent();
        }

        private List<string> h_read_line(string data)
        {
            string[] value = data.Split(',');
            List<string> list = new List<string>();
            string stemp = "";
            bool merge = true;
            foreach(string e in value)
            {
                if(e.Contains('('))
                    merge = false;
                if (e.Contains(')'))
                    merge = true;
                stemp += e;
                if(merge)
                {
                    list.Add(stemp);
                    stemp = "";
                }
            }
            return list;
        }
        private List<List<string>> h_culum_create(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.Default);
            List<List<string>> data = new List<List<string>>();
            List<string> header = h_read_line(sr.ReadLine());
            int length = 0;
            foreach(string e in header)
            {
                List<string> ltemp = new List<string>();
                ltemp.Add(e);
                data.Add(ltemp);
                length++;
            }
            while(sr.EndOfStream==false)
            {
                List<string> row = h_read_line(sr.ReadLine());
                for(int i = 0; i<length;i++)
                {
                    data[i].Add(row[i]);
                }
            }
            sr.Close();
            return data;
        }
        private List<List<string>>h_row_create(string filename)
        {
            StreamReader sr = new StreamReader(new FileStream(filename, FileMode.Open), Encoding.Default);
            List<List<string>> data = new List<List<string>>();
            List<string> header = h_read_line(sr.ReadLine());
            data.Add(header);
            while (sr.EndOfStream == false)
            {
                List<string> row = h_read_line(sr.ReadLine());
                data.Add(row);
            }
            sr.Close();
            return data;
        }
        private void h_print_culum_base_culum(List<List<string>> data)
        {
            string stemp = "";
            foreach(List<string> line in data)
            {
                bool start = true;
                foreach(string e in line)
                {
                    stemp += e;
                    if (start)
                    {
                        start = false;
                        stemp += "\r\n";
                    }
                }
                stemp += "\r\n";
            }
            textBoxDisplay.Text = stemp;
        }
        private void h_print_row_base_culum(List<List<string>> data)
        {
            string stemp = "";
            for(int i = 0; i< data[0].Count;i++)
            {
                for(int j = 0; j<data.Count;j++)
                {
                    stemp += data[j][i] + "\t";
                }
                stemp += "\r\n";
            }
            textBoxDisplay.Text = stemp;
        }
        private void h_print_row_base_row(List<List<string>> data)
        {
            string stemp = "";
            foreach(List<string> line in data)
            {
                foreach(string e in line)
                {
                    stemp += e+"\t";
                }
                stemp += "\r\n";
            }
            textBoxDisplay.Text = stemp;
        }
        private void h_print_culum_base_row(List<List<string>>data)
        {
            string stemp = "";
            for(int i = 0; i<data[0].Count;i++)
            {
                bool start = true;
                for(int j = 0; j<data.Count;j++)
                {
                    stemp += data[j][i];
                    if (start)
                    {
                        start = false;
                        stemp += "\r\n";
                    }
                }
                stemp+="\r\n";
            }
            textBoxDisplay.Text = stemp;
        }
        private void h_set_header_list(List<string> header)
        {
            foreach (var e in header)
            {
                listBoxCulum.Items.Add(e);
            }

        }
        private bool h_stirng_same_string(string target,string contain)
        {
            if (contain.Length > 0)
            {
                for (int i = 0; i < target.Length; i++)
                {
                    if (target[i] == contain[0])
                    {
                        bool end = true;
                        for (int j = 1; j < contain.Length; j++)
                        {
                            if (target[i + j] != contain[j])
                            {
                                end = false;
                                break;
                            }
                        }
                        if (end)
                            return true;
                    }
                }
                return false;
            }
            else
                return true;
        }
        private void buttonOpenCSV_Click(object sender, EventArgs e)
        {
            var FD = new OpenFileDialog();
            DialogResult dresult = FD.ShowDialog();

            if(dresult == DialogResult.OK)
            {
                string filename = FD.FileName;
                m_data = h_row_create(filename);

                h_set_header_list(m_data[0]);
                h_print_row_base_culum(m_data);
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string data = "";
            foreach (List<string> row in m_data)
            {
                string stemp =row[listBoxCulum.SelectedIndex];
                if(h_stirng_same_string(stemp,textBoxSearch.Text))
                {
                    data += stemp+"\r\n";
                    
                }
            }
            textBoxSearchReasult.Text = data;
        }
        string strconn = "Server=49.50.174.201;Database=s5414196;Uid=s5414196;Pwd=s5414196;Charset=utf8";
        private void buttonInsert_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(strconn))
            {
                conn.Open();
                //string query = "INSERT INTO Studant(name,gender) VALUES ('미히누나','남자')";
                string query = "INSERT INTO Student(Name, Gender, Number, Memo, ID) VALUES ('라경준','남자','5414196','메모','1')";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
    }
}
