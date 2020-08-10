namespace QLVT_CSDLPT
{
    partial class frmDatHang
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
            System.Windows.Forms.Label masoDDHLabel;
            System.Windows.Forms.Label mANVLabel;
            System.Windows.Forms.Label nhaCCLabel;
            System.Windows.Forms.Label nGAYLabel;
            System.Windows.Forms.Label mAKHOLabel;
            System.Windows.Forms.Label masoDDHLabel1;
            System.Windows.Forms.Label mAVTLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatHang));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbChiNhanh = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toolStripDH = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnLuu = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.datHangGridControl = new DevExpress.XtraGrid.GridControl();
            this.datHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dS = new QLVT_CSDLPT.DS();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNGAY = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNhaCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMANV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAKHO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStripCTDH = new System.Windows.Forms.ToolStrip();
            this.btnThemCT = new System.Windows.Forms.ToolStripButton();
            this.btnXoaCT = new System.Windows.Forms.ToolStripButton();
            this.btnSuaCT = new System.Windows.Forms.ToolStripButton();
            this.btnLuuCT = new System.Windows.Forms.ToolStripButton();
            this.btnUndoCT = new System.Windows.Forms.ToolStripButton();
            this.btnRefreshCT = new System.Windows.Forms.ToolStripButton();
            this.cTDDHGridControl = new DevExpress.XtraGrid.GridControl();
            this.cTDDHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMasoDDH1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOLUONG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDONGIA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtpNGAY = new System.Windows.Forms.DateTimePicker();
            this.cmbKHO = new System.Windows.Forms.ComboBox();
            this.khoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMAKHO = new DevExpress.XtraEditors.TextEdit();
            this.txtNHACC = new DevExpress.XtraEditors.TextEdit();
            this.txtMANV = new DevExpress.XtraEditors.SpinEdit();
            this.txtMASODDHDH = new DevExpress.XtraEditors.TextEdit();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbVATTU = new System.Windows.Forms.ComboBox();
            this.vattuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seDONGIA = new DevExpress.XtraEditors.SpinEdit();
            this.seSOLUONG = new DevExpress.XtraEditors.SpinEdit();
            this.txtMAVT = new DevExpress.XtraEditors.TextEdit();
            this.txtMASODDH = new DevExpress.XtraEditors.TextEdit();
            this.datHangTableAdapter = new QLVT_CSDLPT.DSTableAdapters.DatHangTableAdapter();
            this.tableAdapterManager = new QLVT_CSDLPT.DSTableAdapters.TableAdapterManager();
            this.cTDDHTableAdapter = new QLVT_CSDLPT.DSTableAdapters.CTDDHTableAdapter();
            this.khoTableAdapter = new QLVT_CSDLPT.DSTableAdapters.KhoTableAdapter();
            this.vattuTableAdapter = new QLVT_CSDLPT.DSTableAdapters.VattuTableAdapter();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            masoDDHLabel = new System.Windows.Forms.Label();
            mANVLabel = new System.Windows.Forms.Label();
            nhaCCLabel = new System.Windows.Forms.Label();
            nGAYLabel = new System.Windows.Forms.Label();
            mAKHOLabel = new System.Windows.Forms.Label();
            masoDDHLabel1 = new System.Windows.Forms.Label();
            mAVTLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStripDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toolStripCTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNHACC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASODDHDH.Properties)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDONGIA.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSOLUONG.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASODDH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // masoDDHLabel
            // 
            masoDDHLabel.AutoSize = true;
            masoDDHLabel.Location = new System.Drawing.Point(20, 52);
            masoDDHLabel.Name = "masoDDHLabel";
            masoDDHLabel.Size = new System.Drawing.Size(81, 17);
            masoDDHLabel.TabIndex = 0;
            masoDDHLabel.Text = "Maso DDH:";
            // 
            // mANVLabel
            // 
            mANVLabel.AutoSize = true;
            mANVLabel.Location = new System.Drawing.Point(315, 52);
            mANVLabel.Name = "mANVLabel";
            mANVLabel.Size = new System.Drawing.Size(56, 17);
            mANVLabel.TabIndex = 4;
            mANVLabel.Text = "MANV:";
            // 
            // nhaCCLabel
            // 
            nhaCCLabel.AutoSize = true;
            nhaCCLabel.Location = new System.Drawing.Point(311, 107);
            nhaCCLabel.Name = "nhaCCLabel";
            nhaCCLabel.Size = new System.Drawing.Size(60, 17);
            nhaCCLabel.TabIndex = 6;
            nhaCCLabel.Text = "Nha CC:";
            // 
            // nGAYLabel
            // 
            nGAYLabel.AutoSize = true;
            nGAYLabel.Location = new System.Drawing.Point(40, 107);
            nGAYLabel.Name = "nGAYLabel";
            nGAYLabel.Size = new System.Drawing.Size(52, 17);
            nGAYLabel.TabIndex = 7;
            nGAYLabel.Text = "NGAY:";
            // 
            // mAKHOLabel
            // 
            mAKHOLabel.AutoSize = true;
            mAKHOLabel.Location = new System.Drawing.Point(24, 167);
            mAKHOLabel.Name = "mAKHOLabel";
            mAKHOLabel.Size = new System.Drawing.Size(68, 17);
            mAKHOLabel.TabIndex = 8;
            mAKHOLabel.Text = "MAKHO:";
            // 
            // masoDDHLabel1
            // 
            masoDDHLabel1.AutoSize = true;
            masoDDHLabel1.Location = new System.Drawing.Point(45, 52);
            masoDDHLabel1.Name = "masoDDHLabel1";
            masoDDHLabel1.Size = new System.Drawing.Size(81, 17);
            masoDDHLabel1.TabIndex = 0;
            masoDDHLabel1.Text = "Maso DDH:";
            // 
            // mAVTLabel
            // 
            mAVTLabel.AutoSize = true;
            mAVTLabel.Location = new System.Drawing.Point(74, 109);
            mAVTLabel.Name = "mAVTLabel";
            mAVTLabel.Size = new System.Drawing.Size(52, 17);
            mAVTLabel.TabIndex = 2;
            mAVTLabel.Text = "MAVT:";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(44, 165);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 17);
            sOLUONGLabel.TabIndex = 4;
            sOLUONGLabel.Text = "SOLUONG:";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(300, 167);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(70, 17);
            dONGIALabel.TabIndex = 6;
            dONGIALabel.Text = "DONGIA:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmbChiNhanh);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 64);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(375, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chi nhánh :";
            // 
            // cmbChiNhanh
            // 
            this.cmbChiNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbChiNhanh.FormattingEnabled = true;
            this.cmbChiNhanh.Location = new System.Drawing.Point(469, 26);
            this.cmbChiNhanh.Name = "cmbChiNhanh";
            this.cmbChiNhanh.Size = new System.Drawing.Size(262, 25);
            this.cmbChiNhanh.TabIndex = 0;
            this.cmbChiNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbChiNhanh_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox4, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 524);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.toolStripDH);
            this.groupBox1.Controls.Add(this.datHangGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(527, 256);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bảng Đặt hàng";
            // 
            // toolStripDH
            // 
            this.toolStripDH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnXoa,
            this.btnSua,
            this.btnLuu,
            this.btnUndo,
            this.btnRefresh});
            this.toolStripDH.Location = new System.Drawing.Point(3, 21);
            this.toolStripDH.Name = "toolStripDH";
            this.toolStripDH.Size = new System.Drawing.Size(521, 25);
            this.toolStripDH.TabIndex = 1;
            this.toolStripDH.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(23, 22);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(23, 22);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(23, 22);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(23, 22);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.ToolTipText = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(23, 22);
            this.btnUndo.Text = "Undo";
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
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.ToolTipText = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // datHangGridControl
            // 
            this.datHangGridControl.DataSource = this.datHangBindingSource;
            this.datHangGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datHangGridControl.Location = new System.Drawing.Point(3, 21);
            this.datHangGridControl.MainView = this.gridView1;
            this.datHangGridControl.Name = "datHangGridControl";
            this.datHangGridControl.Size = new System.Drawing.Size(521, 232);
            this.datHangGridControl.TabIndex = 0;
            this.datHangGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // datHangBindingSource
            // 
            this.datHangBindingSource.DataMember = "DatHang";
            this.datHangBindingSource.DataSource = this.dS;
            // 
            // dS
            // 
            this.dS.DataSetName = "DS";
            this.dS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toolStripCTDH);
            this.groupBox2.Controls.Add(this.cTDDHGridControl);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(536, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(528, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng Chi tiết DDH";
            // 
            // toolStripCTDH
            // 
            this.toolStripCTDH.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThemCT,
            this.btnXoaCT,
            this.btnSuaCT,
            this.btnLuuCT,
            this.btnUndoCT,
            this.btnRefreshCT});
            this.toolStripCTDH.Location = new System.Drawing.Point(3, 21);
            this.toolStripCTDH.Name = "toolStripCTDH";
            this.toolStripCTDH.Size = new System.Drawing.Size(522, 25);
            this.toolStripCTDH.TabIndex = 1;
            this.toolStripCTDH.Text = "toolStrip2";
            // 
            // btnThemCT
            // 
            this.btnThemCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnThemCT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCT.Image")));
            this.btnThemCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(23, 22);
            this.btnThemCT.Text = "Thêm";
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnXoaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnXoaCT.Image")));
            this.btnXoaCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(23, 22);
            this.btnXoaCT.Text = "Xóa";
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSuaCT.Image = ((System.Drawing.Image)(resources.GetObject("btnSuaCT.Image")));
            this.btnSuaCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(23, 22);
            this.btnSuaCT.Text = "Sửa";
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnLuuCT
            // 
            this.btnLuuCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLuuCT.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuCT.Image")));
            this.btnLuuCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLuuCT.Name = "btnLuuCT";
            this.btnLuuCT.Size = new System.Drawing.Size(23, 22);
            this.btnLuuCT.Text = "Lưu";
            this.btnLuuCT.Click += new System.EventHandler(this.btnLuuCT_Click);
            // 
            // btnUndoCT
            // 
            this.btnUndoCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUndoCT.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoCT.Image")));
            this.btnUndoCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndoCT.Name = "btnUndoCT";
            this.btnUndoCT.Size = new System.Drawing.Size(23, 22);
            this.btnUndoCT.Text = "Undo";
            // 
            // btnRefreshCT
            // 
            this.btnRefreshCT.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefreshCT.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshCT.Image")));
            this.btnRefreshCT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefreshCT.Name = "btnRefreshCT";
            this.btnRefreshCT.Size = new System.Drawing.Size(23, 22);
            this.btnRefreshCT.Text = "Refresh";
            // 
            // cTDDHGridControl
            // 
            this.cTDDHGridControl.DataSource = this.cTDDHBindingSource;
            this.cTDDHGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cTDDHGridControl.Location = new System.Drawing.Point(3, 21);
            this.cTDDHGridControl.MainView = this.gridView2;
            this.cTDDHGridControl.Name = "cTDDHGridControl";
            this.cTDDHGridControl.Size = new System.Drawing.Size(522, 232);
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
            this.colSOLUONG.FieldName = "SOLUONG";
            this.colSOLUONG.Name = "colSOLUONG";
            this.colSOLUONG.Visible = true;
            this.colSOLUONG.VisibleIndex = 2;
            // 
            // colDONGIA
            // 
            this.colDONGIA.Caption = "DONGIA";
            this.colDONGIA.FieldName = "DONGIA";
            this.colDONGIA.Name = "colDONGIA";
            this.colDONGIA.Visible = true;
            this.colDONGIA.VisibleIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtpNGAY);
            this.groupBox3.Controls.Add(this.cmbKHO);
            this.groupBox3.Controls.Add(mAKHOLabel);
            this.groupBox3.Controls.Add(this.txtMAKHO);
            this.groupBox3.Controls.Add(nGAYLabel);
            this.groupBox3.Controls.Add(nhaCCLabel);
            this.groupBox3.Controls.Add(this.txtNHACC);
            this.groupBox3.Controls.Add(mANVLabel);
            this.groupBox3.Controls.Add(this.txtMANV);
            this.groupBox3.Controls.Add(masoDDHLabel);
            this.groupBox3.Controls.Add(this.txtMASODDHDH);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(527, 256);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Đặt hàng";
            // 
            // dtpNGAY
            // 
            this.dtpNGAY.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.datHangBindingSource, "NGAY", true));
            this.dtpNGAY.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNGAY.Location = new System.Drawing.Point(107, 103);
            this.dtpNGAY.Name = "dtpNGAY";
            this.dtpNGAY.Size = new System.Drawing.Size(149, 25);
            this.dtpNGAY.TabIndex = 11;
            // 
            // cmbKHO
            // 
            this.cmbKHO.DataSource = this.khoBindingSource;
            this.cmbKHO.DisplayMember = "TENKHO";
            this.cmbKHO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKHO.FormattingEnabled = true;
            this.cmbKHO.Location = new System.Drawing.Point(107, 157);
            this.cmbKHO.Name = "cmbKHO";
            this.cmbKHO.Size = new System.Drawing.Size(149, 25);
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
            this.txtMAKHO.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MAKHO", true));
            this.txtMAKHO.Location = new System.Drawing.Point(262, 162);
            this.txtMAKHO.Name = "txtMAKHO";
            this.txtMAKHO.Size = new System.Drawing.Size(109, 20);
            this.txtMAKHO.TabIndex = 9;
            // 
            // txtNHACC
            // 
            this.txtNHACC.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "NhaCC", true));
            this.txtNHACC.Location = new System.Drawing.Point(398, 103);
            this.txtNHACC.Name = "txtNHACC";
            this.txtNHACC.Size = new System.Drawing.Size(123, 20);
            this.txtNHACC.TabIndex = 7;
            // 
            // txtMANV
            // 
            this.txtMANV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MANV", true));
            this.txtMANV.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.txtMANV.Location = new System.Drawing.Point(398, 49);
            this.txtMANV.Name = "txtMANV";
            this.txtMANV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtMANV.Size = new System.Drawing.Size(123, 20);
            this.txtMANV.TabIndex = 5;
            // 
            // txtMASODDHDH
            // 
            this.txtMASODDHDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.datHangBindingSource, "MasoDDH", true));
            this.txtMASODDHDH.Location = new System.Drawing.Point(107, 49);
            this.txtMASODDHDH.Name = "txtMASODDHDH";
            this.txtMASODDHDH.Size = new System.Drawing.Size(149, 20);
            this.txtMASODDHDH.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbVATTU);
            this.groupBox4.Controls.Add(dONGIALabel);
            this.groupBox4.Controls.Add(this.seDONGIA);
            this.groupBox4.Controls.Add(sOLUONGLabel);
            this.groupBox4.Controls.Add(this.seSOLUONG);
            this.groupBox4.Controls.Add(mAVTLabel);
            this.groupBox4.Controls.Add(this.txtMAVT);
            this.groupBox4.Controls.Add(masoDDHLabel1);
            this.groupBox4.Controls.Add(this.txtMASODDH);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(536, 265);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(528, 256);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CTDDH";
            // 
            // cmbVATTU
            // 
            this.cmbVATTU.DataSource = this.vattuBindingSource;
            this.cmbVATTU.DisplayMember = "TENVT";
            this.cmbVATTU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbVATTU.FormattingEnabled = true;
            this.cmbVATTU.Location = new System.Drawing.Point(132, 106);
            this.cmbVATTU.Name = "cmbVATTU";
            this.cmbVATTU.Size = new System.Drawing.Size(176, 25);
            this.cmbVATTU.TabIndex = 8;
            this.cmbVATTU.ValueMember = "MAVT";
            // 
            // vattuBindingSource
            // 
            this.vattuBindingSource.DataMember = "Vattu";
            this.vattuBindingSource.DataSource = this.dS;
            // 
            // seDONGIA
            // 
            this.seDONGIA.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "DONGIA", true));
            this.seDONGIA.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seDONGIA.Location = new System.Drawing.Point(376, 164);
            this.seDONGIA.Name = "seDONGIA";
            this.seDONGIA.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seDONGIA.Size = new System.Drawing.Size(100, 20);
            this.seDONGIA.TabIndex = 7;
            // 
            // seSOLUONG
            // 
            this.seSOLUONG.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "SOLUONG", true));
            this.seSOLUONG.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.seSOLUONG.Location = new System.Drawing.Point(132, 162);
            this.seSOLUONG.Name = "seSOLUONG";
            this.seSOLUONG.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.seSOLUONG.Size = new System.Drawing.Size(112, 20);
            this.seSOLUONG.TabIndex = 5;
            // 
            // txtMAVT
            // 
            this.txtMAVT.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MAVT", true));
            this.txtMAVT.Location = new System.Drawing.Point(314, 106);
            this.txtMAVT.Name = "txtMAVT";
            this.txtMAVT.Size = new System.Drawing.Size(100, 20);
            this.txtMAVT.TabIndex = 3;
            // 
            // txtMASODDH
            // 
            this.txtMASODDH.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.cTDDHBindingSource, "MasoDDH", true));
            this.txtMASODDH.Location = new System.Drawing.Point(132, 49);
            this.txtMASODDH.Name = "txtMASODDH";
            this.txtMASODDH.Size = new System.Drawing.Size(282, 20);
            this.txtMASODDH.TabIndex = 1;
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
            this.tableAdapterManager.CTPNTableAdapter = null;
            this.tableAdapterManager.CTPXTableAdapter = null;
            this.tableAdapterManager.DatHangTableAdapter = this.datHangTableAdapter;
            this.tableAdapterManager.KhoTableAdapter = null;
            this.tableAdapterManager.NhanVienTableAdapter = null;
            this.tableAdapterManager.PhieuNhapTableAdapter = null;
            this.tableAdapterManager.PhieuXuatTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = QLVT_CSDLPT.DSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VattuTableAdapter = null;
            // 
            // cTDDHTableAdapter
            // 
            this.cTDDHTableAdapter.ClearBeforeFill = true;
            // 
            // khoTableAdapter
            // 
            this.khoTableAdapter.ClearBeforeFill = true;
            // 
            // vattuTableAdapter
            // 
            this.vattuTableAdapter.ClearBeforeFill = true;
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 588);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1067, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 588);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1067, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 588);
            // 
            // frmDatHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 588);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDatHang";
            this.Text = "frmDatHang";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDatHang_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStripDH.ResumeLayout(false);
            this.toolStripDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datHangGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.toolStripCTDH.ResumeLayout(false);
            this.toolStripCTDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTDDHBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAKHO.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNHACC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMANV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASODDHDH.Properties)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vattuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seDONGIA.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seSOLUONG.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMAVT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMASODDH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private DevExpress.XtraEditors.TextEdit txtMAKHO;
        private DevExpress.XtraEditors.TextEdit txtNHACC;
        private DevExpress.XtraEditors.SpinEdit txtMANV;
        private DevExpress.XtraEditors.TextEdit txtMASODDHDH;
        private DevExpress.XtraEditors.SpinEdit seDONGIA;
        private DevExpress.XtraEditors.SpinEdit seSOLUONG;
        private DevExpress.XtraEditors.TextEdit txtMAVT;
        private DevExpress.XtraEditors.TextEdit txtMASODDH;
        private System.Windows.Forms.BindingSource khoBindingSource;
        private DSTableAdapters.KhoTableAdapter khoTableAdapter;
        private System.Windows.Forms.BindingSource vattuBindingSource;
        private DSTableAdapters.VattuTableAdapter vattuTableAdapter;
        private System.Windows.Forms.ComboBox cmbKHO;
        private System.Windows.Forms.ComboBox cmbVATTU;
        private System.Windows.Forms.ToolStrip toolStripDH;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnLuu;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStrip toolStripCTDH;
        private System.Windows.Forms.ToolStripButton btnThemCT;
        private System.Windows.Forms.ToolStripButton btnXoaCT;
        private System.Windows.Forms.ToolStripButton btnSuaCT;
        private System.Windows.Forms.ToolStripButton btnLuuCT;
        private System.Windows.Forms.ToolStripButton btnUndoCT;
        private System.Windows.Forms.ToolStripButton btnRefreshCT;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.DateTimePicker dtpNGAY;
    }
}