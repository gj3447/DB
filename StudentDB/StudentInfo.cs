using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDB
{
    public class StudentInfo
    {
        public int m_ID;
        TextBox m_name;
        TextBox m_number;
        TextBox m_memo;
        ComboBox m_gender;
        string m_conn;
        static public List<StudentInfo> m_student_list = new List<StudentInfo>();
        public StudentInfo(int Id, TextBox number, TextBox name, TextBox memo, ComboBox gender)
        {
            m_name = name;
            m_memo = memo;
            m_gender = gender;
            m_ID = Id;
            m_number = number;
            m_gender.Items.Clear();
            m_gender.Items.Add("남자");
            m_gender.Items.Add("여자");
            m_gender.SelectedIndex = 0;
            m_name.Text = "학생 정보없음";
            m_memo.Text = "메모를 입력해주세요";
            m_conn = "Server=49.50.174.201;Database=s5414196;Uid=s5414196;Pwd=s5414196;Charset=utf8";
        }
        public void h_load(int ID)
        {
            if (ID >= 0)
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigManager.m_conn))
                {
                    conn.Open();
                    string query = string.Format("SELECT * FROM Student WHERE ID={0}", ID);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        m_memo.Text = (string)rdr["Memo"];
                        if ((string)rdr["Gender"] == "남자")
                            m_gender.SelectedIndex = 0;
                        else
                            m_gender.SelectedIndex = 1;
                        m_name.Text = (string)rdr["Name"];
                        m_number.Text = (string)rdr["Number"];
                    }
                    else
                    {
                        Console.WriteLine("데이터가 없습니다");
                    }
                    conn.Close();
                }
            }
        }
        public int h_save()
        {
            int ID = ConfigManager.count;
            using (MySqlConnection conn = new MySqlConnection(m_conn))
            {
                conn.Open();
                string gender;
                if (m_gender.SelectedIndex == 0)
                    gender = "남자";
                else
                    gender = "여자";
                string query = string.Format("INSERT INTO Student(Name,Gender,Number,Memo,ID) VALUES ('{0}','{1}','{2}','{3}',{4})"
                    , m_name.Text, gender, m_number.Text, m_memo.Text, ID);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                ConfigManager.count++;
                ConfigManager.h_auto_save();
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            return ID;
        }    
    }
}
