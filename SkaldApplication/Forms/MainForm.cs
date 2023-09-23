using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkaldApplication.Forms.Elements;

namespace SkaldApplication
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ButtonAccountEnter_Click(object sender, EventArgs e)
        {
            UserControlEnterAccounts ucea = new UserControlEnterAccounts();
            SplitContainer.Panel2.Controls.Add(ucea);
        }
    }
}
