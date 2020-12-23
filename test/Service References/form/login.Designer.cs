namespace test.form
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.edtTaiKhoan = new DevExpress.XtraEditors.TextEdit();
            this.edtMatKhau = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.errorPro = new System.Windows.Forms.ErrorProvider(this.components);
            this.PassWord = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.edtTaiKhoan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMatKhau.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Cookies", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightCoral;
            this.label3.Location = new System.Drawing.Point(172, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 33);
            this.label3.TabIndex = 0;
            this.label3.Text = "Đăng Nhập";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.IndianRed;
            this.label4.Location = new System.Drawing.Point(19, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tài khoản";
            // 
            // edtTaiKhoan
            // 
            this.edtTaiKhoan.EditValue = "";
            this.edtTaiKhoan.Location = new System.Drawing.Point(124, 122);
            this.edtTaiKhoan.Name = "edtTaiKhoan";
            this.edtTaiKhoan.Properties.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.edtTaiKhoan.Properties.Appearance.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTaiKhoan.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.edtTaiKhoan.Properties.Appearance.Options.UseBackColor = true;
            this.edtTaiKhoan.Properties.Appearance.Options.UseFont = true;
            this.edtTaiKhoan.Properties.Appearance.Options.UseForeColor = true;
            this.edtTaiKhoan.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.edtTaiKhoan.Properties.Mask.BeepOnError = true;
            this.edtTaiKhoan.Size = new System.Drawing.Size(258, 30);
            this.edtTaiKhoan.TabIndex = 2;
            this.edtTaiKhoan.EditValueChanged += new System.EventHandler(this.edtTaiKhoan_EditValueChanged);
            this.edtTaiKhoan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtTaiKhoan_KeyDown);
            // 
            // edtMatKhau
            // 
            this.edtMatKhau.EditValue = "";
            this.edtMatKhau.Location = new System.Drawing.Point(124, 161);
            this.edtMatKhau.Name = "edtMatKhau";
            this.edtMatKhau.Properties.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.edtMatKhau.Properties.Appearance.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtMatKhau.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.edtMatKhau.Properties.Appearance.Options.UseBackColor = true;
            this.edtMatKhau.Properties.Appearance.Options.UseFont = true;
            this.edtMatKhau.Properties.Appearance.Options.UseForeColor = true;
            this.edtMatKhau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.edtMatKhau.Properties.UseSystemPasswordChar = true;
            this.edtMatKhau.Size = new System.Drawing.Size(258, 30);
            this.edtMatKhau.TabIndex = 4;
            this.edtMatKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtMatKhau_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(24, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangNhap.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDangNhap.FlatAppearance.BorderSize = 2;
            this.btnDangNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDangNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDangNhap.Location = new System.Drawing.Point(124, 232);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(111, 39);
            this.btnDangNhap.TabIndex = 5;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = false;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatAppearance.BorderSize = 2;
            this.btnThoat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Location = new System.Drawing.Point(278, 232);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(104, 39);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cb
            // 
            this.cb.BackColor = System.Drawing.Color.Linen;
            this.cb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cb.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb.ForeColor = System.Drawing.Color.Maroon;
            this.cb.FormattingEnabled = true;
            this.cb.Location = new System.Drawing.Point(124, 76);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(259, 28);
            this.cb.TabIndex = 7;
            this.cb.Tag = "";
            this.cb.SelectedIndexChanged += new System.EventHandler(this.cb_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.IndianRed;
            this.label6.Location = new System.Drawing.Point(57, 82);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Khoa";
            // 
            // errorPro
            // 
            this.errorPro.BlinkRate = 0;
            this.errorPro.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorPro.ContainerControl = this;
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Font = new System.Drawing.Font("SVN-Cookies", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.LightCoral;
            this.PassWord.Location = new System.Drawing.Point(388, 165);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(105, 19);
            this.PassWord.TabIndex = 20;
            this.PassWord.Text = "Hiện password";
            this.PassWord.UseVisualStyleBackColor = true;
            this.PassWord.CheckedChanged += new System.EventHandler(this.PassWord_CheckedChanged);
            // 
            // Main
            // 
            this.ClientSize = new System.Drawing.Size(507, 322);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.cb);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.edtMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtTaiKhoan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtTaiKhoan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtMatKhau.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDangNhap;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit edtTaiKhoan;
        private DevExpress.XtraEditors.TextEdit edtMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cb;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ErrorProvider errorPro;
        private System.Windows.Forms.CheckBox PassWord;
        //private QLDSVDataSetTableAdapters.V_DS_PHANMANHTableAdapter v_DS_PHANMANHTableAdapter;
    }
}

