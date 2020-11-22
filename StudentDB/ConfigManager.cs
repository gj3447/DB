using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDB
{
    public class ConfigManager
    {
        public static CheckBox m_student_auto_load;
        public static CheckBox m_major_auto_load;
        public static List<StudentInfo> m_student_list = new List<StudentInfo>();
        public static ListBox m_major_list;
        public static int count;
        public static Label m_student_amount;
        public static readonly string m_conn = "Server=49.50.174.201;Database=s5414196;Uid=s5414196;Pwd=s5414196;Charset=utf8";
        static ConfigManager configmanager;
        public static ConfigManager Get { get { return configmanager; } }
        public static void Set(List<StudentInfo> student_list,ListBox mojor_list, CheckBox student_load,CheckBox major_load,Label amount)
        {
            m_major_list = mojor_list;
            m_student_auto_load = student_load;
            m_major_auto_load = major_load;
            m_student_list = student_list;
            m_student_amount = amount;
            h_auto_load();
        }
        public void Set()
        {
            configmanager = this;
        }
        public static void h_amount()
        {
            int count_ = 0;
            using (MySqlConnection conn = new MySqlConnection(ConfigManager.m_conn))
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Major");
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    if ((int)rdr["Student1_key"] >= 0)
                        count_++;
                    if ((int)rdr["Student2_key"] >= 0)
                        count_++;
                    if ((int)rdr["Student3_key"] >= 0)
                        count_++;
                }
                conn.Close();
            }
            m_student_amount.Text = string.Format("학생수 = {0}", count_.ToString());
        }
        public static void h_auto_save()
        {
            StreamWriter sw = new StreamWriter(new FileStream("auto.dat", FileMode.Create));
            if (m_student_auto_load.Checked)
                sw.WriteLine("student_check");
            else
                sw.WriteLine("student_non");
            if (m_major_auto_load.Checked)
                sw.WriteLine("major_index={0}",m_major_list.SelectedIndex);
            else
                sw.WriteLine("major_non");
            sw.WriteLine(string.Format("count={0}",count.ToString()));
            sw.Close();
        }
        public static void h_auto_load()
        {
            FileInfo info = new FileInfo("auto.dat");
            if (info.Exists)
            {
                StreamReader sr = new StreamReader(new FileStream("auto.dat", FileMode.Open));
                string student_ = sr.ReadLine();
                string major_ = sr.ReadLine();
                string count_ = sr.ReadLine();
                sr.Close();
                if (major_ != null)
                { 
                    if (major_ != "major_non")
                    {
                        m_major_auto_load.Checked = true;
                        string[] smajordata = major_.Split('=');
                        m_major_list.SelectedIndex = int.Parse(smajordata[1]);
                    }
                }
                if (student_ != null)
                {
                    if (student_ != "student_non")
                    {
                        m_student_auto_load.Checked = true;
                        MajorInfo.h_load();
                    }
                }
                if (count_ != null)
                {
                    string[] sdata = count_.Split('=');
                    count = int.Parse(sdata[1]);
                }
            }
            h_amount();

        }
        
    }
}
