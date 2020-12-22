using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QL_NHANSU.Data;

namespace QL_NHANSU.GUI
{
    public partial class PB : Form
    {
        MyContext context = new MyContext();
        public PB()
        {
            InitializeComponent();
            dgvPB.AutoGenerateColumns = false;
            init();
        }
        private void init()
        {
            var TBPB = context.PhongBans.ToList();
            dgvPB.DataSource = TBPB;
            dgvPB.Refresh();
        }
        private void display(int row)
        {
            var temp = dgvPB.Rows[row];
            txtMaPhong.Text = temp.Cells[0].Value.ToString();
            txtTenPhong.Text = temp.Cells[1].Value.ToString();
            txtSoNV.Text = temp.Cells[4].Value.ToString();
            DateNC.Value= Convert.ToDateTime(temp.Cells[3].Value);

            int mapb = Convert.ToInt32(txtMaPhong.Text);
            var TBTP = context.NhanViens.Where(x => x.MaPB == mapb).Select(x => x.MaNV).ToList();
            cbbTP.DataSource = TBTP;
            cbbTP.Refresh();
            cbbTP.Text = temp.Cells[2].Value.ToString();

        }
        private void clear()
        {
            txtMaPhong.Text = "";
            DateNC.Value = Convert.ToDateTime("2020/2/2");
            txtTenPhong.Text = "";
            cbbTP.Text = "";
            txtSoNV.Text = "";
        }
        private void dgvPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvPB.CurrentCell.RowIndex;

            display(row);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int mapb_max = context.PhongBans.Max(x => x.MaPB) + 1;
            if (Convert.ToInt32(txtMaPhong.Text) < mapb_max || txtMaPhong.Text == null)
            {
                clear();
                txtMaPhong.Text = (context.PhongBans.Max(x => x.MaPB) + 1).ToString();
                MessageBox.Show("Mời nhập thông tin");
                return;
            }
            else
            {
                txtMaPhong.Text = mapb_max.ToString();
                if (txtTenPhong.Text.Trim() == "" || txtSoNV.Text.Trim() == "" || cbbTP.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
                else
                {
                    PhongBan pb = new PhongBan();
                    pb.MaPB = Convert.ToInt32(txtMaPhong.Text);
                    pb.TenPB = txtTenPhong.Text;
                    pb.Ng_NC = DateNC.Value;
                    pb.MaTP = Convert.ToInt32(cbbTP.Text);
                    context.PhongBans.Add(pb);
                    context.SaveChanges();
                    dgvPB.Refresh();
                    init();
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            PhongBan pb = context.PhongBans.Find(Convert.ToInt32(txtMaPhong.Text));
            context.PhongBans.Remove(pb);
            context.SaveChanges();
            init();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtTenPhong.Text.Trim() == "" || txtSoNV.Text.Trim() == "" || cbbTP.Text.Trim() == "")
            {
                    MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                PhongBan pb = context.PhongBans.Find(Convert.ToInt32(txtMaPhong.Text));
                pb.TenPB = txtTenPhong.Text;
                pb.Ng_NC = DateNC.Value;
                pb.SoNV = Convert.ToInt32(txtSoNV.Text);
                pb.MaTP = Convert.ToInt32(cbbTP.Text);
                context.SaveChanges();
                init();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<PhongBan> DSPB = new List<PhongBan>();
            switch (cbbKey.Text)
            {
                case "Mã PB":
                    {
                        int mapb = Convert.ToInt32(txtKey.Text);
                        DSPB = context.PhongBans.Where(x => x.MaPB == mapb).OrderByDescending(x => x.MaPB).ToList();
                        break;
                    }
                case "Tên PB":
                    {
                        DSPB = context.PhongBans.Where(x => x.TenPB == txtKey.Text).OrderByDescending(x => x.TenPB).ToList();
                        break;
                    }
            }
            dgvPB.DataSource = DSPB;
            dgvPB.Refresh();
        }

        private void btnKP_Click(object sender, EventArgs e)
        {
            init();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            NhanVienNV add = new NhanVienNV();
            add.Visible = true;
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            DuAnNV da = new DuAnNV();
            da.Visible = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Visible = true;
            this.Hide();
        }
    }
}
