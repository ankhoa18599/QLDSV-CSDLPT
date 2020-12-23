namespace test.form
{
    partial class RpHPLop
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label label2;
            this.numHocKi = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.edtLOP = new DevExpress.XtraEditors.TextEdit();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.cmbNienKhoa = new System.Windows.Forms.ComboBox();
            this.lOPTableAdapter = new test.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            label4 = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            tENLOPLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numHocKi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("SVN-Cookies", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.IndianRed;
            label4.Location = new System.Drawing.Point(242, 48);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(405, 44);
            label4.TabIndex = 43;
            label4.Text = "IN DANH SÁCH HỌC PHÍ LỚP";
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel1.ForeColor = System.Drawing.Color.IndianRed;
            mALOPLabel1.Location = new System.Drawing.Point(67, 209);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(66, 22);
            mALOPLabel1.TabIndex = 38;
            mALOPLabel1.Text = "Mã lớp:";
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.ForeColor = System.Drawing.Color.IndianRed;
            tENLOPLabel.Location = new System.Drawing.Point(58, 152);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(74, 22);
            tENLOPLabel.TabIndex = 35;
            tENLOPLabel.Text = "Tên lớp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.IndianRed;
            label2.Location = new System.Drawing.Point(41, 259);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(91, 22);
            label2.TabIndex = 38;
            label2.Text = "Niên khóa:";
            // 
            // numHocKi
            // 
            this.numHocKi.BackColor = System.Drawing.Color.Linen;
            this.numHocKi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHocKi.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F);
            this.numHocKi.ForeColor = System.Drawing.Color.Maroon;
            this.numHocKi.Location = new System.Drawing.Point(664, 261);
            this.numHocKi.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numHocKi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHocKi.Name = "numHocKi";
            this.numHocKi.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numHocKi.Size = new System.Drawing.Size(88, 27);
            this.numHocKi.TabIndex = 42;
            this.numHocKi.Value = new decimal(new int[] {
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
            this.label3.Location = new System.Drawing.Point(571, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 41;
            this.label3.Text = "Học kì:";
            // 
            // edtLOP
            // 
            this.edtLOP.Location = new System.Drawing.Point(144, 203);
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
            this.edtLOP.TabIndex = 40;
            this.edtLOP.EditValueChanged += new System.EventHandler(this.edtLOP_EditValueChanged);
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
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.White;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThoat.FlatAppearance.BorderSize = 2;
            this.btnThoat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MistyRose;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.IndianRed;
            this.btnThoat.Location = new System.Drawing.Point(476, 380);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 35);
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
            this.btnIN.Location = new System.Drawing.Point(250, 380);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(136, 35);
            this.btnIN.TabIndex = 36;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // cmbNienKhoa
            // 
            this.cmbNienKhoa.BackColor = System.Drawing.Color.Linen;
            this.cmbNienKhoa.DisplayMember = "TENLOP";
            this.cmbNienKhoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbNienKhoa.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbNienKhoa.ForeColor = System.Drawing.Color.Maroon;
            this.cmbNienKhoa.FormattingEnabled = true;
            this.cmbNienKhoa.Location = new System.Drawing.Point(144, 257);
            this.cmbNienKhoa.Name = "cmbNienKhoa";
            this.cmbNienKhoa.Size = new System.Drawing.Size(277, 28);
            this.cmbNienKhoa.TabIndex = 39;
            this.cmbNienKhoa.ValueMember = "MALOP";
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(138, 154);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DataSource = this.lOPBindingSource;
            this.lookUpEdit1.Properties.DisplayMember = "TENLOP";
            this.lookUpEdit1.Properties.NullText = "Chọn lớp";
            this.lookUpEdit1.Properties.ValueMember = "MALOP";
            this.lookUpEdit1.Size = new System.Drawing.Size(614, 20);
            this.lookUpEdit1.TabIndex = 44;
            this.lookUpEdit1.EditValueChanged += new System.EventHandler(this.lookUpEdit1_EditValueChanged);
            // 
            // RpHPLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 466);
            this.Controls.Add(this.lookUpEdit1);
            this.Controls.Add(label4);
            this.Controls.Add(this.numHocKi);
            this.Controls.Add(this.label3);
            this.Controls.Add(label2);
            this.Controls.Add(mALOPLabel1);
            this.Controls.Add(this.edtLOP);
            this.Controls.Add(this.cmbNienKhoa);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIN);
            this.Name = "RpHPLop";
            this.Text = "Báo cáo học phí lớp";
            this.Load += new System.EventHandler(this.RpHPLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHocKi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numHocKi;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit edtLOP;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIN;
        private System.Windows.Forms.ComboBox cmbNienKhoa;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
    }
}