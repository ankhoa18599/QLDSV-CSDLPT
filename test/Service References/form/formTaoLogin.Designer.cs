namespace test.form
{
    partial class formTaoLogin
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
            System.Windows.Forms.Label hOTENLabel;
            this.Thoat = new System.Windows.Forms.Button();
            this.taoLogin = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.PassWord = new System.Windows.Forms.CheckBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lookUpUser = new DevExpress.XtraEditors.LookUpEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.showConfirmPass = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.NhomQuyenGroup = new DevExpress.XtraEditors.RadioGroup();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.cmbChonKhoa = new System.Windows.Forms.ComboBox();
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.vdsPhanManhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.v_ds_PhanManhTableAdapter = new test.QLDSVDataSetTableAdapters.v_ds_PhanManhTableAdapter();
            this.dSGVCTTKBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSGV_CTTKTableAdapter = new test.QLDSVDataSetTableAdapters.DSGV_CTTKTableAdapter();
            hOTENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomQuyenGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vdsPhanManhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGVCTTKBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hOTENLabel
            // 
            hOTENLabel.AutoSize = true;
            hOTENLabel.BackColor = System.Drawing.Color.Transparent;
            hOTENLabel.Location = new System.Drawing.Point(334, 277);
            hOTENLabel.Name = "hOTENLabel";
            hOTENLabel.Size = new System.Drawing.Size(104, 13);
            hOTENLabel.TabIndex = 20;
            hOTENLabel.Text = "CHỌN GIẢNG VIÊN :";
            // 
            // Thoat
            // 
            this.Thoat.Location = new System.Drawing.Point(671, 411);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(106, 41);
            this.Thoat.TabIndex = 25;
            this.Thoat.Text = "THOÁT";
            this.Thoat.UseVisualStyleBackColor = true;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // taoLogin
            // 
            this.taoLogin.Location = new System.Drawing.Point(477, 411);
            this.taoLogin.Name = "taoLogin";
            this.taoLogin.Size = new System.Drawing.Size(118, 41);
            this.taoLogin.TabIndex = 24;
            this.taoLogin.Text = "TẠO LOGIN";
            this.taoLogin.UseVisualStyleBackColor = true;
            this.taoLogin.Click += new System.EventHandler(this.taoLogin_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(357, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "NHÓM QUYỀN :";
            // 
            // PassWord
            // 
            this.PassWord.AutoSize = true;
            this.PassWord.Location = new System.Drawing.Point(795, 178);
            this.PassWord.Name = "PassWord";
            this.PassWord.Size = new System.Drawing.Size(96, 17);
            this.PassWord.TabIndex = 19;
            this.PassWord.Text = "Hiện password";
            this.PassWord.UseVisualStyleBackColor = true;
            this.PassWord.CheckedChanged += new System.EventHandler(this.PassWord_CheckedChanged);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(473, 174);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(304, 21);
            this.txtPass.TabIndex = 18;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(473, 120);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(304, 21);
            this.txtLogin.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(363, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "PASSWORD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(358, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "LOGIN NAME :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label1.Location = new System.Drawing.Point(541, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "TẠO LOGIN";
            // 
            // lookUpUser
            // 
            this.lookUpUser.Location = new System.Drawing.Point(477, 274);
            this.lookUpUser.Name = "lookUpUser";
            this.lookUpUser.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.lookUpUser.Properties.Appearance.Options.UseBackColor = true;
            this.lookUpUser.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUser.Properties.DataSource = this.dSGVCTTKBindingSource;
            this.lookUpUser.Properties.DisplayMember = "HOTEN";
            this.lookUpUser.Properties.DropDownRows = 5;
            this.lookUpUser.Properties.NullText = "Chọn mã giảng viên";
            this.lookUpUser.Properties.ValueMember = "MAGV";
            this.lookUpUser.Size = new System.Drawing.Size(300, 20);
            this.lookUpUser.TabIndex = 26;
            this.lookUpUser.EditValueChanged += new System.EventHandler(this.lookUpUser_EditValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(363, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "PASSWORD :";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Location = new System.Drawing.Point(473, 220);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(304, 21);
            this.txtConfirm.TabIndex = 18;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // showConfirmPass
            // 
            this.showConfirmPass.AutoSize = true;
            this.showConfirmPass.Location = new System.Drawing.Point(795, 224);
            this.showConfirmPass.Name = "showConfirmPass";
            this.showConfirmPass.Size = new System.Drawing.Size(96, 17);
            this.showConfirmPass.TabIndex = 19;
            this.showConfirmPass.Text = "Hiện password";
            this.showConfirmPass.UseVisualStyleBackColor = true;
            this.showConfirmPass.CheckedChanged += new System.EventHandler(this.showConfirmPass_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(363, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "CHỌN KHOA:";
            // 
            // NhomQuyenGroup
            // 
            this.NhomQuyenGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NhomQuyenGroup.EditValue = "PGV";
            this.NhomQuyenGroup.Location = new System.Drawing.Point(473, 309);
            this.NhomQuyenGroup.Name = "NhomQuyenGroup";
            this.NhomQuyenGroup.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.NhomQuyenGroup.Properties.Appearance.BorderColor = System.Drawing.Color.White;
            this.NhomQuyenGroup.Properties.Appearance.Options.UseBackColor = true;
            this.NhomQuyenGroup.Properties.Appearance.Options.UseBorderColor = true;
            this.NhomQuyenGroup.Properties.AppearanceDisabled.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.ControlText;
            this.NhomQuyenGroup.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.NhomQuyenGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.NhomQuyenGroup.Properties.Columns = 2;
            this.NhomQuyenGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PGV", "Phòng Giáo Vụ", true, "PGV"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("Khoa", "Khoa"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("PKT", "Phòng Kế toán"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem("User", "User")});
            this.NhomQuyenGroup.Properties.NullText = "Chọn nhóm quyền";
            this.NhomQuyenGroup.Size = new System.Drawing.Size(304, 80);
            this.NhomQuyenGroup.TabIndex = 30;
            // 
            // cmbChonKhoa
            // 
            this.cmbChonKhoa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cmbChonKhoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChonKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbChonKhoa.FormattingEnabled = true;
            this.cmbChonKhoa.Location = new System.Drawing.Point(473, 74);
            this.cmbChonKhoa.Name = "cmbChonKhoa";
            this.cmbChonKhoa.Size = new System.Drawing.Size(304, 21);
            this.cmbChonKhoa.TabIndex = 31;
            this.cmbChonKhoa.SelectedIndexChanged += new System.EventHandler(this.cmbChonKhoa_SelectedIndexChanged);
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vdsPhanManhBindingSource
            // 
            this.vdsPhanManhBindingSource.DataMember = "v_ds_PhanManh";
            this.vdsPhanManhBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // v_ds_PhanManhTableAdapter
            // 
            this.v_ds_PhanManhTableAdapter.ClearBeforeFill = true;
            // 
            // dSGVCTTKBindingSource
            // 
            this.dSGVCTTKBindingSource.DataMember = "DSGV_CTTK";
            this.dSGVCTTKBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // dSGV_CTTKTableAdapter
            // 
            this.dSGV_CTTKTableAdapter.ClearBeforeFill = true;
            // 
            // formTaoLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 464);
            this.Controls.Add(this.cmbChonKhoa);
            this.Controls.Add(this.NhomQuyenGroup);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lookUpUser);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.taoLogin);
            this.Controls.Add(this.label4);
            this.Controls.Add(hOTENLabel);
            this.Controls.Add(this.showConfirmPass);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.txtConfirm);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "formTaoLogin";
            this.Text = "formTaoLogin";
            this.Load += new System.EventHandler(this.formTaoLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NhomQuyenGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vdsPhanManhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSGVCTTKBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Thoat;
        private System.Windows.Forms.Button taoLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox PassWord;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLDSVDataSet qLDSVDataSet;
        private DevExpress.XtraEditors.LookUpEdit lookUpUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.CheckBox showConfirmPass;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource vdsPhanManhBindingSource;
        private QLDSVDataSetTableAdapters.v_ds_PhanManhTableAdapter v_ds_PhanManhTableAdapter;
        private DevExpress.XtraEditors.RadioGroup NhomQuyenGroup;
        private System.Windows.Forms.ComboBox cmbChonKhoa;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.BindingSource dSGVCTTKBindingSource;
        private QLDSVDataSetTableAdapters.DSGV_CTTKTableAdapter dSGV_CTTKTableAdapter;
    }
}