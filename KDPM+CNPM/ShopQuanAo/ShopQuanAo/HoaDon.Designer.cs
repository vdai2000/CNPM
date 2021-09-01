namespace ShopQuanAo
{
    partial class HoaDon
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
            System.Windows.Forms.Label mAHDLabel;
            System.Windows.Forms.Label mAKHLabel;
            System.Windows.Forms.Label nGAYDATHANGLabel;
            System.Windows.Forms.Label gIAMGIALabel;
            System.Windows.Forms.Label sDTLabel;
            System.Windows.Forms.Label tONGTIENLabel;
            System.Windows.Forms.Label dIACHILabel;
            System.Windows.Forms.Label tRANGTHAILabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HoaDon));
            this.dataSet1 = new ShopQuanAo.DataSet1();
            this.hOADONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hOADONTableAdapter = new ShopQuanAo.DataSet1TableAdapters.HOADONTableAdapter();
            this.tableAdapterManager = new ShopQuanAo.DataSet1TableAdapters.TableAdapterManager();
            this.hOADONBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.hOADONBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCTHD = new System.Windows.Forms.ToolStripButton();
            this.hOADONDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAHDTextBox = new System.Windows.Forms.TextBox();
            this.mAKHTextBox = new System.Windows.Forms.TextBox();
            this.nGAYDATHANGDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gIAMGIATextBox = new System.Windows.Forms.TextBox();
            this.sDTTextBox = new System.Windows.Forms.TextBox();
            this.tONGTIENTextBox = new System.Windows.Forms.TextBox();
            this.dIACHITextBox = new System.Windows.Forms.TextBox();
            this.tRANGTHAITextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            mAHDLabel = new System.Windows.Forms.Label();
            mAKHLabel = new System.Windows.Forms.Label();
            nGAYDATHANGLabel = new System.Windows.Forms.Label();
            gIAMGIALabel = new System.Windows.Forms.Label();
            sDTLabel = new System.Windows.Forms.Label();
            tONGTIENLabel = new System.Windows.Forms.Label();
            dIACHILabel = new System.Windows.Forms.Label();
            tRANGTHAILabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).BeginInit();
            this.hOADONBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mAHDLabel
            // 
            mAHDLabel.AutoSize = true;
            mAHDLabel.Location = new System.Drawing.Point(25, 43);
            mAHDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAHDLabel.Name = "mAHDLabel";
            mAHDLabel.Size = new System.Drawing.Size(106, 20);
            mAHDLabel.TabIndex = 2;
            mAHDLabel.Text = "Mã hoá đơn";
            // 
            // mAKHLabel
            // 
            mAKHLabel.AutoSize = true;
            mAKHLabel.Location = new System.Drawing.Point(25, 86);
            mAKHLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mAKHLabel.Name = "mAKHLabel";
            mAKHLabel.Size = new System.Drawing.Size(135, 20);
            mAKHLabel.TabIndex = 4;
            mAKHLabel.Text = "Mã khách hàng";
            mAKHLabel.Click += new System.EventHandler(this.mAKHLabel_Click);
            // 
            // nGAYDATHANGLabel
            // 
            nGAYDATHANGLabel.AutoSize = true;
            nGAYDATHANGLabel.Location = new System.Drawing.Point(25, 126);
            nGAYDATHANGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nGAYDATHANGLabel.Name = "nGAYDATHANGLabel";
            nGAYDATHANGLabel.Size = new System.Drawing.Size(129, 20);
            nGAYDATHANGLabel.TabIndex = 6;
            nGAYDATHANGLabel.Text = "Ngày đặt hàng";
            // 
            // gIAMGIALabel
            // 
            gIAMGIALabel.AutoSize = true;
            gIAMGIALabel.Location = new System.Drawing.Point(25, 174);
            gIAMGIALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            gIAMGIALabel.Name = "gIAMGIALabel";
            gIAMGIALabel.Size = new System.Drawing.Size(84, 20);
            gIAMGIALabel.TabIndex = 8;
            gIAMGIALabel.Text = "Giảm giá";
            // 
            // sDTLabel
            // 
            sDTLabel.AutoSize = true;
            sDTLabel.Location = new System.Drawing.Point(655, 47);
            sDTLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sDTLabel.Name = "sDTLabel";
            sDTLabel.Size = new System.Drawing.Size(119, 20);
            sDTLabel.TabIndex = 10;
            sDTLabel.Text = "Số điện thoại";
            // 
            // tONGTIENLabel
            // 
            tONGTIENLabel.AutoSize = true;
            tONGTIENLabel.Location = new System.Drawing.Point(655, 90);
            tONGTIENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tONGTIENLabel.Name = "tONGTIENLabel";
            tONGTIENLabel.Size = new System.Drawing.Size(87, 20);
            tONGTIENLabel.TabIndex = 12;
            tONGTIENLabel.Text = "Tổng tiền";
            // 
            // dIACHILabel
            // 
            dIACHILabel.AutoSize = true;
            dIACHILabel.Location = new System.Drawing.Point(655, 132);
            dIACHILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dIACHILabel.Name = "dIACHILabel";
            dIACHILabel.Size = new System.Drawing.Size(68, 20);
            dIACHILabel.TabIndex = 14;
            dIACHILabel.Text = "Địa chỉ";
            // 
            // tRANGTHAILabel
            // 
            tRANGTHAILabel.AutoSize = true;
            tRANGTHAILabel.Location = new System.Drawing.Point(655, 174);
            tRANGTHAILabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tRANGTHAILabel.Name = "tRANGTHAILabel";
            tRANGTHAILabel.Size = new System.Drawing.Size(94, 20);
            tRANGTHAILabel.TabIndex = 16;
            tRANGTHAILabel.Text = "Trạng thái";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hOADONBindingSource
            // 
            this.hOADONBindingSource.DataMember = "HOADON";
            this.hOADONBindingSource.DataSource = this.dataSet1;
            // 
            // hOADONTableAdapter
            // 
            this.hOADONTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = this.hOADONTableAdapter;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = null;
            this.tableAdapterManager.QUANLYTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopQuanAo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VANTAYTableAdapter = null;
            // 
            // hOADONBindingNavigator
            // 
            this.hOADONBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.hOADONBindingNavigator.BindingSource = this.hOADONBindingSource;
            this.hOADONBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.hOADONBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.hOADONBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hOADONBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.hOADONBindingNavigatorSaveItem,
            this.btnCTHD});
            this.hOADONBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.hOADONBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.hOADONBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.hOADONBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.hOADONBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.hOADONBindingNavigator.Name = "hOADONBindingNavigator";
            this.hOADONBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.hOADONBindingNavigator.Size = new System.Drawing.Size(1264, 27);
            this.hOADONBindingNavigator.TabIndex = 0;
            this.hOADONBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(65, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // hOADONBindingNavigatorSaveItem
            // 
            this.hOADONBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.hOADONBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("hOADONBindingNavigatorSaveItem.Image")));
            this.hOADONBindingNavigatorSaveItem.Name = "hOADONBindingNavigatorSaveItem";
            this.hOADONBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.hOADONBindingNavigatorSaveItem.Text = "Save Data";
            this.hOADONBindingNavigatorSaveItem.Click += new System.EventHandler(this.hOADONBindingNavigatorSaveItem_Click);
            // 
            // btnCTHD
            // 
            this.btnCTHD.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCTHD.Image = ((System.Drawing.Image)(resources.GetObject("btnCTHD.Image")));
            this.btnCTHD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCTHD.Name = "btnCTHD";
            this.btnCTHD.Size = new System.Drawing.Size(29, 24);
            this.btnCTHD.Text = "Chi Tiết Hoá Đơn";
            this.btnCTHD.Click += new System.EventHandler(this.btnCTHD_Click);
            // 
            // hOADONDataGridView
            // 
            this.hOADONDataGridView.AutoGenerateColumns = false;
            this.hOADONDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hOADONDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.hOADONDataGridView.DataSource = this.hOADONBindingSource;
            this.hOADONDataGridView.Location = new System.Drawing.Point(32, 329);
            this.hOADONDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.hOADONDataGridView.Name = "hOADONDataGridView";
            this.hOADONDataGridView.RowHeadersWidth = 51;
            this.hOADONDataGridView.Size = new System.Drawing.Size(1133, 271);
            this.hOADONDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MAHD";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã hoá đơn";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MAKH";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NGAYDATHANG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Ngày đặt mua";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GIAMGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Giảm giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "SDT";
            this.dataGridViewTextBoxColumn5.HeaderText = "Số điện thoại";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TONGTIEN";
            this.dataGridViewTextBoxColumn6.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DIACHI";
            this.dataGridViewTextBoxColumn7.HeaderText = "Địa chỉ";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TRANGTHAI";
            this.dataGridViewTextBoxColumn8.HeaderText = "Trạng thái";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // mAHDTextBox
            // 
            this.mAHDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAHD", true));
            this.mAHDTextBox.Location = new System.Drawing.Point(185, 36);
            this.mAHDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAHDTextBox.Name = "mAHDTextBox";
            this.mAHDTextBox.Size = new System.Drawing.Size(368, 26);
            this.mAHDTextBox.TabIndex = 3;
            // 
            // mAKHTextBox
            // 
            this.mAKHTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "MAKH", true));
            this.mAKHTextBox.Location = new System.Drawing.Point(185, 79);
            this.mAKHTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mAKHTextBox.Name = "mAKHTextBox";
            this.mAKHTextBox.Size = new System.Drawing.Size(368, 26);
            this.mAKHTextBox.TabIndex = 5;
            // 
            // nGAYDATHANGDateTimePicker
            // 
            this.nGAYDATHANGDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.hOADONBindingSource, "NGAYDATHANG", true));
            this.nGAYDATHANGDateTimePicker.Location = new System.Drawing.Point(185, 126);
            this.nGAYDATHANGDateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nGAYDATHANGDateTimePicker.Name = "nGAYDATHANGDateTimePicker";
            this.nGAYDATHANGDateTimePicker.Size = new System.Drawing.Size(368, 26);
            this.nGAYDATHANGDateTimePicker.TabIndex = 7;
            // 
            // gIAMGIATextBox
            // 
            this.gIAMGIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "GIAMGIA", true));
            this.gIAMGIATextBox.Location = new System.Drawing.Point(185, 166);
            this.gIAMGIATextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gIAMGIATextBox.Name = "gIAMGIATextBox";
            this.gIAMGIATextBox.Size = new System.Drawing.Size(368, 26);
            this.gIAMGIATextBox.TabIndex = 9;
            // 
            // sDTTextBox
            // 
            this.sDTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "SDT", true));
            this.sDTTextBox.Location = new System.Drawing.Point(801, 43);
            this.sDTTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sDTTextBox.Name = "sDTTextBox";
            this.sDTTextBox.Size = new System.Drawing.Size(265, 26);
            this.sDTTextBox.TabIndex = 11;
            // 
            // tONGTIENTextBox
            // 
            this.tONGTIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "TONGTIEN", true));
            this.tONGTIENTextBox.Location = new System.Drawing.Point(801, 82);
            this.tONGTIENTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tONGTIENTextBox.Name = "tONGTIENTextBox";
            this.tONGTIENTextBox.Size = new System.Drawing.Size(265, 26);
            this.tONGTIENTextBox.TabIndex = 13;
            // 
            // dIACHITextBox
            // 
            this.dIACHITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "DIACHI", true));
            this.dIACHITextBox.Location = new System.Drawing.Point(801, 126);
            this.dIACHITextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dIACHITextBox.Name = "dIACHITextBox";
            this.dIACHITextBox.Size = new System.Drawing.Size(265, 26);
            this.dIACHITextBox.TabIndex = 15;
            // 
            // tRANGTHAITextBox
            // 
            this.tRANGTHAITextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.hOADONBindingSource, "TRANGTHAI", true));
            this.tRANGTHAITextBox.Location = new System.Drawing.Point(801, 170);
            this.tRANGTHAITextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tRANGTHAITextBox.Name = "tRANGTHAITextBox";
            this.tRANGTHAITextBox.Size = new System.Drawing.Size(265, 26);
            this.tRANGTHAITextBox.TabIndex = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mAHDLabel);
            this.groupBox1.Controls.Add(sDTLabel);
            this.groupBox1.Controls.Add(this.sDTTextBox);
            this.groupBox1.Controls.Add(this.gIAMGIATextBox);
            this.groupBox1.Controls.Add(tONGTIENLabel);
            this.groupBox1.Controls.Add(this.mAHDTextBox);
            this.groupBox1.Controls.Add(this.tONGTIENTextBox);
            this.groupBox1.Controls.Add(gIAMGIALabel);
            this.groupBox1.Controls.Add(dIACHILabel);
            this.groupBox1.Controls.Add(mAKHLabel);
            this.groupBox1.Controls.Add(this.dIACHITextBox);
            this.groupBox1.Controls.Add(this.nGAYDATHANGDateTimePicker);
            this.groupBox1.Controls.Add(tRANGTHAILabel);
            this.groupBox1.Controls.Add(this.mAKHTextBox);
            this.groupBox1.Controls.Add(this.tRANGTHAITextBox);
            this.groupBox1.Controls.Add(nGAYDATHANGLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 64);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1133, 234);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hoá đơn";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(491, 622);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 42);
            this.button1.TabIndex = 19;
            this.button1.Text = "In Hoá Đơn";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.hOADONDataGridView);
            this.Controls.Add(this.hOADONBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "HoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HoaDon";
            this.Load += new System.EventHandler(this.HoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONBindingNavigator)).EndInit();
            this.hOADONBindingNavigator.ResumeLayout(false);
            this.hOADONBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hOADONDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource hOADONBindingSource;
        private DataSet1TableAdapters.HOADONTableAdapter hOADONTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator hOADONBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton hOADONBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView hOADONDataGridView;
        private System.Windows.Forms.TextBox mAHDTextBox;
        private System.Windows.Forms.TextBox mAKHTextBox;
        private System.Windows.Forms.DateTimePicker nGAYDATHANGDateTimePicker;
        private System.Windows.Forms.TextBox gIAMGIATextBox;
        private System.Windows.Forms.TextBox sDTTextBox;
        private System.Windows.Forms.TextBox tONGTIENTextBox;
        private System.Windows.Forms.TextBox dIACHITextBox;
        private System.Windows.Forms.TextBox tRANGTHAITextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripButton btnCTHD;
        private System.Windows.Forms.Button button1;
    }
}