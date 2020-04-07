using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Forma1.controller;
using Forma1.myexeption;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        F1Controller controller;
        public Form1Form()
        {
            controller = new F1Controller();
            InitializeComponent();
        }

        private void buttonInitializeData_Click(object sender, EventArgs e)
        {
            controller.initializeTestData();
            listBoxTeam.DataSource = controller.getTeamNames();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
    }
}
