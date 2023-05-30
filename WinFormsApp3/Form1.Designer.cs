namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            pnlSig = new Panel();
            btnTaoKhoa = new Button();
            txtA = new TextBox();
            label10 = new Label();
            btnLuu = new Button();
            btnChuyen = new Button();
            txtChuKy = new TextBox();
            label9 = new Label();
            btnKy = new Button();
            btnRandomPQ = new Button();
            txtB = new TextBox();
            label8 = new Label();
            txtQ = new TextBox();
            label7 = new Label();
            txtP = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnFileBanRo = new Button();
            txtBanRo = new TextBox();
            label4 = new Label();
            label15 = new Label();
            label14 = new Label();
            txtBanRoCheck = new TextBox();
            btnFileBanRoCheck = new Button();
            label3 = new Label();
            txtChuKyCheck = new TextBox();
            btnCheck = new Button();
            panel1 = new Panel();
            txtThongBao = new TextBox();
            label11 = new Label();
            btnFileChuKyCheck = new Button();
            btnReset = new Button();
            pnlSig.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(456, 9);
            label1.Name = "label1";
            label1.Size = new Size(314, 32);
            label1.TabIndex = 0;
            label1.Text = "Phần mềm tạo chữ ký RSA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(191, 18);
            label2.Name = "label2";
            label2.Size = new Size(126, 30);
            label2.TabIndex = 1;
            label2.Text = "Tạo chữ ký";
            // 
            // pnlSig
            // 
            pnlSig.Controls.Add(btnTaoKhoa);
            pnlSig.Controls.Add(txtA);
            pnlSig.Controls.Add(label10);
            pnlSig.Controls.Add(btnLuu);
            pnlSig.Controls.Add(btnChuyen);
            pnlSig.Controls.Add(txtChuKy);
            pnlSig.Controls.Add(label9);
            pnlSig.Controls.Add(btnKy);
            pnlSig.Controls.Add(btnRandomPQ);
            pnlSig.Controls.Add(txtB);
            pnlSig.Controls.Add(label8);
            pnlSig.Controls.Add(txtQ);
            pnlSig.Controls.Add(label7);
            pnlSig.Controls.Add(txtP);
            pnlSig.Controls.Add(label6);
            pnlSig.Controls.Add(label5);
            pnlSig.Controls.Add(btnFileBanRo);
            pnlSig.Controls.Add(txtBanRo);
            pnlSig.Controls.Add(label4);
            pnlSig.Controls.Add(label2);
            pnlSig.Location = new Point(12, 67);
            pnlSig.Name = "pnlSig";
            pnlSig.Size = new Size(546, 616);
            pnlSig.TabIndex = 3;
            // 
            // btnTaoKhoa
            // 
            btnTaoKhoa.Location = new Point(307, 332);
            btnTaoKhoa.Name = "btnTaoKhoa";
            btnTaoKhoa.Size = new Size(112, 34);
            btnTaoKhoa.TabIndex = 22;
            btnTaoKhoa.Text = "Tạo khoá";
            btnTaoKhoa.UseVisualStyleBackColor = true;
            btnTaoKhoa.Click += btnTaoKhoa_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(328, 279);
            txtA.Name = "txtA";
            txtA.ReadOnly = true;
            txtA.RightToLeft = RightToLeft.No;
            txtA.Size = new Size(161, 31);
            txtA.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(296, 282);
            label10.Name = "label10";
            label10.RightToLeft = RightToLeft.No;
            label10.Size = new Size(28, 25);
            label10.TabIndex = 20;
            label10.Text = "A:";
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(431, 541);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(112, 34);
            btnLuu.TabIndex = 19;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnChuyen
            // 
            btnChuyen.Location = new Point(431, 475);
            btnChuyen.Name = "btnChuyen";
            btnChuyen.Size = new Size(112, 34);
            btnChuyen.TabIndex = 18;
            btnChuyen.Text = "Chuyển";
            btnChuyen.UseVisualStyleBackColor = true;
            btnChuyen.Click += btnChuyen_Click;
            // 
            // txtChuKy
            // 
            txtChuKy.Location = new Point(126, 448);
            txtChuKy.Multiline = true;
            txtChuKy.Name = "txtChuKy";
            txtChuKy.ReadOnly = true;
            txtChuKy.ScrollBars = ScrollBars.Vertical;
            txtChuKy.Size = new Size(293, 149);
            txtChuKy.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 448);
            label9.Name = "label9";
            label9.Size = new Size(71, 25);
            label9.TabIndex = 16;
            label9.Text = "Chữ ký:";
            // 
            // btnKy
            // 
            btnKy.Location = new Point(217, 390);
            btnKy.Name = "btnKy";
            btnKy.Size = new Size(112, 34);
            btnKy.TabIndex = 15;
            btnKy.Text = "Ký";
            btnKy.UseVisualStyleBackColor = true;
            btnKy.Click += btnKy_Click;
            // 
            // btnRandomPQ
            // 
            btnRandomPQ.AutoSize = true;
            btnRandomPQ.Location = new Point(124, 332);
            btnRandomPQ.Name = "btnRandomPQ";
            btnRandomPQ.Size = new Size(177, 35);
            btnRandomPQ.TabIndex = 14;
            btnRandomPQ.Text = "Tạo P,Q ngẫu nhiên";
            btnRandomPQ.UseVisualStyleBackColor = true;
            btnRandomPQ.Click += btnRandomPQ_Click;
            // 
            // txtB
            // 
            txtB.Location = new Point(126, 279);
            txtB.Name = "txtB";
            txtB.ReadOnly = true;
            txtB.RightToLeft = RightToLeft.No;
            txtB.Size = new Size(161, 31);
            txtB.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(94, 282);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(26, 25);
            label8.TabIndex = 12;
            label8.Text = "B:";
            // 
            // txtQ
            // 
            txtQ.Location = new Point(328, 232);
            txtQ.Name = "txtQ";
            txtQ.Size = new Size(161, 31);
            txtQ.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 235);
            label7.Name = "label7";
            label7.Size = new Size(30, 25);
            label7.TabIndex = 10;
            label7.Text = "Q:";
            // 
            // txtP
            // 
            txtP.Location = new Point(126, 235);
            txtP.Name = "txtP";
            txtP.Size = new Size(161, 31);
            txtP.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 235);
            label6.Name = "label6";
            label6.Size = new Size(26, 25);
            label6.TabIndex = 8;
            label6.Text = "P:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 232);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 5;
            label5.Text = "Khoá:";
            // 
            // btnFileBanRo
            // 
            btnFileBanRo.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFileBanRo.Location = new Point(444, 115);
            btnFileBanRo.Name = "btnFileBanRo";
            btnFileBanRo.Size = new Size(79, 46);
            btnFileBanRo.TabIndex = 4;
            btnFileBanRo.Text = "File";
            btnFileBanRo.UseVisualStyleBackColor = true;
            btnFileBanRo.Click += btnFileBanRo_Click;
            // 
            // txtBanRo
            // 
            txtBanRo.Location = new Point(126, 67);
            txtBanRo.Multiline = true;
            txtBanRo.Name = "txtBanRo";
            txtBanRo.ScrollBars = ScrollBars.Vertical;
            txtBanRo.Size = new Size(293, 149);
            txtBanRo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 67);
            label4.Name = "label4";
            label4.Size = new Size(103, 25);
            label4.TabIndex = 2;
            label4.Text = "Văn bản ký:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(191, 18);
            label15.Name = "label15";
            label15.Size = new Size(176, 30);
            label15.TabIndex = 1;
            label15.Text = "Kiểm tra chữ ký";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 67);
            label14.Name = "label14";
            label14.Size = new Size(103, 25);
            label14.TabIndex = 2;
            label14.Text = "Văn bản ký:";
            // 
            // txtBanRoCheck
            // 
            txtBanRoCheck.Location = new Point(126, 67);
            txtBanRoCheck.Multiline = true;
            txtBanRoCheck.Name = "txtBanRoCheck";
            txtBanRoCheck.ReadOnly = true;
            txtBanRoCheck.ScrollBars = ScrollBars.Vertical;
            txtBanRoCheck.Size = new Size(293, 149);
            txtBanRoCheck.TabIndex = 3;
            // 
            // btnFileBanRoCheck
            // 
            btnFileBanRoCheck.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFileBanRoCheck.Location = new Point(445, 115);
            btnFileBanRoCheck.Name = "btnFileBanRoCheck";
            btnFileBanRoCheck.Size = new Size(79, 46);
            btnFileBanRoCheck.TabIndex = 4;
            btnFileBanRoCheck.Text = "File";
            btnFileBanRoCheck.UseVisualStyleBackColor = true;
            btnFileBanRoCheck.Click += btnFileBanRoCheck_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 248);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 16;
            label3.Text = "Chữ ký:";
            // 
            // txtChuKyCheck
            // 
            txtChuKyCheck.Location = new Point(126, 248);
            txtChuKyCheck.Multiline = true;
            txtChuKyCheck.Name = "txtChuKyCheck";
            txtChuKyCheck.ReadOnly = true;
            txtChuKyCheck.ScrollBars = ScrollBars.Vertical;
            txtChuKyCheck.Size = new Size(293, 149);
            txtChuKyCheck.TabIndex = 17;
            // 
            // btnCheck
            // 
            btnCheck.Location = new Point(210, 415);
            btnCheck.Name = "btnCheck";
            btnCheck.Size = new Size(112, 34);
            btnCheck.TabIndex = 18;
            btnCheck.Text = "Kiểm tra";
            btnCheck.UseVisualStyleBackColor = true;
            btnCheck.Click += btnCheck_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtThongBao);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(btnFileChuKyCheck);
            panel1.Controls.Add(btnCheck);
            panel1.Controls.Add(txtChuKyCheck);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnFileBanRoCheck);
            panel1.Controls.Add(txtBanRoCheck);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(label15);
            panel1.Location = new Point(690, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 616);
            panel1.TabIndex = 20;
            // 
            // txtThongBao
            // 
            txtThongBao.Location = new Point(126, 461);
            txtThongBao.Multiline = true;
            txtThongBao.Name = "txtThongBao";
            txtThongBao.ReadOnly = true;
            txtThongBao.Size = new Size(293, 136);
            txtThongBao.TabIndex = 22;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 475);
            label11.Name = "label11";
            label11.Size = new Size(103, 25);
            label11.TabIndex = 21;
            label11.Text = "Thông báo:";
            // 
            // btnFileChuKyCheck
            // 
            btnFileChuKyCheck.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnFileChuKyCheck.Location = new Point(445, 301);
            btnFileChuKyCheck.Name = "btnFileChuKyCheck";
            btnFileChuKyCheck.Size = new Size(79, 46);
            btnFileChuKyCheck.TabIndex = 20;
            btnFileChuKyCheck.Text = "File";
            btnFileChuKyCheck.UseVisualStyleBackColor = true;
            btnFileChuKyCheck.Click += btnFileChuKyCheck_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(582, 302);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(81, 63);
            btnReset.TabIndex = 21;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 696);
            Controls.Add(btnReset);
            Controls.Add(panel1);
            Controls.Add(pnlSig);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Electronic Signature RSA";
            pnlSig.ResumeLayout(false);
            pnlSig.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Panel pnlSig;
        private TextBox txtBanRo;
        private Label label4;
        private TextBox txtQ;
        private Label label7;
        private TextBox txtP;
        private Label label6;
        private Label label5;
        private Button btnFileBanRo;
        private Button btnRandomPQ;
        private TextBox txtB;
        private Label label8;
        private Button btnKy;
        private Button btnLuu;
        private Button btnChuyen;
        private TextBox txtChuKy;
        private Label label9;
        private TextBox txtA;
        private Label label10;
        private Label label15;
        private Label label14;
        private TextBox txtBanRoCheck;
        private Button btnFileBanRoCheck;
        private Label label3;
        private TextBox txtChuKyCheck;
        private Button btnCheck;
        private Panel panel1;
        private TextBox txtThongBao;
        private Label label11;
        private Button btnFileChuKyCheck;
        private Button btnReset;
        private Button btnTaoKhoa;
    }
}