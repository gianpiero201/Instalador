using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instalador
{
    public partial class Instalador : DevExpress.XtraEditors.XtraForm
    {
        public Instalador()
        {
            InitializeComponent();
        }

        public void Test()
        {
            MessageBox.Show("teste");
        }

        private void LoginBtn_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            MessageBox.Show("teste");
        }
    }
}