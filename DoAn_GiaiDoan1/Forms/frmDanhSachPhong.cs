using Microsoft.EntityFrameworkCore;
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
                .Where(p => p.TrangThai != "Ngưng hoạt động")
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

                // Picture
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

                // Label
                Label lbl = new Label();
                lbl.Dock = DockStyle.Fill;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                bool dangHat = context.DatPhong
                    .Any(x => x.PhongID == p.ID && x.ThoiGianKetThuc == null);

                lbl.Text =
                    p.TenPhong + "\n" +
                    p.Gia.ToString("N0") + "VNĐ\n" +
                    (dangHat ? "Đang hát" : "Trống");

                // Màu
                if (p.TrangThai == "Ngưng hoạt động")
                    panel.BackColor = Color.Black;
                else if (p.TrangThai == "Bảo trì")
                    panel.BackColor = Color.Gray;
                else if (dangHat)
                    panel.BackColor = Color.Red;
                else
                    panel.BackColor = Color.LightGreen;

                // Click
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

            if (phong.TrangThai == "Ngưng hoạt động")
            {
                MessageBox.Show("Phòng đã ngưng hoạt động!");
                return;
            }

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

                        var hoaDon = context.HoaDon
                             .FirstOrDefault(x => x.DatPhongID == dp.ID);

                        if (hoaDon == null)
                        {
                            hoaDon = new HoaDon
                            {
                                DatPhongID = dp.ID,
                                ThoiGianLap = DateTime.Now
                            };

                            context.HoaDon.Add(hoaDon);
                            context.SaveChanges();
                        }

                        TimeSpan tg = dp.ThoiGianKetThuc.Value - dp.ThoiGianBatDau;
                        double gio = Math.Round(tg.TotalHours, 2);

                        decimal gia = (decimal)context.Phong
                            .Where(p => p.ID == phongID)
                            .Select(p => p.LoaiPhong.GiaGio)
                            .FirstOrDefault();

                        ChiTietHoaDon ct = new ChiTietHoaDon
                        {
                            HoaDonID = hoaDon.ID,
                            Loai = "Phong",
                            Ten = phong.TenPhong,
                            SoLuong = gio,
                            DonGia = gia,
                            ThanhTien = (decimal)gio * gia
                        };

                        context.ChiTietHoaDon.Add(ct);

                        // lấy danh sách dịch vụ đã dùng
                        var dsDV = context.SuDungDichVu
                            .Where(x => x.DatPhongID == dp.ID)
                            .Include(x => x.DichVu)
                            .ToList();

                        foreach (var item in dsDV)
                        {
                            ChiTietHoaDon ctDV = new ChiTietHoaDon
                            {
                                HoaDonID = hoaDon.ID,
                                Loai = "DichVu",
                                Ten = item.DichVu.TenDV,
                                SoLuong = item.SoLuong,
                                DonGia = item.DichVu.DonGia,
                                ThanhTien = item.SoLuong * item.DichVu.DonGia
                            };

                            context.ChiTietHoaDon.Add(ctDV);
                        }

                        context.SaveChanges();
                        MessageBox.Show("Đóng phòng thành công!");
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            frmDanhSachPhong_Load(sender, e);
        }
    }
}
