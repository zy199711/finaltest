namespace trader
{
	partial class FormTrade
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("未知", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("未成交还在队列中", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup3 = new System.Windows.Forms.ListViewGroup("未成交不在队列中", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup4 = new System.Windows.Forms.ListViewGroup("部分成交还在队列中", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("部分成交不在队列中", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("已撤单", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup7 = new System.Windows.Forms.ListViewGroup("全部成交", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup8 = new System.Windows.Forms.ListViewGroup("尚未触发", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup9 = new System.Windows.Forms.ListViewGroup("已触发", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup10 = new System.Windows.Forms.ListViewGroup("当日持仓", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup11 = new System.Windows.Forms.ListViewGroup("历史持仓", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup12 = new System.Windows.Forms.ListViewGroup("套利", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTrade));
            this.comboBoxErrMsg = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.listViewOrder = new trader.HFListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader43 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPosition = new trader.HFListView();
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader28 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader29 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader26 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader27 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader34 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader44 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader31 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader32 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader25 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hfListViewParkedOrder = new trader.HFListView();
            this.columnHeader33 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader35 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader36 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader37 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader38 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader39 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader41 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader42 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hfListViewParkedAction = new trader.HFListView();
            this.tabPageSHFE = new System.Windows.Forms.TabPage();
            this.dataGridViewSHFE = new trader.DoubleBufferDGV();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.myPlot = new NPlot.Windows.PlotSurface2D();
            this.label2 = new System.Windows.Forms.Label();
            this.label_symbol = new System.Windows.Forms.Label();
            this.W1 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageCZCE = new System.Windows.Forms.TabPage();
            this.dataGridViewCZCE = new trader.DoubleBufferDGV();
            this.tabPageDCE = new System.Windows.Forms.TabPage();
            this.dataGridViewDCE = new trader.DoubleBufferDGV();
            this.tabPageCFFEX = new System.Windows.Forms.TabPage();
            this.dataGridViewCFFEX = new trader.DoubleBufferDGV();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControSystem = new System.Windows.Forms.TabControl();
            this.tabPageOrder = new System.Windows.Forms.TabPage();
            this.tabPagePosition = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonQuickLock = new System.Windows.Forms.Button();
            this.buttonCovert = new System.Windows.Forms.Button();
            this.buttonQuickClose = new System.Windows.Forms.Button();
            this.tabPageParked = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.splitContainer7 = new System.Windows.Forms.SplitContainer();
            this.buttonQryAccount = new System.Windows.Forms.Button();
            this.userControlTradeAccount1 = new trader.UserControlTradeAccount();
            this.tabPageInstrument = new System.Windows.Forms.TabPage();
            this.dataGridViewInstruments = new trader.DoubleBufferDGV();
            this.tabPageInstrumentSelf = new System.Windows.Forms.TabPage();
            this.dataGridViewInstrumentsSelected = new trader.DoubleBufferDGV();
            this.tabPageQryTrade = new System.Windows.Forms.TabPage();
            this.buttonSaveTrade = new System.Windows.Forms.Button();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.buttonQryPosition = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.hfListViewTrade = new trader.HFListView();
            this.columnHeader45 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader53 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader46 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader47 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader48 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader49 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader51 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader54 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainerOrder = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label17 = new System.Windows.Forms.Label();
            this.labelAskPrice = new System.Windows.Forms.Label();
            this.labelAskVolume = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.labelBidPrice = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.labelBidVolume = new System.Windows.Forms.Label();
            this.labelInstrumentName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.labelLastPrice = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.labelUpperLimit = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.labelLowerLimit = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.labelWeiBi = new System.Windows.Forms.Label();
            this.labelWeiCha = new System.Windows.Forms.Label();
            this.labelSettlementPrice = new System.Windows.Forms.Label();
            this.labelPreSettlementPrice = new System.Windows.Forms.Label();
            this.labelUpDown = new System.Windows.Forms.Label();
            this.labelTotalVolume = new System.Windows.Forms.Label();
            this.labelOpenPrice = new System.Windows.Forms.Label();
            this.labelHighest = new System.Windows.Forms.Label();
            this.labelLowest = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelOpenInstetest = new System.Windows.Forms.Label();
            this.labelPreOI = new System.Windows.Forms.Label();
            this.labelOIDiff = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboBoxInstrument = new System.Windows.Forms.ComboBox();
            this.numericUpDownVolume = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownPrice = new System.Windows.Forms.NumericUpDown();
            this.buttonPrice = new System.Windows.Forms.Button();
            this.comboBoxOffset = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelUpper = new System.Windows.Forms.Label();
            this.labelLower = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelVolumeMax = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxDirector = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnParked = new System.Windows.Forms.Button();
            this.tabPageSHFE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSHFE)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageCZCE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCZCE)).BeginInit();
            this.tabPageDCE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDCE)).BeginInit();
            this.tabPageCFFEX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCFFEX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControSystem.SuspendLayout();
            this.tabPageOrder.SuspendLayout();
            this.tabPagePosition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tabPageParked.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).BeginInit();
            this.splitContainer7.Panel1.SuspendLayout();
            this.splitContainer7.Panel2.SuspendLayout();
            this.splitContainer7.SuspendLayout();
            this.tabPageInstrument.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstruments)).BeginInit();
            this.tabPageInstrumentSelf.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrumentsSelected)).BeginInit();
            this.tabPageQryTrade.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOrder)).BeginInit();
            this.splitContainerOrder.Panel1.SuspendLayout();
            this.splitContainerOrder.Panel2.SuspendLayout();
            this.splitContainerOrder.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxErrMsg
            // 
            this.comboBoxErrMsg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxErrMsg.FormattingEnabled = true;
            this.comboBoxErrMsg.Location = new System.Drawing.Point(163, 0);
            this.comboBoxErrMsg.Name = "comboBoxErrMsg";
            this.comboBoxErrMsg.Size = new System.Drawing.Size(917, 20);
            this.comboBoxErrMsg.TabIndex = 3;
            // 
            // toolTip1
            // 
            this.toolTip1.Active = global::trader.Properties.Settings.Default.ShowTootip;
            this.toolTip1.AutomaticDelay = 100;
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.InitialDelay = 100;
            this.toolTip1.ReshowDelay = 20;
            // 
            // listViewOrder
            // 
            this.listViewOrder.AllowColumnReorder = true;
            this.listViewOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader22,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader43,
            this.columnHeader23});
            this.listViewOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewOrder.FullRowSelect = true;
            listViewGroup1.Header = "未知";
            listViewGroup1.Name = "Unknown";
            listViewGroup2.Header = "未成交还在队列中";
            listViewGroup2.Name = "NoTradeQueueing";
            listViewGroup3.Header = "未成交不在队列中";
            listViewGroup3.Name = "NoTradeNotQueueing";
            listViewGroup4.Header = "部分成交还在队列中";
            listViewGroup4.Name = "PartTradedQueueing";
            listViewGroup5.Header = "部分成交不在队列中";
            listViewGroup5.Name = "PartTradedNotQueueing";
            listViewGroup6.Header = "已撤单";
            listViewGroup6.Name = "Canceled";
            listViewGroup7.Header = "全部成交";
            listViewGroup7.Name = "AllTraded";
            listViewGroup8.Header = "尚未触发";
            listViewGroup8.Name = "NotTouched";
            listViewGroup9.Header = "已触发";
            listViewGroup9.Name = "Touched";
            this.listViewOrder.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2,
            listViewGroup3,
            listViewGroup4,
            listViewGroup5,
            listViewGroup6,
            listViewGroup7,
            listViewGroup8,
            listViewGroup9});
            this.listViewOrder.HideSelection = false;
            this.listViewOrder.Location = new System.Drawing.Point(3, 3);
            this.listViewOrder.MultiSelect = false;
            this.listViewOrder.Name = "listViewOrder";
            this.listViewOrder.Size = new System.Drawing.Size(782, 250);
            this.listViewOrder.SortColumn = 7;
            this.listViewOrder.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.listViewOrder.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listViewOrder, "双击撤单");
            this.listViewOrder.UseCompatibleStateImageBehavior = false;
            this.listViewOrder.View = System.Windows.Forms.View.Details;
            this.listViewOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewOrder_MouseDoubleClick);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "合约";
            this.columnHeader13.Width = 50;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "买卖";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 41;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "开平";
            this.columnHeader15.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader15.Width = 43;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "报单价格";
            this.columnHeader16.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "成交均价";
            this.columnHeader22.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "报单手数";
            this.columnHeader17.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "成交手数";
            this.columnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "报单时间";
            this.columnHeader19.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader19.Width = 69;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "响应时间";
            this.columnHeader20.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader43
            // 
            this.columnHeader43.Text = "报单编号";
            this.columnHeader43.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "报单状态";
            this.columnHeader23.Width = 160;
            // 
            // listViewPosition
            // 
            this.listViewPosition.AllowColumnReorder = true;
            this.listViewPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewPosition.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader21,
            this.columnHeader24,
            this.columnHeader28,
            this.columnHeader29,
            this.columnHeader26,
            this.columnHeader27,
            this.columnHeader34,
            this.columnHeader44,
            this.columnHeader30,
            this.columnHeader31,
            this.columnHeader32,
            this.columnHeader25});
            this.listViewPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPosition.FullRowSelect = true;
            this.listViewPosition.GridLines = true;
            listViewGroup10.Header = "当日持仓";
            listViewGroup10.Name = "Today";
            listViewGroup11.Header = "历史持仓";
            listViewGroup11.Name = "History";
            listViewGroup12.Header = "套利";
            listViewGroup12.Name = "Arbitrage";
            this.listViewPosition.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup10,
            listViewGroup11,
            listViewGroup12});
            this.listViewPosition.HideSelection = false;
            this.listViewPosition.Location = new System.Drawing.Point(0, 0);
            this.listViewPosition.MultiSelect = false;
            this.listViewPosition.Name = "listViewPosition";
            this.listViewPosition.Size = new System.Drawing.Size(782, 218);
            this.listViewPosition.SortColumn = 0;
            this.listViewPosition.TabIndex = 0;
            this.toolTip1.SetToolTip(this.listViewPosition, "单击选择合约,下单区平仓\r\n双击快速平仓");
            this.listViewPosition.UseCompatibleStateImageBehavior = false;
            this.listViewPosition.View = System.Windows.Forms.View.Details;
            this.listViewPosition.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listViewPosition_MouseClick);
            this.listViewPosition.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewPosition_MouseDoubleClick);
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "合约";
            this.columnHeader21.Width = 50;
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "多空";
            this.columnHeader24.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader24.Width = 40;
            // 
            // columnHeader28
            // 
            this.columnHeader28.Text = "昨持";
            this.columnHeader28.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader28.Width = 40;
            // 
            // columnHeader29
            // 
            this.columnHeader29.Text = "今持";
            this.columnHeader29.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader29.Width = 40;
            // 
            // columnHeader26
            // 
            this.columnHeader26.Text = "持仓均价";
            this.columnHeader26.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader26.Width = 80;
            // 
            // columnHeader27
            // 
            this.columnHeader27.Text = "持仓盈亏";
            this.columnHeader27.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // columnHeader34
            // 
            this.columnHeader34.Text = "开仓均价";
            this.columnHeader34.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader34.Width = 80;
            // 
            // columnHeader44
            // 
            this.columnHeader44.Text = "手数";
            this.columnHeader44.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader44.Width = 40;
            // 
            // columnHeader30
            // 
            this.columnHeader30.Text = "平仓均价";
            this.columnHeader30.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader30.Width = 80;
            // 
            // columnHeader31
            // 
            this.columnHeader31.Text = "手数";
            this.columnHeader31.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader31.Width = 40;
            // 
            // columnHeader32
            // 
            this.columnHeader32.Text = "平仓盈亏";
            this.columnHeader32.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader32.Width = 70;
            // 
            // columnHeader25
            // 
            this.columnHeader25.Text = "手续费";
            this.columnHeader25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // hfListViewParkedOrder
            // 
            this.hfListViewParkedOrder.AllowColumnReorder = true;
            this.hfListViewParkedOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hfListViewParkedOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader33,
            this.columnHeader35,
            this.columnHeader36,
            this.columnHeader37,
            this.columnHeader38,
            this.columnHeader39,
            this.columnHeader40,
            this.columnHeader41,
            this.columnHeader42});
            this.hfListViewParkedOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hfListViewParkedOrder.FullRowSelect = true;
            this.hfListViewParkedOrder.GridLines = true;
            this.hfListViewParkedOrder.HideSelection = false;
            this.hfListViewParkedOrder.Location = new System.Drawing.Point(0, 0);
            this.hfListViewParkedOrder.MultiSelect = false;
            this.hfListViewParkedOrder.Name = "hfListViewParkedOrder";
            this.hfListViewParkedOrder.Size = new System.Drawing.Size(782, 216);
            this.hfListViewParkedOrder.SortColumn = 0;
            this.hfListViewParkedOrder.TabIndex = 0;
            this.toolTip1.SetToolTip(this.hfListViewParkedOrder, "预埋单\r\n双击删除");
            this.hfListViewParkedOrder.UseCompatibleStateImageBehavior = false;
            this.hfListViewParkedOrder.View = System.Windows.Forms.View.Details;
            this.hfListViewParkedOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.hfListViewParkedOrder_MouseDoubleClick);
            // 
            // columnHeader33
            // 
            this.columnHeader33.Text = "合约";
            this.columnHeader33.Width = 50;
            // 
            // columnHeader35
            // 
            this.columnHeader35.Text = "触发价格";
            this.columnHeader35.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader35.Width = 80;
            // 
            // columnHeader36
            // 
            this.columnHeader36.Text = "买卖";
            this.columnHeader36.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader36.Width = 40;
            // 
            // columnHeader37
            // 
            this.columnHeader37.Text = "开平";
            this.columnHeader37.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader37.Width = 40;
            // 
            // columnHeader38
            // 
            this.columnHeader38.Text = "价格条件";
            this.columnHeader38.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader38.Width = 80;
            // 
            // columnHeader39
            // 
            this.columnHeader39.Text = "报单价格";
            this.columnHeader39.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader39.Width = 80;
            // 
            // columnHeader40
            // 
            this.columnHeader40.Text = "报单数量";
            this.columnHeader40.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader41
            // 
            this.columnHeader41.Text = "埋单状态";
            this.columnHeader41.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader41.Width = 100;
            // 
            // columnHeader42
            // 
            this.columnHeader42.Text = "错误信息";
            this.columnHeader42.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader42.Width = 150;
            // 
            // hfListViewParkedAction
            // 
            this.hfListViewParkedAction.AllowColumnReorder = true;
            this.hfListViewParkedAction.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hfListViewParkedAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hfListViewParkedAction.FullRowSelect = true;
            this.hfListViewParkedAction.GridLines = true;
            this.hfListViewParkedAction.HideSelection = false;
            this.hfListViewParkedAction.Location = new System.Drawing.Point(0, 0);
            this.hfListViewParkedAction.MultiSelect = false;
            this.hfListViewParkedAction.Name = "hfListViewParkedAction";
            this.hfListViewParkedAction.Size = new System.Drawing.Size(782, 30);
            this.hfListViewParkedAction.SortColumn = 0;
            this.hfListViewParkedAction.TabIndex = 0;
            this.toolTip1.SetToolTip(this.hfListViewParkedAction, "预埋撤单\r\n双击删除");
            this.hfListViewParkedAction.UseCompatibleStateImageBehavior = false;
            this.hfListViewParkedAction.View = System.Windows.Forms.View.Details;
            this.hfListViewParkedAction.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.hfListViewParkedAction_MouseDoubleClick);
            // 
            // tabPageSHFE
            // 
            this.tabPageSHFE.Controls.Add(this.dataGridViewSHFE);
            this.tabPageSHFE.Location = new System.Drawing.Point(4, 4);
            this.tabPageSHFE.Name = "tabPageSHFE";
            this.tabPageSHFE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSHFE.Size = new System.Drawing.Size(1046, 159);
            this.tabPageSHFE.TabIndex = 0;
            this.tabPageSHFE.Text = "上期所";
            this.tabPageSHFE.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSHFE
            // 
            this.dataGridViewSHFE.AllowUserToAddRows = false;
            this.dataGridViewSHFE.AllowUserToDeleteRows = false;
            this.dataGridViewSHFE.AllowUserToOrderColumns = true;
            this.dataGridViewSHFE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSHFE.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewSHFE.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSHFE.Name = "dataGridViewSHFE";
            this.dataGridViewSHFE.RowTemplate.Height = 23;
            this.dataGridViewSHFE.Size = new System.Drawing.Size(1173, 153);
            this.dataGridViewSHFE.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxErrMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 652);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 24);
            this.panel1.TabIndex = 4;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.button5);
            this.panelTop.Controls.Add(this.comboBox2);
            this.panelTop.Controls.Add(this.label9);
            this.panelTop.Controls.Add(this.textBox2);
            this.panelTop.Controls.Add(this.textBox1);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.tabControl1);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.DataBindings.Add(new System.Windows.Forms.Binding("Visible", global::trader.Properties.Settings.Default, "TopVisable", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1312, 373);
            this.panelTop.TabIndex = 8;
            this.panelTop.Visible = global::trader.Properties.Settings.Default.TopVisable;
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Location = new System.Drawing.Point(1162, 196);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(123, 24);
            this.button5.TabIndex = 32;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBox2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1162, 291);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(123, 20);
            this.comboBox2.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(1059, 291);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 23);
            this.label9.TabIndex = 30;
            this.label9.Text = "自动化策略";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1162, 259);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(123, 21);
            this.textBox2.TabIndex = 29;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1162, 226);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 21);
            this.textBox1.TabIndex = 28;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(1059, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 27;
            this.label8.Text = "止损亏损";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(1060, 224);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 26;
            this.label7.Text = "止盈收入";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(1091, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 23);
            this.label6.TabIndex = 24;
            this.label6.Text = "合约";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.myPlot);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label_symbol);
            this.panel2.Controls.Add(this.W1);
            this.panel2.Location = new System.Drawing.Point(7, 182);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1057, 223);
            this.panel2.TabIndex = 23;
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.CausesValidation = false;
            this.button3.Location = new System.Drawing.Point(269, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(39, 24);
            this.button3.TabIndex = 23;
            this.button3.TabStop = false;
            this.button3.Text = "所有";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoSize = true;
            this.button2.CausesValidation = false;
            this.button2.Location = new System.Drawing.Point(224, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(39, 24);
            this.button2.TabIndex = 22;
            this.button2.TabStop = false;
            this.button2.Text = "1月";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // myPlot
            // 
            this.myPlot.AutoScaleAutoGeneratedAxes = false;
            this.myPlot.AutoScaleTitle = false;
            this.myPlot.BackColor = System.Drawing.Color.White;
            this.myPlot.DateTimeToolTip = true;
            this.myPlot.ForeColor = System.Drawing.Color.White;
            this.myPlot.Legend = null;
            this.myPlot.LegendZOrder = -1;
            this.myPlot.Location = new System.Drawing.Point(3, 42);
            this.myPlot.Name = "myPlot";
            this.myPlot.RightMenu = null;
            this.myPlot.ShowCoordinates = true;
            this.myPlot.Size = new System.Drawing.Size(1044, 171);
            this.myPlot.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this.myPlot.TabIndex = 2;
            this.myPlot.Text = "myPlotSurface2D1";
            this.myPlot.Title = "";
            this.myPlot.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.myPlot.XAxis1 = null;
            this.myPlot.XAxis2 = null;
            this.myPlot.YAxis1 = null;
            this.myPlot.YAxis2 = null;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "商品";
            // 
            // label_symbol
            // 
            this.label_symbol.AutoSize = true;
            this.label_symbol.Location = new System.Drawing.Point(67, 14);
            this.label_symbol.Name = "label_symbol";
            this.label_symbol.Size = new System.Drawing.Size(41, 12);
            this.label_symbol.TabIndex = 11;
            this.label_symbol.Text = "label1";
            // 
            // W1
            // 
            this.W1.AutoSize = true;
            this.W1.CausesValidation = false;
            this.W1.Location = new System.Drawing.Point(179, 8);
            this.W1.Name = "W1";
            this.W1.Size = new System.Drawing.Size(39, 24);
            this.W1.TabIndex = 9;
            this.W1.TabStop = false;
            this.W1.Text = "1周";
            this.W1.UseVisualStyleBackColor = true;
            this.W1.Click += new System.EventHandler(this.W1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageCZCE);
            this.tabControl1.Controls.Add(this.tabPageDCE);
            this.tabControl1.Controls.Add(this.tabPageCFFEX);
            this.tabControl1.Controls.Add(this.tabPageSHFE);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1054, 185);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageCZCE
            // 
            this.tabPageCZCE.Controls.Add(this.dataGridViewCZCE);
            this.tabPageCZCE.Location = new System.Drawing.Point(4, 4);
            this.tabPageCZCE.Name = "tabPageCZCE";
            this.tabPageCZCE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCZCE.Size = new System.Drawing.Size(1046, 159);
            this.tabPageCZCE.TabIndex = 1;
            this.tabPageCZCE.Text = "郑商所";
            this.tabPageCZCE.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCZCE
            // 
            this.dataGridViewCZCE.AllowUserToAddRows = false;
            this.dataGridViewCZCE.AllowUserToDeleteRows = false;
            this.dataGridViewCZCE.AllowUserToOrderColumns = true;
            this.dataGridViewCZCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCZCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCZCE.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCZCE.Name = "dataGridViewCZCE";
            this.dataGridViewCZCE.RowTemplate.Height = 23;
            this.dataGridViewCZCE.Size = new System.Drawing.Size(1040, 153);
            this.dataGridViewCZCE.TabIndex = 0;
            this.dataGridViewCZCE.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCZCE_CellContentClick);
            // 
            // tabPageDCE
            // 
            this.tabPageDCE.Controls.Add(this.dataGridViewDCE);
            this.tabPageDCE.Location = new System.Drawing.Point(4, 4);
            this.tabPageDCE.Name = "tabPageDCE";
            this.tabPageDCE.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDCE.Size = new System.Drawing.Size(1046, 159);
            this.tabPageDCE.TabIndex = 2;
            this.tabPageDCE.Text = "大商所";
            this.tabPageDCE.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDCE
            // 
            this.dataGridViewDCE.AllowUserToAddRows = false;
            this.dataGridViewDCE.AllowUserToDeleteRows = false;
            this.dataGridViewDCE.AllowUserToOrderColumns = true;
            this.dataGridViewDCE.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDCE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDCE.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewDCE.Name = "dataGridViewDCE";
            this.dataGridViewDCE.ReadOnly = true;
            this.dataGridViewDCE.RowTemplate.Height = 23;
            this.dataGridViewDCE.Size = new System.Drawing.Size(1040, 153);
            this.dataGridViewDCE.TabIndex = 0;
            // 
            // tabPageCFFEX
            // 
            this.tabPageCFFEX.Controls.Add(this.dataGridViewCFFEX);
            this.tabPageCFFEX.Location = new System.Drawing.Point(4, 4);
            this.tabPageCFFEX.Name = "tabPageCFFEX";
            this.tabPageCFFEX.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCFFEX.Size = new System.Drawing.Size(1046, 159);
            this.tabPageCFFEX.TabIndex = 3;
            this.tabPageCFFEX.Text = "中金所";
            this.tabPageCFFEX.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCFFEX
            // 
            this.dataGridViewCFFEX.AllowUserToAddRows = false;
            this.dataGridViewCFFEX.AllowUserToDeleteRows = false;
            this.dataGridViewCFFEX.AllowUserToOrderColumns = true;
            this.dataGridViewCFFEX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCFFEX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCFFEX.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCFFEX.Name = "dataGridViewCFFEX";
            this.dataGridViewCFFEX.ReadOnly = true;
            this.dataGridViewCFFEX.RowTemplate.Height = 23;
            this.dataGridViewCFFEX.Size = new System.Drawing.Size(1040, 153);
            this.dataGridViewCFFEX.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1063, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 49);
            this.button1.TabIndex = 21;
            this.button1.Text = "开启自动化交易";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // toolTipInfo
            // 
            this.toolTipInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 373);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControSystem);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainerOrder);
            this.splitContainer1.Size = new System.Drawing.Size(1312, 279);
            this.splitContainer1.SplitterDistance = 923;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControSystem
            // 
            this.tabControSystem.Controls.Add(this.tabPageOrder);
            this.tabControSystem.Controls.Add(this.tabPagePosition);
            this.tabControSystem.Controls.Add(this.tabPageParked);
            this.tabControSystem.Controls.Add(this.tabPageAccount);
            this.tabControSystem.Controls.Add(this.tabPageInstrument);
            this.tabControSystem.Controls.Add(this.tabPageInstrumentSelf);
            this.tabControSystem.Controls.Add(this.tabPageQryTrade);
            this.tabControSystem.Location = new System.Drawing.Point(0, 0);
            this.tabControSystem.Name = "tabControSystem";
            this.tabControSystem.SelectedIndex = 0;
            this.tabControSystem.Size = new System.Drawing.Size(796, 282);
            this.tabControSystem.TabIndex = 0;
            // 
            // tabPageOrder
            // 
            this.tabPageOrder.Controls.Add(this.listViewOrder);
            this.tabPageOrder.Location = new System.Drawing.Point(4, 22);
            this.tabPageOrder.Name = "tabPageOrder";
            this.tabPageOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOrder.Size = new System.Drawing.Size(788, 256);
            this.tabPageOrder.TabIndex = 0;
            this.tabPageOrder.Text = "委  托";
            this.tabPageOrder.UseVisualStyleBackColor = true;
            // 
            // tabPagePosition
            // 
            this.tabPagePosition.Controls.Add(this.splitContainer4);
            this.tabPagePosition.Location = new System.Drawing.Point(4, 22);
            this.tabPagePosition.Name = "tabPagePosition";
            this.tabPagePosition.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePosition.Size = new System.Drawing.Size(788, 256);
            this.tabPagePosition.TabIndex = 2;
            this.tabPagePosition.Text = "持  仓";
            this.tabPagePosition.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.button4);
            this.splitContainer4.Panel1.Controls.Add(this.buttonQuickLock);
            this.splitContainer4.Panel1.Controls.Add(this.buttonCovert);
            this.splitContainer4.Panel1.Controls.Add(this.buttonQuickClose);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.listViewPosition);
            this.splitContainer4.Size = new System.Drawing.Size(782, 250);
            this.splitContainer4.SplitterDistance = 28;
            this.splitContainer4.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(541, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "市价反手";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            // 
            // buttonQuickLock
            // 
            this.buttonQuickLock.Location = new System.Drawing.Point(387, 4);
            this.buttonQuickLock.Name = "buttonQuickLock";
            this.buttonQuickLock.Size = new System.Drawing.Size(75, 23);
            this.buttonQuickLock.TabIndex = 3;
            this.buttonQuickLock.Text = "快速锁仓";
            this.buttonQuickLock.UseVisualStyleBackColor = true;
            this.buttonQuickLock.Click += new System.EventHandler(this.buttonQuickLock_Click);
            // 
            // buttonCovert
            // 
            this.buttonCovert.Location = new System.Drawing.Point(233, 4);
            this.buttonCovert.Name = "buttonCovert";
            this.buttonCovert.Size = new System.Drawing.Size(75, 23);
            this.buttonCovert.TabIndex = 2;
            this.buttonCovert.Text = "快速反手";
            this.buttonCovert.UseVisualStyleBackColor = true;
            this.buttonCovert.Click += new System.EventHandler(this.buttonCovert_Click);
            // 
            // buttonQuickClose
            // 
            this.buttonQuickClose.Location = new System.Drawing.Point(79, 4);
            this.buttonQuickClose.Name = "buttonQuickClose";
            this.buttonQuickClose.Size = new System.Drawing.Size(75, 23);
            this.buttonQuickClose.TabIndex = 1;
            this.buttonQuickClose.Text = "快速平仓";
            this.buttonQuickClose.UseVisualStyleBackColor = true;
            this.buttonQuickClose.Click += new System.EventHandler(this.buttonQuickClose_Click);
            // 
            // tabPageParked
            // 
            this.tabPageParked.Controls.Add(this.splitContainer5);
            this.tabPageParked.Location = new System.Drawing.Point(4, 22);
            this.tabPageParked.Name = "tabPageParked";
            this.tabPageParked.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageParked.Size = new System.Drawing.Size(788, 256);
            this.tabPageParked.TabIndex = 3;
            this.tabPageParked.Text = "预  埋";
            this.tabPageParked.UseVisualStyleBackColor = true;
            this.tabPageParked.Enter += new System.EventHandler(this.tabPageParked_Enter);
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.hfListViewParkedOrder);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.hfListViewParkedAction);
            this.splitContainer5.Size = new System.Drawing.Size(782, 250);
            this.splitContainer5.SplitterDistance = 216;
            this.splitContainer5.TabIndex = 1;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.splitContainer7);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 22);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(788, 256);
            this.tabPageAccount.TabIndex = 4;
            this.tabPageAccount.Text = "资  金";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            this.tabPageAccount.Enter += new System.EventHandler(this.tabPageAccount_Enter);
            // 
            // splitContainer7
            // 
            this.splitContainer7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer7.Location = new System.Drawing.Point(3, 3);
            this.splitContainer7.Name = "splitContainer7";
            this.splitContainer7.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer7.Panel1
            // 
            this.splitContainer7.Panel1.Controls.Add(this.buttonQryAccount);
            // 
            // splitContainer7.Panel2
            // 
            this.splitContainer7.Panel2.Controls.Add(this.userControlTradeAccount1);
            this.splitContainer7.Size = new System.Drawing.Size(782, 250);
            this.splitContainer7.SplitterDistance = 28;
            this.splitContainer7.TabIndex = 0;
            // 
            // buttonQryAccount
            // 
            this.buttonQryAccount.Location = new System.Drawing.Point(163, 5);
            this.buttonQryAccount.Name = "buttonQryAccount";
            this.buttonQryAccount.Size = new System.Drawing.Size(75, 23);
            this.buttonQryAccount.TabIndex = 0;
            this.buttonQryAccount.Text = "刷  新";
            this.buttonQryAccount.UseVisualStyleBackColor = true;
            this.buttonQryAccount.Click += new System.EventHandler(this.buttonQryAccount_Click);
            // 
            // userControlTradeAccount1
            // 
            this.userControlTradeAccount1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlTradeAccount1.IsActive = false;
            this.userControlTradeAccount1.Location = new System.Drawing.Point(0, 0);
            this.userControlTradeAccount1.Name = "userControlTradeAccount1";
            this.userControlTradeAccount1.Size = new System.Drawing.Size(782, 218);
            this.userControlTradeAccount1.TabIndex = 0;
            // 
            // tabPageInstrument
            // 
            this.tabPageInstrument.Controls.Add(this.dataGridViewInstruments);
            this.tabPageInstrument.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstrument.Name = "tabPageInstrument";
            this.tabPageInstrument.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstrument.Size = new System.Drawing.Size(788, 256);
            this.tabPageInstrument.TabIndex = 5;
            this.tabPageInstrument.Text = "合  约";
            this.tabPageInstrument.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInstruments
            // 
            this.dataGridViewInstruments.AllowUserToAddRows = false;
            this.dataGridViewInstruments.AllowUserToDeleteRows = false;
            this.dataGridViewInstruments.AllowUserToOrderColumns = true;
            this.dataGridViewInstruments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstruments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInstruments.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewInstruments.Name = "dataGridViewInstruments";
            this.dataGridViewInstruments.ReadOnly = true;
            this.dataGridViewInstruments.RowTemplate.Height = 23;
            this.dataGridViewInstruments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInstruments.Size = new System.Drawing.Size(782, 250);
            this.dataGridViewInstruments.TabIndex = 0;
            // 
            // tabPageInstrumentSelf
            // 
            this.tabPageInstrumentSelf.Controls.Add(this.dataGridViewInstrumentsSelected);
            this.tabPageInstrumentSelf.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstrumentSelf.Name = "tabPageInstrumentSelf";
            this.tabPageInstrumentSelf.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstrumentSelf.Size = new System.Drawing.Size(788, 256);
            this.tabPageInstrumentSelf.TabIndex = 6;
            this.tabPageInstrumentSelf.Text = "自选合约";
            this.tabPageInstrumentSelf.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInstrumentsSelected
            // 
            this.dataGridViewInstrumentsSelected.AllowUserToAddRows = false;
            this.dataGridViewInstrumentsSelected.AllowUserToDeleteRows = false;
            this.dataGridViewInstrumentsSelected.AllowUserToOrderColumns = true;
            this.dataGridViewInstrumentsSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInstrumentsSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInstrumentsSelected.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewInstrumentsSelected.Name = "dataGridViewInstrumentsSelected";
            this.dataGridViewInstrumentsSelected.ReadOnly = true;
            this.dataGridViewInstrumentsSelected.RowTemplate.Height = 23;
            this.dataGridViewInstrumentsSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewInstrumentsSelected.Size = new System.Drawing.Size(782, 250);
            this.dataGridViewInstrumentsSelected.TabIndex = 0;
            // 
            // tabPageQryTrade
            // 
            this.tabPageQryTrade.Controls.Add(this.buttonSaveTrade);
            this.tabPageQryTrade.Controls.Add(this.label41);
            this.tabPageQryTrade.Controls.Add(this.label40);
            this.tabPageQryTrade.Controls.Add(this.buttonQryPosition);
            this.tabPageQryTrade.Controls.Add(this.dateTimePickerEnd);
            this.tabPageQryTrade.Controls.Add(this.dateTimePickerStart);
            this.tabPageQryTrade.Controls.Add(this.hfListViewTrade);
            this.tabPageQryTrade.Location = new System.Drawing.Point(4, 22);
            this.tabPageQryTrade.Name = "tabPageQryTrade";
            this.tabPageQryTrade.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQryTrade.Size = new System.Drawing.Size(788, 256);
            this.tabPageQryTrade.TabIndex = 12;
            this.tabPageQryTrade.Text = "历史成交";
            this.tabPageQryTrade.UseVisualStyleBackColor = true;
            // 
            // buttonSaveTrade
            // 
            this.buttonSaveTrade.Location = new System.Drawing.Point(530, 14);
            this.buttonSaveTrade.Name = "buttonSaveTrade";
            this.buttonSaveTrade.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTrade.TabIndex = 6;
            this.buttonSaveTrade.Text = "保  存";
            this.buttonSaveTrade.UseVisualStyleBackColor = true;
            this.buttonSaveTrade.Click += new System.EventHandler(this.buttonSaveTrade_Click);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(248, 18);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(53, 12);
            this.label41.TabIndex = 4;
            this.label41.Text = "结束时间";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(85, 18);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(53, 12);
            this.label40.TabIndex = 4;
            this.label40.Text = "开始时间";
            // 
            // buttonQryPosition
            // 
            this.buttonQryPosition.Location = new System.Drawing.Point(433, 13);
            this.buttonQryPosition.Name = "buttonQryPosition";
            this.buttonQryPosition.Size = new System.Drawing.Size(75, 23);
            this.buttonQryPosition.TabIndex = 3;
            this.buttonQryPosition.Text = "查  询";
            this.buttonQryPosition.UseVisualStyleBackColor = true;
            this.buttonQryPosition.Click += new System.EventHandler(this.buttonQryPosition_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.CustomFormat = "HH:mm:ss";
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(307, 14);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.ShowUpDown = true;
            this.dateTimePickerEnd.Size = new System.Drawing.Size(89, 21);
            this.dateTimePickerEnd.TabIndex = 2;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "HH:mm:ss";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(141, 14);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.ShowUpDown = true;
            this.dateTimePickerStart.Size = new System.Drawing.Size(87, 21);
            this.dateTimePickerStart.TabIndex = 1;
            // 
            // hfListViewTrade
            // 
            this.hfListViewTrade.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader45,
            this.columnHeader53,
            this.columnHeader46,
            this.columnHeader47,
            this.columnHeader48,
            this.columnHeader49,
            this.columnHeader50,
            this.columnHeader51,
            this.columnHeader54});
            this.hfListViewTrade.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hfListViewTrade.Location = new System.Drawing.Point(3, 53);
            this.hfListViewTrade.Name = "hfListViewTrade";
            this.hfListViewTrade.Size = new System.Drawing.Size(782, 200);
            this.hfListViewTrade.SortColumn = 0;
            this.hfListViewTrade.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.hfListViewTrade.TabIndex = 0;
            this.hfListViewTrade.UseCompatibleStateImageBehavior = false;
            this.hfListViewTrade.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader45
            // 
            this.columnHeader45.Text = "合约";
            this.columnHeader45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader45.Width = 65;
            // 
            // columnHeader53
            // 
            this.columnHeader53.Text = "成交时间";
            this.columnHeader53.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader53.Width = 71;
            // 
            // columnHeader46
            // 
            this.columnHeader46.Text = "交易所";
            this.columnHeader46.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader47
            // 
            this.columnHeader47.Text = "报单编号";
            this.columnHeader47.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader47.Width = 66;
            // 
            // columnHeader48
            // 
            this.columnHeader48.Text = "买卖";
            this.columnHeader48.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader49
            // 
            this.columnHeader49.Text = "开平";
            this.columnHeader49.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader50
            // 
            this.columnHeader50.Text = "价格";
            this.columnHeader50.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader50.Width = 77;
            // 
            // columnHeader51
            // 
            this.columnHeader51.Text = "数量";
            this.columnHeader51.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // columnHeader54
            // 
            this.columnHeader54.Text = "经纪公司报单编号";
            this.columnHeader54.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader54.Width = 128;
            // 
            // splitContainerOrder
            // 
            this.splitContainerOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerOrder.Location = new System.Drawing.Point(0, 0);
            this.splitContainerOrder.Name = "splitContainerOrder";
            // 
            // splitContainerOrder.Panel1
            // 
            this.splitContainerOrder.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainerOrder.Panel2
            // 
            this.splitContainerOrder.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainerOrder.Panel2.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainerOrder.Size = new System.Drawing.Size(385, 279);
            this.splitContainerOrder.SplitterDistance = 187;
            this.splitContainerOrder.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label17, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAskPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelAskVolume, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label16, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBidPrice, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label18, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelBidVolume, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelInstrumentName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label14, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelLastPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label21, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label22, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label25, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.label26, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label27, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.label23, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelUpperLimit, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.label24, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.labelLowerLimit, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.label28, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label29, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.label30, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label31, 2, 8);
            this.tableLayoutPanel1.Controls.Add(this.label32, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label33, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.label36, 2, 9);
            this.tableLayoutPanel1.Controls.Add(this.label37, 2, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelWeiBi, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelWeiCha, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelSettlementPrice, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelPreSettlementPrice, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelUpDown, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.labelTotalVolume, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelOpenPrice, 3, 6);
            this.tableLayoutPanel1.Controls.Add(this.labelHighest, 3, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelLowest, 3, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelVolume, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.labelOpenInstetest, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.labelPreOI, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.labelOIDiff, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.label19, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(185, 256);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 3;
            this.label17.Text = "卖价";
            // 
            // labelAskPrice
            // 
            this.labelAskPrice.AutoEllipsis = true;
            this.labelAskPrice.AutoSize = true;
            this.labelAskPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAskPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAskPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAskPrice.Location = new System.Drawing.Point(46, 23);
            this.labelAskPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelAskPrice.Name = "labelAskPrice";
            this.labelAskPrice.Size = new System.Drawing.Size(52, 23);
            this.labelAskPrice.TabIndex = 2;
            this.labelAskPrice.Text = "-";
            this.labelAskPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAskVolume
            // 
            this.labelAskVolume.AutoEllipsis = true;
            this.labelAskVolume.AutoSize = true;
            this.labelAskVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAskVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelAskVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAskVolume.Location = new System.Drawing.Point(136, 23);
            this.labelAskVolume.Name = "labelAskVolume";
            this.labelAskVolume.Size = new System.Drawing.Size(46, 23);
            this.labelAskVolume.TabIndex = 1;
            this.labelAskVolume.Text = "-";
            this.labelAskVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(101, 28);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 3;
            this.label16.Text = "卖量";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 12);
            this.label20.TabIndex = 6;
            this.label20.Text = "买价";
            // 
            // labelBidPrice
            // 
            this.labelBidPrice.AutoEllipsis = true;
            this.labelBidPrice.AutoSize = true;
            this.labelBidPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBidPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBidPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidPrice.Location = new System.Drawing.Point(49, 46);
            this.labelBidPrice.Name = "labelBidPrice";
            this.labelBidPrice.Size = new System.Drawing.Size(46, 23);
            this.labelBidPrice.TabIndex = 0;
            this.labelBidPrice.Text = "-";
            this.labelBidPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(101, 51);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 6;
            this.label18.Text = "买量";
            // 
            // labelBidVolume
            // 
            this.labelBidVolume.AutoEllipsis = true;
            this.labelBidVolume.AutoSize = true;
            this.labelBidVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBidVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelBidVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBidVolume.Location = new System.Drawing.Point(136, 46);
            this.labelBidVolume.Name = "labelBidVolume";
            this.labelBidVolume.Size = new System.Drawing.Size(46, 23);
            this.labelBidVolume.TabIndex = 0;
            this.labelBidVolume.Text = "-";
            this.labelBidVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInstrumentName
            // 
            this.labelInstrumentName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInstrumentName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelInstrumentName, 2);
            this.labelInstrumentName.Location = new System.Drawing.Point(133, 5);
            this.labelInstrumentName.Name = "labelInstrumentName";
            this.labelInstrumentName.Size = new System.Drawing.Size(17, 12);
            this.labelInstrumentName.TabIndex = 3;
            this.labelInstrumentName.Text = "--";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 97);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(29, 12);
            this.label14.TabIndex = 0;
            this.label14.Text = "最新";
            // 
            // labelLastPrice
            // 
            this.labelLastPrice.AutoEllipsis = true;
            this.labelLastPrice.AutoSize = true;
            this.labelLastPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLastPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLastPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLastPrice.Location = new System.Drawing.Point(49, 92);
            this.labelLastPrice.Name = "labelLastPrice";
            this.labelLastPrice.Size = new System.Drawing.Size(46, 23);
            this.labelLastPrice.TabIndex = 5;
            this.labelLastPrice.Text = "-";
            this.labelLastPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 74);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(29, 12);
            this.label21.TabIndex = 0;
            this.label21.Text = "委比";
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(101, 74);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(29, 12);
            this.label22.TabIndex = 0;
            this.label22.Text = "委差";
            // 
            // label25
            // 
            this.label25.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(101, 97);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(29, 12);
            this.label25.TabIndex = 0;
            this.label25.Text = "均价";
            // 
            // label26
            // 
            this.label26.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(8, 120);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(29, 12);
            this.label26.TabIndex = 0;
            this.label26.Text = "涨跌";
            // 
            // label27
            // 
            this.label27.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(101, 120);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(29, 12);
            this.label27.TabIndex = 0;
            this.label27.Text = "昨结";
            // 
            // label23
            // 
            this.label23.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(8, 166);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(29, 12);
            this.label23.TabIndex = 6;
            this.label23.Text = "涨板";
            // 
            // labelUpperLimit
            // 
            this.labelUpperLimit.AutoEllipsis = true;
            this.labelUpperLimit.AutoSize = true;
            this.labelUpperLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUpperLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUpperLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpperLimit.ForeColor = System.Drawing.Color.Red;
            this.labelUpperLimit.Location = new System.Drawing.Point(49, 161);
            this.labelUpperLimit.Name = "labelUpperLimit";
            this.labelUpperLimit.Size = new System.Drawing.Size(46, 23);
            this.labelUpperLimit.TabIndex = 5;
            this.labelUpperLimit.Text = "-";
            this.labelUpperLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(101, 166);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 12);
            this.label24.TabIndex = 6;
            this.label24.Text = "跌板";
            // 
            // labelLowerLimit
            // 
            this.labelLowerLimit.AutoEllipsis = true;
            this.labelLowerLimit.AutoSize = true;
            this.labelLowerLimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLowerLimit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLowerLimit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowerLimit.ForeColor = System.Drawing.Color.Green;
            this.labelLowerLimit.Location = new System.Drawing.Point(136, 161);
            this.labelLowerLimit.Name = "labelLowerLimit";
            this.labelLowerLimit.Size = new System.Drawing.Size(46, 23);
            this.labelLowerLimit.TabIndex = 5;
            this.labelLowerLimit.Text = "-";
            this.labelLowerLimit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(8, 143);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(29, 12);
            this.label28.TabIndex = 0;
            this.label28.Text = "总手";
            // 
            // label29
            // 
            this.label29.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(101, 143);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(29, 12);
            this.label29.TabIndex = 0;
            this.label29.Text = "开盘";
            // 
            // label30
            // 
            this.label30.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(8, 189);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(29, 12);
            this.label30.TabIndex = 6;
            this.label30.Text = "现手";
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(101, 189);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(29, 12);
            this.label31.TabIndex = 6;
            this.label31.Text = "最高";
            // 
            // label32
            // 
            this.label32.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(8, 212);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(29, 12);
            this.label32.TabIndex = 6;
            this.label32.Text = "持仓";
            // 
            // label33
            // 
            this.label33.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(8, 237);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(29, 12);
            this.label33.TabIndex = 6;
            this.label33.Text = "昨仓";
            // 
            // label36
            // 
            this.label36.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(101, 212);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(29, 12);
            this.label36.TabIndex = 6;
            this.label36.Text = "最低";
            // 
            // label37
            // 
            this.label37.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(101, 237);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(29, 12);
            this.label37.TabIndex = 6;
            this.label37.Text = "仓差";
            // 
            // labelWeiBi
            // 
            this.labelWeiBi.AutoEllipsis = true;
            this.labelWeiBi.AutoSize = true;
            this.labelWeiBi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWeiBi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWeiBi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeiBi.Location = new System.Drawing.Point(49, 69);
            this.labelWeiBi.Name = "labelWeiBi";
            this.labelWeiBi.Size = new System.Drawing.Size(46, 23);
            this.labelWeiBi.TabIndex = 0;
            this.labelWeiBi.Text = "-";
            this.labelWeiBi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeiCha
            // 
            this.labelWeiCha.AutoEllipsis = true;
            this.labelWeiCha.AutoSize = true;
            this.labelWeiCha.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelWeiCha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelWeiCha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWeiCha.Location = new System.Drawing.Point(136, 69);
            this.labelWeiCha.Name = "labelWeiCha";
            this.labelWeiCha.Size = new System.Drawing.Size(46, 23);
            this.labelWeiCha.TabIndex = 0;
            this.labelWeiCha.Text = "-";
            this.labelWeiCha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelSettlementPrice
            // 
            this.labelSettlementPrice.AutoEllipsis = true;
            this.labelSettlementPrice.AutoSize = true;
            this.labelSettlementPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelSettlementPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSettlementPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSettlementPrice.Location = new System.Drawing.Point(136, 92);
            this.labelSettlementPrice.Name = "labelSettlementPrice";
            this.labelSettlementPrice.Size = new System.Drawing.Size(46, 23);
            this.labelSettlementPrice.TabIndex = 0;
            this.labelSettlementPrice.Text = "-";
            this.labelSettlementPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPreSettlementPrice
            // 
            this.labelPreSettlementPrice.AutoEllipsis = true;
            this.labelPreSettlementPrice.AutoSize = true;
            this.labelPreSettlementPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPreSettlementPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPreSettlementPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreSettlementPrice.Location = new System.Drawing.Point(136, 115);
            this.labelPreSettlementPrice.Name = "labelPreSettlementPrice";
            this.labelPreSettlementPrice.Size = new System.Drawing.Size(46, 23);
            this.labelPreSettlementPrice.TabIndex = 0;
            this.labelPreSettlementPrice.Text = "-";
            this.labelPreSettlementPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUpDown
            // 
            this.labelUpDown.AutoEllipsis = true;
            this.labelUpDown.AutoSize = true;
            this.labelUpDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUpDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpDown.Location = new System.Drawing.Point(49, 115);
            this.labelUpDown.Name = "labelUpDown";
            this.labelUpDown.Size = new System.Drawing.Size(46, 23);
            this.labelUpDown.TabIndex = 5;
            this.labelUpDown.Text = "-";
            this.labelUpDown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalVolume
            // 
            this.labelTotalVolume.AutoEllipsis = true;
            this.labelTotalVolume.AutoSize = true;
            this.labelTotalVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTotalVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalVolume.Location = new System.Drawing.Point(49, 138);
            this.labelTotalVolume.Name = "labelTotalVolume";
            this.labelTotalVolume.Size = new System.Drawing.Size(46, 23);
            this.labelTotalVolume.TabIndex = 5;
            this.labelTotalVolume.Text = "-";
            this.labelTotalVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOpenPrice
            // 
            this.labelOpenPrice.AutoEllipsis = true;
            this.labelOpenPrice.AutoSize = true;
            this.labelOpenPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOpenPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOpenPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenPrice.Location = new System.Drawing.Point(136, 138);
            this.labelOpenPrice.Name = "labelOpenPrice";
            this.labelOpenPrice.Size = new System.Drawing.Size(46, 23);
            this.labelOpenPrice.TabIndex = 0;
            this.labelOpenPrice.Text = "-";
            this.labelOpenPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHighest
            // 
            this.labelHighest.AutoEllipsis = true;
            this.labelHighest.AutoSize = true;
            this.labelHighest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelHighest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelHighest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHighest.Location = new System.Drawing.Point(136, 184);
            this.labelHighest.Name = "labelHighest";
            this.labelHighest.Size = new System.Drawing.Size(46, 23);
            this.labelHighest.TabIndex = 5;
            this.labelHighest.Text = "-";
            this.labelHighest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLowest
            // 
            this.labelLowest.AutoEllipsis = true;
            this.labelLowest.AutoSize = true;
            this.labelLowest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLowest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelLowest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLowest.Location = new System.Drawing.Point(136, 207);
            this.labelLowest.Name = "labelLowest";
            this.labelLowest.Size = new System.Drawing.Size(46, 23);
            this.labelLowest.TabIndex = 5;
            this.labelLowest.Text = "-";
            this.labelLowest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVolume
            // 
            this.labelVolume.AutoEllipsis = true;
            this.labelVolume.AutoSize = true;
            this.labelVolume.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVolume.Location = new System.Drawing.Point(49, 184);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(46, 23);
            this.labelVolume.TabIndex = 5;
            this.labelVolume.Text = "-";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOpenInstetest
            // 
            this.labelOpenInstetest.AutoEllipsis = true;
            this.labelOpenInstetest.AutoSize = true;
            this.labelOpenInstetest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOpenInstetest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOpenInstetest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpenInstetest.Location = new System.Drawing.Point(49, 207);
            this.labelOpenInstetest.Name = "labelOpenInstetest";
            this.labelOpenInstetest.Size = new System.Drawing.Size(46, 23);
            this.labelOpenInstetest.TabIndex = 5;
            this.labelOpenInstetest.Text = "-";
            this.labelOpenInstetest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPreOI
            // 
            this.labelPreOI.AutoEllipsis = true;
            this.labelPreOI.AutoSize = true;
            this.labelPreOI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPreOI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelPreOI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPreOI.Location = new System.Drawing.Point(49, 230);
            this.labelPreOI.Name = "labelPreOI";
            this.labelPreOI.Size = new System.Drawing.Size(46, 26);
            this.labelPreOI.TabIndex = 5;
            this.labelPreOI.Text = "-";
            this.labelPreOI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelOIDiff
            // 
            this.labelOIDiff.AutoEllipsis = true;
            this.labelOIDiff.AutoSize = true;
            this.labelOIDiff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOIDiff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelOIDiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOIDiff.Location = new System.Drawing.Point(136, 230);
            this.labelOIDiff.Name = "labelOIDiff";
            this.labelOIDiff.Size = new System.Drawing.Size(46, 26);
            this.labelOIDiff.TabIndex = 5;
            this.labelOIDiff.Text = "-";
            this.labelOIDiff.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label19.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label19, 2);
            this.label19.Location = new System.Drawing.Point(3, 5);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 3;
            this.label19.Text = "盘口明细";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.splitter1);
            this.splitContainer3.Panel1.Controls.Add(this.comboBoxInstrument);
            this.splitContainer3.Panel1.Controls.Add(this.numericUpDownVolume);
            this.splitContainer3.Panel1.Controls.Add(this.label1);
            this.splitContainer3.Panel1.Controls.Add(this.numericUpDownPrice);
            this.splitContainer3.Panel1.Controls.Add(this.buttonPrice);
            this.splitContainer3.Panel1.Controls.Add(this.comboBoxOffset);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            this.splitContainer3.Panel1.Controls.Add(this.labelUpper);
            this.splitContainer3.Panel1.Controls.Add(this.labelLower);
            this.splitContainer3.Panel1.Controls.Add(this.label5);
            this.splitContainer3.Panel1.Controls.Add(this.labelVolumeMax);
            this.splitContainer3.Panel1.Controls.Add(this.label15);
            this.splitContainer3.Panel1.Controls.Add(this.comboBoxDirector);
            this.splitContainer3.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.buttonOrder);
            this.splitContainer3.Panel2.Controls.Add(this.buttonCancel);
            this.splitContainer3.Panel2.Controls.Add(this.btnParked);
            this.splitContainer3.Size = new System.Drawing.Size(194, 279);
            this.splitContainer3.SplitterDistance = 121;
            this.splitContainer3.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 119);
            this.splitter1.TabIndex = 21;
            this.splitter1.TabStop = false;
            // 
            // comboBoxInstrument
            // 
            this.comboBoxInstrument.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxInstrument.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.comboBoxInstrument.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxInstrument.FormattingEnabled = true;
            this.comboBoxInstrument.Location = new System.Drawing.Point(49, 2);
            this.comboBoxInstrument.Name = "comboBoxInstrument";
            this.comboBoxInstrument.Size = new System.Drawing.Size(117, 20);
            this.comboBoxInstrument.TabIndex = 10;
            this.comboBoxInstrument.SelectedIndexChanged += new System.EventHandler(this.comboBoxInstrument_SelectedIndexChanged);
            // 
            // numericUpDownVolume
            // 
            this.numericUpDownVolume.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownVolume.Location = new System.Drawing.Point(66, 97);
            this.numericUpDownVolume.Name = "numericUpDownVolume";
            this.numericUpDownVolume.Size = new System.Drawing.Size(77, 26);
            this.numericUpDownVolume.TabIndex = 20;
            this.numericUpDownVolume.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(-6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "合约";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numericUpDownPrice
            // 
            this.numericUpDownPrice.Enabled = false;
            this.numericUpDownPrice.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numericUpDownPrice.Location = new System.Drawing.Point(66, 71);
            this.numericUpDownPrice.Name = "numericUpDownPrice";
            this.numericUpDownPrice.Size = new System.Drawing.Size(77, 26);
            this.numericUpDownPrice.TabIndex = 19;
            this.numericUpDownPrice.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ValueChanged);
            // 
            // buttonPrice
            // 
            this.buttonPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrice.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonPrice.Location = new System.Drawing.Point(7, 71);
            this.buttonPrice.Name = "buttonPrice";
            this.buttonPrice.Size = new System.Drawing.Size(54, 23);
            this.buttonPrice.TabIndex = 18;
            this.buttonPrice.Text = "跟盘价";
            this.buttonPrice.UseVisualStyleBackColor = false;
            this.buttonPrice.Click += new System.EventHandler(this.buttonPrice_Click);
            // 
            // comboBoxOffset
            // 
            this.comboBoxOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOffset.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxOffset.FormattingEnabled = true;
            this.comboBoxOffset.Items.AddRange(new object[] {
            "开仓",
            "平仓",
            "平今"});
            this.comboBoxOffset.Location = new System.Drawing.Point(49, 47);
            this.comboBoxOffset.Name = "comboBoxOffset";
            this.comboBoxOffset.Size = new System.Drawing.Size(117, 20);
            this.comboBoxOffset.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(-6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 14;
            this.label3.Text = "买卖";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelUpper
            // 
            this.labelUpper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUpper.AutoSize = true;
            this.labelUpper.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUpper.ForeColor = System.Drawing.Color.Red;
            this.labelUpper.Location = new System.Drawing.Point(145, -20);
            this.labelUpper.Name = "labelUpper";
            this.labelUpper.Size = new System.Drawing.Size(11, 14);
            this.labelUpper.TabIndex = 5;
            this.labelUpper.Text = "-";
            // 
            // labelLower
            // 
            this.labelLower.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLower.AutoSize = true;
            this.labelLower.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLower.ForeColor = System.Drawing.Color.Green;
            this.labelLower.Location = new System.Drawing.Point(145, -6);
            this.labelLower.Name = "labelLower";
            this.labelLower.Size = new System.Drawing.Size(11, 14);
            this.labelLower.TabIndex = 5;
            this.labelLower.Text = "-";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 23);
            this.label5.TabIndex = 13;
            this.label5.Text = "手 数";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelVolumeMax
            // 
            this.labelVolumeMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelVolumeMax.AutoSize = true;
            this.labelVolumeMax.Font = new System.Drawing.Font("新宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelVolumeMax.Location = new System.Drawing.Point(158, 102);
            this.labelVolumeMax.Name = "labelVolumeMax";
            this.labelVolumeMax.Size = new System.Drawing.Size(14, 14);
            this.labelVolumeMax.TabIndex = 0;
            this.labelVolumeMax.Text = "-";
            this.labelVolumeMax.Click += new System.EventHandler(this.labelVolumeMax_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(149, 104);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 12);
            this.label15.TabIndex = 0;
            this.label15.Text = "≤";
            // 
            // comboBoxDirector
            // 
            this.comboBoxDirector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDirector.Font = new System.Drawing.Font("新宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBoxDirector.FormattingEnabled = true;
            this.comboBoxDirector.Items.AddRange(new object[] {
            "买入",
            "卖出"});
            this.comboBoxDirector.Location = new System.Drawing.Point(49, 24);
            this.comboBoxDirector.Name = "comboBoxDirector";
            this.comboBoxDirector.Size = new System.Drawing.Size(117, 20);
            this.comboBoxDirector.TabIndex = 16;
            this.comboBoxDirector.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirector_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(-5, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 15;
            this.label4.Text = "开平";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(-1, 27);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(87, 52);
            this.buttonOrder.TabIndex = 0;
            this.buttonOrder.Text = "下 单";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(92, 57);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 46);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "取 消";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnParked
            // 
            this.btnParked.Location = new System.Drawing.Point(-6, 91);
            this.btnParked.Name = "btnParked";
            this.btnParked.Size = new System.Drawing.Size(91, 48);
            this.btnParked.TabIndex = 2;
            this.btnParked.Text = "预埋";
            this.btnParked.UseVisualStyleBackColor = true;
            this.btnParked.Click += new System.EventHandler(this.btnParked_Click);
            // 
            // FormTrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1312, 676);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Location", global::trader.Properties.Settings.Default, "FormLocation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = global::trader.Properties.Settings.Default.FormLocation;
            this.Name = "FormTrade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTrade_FormClosed);
            this.Load += new System.EventHandler(this.FormTrade_Load);
            this.LocationChanged += new System.EventHandler(this.FormTrade_LocationChanged);
            this.SizeChanged += new System.EventHandler(this.FormTrade_SizeChanged);
            this.tabPageSHFE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSHFE)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageCZCE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCZCE)).EndInit();
            this.tabPageDCE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDCE)).EndInit();
            this.tabPageCFFEX.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCFFEX)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControSystem.ResumeLayout(false);
            this.tabPageOrder.ResumeLayout(false);
            this.tabPagePosition.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPageParked.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPageAccount.ResumeLayout(false);
            this.splitContainer7.Panel1.ResumeLayout(false);
            this.splitContainer7.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer7)).EndInit();
            this.splitContainer7.ResumeLayout(false);
            this.tabPageInstrument.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstruments)).EndInit();
            this.tabPageInstrumentSelf.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInstrumentsSelected)).EndInit();
            this.tabPageQryTrade.ResumeLayout(false);
            this.tabPageQryTrade.PerformLayout();
            this.splitContainerOrder.Panel1.ResumeLayout(false);
            this.splitContainerOrder.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerOrder)).EndInit();
            this.splitContainerOrder.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainerOrder;
		private System.Windows.Forms.SplitContainer splitContainer3;
		private System.Windows.Forms.ComboBox comboBoxInstrument;
		private System.Windows.Forms.NumericUpDown numericUpDownVolume;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numericUpDownPrice;
		private System.Windows.Forms.Button buttonPrice;
		/// <summary>
		/// 开平
		/// </summary>
		private System.Windows.Forms.ComboBox comboBoxOffset;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		/// <summary>
		/// 买卖
		/// </summary>
		private System.Windows.Forms.ComboBox comboBoxDirector;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonOrder;
		private System.Windows.Forms.Button btnParked;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.ComboBox comboBoxErrMsg;
		private System.Windows.Forms.ToolTip toolTip1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label labelBidPrice;
		private System.Windows.Forms.Label labelBidVolume;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label labelAskPrice;
		private System.Windows.Forms.Label labelAskVolume;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label labelLastPrice;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label labelUpperLimit;
		private System.Windows.Forms.Label labelLowerLimit;
		private System.Windows.Forms.Label labelInstrumentName;
		private System.Windows.Forms.Label labelUpper;
		private System.Windows.Forms.Label labelLower;
		private System.Windows.Forms.Label labelVolumeMax;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.Label labelWeiBi;
		private System.Windows.Forms.Label labelWeiCha;
		private System.Windows.Forms.Label labelSettlementPrice;
		private System.Windows.Forms.Label labelPreSettlementPrice;
		private System.Windows.Forms.Label labelUpDown;
		private System.Windows.Forms.Label labelTotalVolume;
		private System.Windows.Forms.Label labelOpenPrice;
		private System.Windows.Forms.Label labelHighest;
		private System.Windows.Forms.Label labelLowest;
		private System.Windows.Forms.Label labelVolume;
		private System.Windows.Forms.Label labelOpenInstetest;
		private System.Windows.Forms.Label labelPreOI;
		private System.Windows.Forms.Label labelOIDiff;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelTop;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSHFE;
		private System.Windows.Forms.TabPage tabPageCZCE;
		private System.Windows.Forms.TabPage tabPageDCE;
		private System.Windows.Forms.TabPage tabPageCFFEX;
		private DoubleBufferDGV dataGridViewCFFEX;
		private DoubleBufferDGV dataGridViewSHFE;
		private DoubleBufferDGV dataGridViewCZCE;
		private DoubleBufferDGV dataGridViewDCE;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private NPlot.Windows.PlotSurface2D myPlot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_symbol;
        private System.Windows.Forms.Button W1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl tabControSystem;
        private System.Windows.Forms.TabPage tabPageOrder;
        private HFListView listViewOrder;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader43;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.TabPage tabPagePosition;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonQuickLock;
        private System.Windows.Forms.Button buttonCovert;
        private System.Windows.Forms.Button buttonQuickClose;
        private HFListView listViewPosition;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader24;
        private System.Windows.Forms.ColumnHeader columnHeader28;
        private System.Windows.Forms.ColumnHeader columnHeader29;
        private System.Windows.Forms.ColumnHeader columnHeader26;
        private System.Windows.Forms.ColumnHeader columnHeader27;
        private System.Windows.Forms.ColumnHeader columnHeader34;
        private System.Windows.Forms.ColumnHeader columnHeader44;
        private System.Windows.Forms.ColumnHeader columnHeader30;
        private System.Windows.Forms.ColumnHeader columnHeader31;
        private System.Windows.Forms.ColumnHeader columnHeader32;
        private System.Windows.Forms.ColumnHeader columnHeader25;
        private System.Windows.Forms.TabPage tabPageParked;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private HFListView hfListViewParkedOrder;
        private System.Windows.Forms.ColumnHeader columnHeader33;
        private System.Windows.Forms.ColumnHeader columnHeader35;
        private System.Windows.Forms.ColumnHeader columnHeader36;
        private System.Windows.Forms.ColumnHeader columnHeader37;
        private System.Windows.Forms.ColumnHeader columnHeader38;
        private System.Windows.Forms.ColumnHeader columnHeader39;
        private System.Windows.Forms.ColumnHeader columnHeader40;
        private System.Windows.Forms.ColumnHeader columnHeader41;
        private System.Windows.Forms.ColumnHeader columnHeader42;
        private HFListView hfListViewParkedAction;
        private System.Windows.Forms.TabPage tabPageAccount;
        private System.Windows.Forms.SplitContainer splitContainer7;
        private System.Windows.Forms.Button buttonQryAccount;
        private UserControlTradeAccount userControlTradeAccount1;
        private System.Windows.Forms.TabPage tabPageInstrument;
        private DoubleBufferDGV dataGridViewInstruments;
        private System.Windows.Forms.TabPage tabPageInstrumentSelf;
        private DoubleBufferDGV dataGridViewInstrumentsSelected;
        private System.Windows.Forms.TabPage tabPageQryTrade;
        private System.Windows.Forms.Button buttonSaveTrade;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Button buttonQryPosition;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private HFListView hfListViewTrade;
        private System.Windows.Forms.ColumnHeader columnHeader45;
        private System.Windows.Forms.ColumnHeader columnHeader53;
        private System.Windows.Forms.ColumnHeader columnHeader46;
        private System.Windows.Forms.ColumnHeader columnHeader47;
        private System.Windows.Forms.ColumnHeader columnHeader48;
        private System.Windows.Forms.ColumnHeader columnHeader49;
        private System.Windows.Forms.ColumnHeader columnHeader50;
        private System.Windows.Forms.ColumnHeader columnHeader51;
        private System.Windows.Forms.ColumnHeader columnHeader54;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
    }
}

