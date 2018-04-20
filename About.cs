using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace ReverseText
{
    public partial class About : MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.flaticon.com/authors/creaticca-creative-agency");
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            
            Process.Start("http://creativecommons.org/licenses/by/3.0/");
        }
    }
}
