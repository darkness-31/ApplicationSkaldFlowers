using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkaldApplication.Data.Authorization;
using SkaldApplication.Forms.Elements;
using SkaldApplication.Forms.Elements.Autorization;

namespace SkaldApplication
{
    public partial class MainForm : Form
    {
        AccountUser AccountUser { get; set; }

        public MainForm() => InitializeComponent();
        private void CheckTab(TabPage tabPage)
        {
            if (TabsControl.TabCount != 0)
                if (TabsControl.TabPages.ContainsKey(tabPage.Name))
                {
                    var tab = TabsControl.TabPages.IndexOfKey(tabPage.Name);
                    TabsControl.TabPages[tab].Focus();
                    TabsControl.SelectedIndex = tab;
                    return;
                }
            TabsControl.TabPages.Add(tabPage);
        }
        private void ButtonAccountEnter_Click(object sender, EventArgs e)
        {
            UserControlEnterAccounts ucea = new UserControlEnterAccounts();
            ucea.Dock = DockStyle.Fill;
            TabPage tabPage = new TabPage();
            tabPage.Controls.Add(ucea);
            tabPage.Name = ucea.Name;
            tabPage.Text = "Вход";

            ucea.EnteredAccountHandler += (AccountUser account) =>
            {
                TabsControl.TabPages.Clear();
                AccountUser = account;
            };

            CheckTab(tabPage);
        }

        private void ButtonAccountRegistration_Click(object sender, EventArgs e)
        {
            UserControlRegistrationAccounts ucra = new UserControlRegistrationAccounts();
            ucra.Dock = DockStyle.Fill;
            TabPage tabPage = new TabPage();
            tabPage.Controls.Add(ucra);
            tabPage.Name = ucra.Name;
            tabPage.Text = "Регистрация";

            CheckTab(tabPage);
        }



        private void TabsControl_ControlAdded(object sender, ControlEventArgs e)
        {
            if (TabsControl.TabPages.Count > 0)
            {
                ButtonCloseTab.Visible = true;
            }
        }

        private void ButtonCloseTab_MouseClick(object sender, MouseEventArgs e)
        {
            TabsControl.TabPages.Remove(TabsControl.SelectedTab);
        }

        private void TabsControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            if (TabsControl.TabPages.Count <= 1)
            {
                ButtonCloseTab.Visible = false;
            }
        }
    }
}
