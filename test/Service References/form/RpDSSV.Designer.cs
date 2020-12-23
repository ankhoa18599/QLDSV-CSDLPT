namespace test.form
{
    partial class RpDSSV
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
            System.Windows.Forms.Label tENLOPLabel;
            System.Windows.Forms.Label mALOPLabel1;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIN = new System.Windows.Forms.Button();
            this.qLDSVDataSet = new test.QLDSVDataSet();
            this.lOPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lOPTableAdapter = new test.QLDSVDataSetTableAdapters.LOPTableAdapter();
            this.tableAdapterManager = new test.QLDSVDataSetTableAdapters.TableAdapterManager();
            this.lOPComboBox = new System.Windows.Forms.ComboBox();
            this.edtLOP = new DevExpress.XtraEditors.TextEdit();
            tENLOPLabel = new System.Windows.Forms.Label();
            mALOPLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // tENLOPLabel
            // 
            tENLOPLabel.AutoSize = true;
            tENLOPLabel.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tENLOPLabel.ForeColor = System.Drawing.Color.IndianRed;
            tENLOPLabel.Location = new System.Drawing.Point(14, 177);
            tENLOPLabel.Name = "tENLOPLabel";
            tENLOPLabel.Size = new System.Drawing.Size(74, 22);
            tENLOPLabel.TabIndex = 9;
            tENLOPLabel.Text = "Tên lớp:";
            tENLOPLabel.Click += new System.EventHandler(this.tENLOPLabel_Click);
            // 
            // mALOPLabel1
            // 
            mALOPLabel1.AutoSize = true;
            mALOPLabel1.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mALOPLabel1.ForeColor = System.Drawing.Color.IndianRed;
            mALOPLabel1.Location = new System.Drawing.Point(22, 229);
            mALOPLabel1.Name = "mALOPLabel1";
            mALOPLabel1.Size = new System.Drawing.Size(66, 22);
            mALOPLabel1.TabIndex = 14;
            mALOPLabel1.Text = "Mã lớp:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("SVN-Cookies", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.IndianRed;
            label1.Location = new System.Drawing.Point(34, 123);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 22);
            label1.TabIndex = 9;
            label1.Text = "Khoa:";
            label1.Click += new System.EventHandler(this.tENLOPLabel_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("SVN-Cookies", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.IndianRed;
            label2.Location = new System.Drawing.Point(199, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(435, 44);
            label2.TabIndex = 9;
            label2.Text = "IN DANH SÁCH SINH VIÊN LỚP";
            label2.Click += new System.EventHandler(this.tENLOPLabel_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Linen;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("UVF Nexa Slab Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Maroon;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 123);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(609, 28);
            this.comboBox1.TabIndex = 8;
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
            this.btnThoat.Location = new System.Drawing.Point(444, 271);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(156, 35);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.UseVisualStyleBackColor = false;
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
            this.btnIN.Location = new System.Drawing.Point(207, 271);
            this.btnIN.Name = "btnIN";
            this.btnIN.Size = new System.Drawing.Size(136, 35);
            this.btnIN.TabIndex = 12;
            this.btnIN.Text = "IN";
            this.btnIN.UseVisualStyleBackColor = false;
            this.btnIN.Click += new System.EventHandler(this.btnIN_Click);
            // 
            // qLDSVDataSet
            // 
            this.qLDSVDataSet.DataSetName = "QLDSVDataSet";
            this.qLDSVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPBindingSource
            // 
            this.lOPBindingSource.DataMember = "LOP";
            this.lOPBindingSource.DataSource = this.qLDSVDataSet;
            // 
            // lOPTableAdapter
            // 
            this.lOPTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_DONGHOCPHITableAdapter = null;
            this.tableAdapterManager.DIEMTableAdapter = null;
            this.tableAdapterManager.GIANGVIENTableAdapter = null;
            this.tableAdapterManager.HOCPHITableAdapter = null;
            this.tableAdapterManager.KHOATableAdapter = null;
            this.tableAdapterManager.LOPTableAdapter = this.lOPTableAdapter;
            this.tableAdapterManager.MONHOCTableAdapter = null;
            this.tableAdapterManager.SINHVIENTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = test.QLDSVDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.lOPComboBox.Location = new System.Drawing.Point(99, 175);
            this.lOPComboBox.Name = "lOPComboBox";
            this.lOPComboBox.Size = new System.Drawing.Size(609, 28);
            this.lOPComboBox.TabIndex = 14;
            this.lOPComboBox.ValueMember = "MALOP";
            this.lOPComboBox.SelectedIndexChanged += new System.EventHandler(this.lOPComboBox_SelectedIndexChanged);
            // 
            // edtLOP
            // 
            this.edtLOP.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.lOPBindingSource, "MALOP", true));
            this.edtLOP.Location = new System.Drawing.Point(99, 223);
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
            this.edtLOP.TabIndex = 15;
            this.edtLOP.EditValueChanged += new System.EventHandler(this.edtLOP_EditValueChanged);
            // 
            // RpDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 406);
            this.Controls.Add(mALOPLabel1);
            this.Controls.Add(this.edtLOP);
            this.Controls.Add(this.lOPComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(tENLOPLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIN);
            this.Name = "RpDSSV";
            this.Text = "RpDSSV";
            this.Load += new System.EventHandler(this.RpDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qLDSVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edtLOP.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIN;
        private QLDSVDataSet qLDSVDataSet;
        private System.Windows.Forms.BindingSource lOPBindingSource;
        private QLDSVDataSetTableAdapters.LOPTableAdapter lOPTableAdapter;
        private QLDSVDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox lOPComboBox;
        private DevExpress.XtraEditors.TextEdit edtLOP;
    }
}