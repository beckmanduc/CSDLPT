namespace QLVT_CSDLPT
{
    partial class frmPhieuNhap
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
            System.Windows.Forms.Label mAPNLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label mAPNLabel1;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label mAVTLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripPN = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.phieuNhapGridControl = new DevExpress.XtraGrid.GridControl();
            this.phieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_CSDLPT.DS();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasoDDH2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripCTPN = new System.Windows.Forms.ToolStrip();
            this.btnThemCT = new System.Windows.Forms.ToolStripButton();
            this.btnXoaCT = new System.Windows.Forms.ToolStripButton();
            this.btnSuaCT = new System.Windows.Forms.ToolStripButton();
            this.btnLuuCT = new System.Windows.Forms.ToolStripButton();
            this.btnUndoCTPN = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCTPN = new System.Windows.Forms.ToolStripButton();
            this.cTPNGridControl = new DevExpress.XtraGrid.GridControl();
            this.cTPNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMAPN1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbKHO = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAKHO = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.SpinEdit();
            this.dtpNGAY = new System.Windows.Forms.DateTimePicker();
            this.txtMASODDH = new DevExpress.XtraEditors.TextEdit();
            this.txtMAPNPN = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbVatTu = new System.Windows.Forms.ComboBox();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.seDONGIA = new DevExpress.XtraEditors.SpinEdit();
            this.seSOLUONG = new DevExpress.XtraEditors.SpinEdit();
            this.txtMAPN = new DevExpress.XtraEditors.TextEdit();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.datHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.datHangTableAdapter = new QLVT_CSDLPT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT_CSDLPT.DSTableAdapters.CTDDHTableAdapter();
            this.cTPNTableAdapter = new QLVT_CSDLPT.DSTableAdapters.CTPNTableAdapter();
            this.khoTableAdapter = new QLVT_CSDLPT.DSTableAdapters.KhoTableAdapter();
            this.phieuNhapTableAdapter = new QLVT_CSDLPT.DSTableAdapters.PhieuNhapTableAdapter();
            mAPNLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            mAPNLabel1 = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStripCTPN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASODDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPNPN.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDONGIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSOLUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPN.Properties)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mAPNLabel
            // 
            mAPNLabel.AutoSize = true;
            mAPNLabel.Location = new System.Drawing.Point(29, 40);
            mAPNLabel.Name = "mAPNLabel";
            mAPNLabel.Size = new System.Drawing.Size(55, 17);
            mAPNLabel.TabIndex = 0;
            mAPNLabel.Text = "MAPN:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(32, 81);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(52, 17);
            nGAYLabel.TabIndex = 2;
            nGAYLabel.Text = "NGAY:";
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(3, 125);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(81, 17);
            masoDDHLabel.TabIndex = 4;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(248, 40);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(56, 17);
            mANVLabel.TabIndex = 6;
            mANVLabel.Text = "MANV:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(236, 83);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(68, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // mAPNLabel1
            // 
            mAPNLabel1.AutoSize = true;
            mAPNLabel1.Location = new System.Drawing.Point(27, 40);
            mAPNLabel1.Name = "mAPNLabel1";
            mAPNLabel1.Size = new System.Drawing.Size(55, 17);
            mAPNLabel1.TabIndex = 0;
            mAPNLabel1.Text = "MAPN:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(336, 40);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 17);
            sOLUONGLabel.TabIndex = 2;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(348, 88);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(70, 17);
            dONGIALabel.TabIndex = 4;
            dONGIALabel.Text = "DONGIA:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(30, 88);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(52, 17);
            mAVTLabel.TabIndex = 6;
            mAVTLabel.Text = "MAVT:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh :";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(445, 12);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(217, 25);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7657F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.2343F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox6, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.66162F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.33838F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 147F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 677);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStripPN);
            this.groupBox1.Controls.Add(this.phieuNhapGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 255);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Phiếu Nhập";
            // 
            // toolStripPN
            // 
            this.toolStripPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnUndo,
            this.btnRefresh});
            this.toolStripPN.Location = new System.Drawing.Point(3, 21);
            this.toolStripPN.Name = "toolStripPN";
            this.toolStripPN.Size = new System.Drawing.Size(519, 25);
            this.toolStripPN.TabIndex = 1;
            this.toolStripPN.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(23, 22);
            this.btnThem.Text = "toolStripButton1";
            this.btnThem.ToolTipText = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(23, 22);
            this.btnXoa.Text = "toolStripButton2";
            this.btnXoa.ToolTipText = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(23, 22);
            this.btnSua.Text = "toolStripButton3";
            this.btnSua.ToolTipText = "Sửa";
            // 
            // btnLuu
            // 
            this.btnLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(23, 22);
            this.btnLuu.Text = "toolStripButton4";
            this.btnLuu.ToolTipText = "Lưu";
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(23, 22);
            this.btnUndo.Text = "toolStripButton5";
            this.btnUndo.ToolTipText = "Undo";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(23, 22);
            this.btnRefresh.Text = "toolStripButton6";
            this.btnRefresh.ToolTipText = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // phieuNhapGridControl
            // 
            this.phieuNhapGridControl.DataSource = this.phieuNhapBindingSource;
            this.phieuNhapGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phieuNhapGridControl.Location = new System.Drawing.Point(3, 21);
            this.phieuNhapGridControl.MainView = this.gridView3;
            this.phieuNhapGridControl.Name = "phieuNhapGridControl";
            this.phieuNhapGridControl.Size = new System.Drawing.Size(519, 231);
            this.phieuNhapGridControl.TabIndex = 0;
            this.phieuNhapGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // phieuNhapBindingSource
            // 
            this.phieuNhapBindingSource.DataMember = "PhieuNhap";
            this.phieuNhapBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN,
            this.colNGAY1,
            this.colMasoDDH2,
            this.colMANV1,
            this.colMAKHO1});
            this.gridView3.GridControl = this.phieuNhapGridControl;
            this.gridView3.Name = "gridView3";
            // 
            // colMAPN
            // 
            this.colMAPN.Caption = "MAPN";
            this.colMAPN.FieldName = "MAPN";
            this.colMAPN.Name = "colMAPN";
            this.colMAPN.Visible = true;
            this.colMAPN.VisibleIndex = 0;
            // 
            // colNGAY1
            // 
            this.colNGAY1.Caption = "NGAY";
            this.colNGAY1.FieldName = "NGAY";
            this.colNGAY1.Name = "colNGAY1";
            this.colNGAY1.Visible = true;
            this.colNGAY1.VisibleIndex = 1;
            // 
            // colMasoDDH2
            // 
            this.colMasoDDH2.Caption = "Maso DDH";
            this.colMasoDDH2.FieldName = "MasoDDH";
            this.colMasoDDH2.Name = "colMasoDDH2";
            this.colMasoDDH2.Visible = true;
            this.colMasoDDH2.VisibleIndex = 2;
            // 
            // colMANV1
            // 
            this.colMANV1.Caption = "MANV";
            this.colMANV1.FieldName = "MANV";
            this.colMANV1.Name = "colMANV1";
            this.colMANV1.Visible = true;
            this.colMANV1.VisibleIndex = 3;
            // 
            // colMAKHO1
            // 
            this.colMAKHO1.Caption = "MAKHO";
            this.colMAKHO1.FieldName = "MAKHO";
            this.colMAKHO1.Name = "colMAKHO1";
            this.colMAKHO1.Visible = true;
            this.colMAKHO1.VisibleIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStripCTPN);
            this.groupBox2.Controls.Add(this.cTPNGridControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(534, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 255);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng CTPN";
            // 
            // toolStripCTPN
            // 
            this.toolStripCTPN.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCT,
            this.btnXoaCT,
            this.btnSuaCT,
            this.btnLuuCT,
            this.btnUndoCTPN,
            this.btnRefreshCTPN});
            this.toolStripCTPN.Location = new System.Drawing.Point(3, 21);
            this.toolStripCTPN.Name = "toolStripCTPN";
            this.toolStripCTPN.Size = new System.Drawing.Size(524, 25);
            this.toolStripCTPN.TabIndex = 1;
            this.toolStripCTPN.Text = "toolStrip2";
            // 
            // btnThemCT
            // 
            this.btnThemCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(23, 22);
            this.btnThemCT.Text = "toolStripButton7";
            this.btnThemCT.ToolTipText = "Thêm";
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(23, 22);
            this.btnXoaCT.Text = "toolStripButton8";
            this.btnXoaCT.ToolTipText = "Xoá";
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSuaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCT.Image")));
            this.btnSuaCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(23, 22);
            this.btnSuaCT.Text = "toolStripButton9";
            this.btnSuaCT.ToolTipText = "Sửa";
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLuuCT.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCT.Image")));
            this.btnLuuCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(23, 22);
            this.btnLuuCT.Text = "toolStripButton10";
            this.btnLuuCT.ToolTipText = "Lưu";
            // 
            // btnUndoCTPN
            // 
            this.btnUndoCTPN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndoCTPN.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoCTPN.Image")));
            this.btnUndoCTPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndoCTPN.Name = "btnUndoCTPN";
            this.btnUndoCTPN.Size = new System.Drawing.Size(23, 22);
            this.btnUndoCTPN.Text = "toolStripButton11";
            this.btnUndoCTPN.ToolTipText = "Undo";
            // 
            // btnRefreshCTPN
            // 
            this.btnRefreshCTPN.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshCTPN.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCTPN.Image")));
            this.btnRefreshCTPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCTPN.Name = "btnRefreshCTPN";
            this.btnRefreshCTPN.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshCTPN.Text = "toolStripButton12";
            this.btnRefreshCTPN.ToolTipText = "Refresh";
            // 
            // cTPNGridControl
            // 
            this.cTPNGridControl.DataSource = this.cTPNBindingSource;
            this.cTPNGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTPNGridControl.Location = new System.Drawing.Point(3, 21);
            this.cTPNGridControl.MainView = this.gridView4;
            this.cTPNGridControl.Name = "cTPNGridControl";
            this.cTPNGridControl.Size = new System.Drawing.Size(524, 231);
            this.cTPNGridControl.TabIndex = 0;
            this.cTPNGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView4});
            // 
            // cTPNBindingSource
            // 
            this.cTPNBindingSource.DataMember = "CTPN";
            this.cTPNBindingSource.DataSource = this.dS;
            // 
            // gridView4
            // 
            this.gridView4.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMAPN1,
            this.colMAVT1,
            this.colSOLUONG1,
            this.colDONGIA1});
            this.gridView4.GridControl = this.cTPNGridControl;
            this.gridView4.Name = "gridView4";
            // 
            // colMAPN1
            // 
            this.colMAPN1.Caption = "MAPN";
            this.colMAPN1.FieldName = "MAPN";
            this.colMAPN1.Name = "colMAPN1";
            this.colMAPN1.Visible = true;
            this.colMAPN1.VisibleIndex = 0;
            // 
            // colMAVT1
            // 
            this.colMAVT1.Caption = "MAVT";
            this.colMAVT1.FieldName = "MAVT";
            this.colMAVT1.Name = "colMAVT1";
            this.colMAVT1.Visible = true;
            this.colMAVT1.VisibleIndex = 1;
            // 
            // colSOLUONG1
            // 
            this.colSOLUONG1.Caption = "SOLUONG";
            this.colSOLUONG1.FieldName = "SOLUONG";
            this.colSOLUONG1.Name = "colSOLUONG1";
            this.colSOLUONG1.Visible = true;
            this.colSOLUONG1.VisibleIndex = 2;
            // 
            // colDONGIA1
            // 
            this.colDONGIA1.Caption = "DONGIA";
            this.colDONGIA1.FieldName = "DONGIA";
            this.colDONGIA1.Name = "colDONGIA1";
            this.colDONGIA1.Visible = true;
            this.colDONGIA1.VisibleIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbKHO);
            this.groupBox3.Controls.Add(mAKHOLabel);
            this.groupBox3.Controls.Add(this.txtMAKHO);
            this.groupBox3.Controls.Add(mANVLabel);
            this.groupBox3.Controls.Add(this.txtMANV);
            this.groupBox3.Controls.Add(this.dtpNGAY);
            this.groupBox3.Controls.Add(masoDDHLabel);
            this.groupBox3.Controls.Add(this.txtMASODDH);
            this.groupBox3.Controls.Add(nGAYLabel);
            this.groupBox3.Controls.Add(mAPNLabel);
            this.groupBox3.Controls.Add(this.txtMAPNPN);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 532);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(525, 142);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phiếu nhập";
            // 
            // cmbKHO
            // 
            this.cmbKHO.DataSource = this.khoBindingSource;
            this.cmbKHO.DisplayMember = "TENKHO";
            this.cmbKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKHO.FormattingEnabled = true;
            this.cmbKHO.Location = new System.Drawing.Point(310, 85);
            this.cmbKHO.Name = "cmbKHO";
            this.cmbKHO.Size = new System.Drawing.Size(109, 25);
            this.cmbKHO.TabIndex = 10;
            this.cmbKHO.ValueMember = "MAKHO";
            this.cmbKHO.SelectedIndexChanged += new System.EventHandler(this.cmbKHO_SelectedIndexChanged);
            // 
            // khoBindingSource
            // 
            this.khoBindingSource.DataMember = "Kho";
            this.khoBindingSource.DataSource = this.dS;
            // 
            // txtMAKHO
            // 
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(442, 82);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(79, 20);
            this.txtMAKHO.TabIndex = 9;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MANV", true));
            this.txtMANV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMANV.Location = new System.Drawing.Point(310, 37);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMANV.Size = new System.Drawing.Size(100, 20);
            this.txtMANV.TabIndex = 7;
            // 
            // dtpNGAY
            // 
            this.dtpNGAY.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.phieuNhapBindingSource, "NGAY", true));
            this.dtpNGAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNGAY.Location = new System.Drawing.Point(90, 75);
            this.dtpNGAY.Name = "dtpNGAY";
            this.dtpNGAY.Size = new System.Drawing.Size(123, 25);
            this.dtpNGAY.TabIndex = 6;
            this.dtpNGAY.Value = new System.DateTime(2020, 8, 11, 16, 39, 19, 0);
            // 
            // txtMASODDH
            // 
            this.txtMASODDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MasoDDH", true));
            this.txtMASODDH.Location = new System.Drawing.Point(90, 122);
            this.txtMASODDH.Name = "txtMASODDH";
            this.txtMASODDH.Size = new System.Drawing.Size(123, 20);
            this.txtMASODDH.TabIndex = 5;
            // 
            // txtMAPNPN
            // 
            this.txtMAPNPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.phieuNhapBindingSource, "MAPN", true));
            this.txtMAPNPN.Location = new System.Drawing.Point(90, 37);
            this.txtMAPNPN.Name = "txtMAPNPN";
            this.txtMAPNPN.Size = new System.Drawing.Size(123, 20);
            this.txtMAPNPN.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbVatTu);
            this.groupBox4.Controls.Add(mAVTLabel);
            this.groupBox4.Controls.Add(this.txtMAVT);
            this.groupBox4.Controls.Add(dONGIALabel);
            this.groupBox4.Controls.Add(this.seDONGIA);
            this.groupBox4.Controls.Add(sOLUONGLabel);
            this.groupBox4.Controls.Add(this.seSOLUONG);
            this.groupBox4.Controls.Add(mAPNLabel1);
            this.groupBox4.Controls.Add(this.txtMAPN);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(534, 532);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(530, 142);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CTPN";
            // 
            // cmbVatTu
            // 
            this.cmbVatTu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVatTu.FormattingEnabled = true;
            this.cmbVatTu.Location = new System.Drawing.Point(88, 88);
            this.cmbVatTu.Name = "cmbVatTu";
            this.cmbVatTu.Size = new System.Drawing.Size(137, 25);
            this.cmbVatTu.TabIndex = 8;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(231, 87);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(100, 20);
            this.txtMAVT.TabIndex = 7;
            // 
            // seDONGIA
            // 
            this.seDONGIA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "DONGIA", true));
            this.seDONGIA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDONGIA.Location = new System.Drawing.Point(424, 85);
            this.seDONGIA.Name = "seDONGIA";
            this.seDONGIA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDONGIA.Size = new System.Drawing.Size(100, 20);
            this.seDONGIA.TabIndex = 5;
            // 
            // seSOLUONG
            // 
            this.seSOLUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "SOLUONG", true));
            this.seSOLUONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSOLUONG.Location = new System.Drawing.Point(424, 37);
            this.seSOLUONG.Name = "seSOLUONG";
            this.seSOLUONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSOLUONG.Size = new System.Drawing.Size(100, 20);
            this.seSOLUONG.TabIndex = 3;
            // 
            // txtMAPN
            // 
            this.txtMAPN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTPNBindingSource, "MAPN", true));
            this.txtMAPN.Location = new System.Drawing.Point(88, 37);
            this.txtMAPN.Name = "txtMAPN";
            this.txtMAPN.Size = new System.Drawing.Size(100, 20);
            this.txtMAPN.TabIndex = 1;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.datHangGridControl);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(3, 3);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(525, 262);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Đặt Hàng";
            // 
            // datHangGridControl
            // 
            this.datHangGridControl.DataSource = this.datHangBindingSource;
            this.datHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datHangGridControl.Location = new System.Drawing.Point(3, 21);
            this.datHangGridControl.MainView = this.gridView1;
            this.datHangGridControl.Name = "datHangGridControl";
            this.datHangGridControl.Size = new System.Drawing.Size(519, 238);
            this.datHangGridControl.TabIndex = 0;
            this.datHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.dS;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH,
            this.colNGAY,
            this.colNhaCC,
            this.colMANV,
            this.colMAKHO});
            this.gridView1.GridControl = this.datHangGridControl;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMasoDDH
            // 
            this.colMasoDDH.Caption = "Maso DDH";
            this.colMasoDDH.FieldName = "MasoDDH";
            this.colMasoDDH.Name = "colMasoDDH";
            this.colMasoDDH.Visible = true;
            this.colMasoDDH.VisibleIndex = 0;
            // 
            // colNGAY
            // 
            this.colNGAY.Caption = "NGAY";
            this.colNGAY.FieldName = "NGAY";
            this.colNGAY.Name = "colNGAY";
            this.colNGAY.Visible = true;
            this.colNGAY.VisibleIndex = 1;
            // 
            // colNhaCC
            // 
            this.colNhaCC.Caption = "Nha CC";
            this.colNhaCC.FieldName = "NhaCC";
            this.colNhaCC.Name = "colNhaCC";
            this.colNhaCC.Visible = true;
            this.colNhaCC.VisibleIndex = 2;
            // 
            // colMANV
            // 
            this.colMANV.Caption = "MANV";
            this.colMANV.FieldName = "MANV";
            this.colMANV.Name = "colMANV";
            this.colMANV.Visible = true;
            this.colMANV.VisibleIndex = 3;
            // 
            // colMAKHO
            // 
            this.colMAKHO.Caption = "MAKHO";
            this.colMAKHO.FieldName = "MAKHO";
            this.colMAKHO.Name = "colMAKHO";
            this.colMAKHO.Visible = true;
            this.colMAKHO.VisibleIndex = 4;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cTDDHGridControl);
            this.groupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox6.Location = new System.Drawing.Point(534, 3);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(530, 262);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "CTDDH";
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.cTDDHBindingSource;
            this.cTDDHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTDDHGridControl.Location = new System.Drawing.Point(3, 21);
            this.cTDDHGridControl.MainView = this.gridView2;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(524, 238);
            this.cTDDHGridControl.TabIndex = 0;
            this.cTDDHGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // cTDDHBindingSource
            // 
            this.cTDDHBindingSource.DataMember = "CTDDH";
            this.cTDDHBindingSource.DataSource = this.dS;
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasoDDH1,
            this.colMAVT,
            this.colSOLUONG,
            this.colDONGIA});
            this.gridView2.GridControl = this.cTDDHGridControl;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsBehavior.Editable = false;
            // 
            // colMasoDDH1
            // 
            this.colMasoDDH1.Caption = "Maso DDH";
            this.colMasoDDH1.FieldName = "MasoDDH";
            this.colMasoDDH1.Name = "colMasoDDH1";
            this.colMasoDDH1.Visible = true;
            this.colMasoDDH1.VisibleIndex = 0;
            // 
            // colMAVT
            // 
            this.colMAVT.Caption = "MAVT";
            this.colMAVT.FieldName = "MAVT";
            this.colMAVT.Name = "colMAVT";
            this.colMAVT.Visible = true;
            this.colMAVT.VisibleIndex = 1;
            // 
            // colSOLUONG
            // 
            this.colSOLUONG.Caption = "SOLUONG";
            this.colSOLUONG.CustomizationCaption = "DONGIA";
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // datHangTableAdapter
            // 
            this.datHangTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ChiNhanhTableAdapter = null;
            this.tableAdapterManager.CTDDHTableAdapter = this.cTDDHTableAdapter;
            this.tableAdapterManager.CTPNTableAdapter = this.cTPNTableAdapter;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = this.khoTableAdapter;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = this.phieuNhapTableAdapter;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // cTPNTableAdapter
            // 
            this.cTPNTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // phieuNhapTableAdapter
            // 
            this.phieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // frmPhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 732);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuNhap";
            this.Text = "frmPhieuNhap";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPhieuNhap_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripPN.ResumeLayout(false);
            this.toolStripPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStripCTPN.ResumeLayout(false);
            this.toolStripCTPN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTPNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASODDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPNPN.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDONGIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSOLUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAPN.Properties)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbChiNhanh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private DS dS;
        private System.Windows.Forms.BindingSource datHangBindingSource;
        private DSTableAdapters.DatHangTableAdapter datHangTableAdapter;
        private DSTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl datHangGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY;
        private DevExpress.XtraGrid.Columns.GridColumn colNhaCC;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO;
        private DSTableAdapters.CTDDHTableAdapter cTDDHTableAdapter;
        private System.Windows.Forms.BindingSource cTDDHBindingSource;
        private DevExpress.XtraGrid.GridControl cTDDHGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA;
        private DSTableAdapters.PhieuNhapTableAdapter phieuNhapTableAdapter;
        private System.Windows.Forms.BindingSource phieuNhapBindingSource;
        private DevExpress.XtraGrid.GridControl phieuNhapGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN;
        private DevExpress.XtraGrid.Columns.GridColumn colNGAY1;
        private DevExpress.XtraGrid.Columns.GridColumn colMasoDDH2;
        private DevExpress.XtraGrid.Columns.GridColumn colMANV1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAKHO1;
        private DSTableAdapters.CTPNTableAdapter cTPNTableAdapter;
        private System.Windows.Forms.BindingSource cTPNBindingSource;
        private DevExpress.XtraGrid.GridControl cTPNGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Columns.GridColumn colMAPN1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAVT1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOLUONG1;
        private DevExpress.XtraGrid.Columns.GridColumn colDONGIA1;
        private System.Windows.Forms.ComboBox cmbKHO;
        private DevExpress.XtraEditors.TextEdit txtMAKHO;
        private DevExpress.XtraEditors.SpinEdit txtMANV;
        private System.Windows.Forms.DateTimePicker dtpNGAY;
        private DevExpress.XtraEditors.TextEdit txtMASODDH;
        private DevExpress.XtraEditors.TextEdit txtMAPNPN;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private System.Windows.Forms.ToolStrip toolStripPN;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolStripCTPN;
        private System.Windows.Forms.ToolStripButton btnThemCT;
        private System.Windows.Forms.ToolStripButton btnXoaCT;
        private System.Windows.Forms.ToolStripButton btnSuaCT;
        private System.Windows.Forms.ToolStripButton btnLuuCT;
        private System.Windows.Forms.ToolStripButton btnUndoCTPN;
        private System.Windows.Forms.ToolStripButton btnRefreshCTPN;
        private System.Windows.Forms.ComboBox cmbVatTu;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraEditors.SpinEdit seDONGIA;
        private DevExpress.XtraEditors.SpinEdit seSOLUONG;
        private DevExpress.XtraEditors.TextEdit txtMAPN;
    }
}