using QuanLyQuanKaraoke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanKaraoke.Forms
{
    public partial class frmDanhSachPhong : Form
    {
        public frmDanhSachPhong()
        {
            InitializeComponent();
        }
        QLQKDbContext context = new QLQKDbContext();
        string imagesFolder = Application.StartupPath.Replace("bin\\Debug\\net8.0-windows", "Images");


        private void frmDanhSachPhong_Load(object sender, EventArgs e)
        {
            HienThiPhong();
        }

        void HienThiPhong()
        {
            panelPhong.Controls.Clear();

            var dsPhong = context.Phong
                .Select(p => new
                {
                    p.ID,
                    p.TenPhong,
                    p.TrangThai,
                    p.HinhAnh,
                    Gia = p.LoaiPhong.GiaGio
                }).ToList();


            foreach (var p in dsPhong)
            {
                Panel panel = new Panel();
                panel.Size = new Size(200, 315);
                panel.Margin = new Padding(10);
                panel.Tag = p.ID;
                panel.BorderStyle = BorderStyle.FixedSingle;

                // ===== Picture =====
                PictureBox pic = new PictureBox();
                pic.Dock = DockStyle.Top;
                pic.Height = 200;
                pic.SizeMode = PictureBoxSizeMode.StretchImage;

                string path = Path.Combine(imagesFolder, p.HinhAnh);


                if (File.Exists(path))
                {
                    using (var img = Image.FromFile(path))
                    {
                        pic.Image = new Bitmap(img);
                    }
                }
                else
                {
                    pic.BackColor = Color.Black;
                }

                // ===== Label =====
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                bool dangHat = context.DatPhong
                    .Any(x => x.PhongID == p.ID && x.ThoiGianKetThuc == null);

                lbl.Text =
                    p.TenPhong + "\n" +
                    p.Gia.ToString("N0") + "đ\n" +
                    (dangHat ? "Đang hát" : "Trống");

                // ===== Màu =====
                if (p.TrangThai == "Bảo trì")
                    panel.BackColor = Color.Gray;
                else if (dangHat)
                    panel.BackColor = Color.Red;
                else
                    panel.BackColor = Color.LightGreen;

                // ===== Click =====
                panel.Click += Phong_Click;
                pic.Click += Phong_Click;
                lbl.Click += Phong_Click;

                panel.Controls.Add(lbl);
                panel.Controls.Add(pic);

                panelPhong.Controls.Add(panel);

                panelPhong.FlowDirection = FlowDirection.LeftToRight;
                panelPhong.WrapContents = true;
            }
        }

        void Phong_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;

            int phongID = (c is PictureBox || c is Label)
                ? Convert.ToInt32(c.Parent.Tag)
                : Convert.ToInt32(c.Tag);

            Phong phong = context.Phong.Find(phongID);

            if (phong.TrangThai == "Bảo trì")
            {
                MessageBox.Show("Phòng đang sửa chữa!");
                return;
            }
            var dp = context.DatPhong
                .FirstOrDefault(x => x.PhongID == phongID && x.ThoiGianKetThuc == null);

            if (dp == null)
            {
                frmMoPhong f = new frmMoPhong(phongID, frmMain.NVID);
                f.ShowDialog();
                frmDanhSachPhong_Load(sender, e);
            }
            else
            {
                frmLuaChon fchon = new frmLuaChon();

                var result = fchon.ShowDialog();

                if (result == DialogResult.OK)
                {
                    if (fchon.LuaChon == "DongPhong")
                    {
                        dp.ThoiGianKetThuc = DateTime.Now;

                        TimeSpan tg = dp.ThoiGianKetThuc.Value - dp.ThoiGianBatDau;
                        double gio = tg.TotalHours;

                        double tien = gio * (double)context.Phong
                            .Where(p => p.ID == phongID)
                            .Select(p => p.LoaiPhong.GiaGio)
                            .FirstOrDefault();

                        MessageBox.Show($"Giờ: {gio:0.00}\nTiền: {tien:N0}đ");

                        context.SaveChanges();
                        frmDanhSachPhong_Load(sender, e);
                    }
                    else if (fchon.LuaChon == "ThemDV")
                    {
                        frmSuDungDichVu f = new frmSuDungDichVu(dp.ID);
                        f.ShowDialog();
                    }
                }
                else
                {
                    
                    return;
                }
            }
        }
    }
}
