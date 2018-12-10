using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class HomeProfessor : Form
    {
        public HomeProfessor()
        {
            InitializeComponent();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Examen examen = new Examen();
            examen.ShowDialog();
            Close();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SemesterAverageGrate semester = new SemesterAverageGrate();
            semester.ShowDialog();
            Close();

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ListStudent list = new ListStudent();
            list.ShowDialog();
            Close();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ListOfGrade grade = new ListOfGrade();
            grade.ShowDialog();
            Close();
        }
    }
    
}
