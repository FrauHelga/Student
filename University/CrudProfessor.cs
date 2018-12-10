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
    public partial class CrudProfessor : Form
    {
        public CrudProfessor()
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

        private void button7_Click(object sender, EventArgs e)
        {
            Hide();
            CRUD create = new CRUD();
            create.ShowDialog();
            Close();
        }
    }
}
