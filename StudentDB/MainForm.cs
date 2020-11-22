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

namespace StudentDB
{
    public partial class MainForm : Form
    {
        static MainForm mainform;
        public static MainForm Get { get { return mainform; } }
        public MainForm()
        {
            InitializeComponent();
            h_start();
        }
        private void h_start()
        {
            mainform = this;
            List<StudentInfo> m_student_list = new List<StudentInfo>();
            m_student_list.Add(new StudentInfo(1, textBoxStudent1Number, textBoxStudent1Name, textBoxStudent1memo, comboBoxStudent1Gender));
            m_student_list.Add(new StudentInfo(2, textBoxStudent2Number, textBoxStudent2Name, textBoxStudent2memo, comboBoxStudent2Gender));
            m_student_list.Add(new StudentInfo(3, textBoxStudent3Number, textBoxStudent3Name, textBoxStudent3memo, comboBoxStudent3Gender));
            MajorInfo.Set(listBoxMajorList, m_student_list);
            ConfigManager.Set(m_student_list, listBoxMajorList, checkBoxStudentAutoload, checkBoxMajorAutoload,labelStudantAmount);
        }

        private void buttonStudentLoad_Click(object sender, EventArgs e)
        {
            MajorInfo.h_load();
            ConfigManager.h_amount();
        }
        private void buttonStudent1delete_Click(object sender, EventArgs e)
        {
            MajorInfo.h_delete(1);
            ConfigManager.h_amount();
        }
        private void buttonStudent2delete_Click(object sender, EventArgs e)
        {
            MajorInfo.h_delete(2);
            ConfigManager.h_amount();
        }
        private void buttonStudent3delete_Click(object sender, EventArgs e)
        {
            MajorInfo.h_delete(3);
            ConfigManager.h_amount();
        }

        private void buttonStudent1Save_Click(object sender, EventArgs e)
        {
            MajorInfo.h_save(1);
            ConfigManager.h_amount();
        }

        private void buttonStudent2Save_Click(object sender, EventArgs e)
        {
            MajorInfo.h_save(2);
            ConfigManager.h_amount();
        }

        private void buttonStudent3Save_Click(object sender, EventArgs e)
        {
            MajorInfo.h_save(3);
            ConfigManager.h_amount();
        }

        private void buttonMajorAdd_Click(object sender, EventArgs e)
        {
            string name = textBoxMajorName.Text;
            MajorInfo.h_list_add(name);
        }

        private void checkBoxMajorAutoload_CheckedChanged(object sender, EventArgs e)
        {
            ConfigManager.h_auto_save();
        }
        private void checkBoxAutoload_CheckedChanged(object sender, EventArgs e)
        {
            ConfigManager.h_auto_save();
        }

        private void listBoxMajorList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConfigManager.h_auto_save();
        }
    }
}
