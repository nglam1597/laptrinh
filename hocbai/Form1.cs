using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using hocbai.UC;
namespace hocbai
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DongTab()
        {
            TabItem tabItem = TabHeThong.SelectedTab;
            DialogResult dialogResult = MessageBox.Show("Bạn Có Chắc Chắn Đóng Trang : " + tabItem.Text,
                "Xác Nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (TabHeThong.SelectedTabIndex != 0)
                {
                    TabHeThong.Tabs.Remove(tabItem); // xóa theo tab được chọn 
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void rbHeThong_Click(object sender, EventArgs e)
        {

        }

        private void btnThoatHeThong_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn Muốn Thoát Khỏi Hệ Thống", "Xác Nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void addtab(string tabname, UserControl control)
        {
            foreach (TabItem tabPage in TabHeThong.Tabs)
            {
                if (tabPage.Text == tabname)
                {
                    TabHeThong.SelectedTab = tabPage;
                    return;
                }
            }
            TabControlPanel newtabpannel = new DevComponents.DotNetBar.TabControlPanel();
            TabItem newtab = new TabItem(this.components);
            newtabpannel.Dock = System.Windows.Forms.DockStyle.Fill;
            newtabpannel.Location = new System.Drawing.Point(0, 26);
            newtabpannel.Name = tabname;
            newtabpannel.Padding = new System.Windows.Forms.Padding(1);
            newtabpannel.Size = new System.Drawing.Size(1230, 384);
            newtabpannel.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
            newtabpannel.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            newtabpannel.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            newtabpannel.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
            newtabpannel.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right)
                                        | DevComponents.DotNetBar.eBorderSide.Bottom)));
            newtabpannel.Style.GradientAngle = 90;
            newtabpannel.TabIndex = 2;

            newtabpannel.TabItem = newtab;
            Random ran = new Random();
            newtab.Name = tabname + ran.Next(100000) + ran.Next(22342);

            newtab.AttachedControl = newtabpannel;
            newtab.Text = tabname;
            newtab.CloseButtonVisible = true;
            control.Dock = DockStyle.Fill;
            newtabpannel.Controls.Add(control);
            TabHeThong.Controls.Add(newtabpannel);
            TabHeThong.Tabs.Add(newtab);
            TabHeThong.SelectedTab = newtab;
        }

        private void btbKhoHang_Click(object sender, EventArgs e)
        {
            UCKhoHang uCKhoHang = new UCKhoHang();
            addtab("Kho Hàng ", uCKhoHang);
        }

        private void MenuItemDongTrang_Click(object sender, EventArgs e)
        {
            DongTab();
        }

        private void TabHeThong_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            DongTab();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            UCNhaCungCap uCNhaCungCap = new UCNhaCungCap();
            addtab("Nhà Cung Cấp",uCNhaCungCap);
        }
    }
}
