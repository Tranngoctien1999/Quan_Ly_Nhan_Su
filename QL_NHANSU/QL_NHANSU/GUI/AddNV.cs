using QL_NHANSU.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_NHANSU
{
    public partial class AddNV : Form
    {
        MyContext context = new MyContext();
        public AddNV()
        {
            InitializeComponent();
        }
        private void init()
        {
            int mada = Convert.ToInt32(txtMaDA.Text);
            var da_pb = context.DuAns.Where(x=>x.MaDA==mada).Select(x=>x.MaPB).ToList();
            if (da_pb.Count == 0) { MessageBox.Show("Dự án không tồn tại"); }
            else
            {
                int mapb = Convert.ToInt32(da_pb[0]);
                cbbTenNV.DataSource = context.NhanViens.Where(x => x.MaPB == mapb).Select(x=>x.MaNV).ToList();
            }
        }
        private void clear()
        {
            txtMaDA.Text = "1";
            cbbTenNV.Text = "";
            txtSogio.Text = "";
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
              
        }

        private void cbbTenNV_Click(object sender, EventArgs e)
        {
            init();
        }

        private void btnThemDA_NV_Click(object sender, EventArgs e)
        {
            if (txtMaDA.Text.Trim() == "" || cbbTenNV.Text.Trim() == "" || txtSogio.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                int mada = Convert.ToInt32(txtMaDA.Text);
                int manv = Convert.ToInt32(cbbTenNV.Text);
                int sogio= Convert.ToInt32(txtSogio.Text);
                var da = context.PhanCongs.Where(x => x.MaDA == mada).OrderByDescending(x => x.MaNV).ToList();
                da = da.Where(x => x.MaNV == manv).ToList();

                try
                {

                }
                catch { }
                PhanCong pc = context.PhanCongs.Where(x => x.MaDA == mada).Where(x => x.MaNV == manv).OrderBy(x => x.SoGio).ToList()[0];
                if (pc.SoGio == 0)
                {
                    PhanCong pc1 = new PhanCong();
                    pc1.MaDA = mada;
                    pc1.MaNV = manv;
                    pc1.SoGio = sogio;
                    context.PhanCongs.Add(pc1);
                }
                else { pc.SoGio = sogio; }
                context.SaveChanges();
            }
        }

        private void cbbTenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int mada = Convert.ToInt32(txtMaDA.Text);
            int manv = Convert.ToInt32(cbbTenNV.Text);
            var da = context.PhanCongs.Where(x => x.MaDA == mada).ToList();
            var da_sg = da.Where(x => x.MaNV == manv).Select(x => x.SoGio).ToList();
            try
            {
                var sogio = da_sg[0].ToString();
                txtSogio.Text = sogio;
            }
            catch { txtSogio.Text = "0"; }
            
        }
    }
}
