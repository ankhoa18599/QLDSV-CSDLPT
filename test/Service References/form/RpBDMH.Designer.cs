namespace test.form
{
    partial class RpBDMH
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
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label4;
            this.edtLOP = new DevExpress.XtraEditors.TextEdit();
            this.lOPComboBox = new System.Windows.Forms.ComboBox();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.cmbMonHoc = new System.Windows.Forms.ComboBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numLanThi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.mONHOCTableAdapter = new test.QLDSVDataSetTableAdapters.MONHOCTableAdapter();
            this.lOPTableAdapter = new test.QLDSVDataSetTableAdapters.LOPTableAdapter();
            mALOPLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLanThi)).BeginInit();
            this.SuspendLayout();
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel1.ForeColor = System.Drawing.Color.IndianRed;
            mALOPLabel1.Location = new System.Drawing.Point(35, 222);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(66, 22);
            mALOPLabel1.TabIndex = 27;
            mALOPLabel1.Text = "Mã lớp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.IndianRed;
            label1.Location = new System.Drawing.Point(46, 111);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 22);
            label1.TabIndex = 23;
            label1.Text = "Khoa:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.ForeColor = System.Drawing.Color.IndianRed;
            tENLOPLabel.Location = new System.Drawing.Point(26, 165);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(74, 22);
            tENLOPLabel.TabIndex = 24;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.IndianRed;
            label2.Location = new System.Drawing.Point(27, 279);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(76, 22);
            label2.TabIndex = 24;
            label2.Text = "Môn học:";
            // 
            // edtLOP
            // 
            this.edtLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.edtLOP.Location = new System.Drawing.Point(112, 216);
            this.edtLOP.Name = "edtLOP";
            this.edtLOP.Properties.Appearance.BackColor = System.Drawing.Color.Linen;
            this.edtLOP.Properties.Appearance.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtLOP.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.edtLOP.Properties.Appearance.Options.UseBackColor = true;
            this.edtLOP.Properties.Appearance.Options.UseFont = true;
            this.edtLOP.Properties.Appearance.Options.UseForeColor = true;
            this.edtLOP.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.edtLOP.Properties.ReadOnly = true;
            this.edtLOP.Size = new System.Drawing.Size(608, 28);
            this.edtLOP.TabIndex = 29;
            // 
            // lOPComboBox
            // 
            this.lOPComboBox.BackColor = System.Drawing.Color.Linen;
            this.lOPComboBox.DataSource = this.lOPBindingSource;
            this.lOPComboBox.DisplayMember = "TENLOP";
            this.lOPComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lOPComboBox.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lOPComboBox.ForeColor = System.Drawing.Color.Maroon;
            this.lOPComboBox.FormattingEnabled = true;
            this.lOPComboBox.Location = new System.Drawing.Point(111, 163);
            this.lOPComboBox.Name = "lOPComboBox";
            this.lOPComboBox.Size = new System.Drawing.Size(609, 28);
            this.lOPComboBox.TabIndex = 28;
            this.lOPComboBox.ValueMember = "MALOP";
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
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(111, 111);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(609, 28);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.btnThoat.Location = new System.Drawing.Point(444, 361);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 35);
            this.btnThoat.TabIndex = 26;
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
            this.btnIN.Location = new System.Drawing.Point(218, 361);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(136, 35);
            this.btnIN.TabIndex = 25;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.BackColor = System.Drawing.Color.Linen;
            this.cmbMonHoc.DataSource = this.mONHOCBindingSource;
            this.cmbMonHoc.DisplayMember = "TENMH";
            this.cmbMonHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonHoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMonHoc.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMonHoc.ForeColor = System.Drawing.Color.Maroon;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.Location = new System.Drawing.Point(112, 277);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(609, 28);
            this.cmbMonHoc.TabIndex = 28;
            this.cmbMonHoc.ValueMember = "MAMH";
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // numLanThi
            // 
            this.numLanThi.BackColor = System.Drawing.Color.Linen;
            this.numLanThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numLanThi.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F);
            this.numLanThi.ForeColor = System.Drawing.Color.Maroon;
            this.numLanThi.Location = new System.Drawing.Point(814, 277);
            this.numLanThi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numLanThi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLanThi.Name = "numLanThi";
            this.numLanThi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numLanThi.Size = new System.Drawing.Size(71, 27);
            this.numLanThi.TabIndex = 31;
            this.numLanThi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SVN-Cookies", 12F);
            this.label3.ForeColor = System.Drawing.Color.IndianRed;
            this.label3.Location = new System.Drawing.Point(732, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "LẦN THI :";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("SVN-Cookies", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.IndianRed;
            label4.Location = new System.Drawing.Point(156, 32);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(513, 44);
            label4.TabIndex = 32;
            label4.Text = "IN DANH SÁCH BẢNG ĐIỂM MÔN HỌC";
            // 
            // RpBDMH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 465);
            this.Controls.Add(label4);
            this.Controls.Add(this.numLanThi);
            this.Controls.Add(this.label3);
            this.Controls.Add(mALOPLabel1);
            this.Controls.Add(this.edtLOP);
            this.Controls.Add(this.cmbMonHoc);
            this.Controls.Add(this.lOPComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIN);
            this.Name = "RpBDMH";
            this.Text = "RpBDMH";
            this.Load += new System.EventHandler(this.RpBDMH_Load);
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLanThi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit edtLOP;
        private System.Windows.Forms.ComboBox lOPComboBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.ComboBox cmbMonHoc;
        private System.Windows.Forms.NumericUpDown numLanThi;
        private System.Windows.Forms.Label label3;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private QLDSVDataSetTableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
    }
}