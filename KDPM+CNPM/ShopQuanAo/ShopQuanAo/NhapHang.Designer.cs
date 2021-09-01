namespace ShopQuanAo
{
    partial class NhapHang
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
            System.Windows.Forms.Label mANHAPLabel;
            System.Windows.Forms.Label mASPLabel;
            System.Windows.Forms.Label sOLUONGLabel;
            System.Windows.Forms.Label dONGIALabel;
            System.Windows.Forms.Label tHANHTIENLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
            this.dataSet1 = new ShopQuanAo.DataSet1();
            this.nHAPHANGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nHAPHANGTableAdapter = new ShopQuanAo.DataSet1TableAdapters.NHAPHANGTableAdapter();
            this.tableAdapterManager = new ShopQuanAo.DataSet1TableAdapters.TableAdapterManager();
            this.nHAPHANGBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.nHAPHANGBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mANHAPTextBox = new System.Windows.Forms.TextBox();
            this.mASPTextBox = new System.Windows.Forms.TextBox();
            this.sOLUONGTextBox = new System.Windows.Forms.TextBox();
            this.dONGIATextBox = new System.Windows.Forms.TextBox();
            this.tHANHTIENTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nHAPHANGDataGridView = new System.Windows.Forms.DataGridView();
            mANHAPLabel = new System.Windows.Forms.Label();
            mASPLabel = new System.Windows.Forms.Label();
            sOLUONGLabel = new System.Windows.Forms.Label();
            dONGIALabel = new System.Windows.Forms.Label();
            tHANHTIENLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGBindingNavigator)).BeginInit();
            this.nHAPHANGBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mANHAPLabel
            // 
            mANHAPLabel.AutoSize = true;
            mANHAPLabel.Location = new System.Drawing.Point(28, 63);
            mANHAPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mANHAPLabel.Name = "mANHAPLabel";
            mANHAPLabel.Size = new System.Drawing.Size(126, 20);
            mANHAPLabel.TabIndex = 2;
            mANHAPLabel.Text = "Mã nhập hàng";
            // 
            // mASPLabel
            // 
            mASPLabel.AutoSize = true;
            mASPLabel.Location = new System.Drawing.Point(28, 112);
            mASPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            mASPLabel.Name = "mASPLabel";
            mASPLabel.Size = new System.Drawing.Size(121, 20);
            mASPLabel.TabIndex = 4;
            mASPLabel.Text = "Mã sản phẩm";
            // 
            // sOLUONGLabel
            // 
            sOLUONGLabel.AutoSize = true;
            sOLUONGLabel.Location = new System.Drawing.Point(28, 153);
            sOLUONGLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            sOLUONGLabel.Name = "sOLUONGLabel";
            sOLUONGLabel.Size = new System.Drawing.Size(82, 20);
            sOLUONGLabel.TabIndex = 6;
            sOLUONGLabel.Text = "Số lượng";
            // 
            // dONGIALabel
            // 
            dONGIALabel.AutoSize = true;
            dONGIALabel.Location = new System.Drawing.Point(531, 105);
            dONGIALabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dONGIALabel.Name = "dONGIALabel";
            dONGIALabel.Size = new System.Drawing.Size(73, 20);
            dONGIALabel.TabIndex = 8;
            dONGIALabel.Text = "Đơn giá";
            // 
            // tHANHTIENLabel
            // 
            tHANHTIENLabel.AutoSize = true;
            tHANHTIENLabel.Location = new System.Drawing.Point(516, 149);
            tHANHTIENLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            tHANHTIENLabel.Name = "tHANHTIENLabel";
            tHANHTIENLabel.Size = new System.Drawing.Size(97, 20);
            tHANHTIENLabel.TabIndex = 10;
            tHANHTIENLabel.Text = "Thành tiền";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nHAPHANGBindingSource
            // 
            this.nHAPHANGBindingSource.DataMember = "NHAPHANG";
            this.nHAPHANGBindingSource.DataSource = this.dataSet1;
            // 
            // nHAPHANGTableAdapter
            // 
            this.nHAPHANGTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CT_HOADONTableAdapter = null;
            this.tableAdapterManager.HOADONTableAdapter = null;
            this.tableAdapterManager.KHACHHANGTableAdapter = null;
            this.tableAdapterManager.LOAITableAdapter = null;
            this.tableAdapterManager.NHANVIENTableAdapter = null;
            this.tableAdapterManager.NHAPHANGTableAdapter = this.nHAPHANGTableAdapter;
            this.tableAdapterManager.QUANLYTableAdapter = null;
            this.tableAdapterManager.SANPHAMTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ShopQuanAo.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VANTAYTableAdapter = null;
            // 
            // nHAPHANGBindingNavigator
            // 
            this.nHAPHANGBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.nHAPHANGBindingNavigator.BindingSource = this.nHAPHANGBindingSource;
            this.nHAPHANGBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.nHAPHANGBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.nHAPHANGBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.nHAPHANGBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.nHAPHANGBindingNavigatorSaveItem});
            this.nHAPHANGBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.nHAPHANGBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.nHAPHANGBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.nHAPHANGBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.nHAPHANGBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.nHAPHANGBindingNavigator.Name = "nHAPHANGBindingNavigator";
            this.nHAPHANGBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.nHAPHANGBindingNavigator.Size = new System.Drawing.Size(1264, 27);
            this.nHAPHANGBindingNavigator.TabIndex = 0;
            this.nHAPHANGBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            // nHAPHANGBindingNavigatorSaveItem
            // 
            this.nHAPHANGBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.nHAPHANGBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("nHAPHANGBindingNavigatorSaveItem.Image")));
            this.nHAPHANGBindingNavigatorSaveItem.Name = "nHAPHANGBindingNavigatorSaveItem";
            this.nHAPHANGBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.nHAPHANGBindingNavigatorSaveItem.Text = "Save Data";
            this.nHAPHANGBindingNavigatorSaveItem.Click += new System.EventHandler(this.nHAPHANGBindingNavigatorSaveItem_Click);
            // 
            // mANHAPTextBox
            // 
            this.mANHAPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAPHANGBindingSource, "MANHAP", true));
            this.mANHAPTextBox.Location = new System.Drawing.Point(184, 59);
            this.mANHAPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mANHAPTextBox.Name = "mANHAPTextBox";
            this.mANHAPTextBox.Size = new System.Drawing.Size(300, 26);
            this.mANHAPTextBox.TabIndex = 3;
            // 
            // mASPTextBox
            // 
            this.mASPTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAPHANGBindingSource, "MASP", true));
            this.mASPTextBox.Location = new System.Drawing.Point(184, 105);
            this.mASPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mASPTextBox.Name = "mASPTextBox";
            this.mASPTextBox.Size = new System.Drawing.Size(300, 26);
            this.mASPTextBox.TabIndex = 5;
            // 
            // sOLUONGTextBox
            // 
            this.sOLUONGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAPHANGBindingSource, "SOLUONG", true));
            this.sOLUONGTextBox.Location = new System.Drawing.Point(184, 145);
            this.sOLUONGTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sOLUONGTextBox.Name = "sOLUONGTextBox";
            this.sOLUONGTextBox.Size = new System.Drawing.Size(300, 26);
            this.sOLUONGTextBox.TabIndex = 7;
            // 
            // dONGIATextBox
            // 
            this.dONGIATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAPHANGBindingSource, "DONGIA", true));
            this.dONGIATextBox.Location = new System.Drawing.Point(639, 101);
            this.dONGIATextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dONGIATextBox.Name = "dONGIATextBox";
            this.dONGIATextBox.Size = new System.Drawing.Size(300, 26);
            this.dONGIATextBox.TabIndex = 9;
            // 
            // tHANHTIENTextBox
            // 
            this.tHANHTIENTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nHAPHANGBindingSource, "THANHTIEN", true));
            this.tHANHTIENTextBox.Location = new System.Drawing.Point(639, 142);
            this.tHANHTIENTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tHANHTIENTextBox.Name = "tHANHTIENTextBox";
            this.tHANHTIENTextBox.Size = new System.Drawing.Size(300, 26);
            this.tHANHTIENTextBox.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(mANHAPLabel);
            this.groupBox1.Controls.Add(this.tHANHTIENTextBox);
            this.groupBox1.Controls.Add(this.mANHAPTextBox);
            this.groupBox1.Controls.Add(tHANHTIENLabel);
            this.groupBox1.Controls.Add(mASPLabel);
            this.groupBox1.Controls.Add(this.dONGIATextBox);
            this.groupBox1.Controls.Add(this.mASPTextBox);
            this.groupBox1.Controls.Add(dONGIALabel);
            this.groupBox1.Controls.Add(sOLUONGLabel);
            this.groupBox1.Controls.Add(this.sOLUONGTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(79, 80);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(957, 207);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin đơn nhập hàng";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(1080, 105);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(137, 28);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "THANHTIEN";
            this.dataGridViewTextBoxColumn5.HeaderText = "Thành tiền";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DONGIA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Đơn giá";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SOLUONG";
            this.dataGridViewTextBoxColumn3.HeaderText = "Số lượng";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "MASP";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã sản phẩm";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MANHAP";
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã nhập hàng";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // nHAPHANGDataGridView
            // 
            this.nHAPHANGDataGridView.AutoGenerateColumns = false;
            this.nHAPHANGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nHAPHANGDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.nHAPHANGDataGridView.DataSource = this.nHAPHANGBindingSource;
            this.nHAPHANGDataGridView.Location = new System.Drawing.Point(200, 310);
            this.nHAPHANGDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.nHAPHANGDataGridView.Name = "nHAPHANGDataGridView";
            this.nHAPHANGDataGridView.RowHeadersWidth = 51;
            this.nHAPHANGDataGridView.Size = new System.Drawing.Size(679, 271);
            this.nHAPHANGDataGridView.TabIndex = 1;
            this.nHAPHANGDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.nHAPHANGDataGridView_CellContentClick);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 694);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nHAPHANGDataGridView);
            this.Controls.Add(this.nHAPHANGBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NhapHang";
            this.Load += new System.EventHandler(this.NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGBindingNavigator)).EndInit();
            this.nHAPHANGBindingNavigator.ResumeLayout(false);
            this.nHAPHANGBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nHAPHANGDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource nHAPHANGBindingSource;
        private DataSet1TableAdapters.NHAPHANGTableAdapter nHAPHANGTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator nHAPHANGBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton nHAPHANGBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mANHAPTextBox;
        private System.Windows.Forms.TextBox mASPTextBox;
        private System.Windows.Forms.TextBox sOLUONGTextBox;
        private System.Windows.Forms.TextBox dONGIATextBox;
        private System.Windows.Forms.TextBox tHANHTIENTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView nHAPHANGDataGridView;
    }
}