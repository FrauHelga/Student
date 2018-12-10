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
    public partial class CRUD : Form
    {
        public CRUD()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Hide();
            HomeAdmin home = new HomeAdmin();
            home.ShowDialog();
            Close();
        }

        private void CRUD_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            CrudTheme theme = new CrudTheme();
            theme.ShowDialog();
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            CrudProfessor info = new CrudProfessor();
            info.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            CrudStudent student = new CrudStudent();
            student.ShowDialog();
            Close();
        }
    }
}
