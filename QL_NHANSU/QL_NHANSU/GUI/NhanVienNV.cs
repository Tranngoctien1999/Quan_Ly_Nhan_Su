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
    public partial class NhanVienNV : Form
    {
        MyContext context = new MyContext();
        int kt =0;
        public NhanVienNV()
        {
            InitializeComponent();
            init();
        }
        private void init()
        {
            var TBNV = context.NhanViens.ToList();
            dgvNV.DataSource = TBNV;
        }
        private void hienthi_TTNV(int row)
        {
            var temp = dgvNV.Rows[row];
            txtMaNV.Text = temp.Cells[0].Value.ToString();
            txtTen.Text = temp.Cells[1].Value.ToString();
            dtNS.Value = Convert.ToDateTime(temp.Cells[2].Value);
            txtdiachi.Text = temp.Cells[3].Value.ToString();
            comboBox1.Text = temp.Cells[4].Value.ToString();
            txtluong.Text = temp.Cells[5].Value.ToString();
            txtPhong.Text = temp.Cells[6].Value.ToString();
            try
            {
                var temp1 = temp.Cells[7].Value;
                if (temp1 == null) { txtNgGS.Text = "Không có"; }
                else { txtNgGS.Text = temp1.ToString(); }
            }
            catch { }
            txtSonv.Text = temp.Cells[8].Value.ToString();
            txtEmail.Text = temp.Cells[9].Value.ToString();
            try
            {
                var temp1 = temp.Cells[10].Value;
                if (temp1 == null) { txtSoDT.Text = "Không có"; }
                else { txtSoDT.Text = temp1.ToString(); }
                temp1 = temp.Cells[11].Value;
                if (temp1 == null) { txtchucvu.Text = "Không có"; }
                else { txtchucvu.Text = temp1.ToString(); }
            }
            catch { }
        }
        private void hienthi_TTTN(int manv)
        {
            txtMaNV_TN.Text = manv.ToString();
            var TBTN = context.ThanNhans.Where(x => x.MaNV == manv).OrderByDescending(x => x.TenTN).ToList();
            dgvTN.DataSource = TBTN;
        }
        private void display(int row)
        {
            hienthi_TTNV(row);
            int manv = Convert.ToInt32(dgvNV.Rows[row].Cells[0].Value);
            hienthi_TTTN(manv);
        }

        private void clear()
        {
            txtTen.Text = "";
            dtNS.Value = Convert.ToDateTime("2020/2/2");
            txtdiachi.Text = "";
            comboBox1.Text = "";
            txtluong.Text = "";
            txtPhong.Text = "";
            txtNgGS.Text = "";
            txtSonv.Text = "";
            txtEmail.Text = "";

            txtTenTN.Text = "";
            dtNSTN.Value = Convert.ToDateTime("2020/2/2");
            txtQH.Text = "";
            txtGTTN.Text = "";
        }    
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int manv_max = context.NhanViens.Max(x => x.MaNV) + 1;
            if (Convert.ToInt32(txtMaNV.Text)< manv_max||txtMaNV.Text==null)
            {
                clear();
                txtMaNV.Text = (context.NhanViens.Max(x => x.MaNV) + 1).ToString();
                MessageBox.Show("Mời nhập thông tin");
                return;
            }
            else
            {
                txtMaNV.Text = manv_max.ToString();
                if (txtEmail.Text.Trim()== ""|| txtchucvu.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtluong.Text.Trim() == "" || txtSoDT.Text.Trim() == "" || txtSonv.Text.Trim() == "" || txtTen.Text.Trim() == "" )
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
                else
                {
                    NhanVien nv = new NhanVien();
                    nv.MaNV = Convert.ToInt32(txtMaNV.Text);
                    nv.TenNV = txtTen.Text;
                    nv.NgaySinh= dtNS.Value;
                    nv.DChi = txtdiachi.Text;
                    nv.GTinh = comboBox1.Text;
                    try
                    {
                        nv.Luong = Convert.ToInt32(txtluong.Text);

                    }
                    catch { }
                    nv.MaPB = Convert.ToInt32(txtPhong.Text);
                    nv.NgGS = Convert.ToInt32(txtNgGS.Text);
                    nv.Chucvu = txtchucvu.Text;
                    nv.SDT = txtSoDT.Text;
                    nv.SoNVDuoiQuyen = Convert.ToInt32(txtSonv.Text);
                    nv.Email = txtEmail.Text;
                    context.NhanViens.Add(nv);
                    context.SaveChanges();
                    dgvNV.Refresh();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }

        private void dgvNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvNV.CurrentCell.RowIndex;

            display(row);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if (txtEmail.Text.Trim() == "" || txtchucvu.Text.Trim() == "" || txtdiachi.Text.Trim() == "" || txtluong.Text.Trim() == "" || txtSoDT.Text.Trim() == "" || txtSonv.Text.Trim() == "" || txtTen.Text.Trim() == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }

            else
            {
                NhanVien nv =context.NhanViens.Find(Convert.ToInt32(txtMaNV.Text));
                nv.TenNV = txtTen.Text;
                nv.NgaySinh = dtNS.Value;
                nv.DChi = txtdiachi.Text;
                nv.GTinh = comboBox1.Text;
                try
                {
                    nv.Luong = Convert.ToInt32(txtluong.Text);

                }
                catch { }
                nv.MaPB = Convert.ToInt32(txtPhong.Text);
                nv.NgGS = Convert.ToInt32(txtNgGS.Text);
                nv.Chucvu = txtchucvu.Text;
                nv.SDT = txtSoDT.Text;
                nv.SoNVDuoiQuyen = Convert.ToInt32(txtSonv.Text);
                nv.Email = txtEmail.Text;
                context.SaveChanges();
            }
        }

        private void dgvTN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (txtTenTN.Text.Trim() == "" || txtGTTN.Text.Trim() == "" || txtQH.Text.Trim() == "" )
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
            }

            else
            {
                int manv = Convert.ToInt32(txtMaNV_TN.Text);
                List<ThanNhan> dstn = context.ThanNhans.Where(x=>x.MaNV==manv).OrderByDescending(x=>x.MaNV).ToList();
                dstn = dstn.Where(x => x.TenTN == txtTenTN.Text).OrderByDescending(x=>x.TenTN).ToList();
                ThanNhan tn = dstn[0];
                tn.TenTN = txtTenTN.Text;
                tn.NgaySinh = dtNSTN.Value;
                tn.QuanHe = txtQH.Text;
                tn.GioiTinh = txtGTTN.Text;
                context.SaveChanges();
            }
        }

        private void btnthemTN_Click(object sender, EventArgs e)
        {
            if (kt==0)
            {
                clear();
                MessageBox.Show("Mời nhập thông tin");
                kt = 1;
                return;
            }
            else
            {
                if (txtTenTN.Text.Trim() == "" || dtNSTN.Text.Trim() == "" || txtQH.Text.Trim() == "" || txtGTTN.Text.Trim() == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin");
                }
                else
                {
                    ThanNhan tn = new ThanNhan();
                    tn.MaNV = Convert.ToInt32(txtMaNV_TN.Text);
                    tn.TenTN = txtTenTN.Text;
                    tn.NgaySinh = dtNSTN.Value;
                    tn.QuanHe = txtQH.Text;
                    tn.GioiTinh = txtGTTN.Text;
                    context.ThanNhans.Add(tn);
                    context.SaveChanges();
                    kt = 0;
                    dgvTN.Refresh();
                }
            }
        }

        private void btnSuatn_Click(object sender, EventArgs e)
        {

        }

        private void btnXoaTn_Click(object sender, EventArgs e)
        {
            int manv_tn = Convert.ToInt32(txtMaNV_TN.Text);
            var dsnv = context.ThanNhans.Where(x=>x.MaNV==manv_tn).OrderByDescending(x=>x.MaNV).ToList();
            dsnv = dsnv.Where(x => x.TenTN == txtTenTN.Text).OrderByDescending(x => x.TenTN).ToList();
            var tn = dsnv[0];
            context.ThanNhans.Remove(tn);
            context.SaveChanges();
            dgvNV.Refresh();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clear();
            txtMaNV.Text = "";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            NhanVien nv = context.NhanViens.Find(Convert.ToInt32(txtMaNV.Text));
            context.NhanViens.Remove(nv);
            context.SaveChanges();
            dgvNV.Refresh();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            List<NhanVien> DSNV = new List<NhanVien>();
            switch (cbbTK.Text)
            {
                case "Mã nhân viên":
                    {
                        int manv = Convert.ToInt32(txtKey.Text);
                        DSNV = context.NhanViens.Where(x => x.MaNV == manv).OrderByDescending(x=>x.MaNV).ToList();
                        break;
                    }
                case "Tên nhân viên":
                    {
                        DSNV = context.NhanViens.Where(x => x.TenNV == txtKey.Text).OrderByDescending(x => x.TenNV).ToList();
                        break;
                    }
                case "PB":
                    {
                        int mapb = Convert.ToInt32(txtKey.Text);
                        DSNV = context.NhanViens.Where(x => x.MaPB == mapb).OrderByDescending(x => x.MaNV).ToList();
                        break;
                    }
            }
            dgvNV.DataSource = DSNV;
            dgvNV.Refresh();
        }

        private void btnKP_Click(object sender, EventArgs e)
        {
            clear();
            init();
        }

        private void dgvNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dgvTN.CurrentCell.RowIndex;
            var temp = dgvTN.Rows[row];
            txtMaNV_TN.Text = temp.Cells[0].Value.ToString();
            txtTenTN.Text = temp.Cells[1].Value.ToString();
            txtGTTN.Text = temp.Cells[2].Value.ToString();
            dtNSTN.Value = Convert.ToDateTime(temp.Cells[3].Value);
            txtQH.Text = temp.Cells[4].Value.ToString();
        }

        private void btnHuyTN_Click(object sender, EventArgs e)
        {
            clear();
            txtMaNV_TN.Text = "";
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void duAnToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            
        }

        private void dựÁnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DuAnNV da_nv = new DuAnNV();
            da_nv.Visible = true;
        }

        private void phânCôngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNV nv_da = new AddNV();
            nv_da.Visible = true;
        }
    }
}
