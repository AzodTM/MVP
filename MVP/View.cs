using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
            Presentor.CountObjectPlus();
        }
        ~View()
        {
            Presentor.CountObjectMinus();
        }

        private void buttonShowCountObject_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Presentor.GetCountObject()));
        }

        private void buttonShowCoordinateX_Click(object sender, EventArgs e)
        {

        }

        private void buttonShowCoordinateY_Click(object sender, EventArgs e)
        {
            richTextBoxMain.Text = "123123";
        }
    }
}
