namespace GUI
{
    public partial class DanhNhap : Form
    {
        //DangNhapBLL BLLDangNha = new DangNhapBLL();
        public string a = "";
        public string b = "";

        public DanhNhap()
        {
            InitializeComponent();
        }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            //a = txttaikhoan.Text;
            //b = txtmatkhau.Text;
            //if (BLLDangNha.Dangnhap(a, b))
            //{
            //    MessageBox.Show("Đăng Nhập Thành Cônng ", "Thông Báo");
            //    this.Close();
            //}
            //else if (BLLDangNha.dangnhapnv(a, b))
            //{
            //    MessageBox.Show("Đăng Nhập Thành Cônng ", "Thông Báo");
            //    this.Close();
            //}
            //else if (txttaikhoan.Text == "")
            //{
            //    MessageBox.Show("Vui Lòng Nhập Tài Khoản ", "Thông Báo");
            //}
            //else if (txtmatkhau.Text == "")
            //{
            //    MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông Báo");
            //}
            //else
            //{
            //    MessageBox.Show("Thông tin hoặc mật khẩu sai!!! Vui Lòng nhập Lại ", "Thông Báo", MessageBoxButtons.OKCancel);
            //}
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DanhNhap_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
            groupBox2.Parent = pictureBox1;
            groupBox2.BackColor = Color.Transparent;
        }
    }
}
