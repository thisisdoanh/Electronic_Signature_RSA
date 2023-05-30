using System.Security.Cryptography;
using System.Text;
using System.Numerics;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RSA rsa = null;


        long[] listPrime = { 1000151, 1000159, 1000171, 1000183, 1000187,
            1000193, 1000199, 1000211, 1000213, 1000231, 1000249, 1000253,
            1000273, 1000289, 1000291, 1000303, 1000313, 1000333, 1018309,
            1018313, 1018337, 1018357, 1018411, 1023107, 1023133, 1023163,
            1023167 , 1036331, 1036339, 1036349, 1036351, 1036363, 1036367,
            1036369, 1058507, 1058543, 1058549, 1058567, 1058591, 1058593,
            1099313, 1099327, 1099337, 1099363, 1099369, 1099391, 1099393,
            1099409, 1221707, 1221749, 1221751, 1221761, 1221767, 1221791,
            1232071, 1232083, 1232089, 1232171, 1232183, 1232201, 1232213,
            1248353, 1248383, 1248391, 1248407, 1248413, 1248427, 1248449,
            1270513, 1270531, 1270537, 1270541, 1270547, 1270559, 1270561,
            3224789, 3224791, 3224797, 3224801, 3224833, 3224857, 3224861,
            3236531, 3236539, 3236543, 3236557, 3236587, 3236591, 3236621,
            3281081, 3281087, 3281093, 3281101, 3281137, 3281141, 3281149,
            3299617, 3299633, 3299641, 3299651, 3299677, 3299687, 3299689,
            8726573, 8726587, 8726611, 8726633, 8726647, 8726671, 8726677,
            8745311, 8745329, 8745343, 8745353, 8745367, 8745419, 8745437,
            8778593, 8778607, 8778629, 8778641, 8778643, 8778667, 8778701,
            8799887, 8799899, 8799911, 8799913, 8799919, 8799929, 8799941,
            9800009, 9800027, 9800053, 9800101, 9800113, 9800129, 9800137,
            9821419, 9821429, 9821443, 9821453, 9821489, 9821503, 9821507,
            9833491, 9833519, 9833533, 9833561, 9833597, 9833609, 9833617,
            9833623, 9833641, 9833647, 9833671, 9833687, 9833689, 9833711,
            9833717, 9833729, 9841441, 9841457, 9841483, 9841537, 9841543,
            9841561, 9841591, 9841597, 9841607, 9841609, 9841619, 9841627,
            9841661, 9841693, 9841703, 9841721, 9898433, 9898451, 9898457,
            9898481, 9898519, 9898543, 9898547, 9943253, 9943301, 9943303,
            9943319, 9943331, 9943333, 9943357, 9960347, 9960359, 9960367,
            9960371, 9960383, 9960407, 9960443, 9979639, 9979643, 9979681,
            9979727, 9979759, 9979763, 9979771, 9981731, 9981733, 9981739,
            9981779, 9981787, 9981799, 9981809, 9981847, 9981863, 9981869,
            9981889, 9981899, 9981911, 9981913, 9981919, 9981929, 9999883,
            9999889, 9999901, 9999907, 9999929, 9999931, 9999937, 9999943,
            9999971, 9999973, 9999991};

        private void btnRandomPQ_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            this.txtB.Text = "";
            this.txtA.Text = "";
            this.txtP.Text = listPrime[rd.Next(0, listPrime.Length)].ToString();
            this.txtQ.Text = listPrime[rd.Next(0, listPrime.Length)].ToString();


        }

        bool independencePQ(BigInteger p, BigInteger q)
        {
            return Convert.ToBoolean(p.Equals(q)) ? false : true;
        }

        public int[] getA(BigInteger n)
        {
            int[] a;
            if (BigInteger.Compare(n, 2047) < 0)
            {
                a = new int[1] { 2 };
                return a;
            }
            else
            {
                if (BigInteger.Compare(n, 1373653) < 0)
                {
                    a = new int[2] { 2, 3 };
                    return a;
                }
                else
                {
                    if (BigInteger.Compare(n, 9080191) < 0)
                    {
                        a = new int[2] { 31, 73 };
                        return a;
                    }
                    else
                    {
                        if (BigInteger.Compare(n, 4759123141) < 0)
                        {
                            a = new int[3] { 2, 7, 61 };
                            return a;
                        }
                        else
                        {
                            if (BigInteger.Compare(n, BigInteger.Parse("1122004669633")) < 0)
                            {
                                a = new int[4] { 2, 13, 23, 1662803 };
                                return a;
                            }
                            else
                            {
                                if (BigInteger.Compare(n, BigInteger.Parse("2152302898747")) < 0)
                                {
                                    a = new int[5] { 2, 3, 5, 7, 11 };
                                    return a;
                                }
                                else
                                {
                                    if (BigInteger.Compare(n, BigInteger.Parse("3474749660383")) < 0)
                                    {
                                        a = new int[6] { 2, 3, 5, 7, 11, 13 };
                                        return a;
                                    }
                                    else
                                    {
                                        if (BigInteger.Compare(n, BigInteger.Parse("341550071728321")) < 0)
                                        {
                                            a = new int[7] { 2, 3, 5, 7, 11, 13, 17 };
                                            return a;
                                        }
                                        else
                                        {
                                            if (BigInteger.Compare(n, BigInteger.Parse("3825123056546413051")) < 0)
                                            {
                                                a = new int[9] { 2, 3, 5, 7, 11, 13, 17, 19, 23 };
                                                return a;
                                            }
                                            else
                                            {
                                                if (BigInteger.Compare(n, BigInteger.Parse("318665857834031151167461")) < 0)
                                                {
                                                    a = new int[12] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37 };
                                                    return a;
                                                }
                                                else
                                                {
                                                    if (BigInteger.Compare(n, BigInteger.Parse("3317044064679887385961981")) < 0)
                                                    {
                                                        a = new int[13] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41 };
                                                        return a;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return a = new int[1] { 2 };
        }

        public bool millerRabinTesting(BigInteger n)
        {
            if (BigInteger.Compare(n, 2) < 0) return false;
            if (n.Equals(2) || n.Equals(3)) return true;
            int[] a = getA(n);
            BigInteger d = BigInteger.Subtract(n, 1);
            BigInteger s = decompose(ref d);
            for (int i = 0; i < a.Length; i++)
            {
                BigInteger p = modPower(a[i], d, n);
                if (p.Equals(1))
                {
                    return true;
                }
                while (s > 0)
                {
                    if (p.Equals(BigInteger.Subtract(n, 1))) return true;
                    p = BigInteger.Remainder(BigInteger.Multiply(p, p), n);
                    s--;
                }
                return false;
            }
            return false;
        }

        public BigInteger decompose(ref BigInteger p)
        {
            BigInteger i = 0;
            while (BigInteger.Remainder(p, 2).Equals(0))
            {
                i++;
                p /= 2;
            }
            return i;
        }

        public BigInteger modPower(BigInteger a, BigInteger b, BigInteger p)
        {
            if (b.Equals(1))
                return a;
            else
            {
                BigInteger x = modPower(a, BigInteger.Divide(b, 2), p);

                if (BigInteger.Remainder(b, 2).Equals(0))
                {
                    return BigInteger.Remainder(BigInteger.Multiply(x, x), p);
                }
                else
                {
                    return BigInteger.Remainder(BigInteger.Multiply(BigInteger.Multiply(x, x), a), p);
                }
            }
        }



        private void btnTaoKhoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtP.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập giá trị của P", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (this.txtQ.Text.Trim().Equals(""))
                {
                    MessageBox.Show("Bạn chưa nhập giá trị của Q", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BigInteger p = 0, q = 0;

                try
                {
                    p = BigInteger.Parse(this.txtP.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("P không hợp lệ. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    q = BigInteger.Parse(this.txtQ.Text.Trim());
                }
                catch (Exception)
                {
                    MessageBox.Show("Q không hợp lệ. Mời nhập lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                if (!independencePQ(p, q))
                {
                    MessageBox.Show("P, Q phải là 2 giá trị độc lập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    if (!millerRabinTesting(p))
                    {
                        MessageBox.Show("P không phải số nguyên tố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        if (!millerRabinTesting(q))
                        {
                            MessageBox.Show("Q không phải số nguyên tố", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        else
                        {
                            if (BigInteger.Multiply(p, q) < 256)
                            {
                                MessageBox.Show("Hãy chọn 2 số nguyên tố lớn hơn để tăng tính bảo mật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                rsa = new RSA(p, q);
                                this.txtB.Text = rsa.B.ToString();
                                this.txtA.Text = rsa.A.ToString();

                            }
                        }


                    }

                }

            }
            catch (FormatException)
            {
                this.txtP.ResetText();
                this.txtQ.ResetText();
                MessageBox.Show("P, Q không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        //Function tai file len
        public string upFile()
        {
            ///Mowr hộp thoại đeer duyệt thư mục
            OpenFileDialog openFile = new OpenFileDialog();
            ///lọc các file có định dạng text
            openFile.Filter = "|*.txt";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show($"Bạn đã mở thành công file sau: {openFile.FileName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                string text = File.ReadAllText(openFile.FileName);
                return text;
            }
            return "";
        }

        //Đưa chuỗi text vào hàm băm MD5
        public string hashMD5(string text)
        {
            ///convert string về byte
            byte[] textByte = Encoding.ASCII.GetBytes(text);
            MD5 md5 = MD5.Create();
            byte[] hash = md5.ComputeHash(textByte);
            StringBuilder hashSB = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSB.Append(b.ToString("X2"));
            }
            return hashSB.ToString();
        }
        //Function click button tải file bản rõ
        private void btnFileBanRo_Click(object sender, EventArgs e)
        {
            this.txtBanRo.Text = upFile();
            if (this.txtBanRo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Chưa có văn bản nào được nhập vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public string toBinary(BigInteger a, int n)
        {
            StringBuilder sb = new StringBuilder();
            while (a > 0)
            {
                sb.Insert(0, a % n);
                a /= n;
            }
            return sb.ToString();
        }

        public string thuatToanBinhPhuongVaNhan(string ch, BigInteger m, BigInteger b)
        {
            BigInteger c = 0;
            for (int i = 0; i < ch.Length; i++)
            {
                c = BigInteger.Add(c, (int)ch[i]);
            }
            //convert số mũ qua dạng nhị phân
            string charNhiPhan = toBinary(b, 2);
            char[] mangNhiPhan = charNhiPhan.ToCharArray();
            BigInteger p = 1;
            foreach (char item in mangNhiPhan)
            {
                p = BigInteger.Pow(p, 2);
                p = BigInteger.Remainder(p, m);

                if (item == '1')
                {
                    p = BigInteger.Multiply(p, c);
                    p = BigInteger.Remainder(p, m);
                }
            }

            return p.ToString();
        }

        //Function mã hoá RSA
        public string maHoaRSA(string[] textMaHoa, BigInteger a, BigInteger b)
        {
            string result = "";
            foreach (string item in textMaHoa)
            {
                BigInteger c = BigInteger.Parse(thuatToanBinhPhuongVaNhan(item, a, b));
                result = result + c.ToString() + "-";
            }
            result = result.Remove(result.Length - 1, 1);
            return result;
        }

        string txtHashMD5 = "";
        private void btnKy_Click(object sender, EventArgs e)
        {
            //Xét có văn bản hay chưa
            if (this.txtBanRo.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập thông điệp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtP.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số nguyên tố P!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtQ.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập số nguyên tố Q!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtB.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng bấm nút \"Tạo khoá\" trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (BigInteger.Compare(BigInteger.Multiply(BigInteger.Parse(this.txtP.Text.Trim()), BigInteger.Parse(this.txtQ.Text.Trim())), rsa.N) != 0)
            {
                MessageBox.Show("P hoặc Q đã bị thay đổi, vui lòng bấm nút \"Tạo khoá\" rồi thử lại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Băm
            string text = this.txtBanRo.Text;
            string hashMD5Text = hashMD5(text);
            txtHashMD5 = hashMD5Text;

            //Ký
            string maHoa = hashMD5Text;
            string[] charMaHoa = new string[32];

            int lenMaHoa = maHoa.Length;
            for (int i = 0; i < lenMaHoa; i++)
            {
                charMaHoa[i] = maHoa.Substring(i, 1);
            }

            BigInteger a = BigInteger.Parse(this.txtA.Text);
            BigInteger b = BigInteger.Multiply(rsa.p, rsa.q);
            this.txtChuKy.Text = maHoaRSA(charMaHoa, b, a);
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            if (this.txtChuKy.Text.Equals(""))
            {
                MessageBox.Show("Chưa có chữ ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.txtChuKyCheck.Text = this.txtChuKy.Text;
            this.txtBanRoCheck.Text = this.txtBanRo.Text;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            ///check đã có văn bản được ký chưa
            if (this.txtChuKy.Text.Equals(""))
            {
                MessageBox.Show("Chưa có văn bản nào được ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog saveFile = new SaveFileDialog())
            {
                saveFile.Filter = "|*.txt";
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter writer = new StreamWriter(saveFile.FileName);
                    writer.Write(this.txtChuKy.Text.ToString());
                    writer.Close();
                    MessageBox.Show("Chữ ký đã được lưu tại " + saveFile.FileName, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }

        }

        private void btnFileBanRoCheck_Click(object sender, EventArgs e)
        {
            txtBanRoCheck.Text = upFile();
            if (this.txtBanRoCheck.Text.Equals(""))
            {
                MessageBox.Show("Chưa có văn bản nào được nhập vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnFileChuKyCheck_Click(object sender, EventArgs e)
        {
            txtChuKyCheck.Text = upFile();
            if (this.txtChuKyCheck.Text.Equals(""))
            {
                MessageBox.Show("Chưa có văn bản nào được nhập vào!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        //Function decrypt RSA
        public string giaiMaRSA(string[] banMa, BigInteger n, BigInteger b)
        {
            string result = "";

            foreach (string item in banMa)
            {
                string temp = thuatToanBinhPhuongVaNhanCheck(item, n, b);



                BigInteger x = BigInteger.Parse(temp);
                char c;
                try
                {
                    c = (char)x;
                }
                catch (Exception)
                {
                    return result;
                }


                result = result + c.ToString();
            }

            return result;
        }

        public string thuatToanBinhPhuongVaNhanCheck(string ch, BigInteger m, BigInteger b)
        {
            BigInteger c = BigInteger.Parse(ch);

            //convert số mũ qua dạng nhị phân
            string charNhiPhan = toBinary(b, 2);
            char[] mangNhiPhan = charNhiPhan.ToCharArray();
            BigInteger p = 1;
            // Int64 p = 1;
            foreach (char item in mangNhiPhan)
            {
                p = BigInteger.Pow(p, 2);
                p = BigInteger.Remainder(p, m);
                if (item == '1')
                {
                    p = BigInteger.Multiply(p, c);
                    p = BigInteger.Remainder(p, m);
                }
            }

            return p.ToString();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (this.txtBanRoCheck.Text.Trim().Equals(""))
            {
                this.txtThongBao.Text = "";
                MessageBox.Show("Chưa có thông điệp để kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtChuKyCheck.Text.Trim().Equals(""))
            {
                this.txtThongBao.Text = "";
                MessageBox.Show("Chưa có chữ ký để kiểm tra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtP.Text.Trim().Equals(""))
            {
                this.txtThongBao.Text = "";
                MessageBox.Show("Vui lòng nhập P!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (this.txtQ.Text.Trim().Equals(""))
            {
                this.txtThongBao.Text = "";
                MessageBox.Show("Vui lòng nhập Q!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtThongBao.Text = "";
                return;
            }
            if (this.txtB.Text.Trim().Equals(""))
            {
                this.txtThongBao.Text = "";
                MessageBox.Show("Vui lòng nhập B!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtThongBao.Text = "";
                return;
            }
            if (this.txtA.Text.Trim().Equals(""))
            {
                this.txtThongBao.Text = "";
                MessageBox.Show("Vui lòng nhập A!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtThongBao.Text = "";
                return;
            }


            BigInteger n = BigInteger.Multiply(BigInteger.Parse(this.txtP.Text.Trim()), BigInteger.Parse(this.txtQ.Text.Trim()));
            BigInteger b = BigInteger.Parse(this.txtB.Text);

            string textBanRoCheck = this.txtBanRoCheck.Text;
            string textChuKyCheck = this.txtChuKyCheck.Text;

            //Băm bản rõ để check
            string hashBanRoCheck = hashMD5(textBanRoCheck);

            //Đưa bản mã về mảng string để xét
            string[] arrayBanMaCheck = textChuKyCheck.Split('-');

            string[] md5Char = new string[32];
            int i = 0;
            foreach (var item in arrayBanMaCheck)
            {
                md5Char[i] = item;
                i++;
            }

            string giaiMa = giaiMaRSA(md5Char, n, b);

            if (hashBanRoCheck.Equals(giaiMa))
            {
                this.txtThongBao.Text = "Chữ ký chính xác!";
                return;
            }

            else
            {
                this.txtThongBao.Text = "Thông điệp, chữ ký hoặc P,Q đã bị thay đổi. Vui lòng kiểm tra lại!";
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.txtA.ResetText();
            this.txtB.ResetText();
            this.txtP.ResetText();
            this.txtQ.ResetText();
            this.txtBanRo.ResetText();
            this.txtBanRoCheck.ResetText();
            this.txtChuKy.ResetText();
            this.txtChuKyCheck.ResetText();
            rsa = null;
            txtHashMD5 = "";
            this.txtThongBao.Text = "";
        }
    }
}