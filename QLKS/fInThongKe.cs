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
    public partial class fInThongKe : Form
    {
        string beginDay;
        string endDay;
        public fInThongKe(string beginDay,string endDay)
        {
            InitializeComponent();
            this.beginDay = beginDay;
            this.endDay = endDay;
        }

        private void fInThongKe_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLKSDataSet.USP_InThongKe' table. You can move, or remove it, as needed.
            this.USP_InThongKeTableAdapter.Fill(this.QLKSDataSet.USP_InThongKe,beginDay,endDay);
            this.reportViewer1.RefreshReport();

        }
    }
}
