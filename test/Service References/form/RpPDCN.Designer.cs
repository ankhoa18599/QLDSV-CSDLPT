namespace test.form
{
    partial class RpPDCN
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
            System.Windows.Forms.Label tENLabel;
            System.Windows.Forms.Label hOLabel;
            System.Windows.Forms.Label mASVLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label label2;
            this.lOPComboBox = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cmbSV = new System.Windows.Forms.ComboBox();
            this.fKSINHVIENLOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.edtHo = new DevExpress.XtraEditors.TextEdit();
            this.edtTen = new DevExpress.XtraEditors.TextEdit();
            this.lOPTableAdapter = new test.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.sINHVIENTableAdapter = new test.QLDSVDataSetTableAdapters.SINHVIENTableAdapter();
            tENLabel = new System.Windows.Forms.Label();
            hOLabel = new System.Windows.Forms.Label();
            mASVLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLabel
            // 
            tENLabel.AutoSize = true;
            tENLabel.BackColor = System.Drawing.Color.Transparent;
            tENLabel.Font = new System.Drawing.Font("SVN-Cookies", 12F);
            tENLabel.ForeColor = System.Drawing.Color.IndianRed;
            tENLabel.Location = new System.Drawing.Point(530, 306);
            tENLabel.Name = "tENLabel";
            tENLabel.Size = new System.Drawing.Size(48, 22);
            tENLabel.TabIndex = 29;
            tENLabel.Text = "TÊN :";
            // 
            // hOLabel
            // 
            hOLabel.AutoSize = true;
            hOLabel.BackColor = System.Drawing.Color.Transparent;
            hOLabel.Font = new System.Drawing.Font("SVN-Cookies", 12F);
            hOLabel.ForeColor = System.Drawing.Color.IndianRed;
            hOLabel.Location = new System.Drawing.Point(168, 306);
            hOLabel.Name = "hOLabel";
            hOLabel.Size = new System.Drawing.Size(40, 22);
            hOLabel.TabIndex = 27;
            hOLabel.Text = "HỌ :";
            // 
            // mASVLabel
            // 
            mASVLabel.AutoSize = true;
            mASVLabel.BackColor = System.Drawing.Color.Transparent;
            mASVLabel.Font = new System.Drawing.Font("SVN-Cookies", 12F);
            mASVLabel.ForeColor = System.Drawing.Color.IndianRed;
            mASVLabel.Location = new System.Drawing.Point(71, 238);
            mASVLabel.Name = "mASVLabel";
            mASVLabel.Size = new System.Drawing.Size(121, 22);
            mASVLabel.TabIndex = 25;
            mASVLabel.Text = "Mã sinh viên : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.IndianRed;
            label1.Location = new System.Drawing.Point(138, 132);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 22);
            label1.TabIndex = 33;
            label1.Text = "Khoa:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.BackColor = System.Drawing.Color.Transparent;
            tENLOPLabel.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.ForeColor = System.Drawing.Color.IndianRed;
            tENLOPLabel.Location = new System.Drawing.Point(118, 186);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(74, 22);
            tENLOPLabel.TabIndex = 34;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("SVN-Cookies", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.IndianRed;
            label2.Location = new System.Drawing.Point(327, 49);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(351, 44);
            label2.TabIndex = 39;
            label2.Text = "IN PHIẾU ĐIỂM CÁ NHÂN";
            // 
            // lOPComboBox
            // 
            this.lOPComboBox.BackColor = System.Drawing.Color.Linen;
            this.lOPComboBox.DataSource = this.lOPBindingSource;
            this.lOPComboBox.DisplayMember = "TENLOP";
            this.lOPComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lOPComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lOPComboBox.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOPComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.lOPComboBox.FormattingEnabled = true;
            this.lOPComboBox.Location = new System.Drawing.Point(203, 184);
            this.lOPComboBox.Name = "lOPComboBox";
            this.lOPComboBox.Size = new System.Drawing.Size(609, 28);
            this.lOPComboBox.TabIndex = 35;
            this.lOPComboBox.ValueMember = "MALOP";
            this.lOPComboBox.SelectedIndexChanged += new System.EventHandler(this.lOPComboBox_SelectedIndexChanged);
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Linen;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(203, 132);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(609, 28);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbSV
            // 
            this.cmbSV.BackColor = System.Drawing.Color.Linen;
            this.cmbSV.DataSource = this.fKSINHVIENLOPBindingSource;
            this.cmbSV.DisplayMember = "MASV";
            this.cmbSV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSV.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSV.ForeColor = System.Drawing.Color.Maroon;
            this.cmbSV.FormattingEnabled = true;
            this.cmbSV.Location = new System.Drawing.Point(203, 238);
            this.cmbSV.Name = "cmbSV";
            this.cmbSV.Size = new System.Drawing.Size(609, 28);
            this.cmbSV.TabIndex = 35;
            this.cmbSV.ValueMember = "MASV";
            this.cmbSV.SelectedIndexChanged += new System.EventHandler(this.cmbSV_SelectedIndexChanged);
            // 
            // fKSINHVIENLOPBindingSource
            // 
            this.fKSINHVIENLOPBindingSource.DataMember = "FK_SINHVIEN_LOP";
            this.fKSINHVIENLOPBindingSource.DataSource = this.lOPBindingSource;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatAppearance.BorderSize = 2;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Location = new System.Drawing.Point(553, 405);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(165, 35);
            this.btnThoat.TabIndex = 37;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIN
            // 
            this.btnIN.BackColor = System.Drawing.Color.White;
            this.btnIN.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnIN.FlatAppearance.BorderSize = 2;
            this.btnIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIN.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIN.ForeColor = System.Drawing.Color.IndianRed;
            this.btnIN.Location = new System.Drawing.Point(305, 405);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(165, 35);
            this.btnIN.TabIndex = 36;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // edtHo
            // 
            this.edtHo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKSINHVIENLOPBindingSource, "HO", true));
            this.edtHo.Location = new System.Drawing.Point(203, 303);
            this.edtHo.Name = "edtHo";
            this.edtHo.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.edtHo.Properties.Appearance.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHo.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.edtHo.Properties.Appearance.Options.UseBackColor = true;
            this.edtHo.Properties.Appearance.Options.UseFont = true;
            this.edtHo.Properties.Appearance.Options.UseForeColor = true;
            this.edtHo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtHo.Properties.ReadOnly = true;
            this.edtHo.Size = new System.Drawing.Size(300, 28);
            this.edtHo.TabIndex = 38;
            // 
            // edtTen
            // 
            this.edtTen.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.fKSINHVIENLOPBindingSource, "TEN", true));
            this.edtTen.Location = new System.Drawing.Point(573, 303);
            this.edtTen.Name = "edtTen";
            this.edtTen.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.edtTen.Properties.Appearance.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtTen.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.edtTen.Properties.Appearance.Options.UseBackColor = true;
            this.edtTen.Properties.Appearance.Options.UseFont = true;
            this.edtTen.Properties.Appearance.Options.UseForeColor = true;
            this.edtTen.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtTen.Properties.ReadOnly = true;
            this.edtTen.Size = new System.Drawing.Size(239, 28);
            this.edtTen.TabIndex = 38;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // RpPDCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 557);
            this.Controls.Add(label2);
            this.Controls.Add(this.edtTen);
            this.Controls.Add(this.edtHo);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIN);
            this.Controls.Add(this.cmbSV);
            this.Controls.Add(this.lOPComboBox);
            this.Controls.Add(label1);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(tENLabel);
            this.Controls.Add(hOLabel);
            this.Controls.Add(mASVLabel);
            this.Name = "RpPDCN";
            this.Text = "RpPDCN";
            this.Load += new System.EventHandler(this.RpPDCN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKSINHVIENLOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtHo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtTen.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox lOPComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbSV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIN;
        private DevExpress.XtraEditors.TextEdit edtHo;
        private DevExpress.XtraEditors.TextEdit edtTen;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private System.Windows.Forms.BindingSource fKSINHVIENLOPBindingSource;
        private QLDSVDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
    }
}