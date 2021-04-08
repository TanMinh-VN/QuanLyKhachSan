using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class fInHoaDon : Form
    {
        int maBill;
        public fInHoaDon(int maBill)
        {
            InitializeComponent();
            this.maBill = maBill;
        }

        private void fInHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dtSet_InHoaDon.udf_InHoaDon' table. You can move, or remove it, as needed.
            this.udf_InHoaDonTableAdapter.Fill(this.dtSet_InHoaDon.udf_InHoaDon,maBill.ToString());
            this.reportViewer1.RefreshReport();

        }
    }
}
