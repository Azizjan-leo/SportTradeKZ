using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aziza
{
    public partial class ContractorForm : Form
    {
        public ContractorForm()
        {
            InitializeComponent();
        }

        private void IsIndContrChBx_CheckedChanged(object sender, EventArgs e)
        {
            if(((CheckBox)sender).Checked)
            {
                NameLbl.Text = "Наименование";
                FullNameLbl.Text = "Полное наименование";
            }
            else
            {
                NameLbl.Text = "Имя";
                FullNameLbl.Text = "Полное имя";
            }
        }
    }
}
