using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class DescPadronNominal : Form
    {
        public DescPadronNominal()
        {
            InitializeComponent();
        }

        private void btndescargar_Click(object sender, EventArgs e)
        {

        }

        private void webpadron_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void DescPadronNominal_Load(object sender, EventArgs e)
        {
            webpadron.Navigate("https://www.youtube.com/channel/UC4qyW9Ta9jpeBGiJRblKdCw");
        }

        private void lblexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btncnv_Click(object sender, EventArgs e)
        {

        }
    }
}
