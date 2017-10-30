using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIDMaker
{
    public partial class frmGUIDMaker : Form
    {
        public frmGUIDMaker()
        {
            InitializeComponent();
        }

        private void btnMake_Click(object sender, EventArgs e)
        {
            StringBuilder strBuilder = new StringBuilder();
            decimal decCount = nudCount.Value;
            for (decimal d = 0; d < decCount; d++)
            {
                object guid = Guid.NewGuid();

                string strGUID = guid.ToString();
                if (!chkWithHyphen.Checked)
                {
                    strGUID = strGUID.Replace("-", "");
                }

                strBuilder.AppendLine(strGUID);

            }
            txtGUIDs.Text = strBuilder.ToString();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtGUIDs.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
