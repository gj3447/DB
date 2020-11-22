using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentDB
{
    class MajorInfo
    {
        public static ListBox m_major_list { get; set; }
        public static List<StudentInfo> m_student_list;
        static MajorInfo majorinfo;
        public static MajorInfo Get{get{return majorinfo;} }
        static public void Set(ListBox major_list, List<StudentInfo> student_list)
        {
            m_major_list = major_list;
            m_student_list = student_list;
            h_list_load();
        }
        public void Set()
        {
            majorinfo = this;
        }
        static public void h_list_add(string name_)
        {
            foreach(string e in m_major_list.Items)
            {
                if(e==name_)
                {
                    MessageBox.Show("중복된 전공이 있습니다!");
                    return;
                }
            }
            m_major_list.Items.Add(name_);

            using (MySqlConnection conn = new MySqlConnection(ConfigManager.m_conn))
            {
                conn.Open();
                string query = string.Format("INSERT INTO Major (Student1_key,Student2_key,Student3_key,Name,ID) VALUES(-1,-1,-1,'{0}',{1})",name_,m_major_list.Items.Count-1);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
        }
        static void h_list_load()
        {
            using (MySqlConnection conn = new MySqlConnection(ConfigManager.m_conn))
            {
                conn.Open();
                string query = string.Format("SELECT * FROM Major");
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    string name_ = (string)rdr["Name"];
                    m_major_list.Items.Add(name_);
                }
                conn.Close();
            }
        }
        static public void h_save(int number)
        {
            int index = m_major_list.SelectedIndex;
            if (index >= 0)
            {
                StudentInfo studentinfo = m_student_list[number - 1];
                int ID = (int)studentinfo.h_save();
                using (MySqlConnection conn = new MySqlConnection(ConfigManager.m_conn))
                {
                    conn.Open();
                    string studentnumber = string.Format("Student{0}_key", number);
                    string query = string.Format("UPDATE Major SET {0} ={1} WHERE ID={2}", studentnumber, ID, index);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("전공을 선택해주십시오");
            }
        }
        static public void h_delete(int number)
        {
            int index = m_major_list.SelectedIndex;
            if (index >= 0)
            {
                StudentInfo studentinfo = m_student_list[number - 1];
                using (MySqlConnection conn = new MySqlConnection(ConfigManager.m_conn))
                {
                    conn.Open();
                    string studentnumber = string.Format("Student{0}_key", number);
                    string query = string.Format("UPDATE Major SET {0} ={1} WHERE ID={2}", studentnumber, -1, index);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("전공을 선택해주십시오");
            }
        }
        static public void h_load()
        {
            int index = m_major_list.SelectedIndex;
            if (index >= 0)
            {
                using (MySqlConnection conn = new MySqlConnection(ConfigManager.m_conn))
                {
                    conn.Open();
                    string query = string.Format("SELECT * from Major WHERE ID={0}", index);
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        int student1_key = (int)rdr["Student1_key"];
                        int student2_key = (int)rdr["Student2_key"];
                        int student3_key = (int)rdr["Student3_key"];
                        m_student_list[0].h_load(student1_key);
                        m_student_list[1].h_load(student2_key);
                        m_student_list[2].h_load(student3_key);
                    }
                    else
                    {
                        Console.WriteLine("데이터가 없습니다");
                    }
                    conn.Close();
                }
            }
        }
    }
}