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
    public partial class DuAnNV : Form
    {
        MyContext context = new MyContext();
        int kt = 0;
        public DuAnNV()
        {
            InitializeComponent();
            dgvDuAn.AutoGenerateColumns = false;
            dgvPC.AutoGenerateColumns = false;
            init();
        }
        private void init()
        {
            var TBDA = context.DuAns.ToList();
            dgvDuAn.DataSource = TBDA;
            dgvDuAn.Refresh();
        }
        private void init_PC()
        {
            int mada = Convert.ToInt32(txtMaDA_PC.Text);
            var TBPC = context.PhanCongs.Where(x=>x.MaDA==mada).ToList();
            dgvPC.DataSource = TBPC;
            dgvPC.Refresh();
        }
        private void clear()
        {
            txtTenDA.Text = "";
            cbbMaPB.Text = "";
            txtDD.Text = "";
            txtsogio.Text = "";
        }
        private void hienthi_TTDA(int row)
        {
            var temp = dgvDuAn.Rows[row];
            txtMaDA.Text = temp.Cells[0].Value.ToString();
            txtTenDA.Text = temp.Cells[1].Value.ToString();
            cbbMaPB.Text = temp.Cells[2].Value.ToString();
            txtDD.Text = temp.Cells[3].Value.ToString();
            txtsogio.Text = temp.Cells[4].Value.ToString();
        }
        private void hienthi_TTPC(int mada)
        {
            txtMaDA_PC.Text = mada.ToString();
            var TBPC = context.PhanCongs.Where(x => x.MaNV == mada).OrderByDescending(x => x.MaNV).ToList();
            dgvPC.DataSource = TBPC;
        }
        private void display(int row)
        {
            hienthi_TTDA(row);
            int mada = Convert.ToInt32(dgvDuAn.Rows[row].Cells[0].Value);
            hienthi_TTPC(mada);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            int mada_max = context.DuAns.Max(x => x.MaDA)+1;
            if (Convert.ToInt32(txtMaDA.Text) < mada_max || txtMaDA.Text == null)
            {
                clear();
                txtMaDA.Text = (context.DuAns.Max(x => x.MaDA) + 1).ToString();
                MessageBox.Show("Mời nhập thông tin");
                return;
            }
            else
            {
                txtMaDA.Text = mada_max.ToString();
                if (txtMaDA.Text.Trim() == "" || txtTenDA.Text.Trim() == "" || cbbMaPB.Text.Trim() == "" || txtDD.Text.Trim() == "" || txtsogio.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
                else
                {
                    DuAn da = new DuAn();
                    da.MaDA = Convert.ToInt32(txtMaDA.Text);
                    da.TenDA = txtTenDA.Text;
                    da.MaPB = Convert.ToInt32(cbbMaPB.Text);
                    da.DiaDiem = txtDD.Text;
                    da.tongsogio = Convert.ToInt32(txtsogio.Text);
                    context.DuAns.Add(da);
                    context.SaveChanges();
                }
            }
            init();
            dgvDuAn.Refresh();
        }

        private void dgvDuAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvDuAn.CurrentCell.RowIndex;

            display(row);
        }

        private void dgvPC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvPC.CurrentCell.RowIndex;
            var temp = dgvPC.Rows[row];
            txtMaDA_PC.Text = temp.Cells[0].Value.ToString();
            txtMaNV_PC.Text = temp.Cells[1].Value.ToString();
            txtSG_PC.Text = temp.Cells[2].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DuAn da = context.DuAns.Find(Convert.ToInt32(txtMaDA.Text));
            context.DuAns.Remove(da);
            context.SaveChanges();
            init();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<DuAn> DSDA = new List<DuAn>();
            switch (cbbTK.Text)
            {
                case "Mã dự án":
                    {
                        int mada = Convert.ToInt32(txtKey.Text);
                        DSDA = context.DuAns.Where(x => x.MaDA == mada).OrderByDescending(x => x.TenDA).ToList();
                        break;
                    }
                case "Tên dự án":
                    {
                        DSDA = context.DuAns.Where(x => x.TenDA == txtKey.Text).OrderByDescending(x => x.MaDA).ToList();
                        break;
                    }
                case "PB":
                    {
                        int mapb = Convert.ToInt32(txtKey.Text);
                        DSDA = context.DuAns.Where(x => x.MaPB == mapb).OrderByDescending(x => x.MaDA).ToList();
                        break;
                    }
            }
            dgvDuAn.DataSource = DSDA;
            dgvDuAn.Refresh();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaDA.Text.Trim() == "" || txtTenDA.Text.Trim() == "" || cbbMaPB.Text.Trim() == "" || txtDD.Text.Trim() == "" || txtsogio.Text.Trim() == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }
            else
            {
                DuAn da = context.DuAns.Find(Convert.ToInt32(txtMaDA.Text));
                da.TenDA = txtTenDA.Text;
                da.MaPB = Convert.ToInt32(cbbMaPB.Text);
                da.DiaDiem = txtDD.Text;
                da.tongsogio = Convert.ToInt32(txtsogio.Text);
                context.SaveChanges();
                init();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (kt == 0)
            {
                clear();
                MessageBox.Show("Mời nhập thông tin");
                kt = 1;
                return;
            }
            else
            {
                if (txtMaDA_PC.Text.Trim() == "" || txtMaNV_PC.Text.Trim() == "" || txtSG_PC.Text.Trim() == "" )
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
                else
                {
                    PhanCong pc = new PhanCong();
                    pc.MaDA = Convert.ToInt32(txtMaDA_PC.Text);
                    pc.MaNV = Convert.ToInt32(txtMaNV_PC.Text);
                    pc.SoGio = Convert.ToInt32(txtSG_PC.Text);
                    context.PhanCongs.Add(pc);
                    context.SaveChanges();
                    kt = 0;
                    init_PC();
                }
            }

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int mada_pc = Convert.ToInt32(txtMaDA_PC.Text);
            int manv_pc = Convert.ToInt32(txtMaNV_PC.Text);
            var dspc = context.PhanCongs.Where(x => x.MaDA == mada_pc).OrderByDescending(x => x.MaDA).ToList();
            dspc = dspc.Where(x => x.MaNV == manv_pc).OrderByDescending(x => x.MaNV).ToList();
            var pc = dspc[0];
            context.PhanCongs.Remove(pc);
            context.SaveChanges();
            init_PC();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtMaDA_PC.Text.Trim() == "" || txtMaNV_PC.Text.Trim() == "" || txtSG_PC.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }

            else
            {
                int manv_pc = Convert.ToInt32(txtMaNV_PC.Text);
                int mada_pc = Convert.ToInt32(txtMaDA_PC.Text);
                List<PhanCong> dspc = context.PhanCongs.Where(x => x.MaNV == manv_pc).OrderByDescending(x => x.MaNV).ToList();
                dspc = dspc.Where(x => x.MaDA == mada_pc).OrderByDescending(x => x.MaDA).ToList();
                PhanCong pc = dspc[0];
                pc.MaDA = mada_pc;
                pc.MaNV = manv_pc;
                pc.SoGio = Convert.ToInt32(txtSG_PC.Text);
                context.SaveChanges();
                init_PC();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            txtMaDA_PC.Text = "";
            txtMaNV_PC.Text = "";
            txtSG_PC.Text = "";
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

        private void phòngBanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            PB pb = new PB();
            pb.Visible = true;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Visible = true;
            this.Hide();
        }
    }
}