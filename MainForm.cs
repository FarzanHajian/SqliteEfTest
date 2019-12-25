using System;
using System.Linq;
using System.Windows.Forms;
using SqliteEfTest.DAL;

namespace SqliteEfTest
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (MainContext ctx = new MainContext())
            {
                grdData.DataSource = ctx.Industries.ToList();
            }
        }
    }
}