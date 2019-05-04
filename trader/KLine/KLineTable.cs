using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NPlot;

namespace trader.KLine
{
    

    partial class KLineForm : Form

    {

    ///<summary>

    /// Required designer variable.

    ///</summary>

        private System.ComponentModel.IContainer components = null;

        ///<summary>

        /// Clean up any resources being used.

        ///</summary>

        ///<param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        protected override void Dispose(bool disposing)
        {

            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);

        }



#region Windows Form Designer generated code



        ///<summary>

        /// Required method for Designer support - do not modify

        /// the contents of this method with the code editor.

        ///</summary>

        private void InitializeComponent()

        {
            this.M5 = new System.Windows.Forms.Button();
            this.M1 = new System.Windows.Forms.Button();
            this.M15 = new System.Windows.Forms.Button();
            this.M30 = new System.Windows.Forms.Button();
            this.H1 = new System.Windows.Forms.Button();
            this.D1 = new System.Windows.Forms.Button();
            this.W1 = new System.Windows.Forms.Button();
            this.Mn1 = new System.Windows.Forms.Button();
            this.label_symbol = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myPlot = new NPlot.Windows.PlotSurface2D();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // M5
            // 
            this.M5.AutoSize = true;
            this.M5.CausesValidation = false;
            this.M5.Location = new System.Drawing.Point(282, 13);
            this.M5.Name = "M5";
            this.M5.Size = new System.Drawing.Size(39, 24);
            this.M5.TabIndex = 2;
            this.M5.TabStop = false;
            this.M5.Text = "5分";
            this.M5.UseVisualStyleBackColor = true;
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.CausesValidation = false;
            this.M1.Location = new System.Drawing.Point(237, 14);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(39, 24);
            this.M1.TabIndex = 4;
            this.M1.TabStop = false;
            this.M1.Text = "1分";
            this.M1.UseVisualStyleBackColor = true;
            // 
            // M15
            // 
            this.M15.AutoSize = true;
            this.M15.CausesValidation = false;
            this.M15.Location = new System.Drawing.Point(327, 14);
            this.M15.Name = "M15";
            this.M15.Size = new System.Drawing.Size(39, 24);
            this.M15.TabIndex = 6;
            this.M15.TabStop = false;
            this.M15.Text = "15分";
            this.M15.UseVisualStyleBackColor = true;
            // 
            // M30
            // 
            this.M30.AutoSize = true;
            this.M30.CausesValidation = false;
            this.M30.Location = new System.Drawing.Point(372, 14);
            this.M30.Name = "M30";
            this.M30.Size = new System.Drawing.Size(39, 24);
            this.M30.TabIndex = 5;
            this.M30.TabStop = false;
            this.M30.Text = "30分";
            this.M30.UseVisualStyleBackColor = true;
            // 
            // H1
            // 
            this.H1.AutoSize = true;
            this.H1.CausesValidation = false;
            this.H1.Location = new System.Drawing.Point(417, 14);
            this.H1.Name = "H1";
            this.H1.Size = new System.Drawing.Size(39, 24);
            this.H1.TabIndex = 8;
            this.H1.TabStop = false;
            this.H1.Text = "1时";
            this.H1.UseVisualStyleBackColor = true;
            // 
            // D1
            // 
            this.D1.AutoSize = true;
            this.D1.CausesValidation = false;
            this.D1.Location = new System.Drawing.Point(462, 14);
            this.D1.Name = "D1";
            this.D1.Size = new System.Drawing.Size(39, 24);
            this.D1.TabIndex = 7;
            this.D1.TabStop = false;
            this.D1.Text = "1日";
            this.D1.UseVisualStyleBackColor = true;
            // 
            // W1
            // 
            this.W1.AutoSize = true;
            this.W1.CausesValidation = false;
            this.W1.Location = new System.Drawing.Point(507, 14);
            this.W1.Name = "W1";
            this.W1.Size = new System.Drawing.Size(39, 24);
            this.W1.TabIndex = 9;
            this.W1.TabStop = false;
            this.W1.Text = "1周";
            this.W1.UseVisualStyleBackColor = true;
            // 
            // Mn1
            // 
            this.Mn1.AutoSize = true;
            this.Mn1.CausesValidation = false;
            this.Mn1.Location = new System.Drawing.Point(552, 14);
            this.Mn1.Name = "Mn1";
            this.Mn1.Size = new System.Drawing.Size(39, 24);
            this.Mn1.TabIndex = 10;
            this.Mn1.TabStop = false;
            this.Mn1.Text = "1月";
            this.Mn1.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "商品";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(597, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(69, 21);
            this.textBox1.TabIndex = 13;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(141, 14);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(41, 12);
            this.labelTime.TabIndex = 16;
            this.labelTime.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(720, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(672, 17);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(42, 21);
            this.textBox2.TabIndex = 20;
            this.textBox2.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.myPlot);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label_symbol);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.M1);
            this.panel1.Controls.Add(this.M5);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.M15);
            this.panel1.Controls.Add(this.Mn1);
            this.panel1.Controls.Add(this.M30);
            this.panel1.Controls.Add(this.W1);
            this.panel1.Controls.Add(this.H1);
            this.panel1.Controls.Add(this.D1);
            this.panel1.Location = new System.Drawing.Point(91, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 261);
            this.panel1.TabIndex = 22;
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
            this.myPlot.Location = new System.Drawing.Point(0, 43);
            this.myPlot.Name = "myPlot";
            this.myPlot.RightMenu = null;
            this.myPlot.ShowCoordinates = true;
            this.myPlot.Size = new System.Drawing.Size(797, 215);
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
            // KLineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 438);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "KLineForm";
            this.Text = "FormCtpThread";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }



#endregion

        private System.Windows.Forms.Button M5;

        private System.Windows.Forms.Button M1;

        private System.Windows.Forms.Button M15;

        private System.Windows.Forms.Button M30;

        private System.Windows.Forms.Button H1;

        private System.Windows.Forms.Button D1;

        private System.Windows.Forms.Button W1;

        private System.Windows.Forms.Button Mn1;

        private System.Windows.Forms.Label label_symbol;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label labelTime;

        private System.Windows.Forms.Button button3;

        private System.Windows.Forms.TextBox textBox2;
        private Panel panel1;
        private NPlot.Windows.PlotSurface2D myPlot;
        private MenuStrip menuStrip1;
        private 

        //private NPlot.Windows.PlotSurface2D myplot;





















        // ----------------------------------- Helper
        void CtpTxt2Charts(string[] vitems, out CtpInfo data)
        {
            //vitems[0]=20160101;
            data = new CtpInfo();
            data.open = Double.Parse(vitems[2].Trim());
            data.high = Double.Parse(vitems[3].Trim());
            data.low = Double.Parse(vitems[4].Trim());
            data.close = Double.Parse(vitems[5].Trim());
            data.volume = Double.Parse(vitems[6].Trim());
            data.hold = Double.Parse(vitems[7].Trim());
            int year = Int32.Parse(vitems[0].Trim().Substring(0, 4));
            int month = Int32.Parse(vitems[0].Trim().Substring(4, 2));
            int day = Int32.Parse(vitems[0].Trim().Substring(6, 2));
            //vitems[1]=0.121212;

            int time = (int)(Double.Parse(vitems[1].Trim()) * 1000000);
            int h = time / 10000;
            int m = Int32.Parse(vitems[1].Trim().Substring(4, 2));
            int s = Int32.Parse(vitems[1].Trim().Substring(6, 2));
            DateTime date1 = new DateTime(year, month, day, h, m, s);

            data.date = date1;
        }


        public List<CtpInfo> LoadCtpInfo(string fileName)
        {
            //MessageBox.Show(fileName);
            using (Stream resourceStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader reader = new StreamReader(resourceStream, Encoding.GetEncoding("GB2312")))
                {
                
                    var strings = reader.ReadToEnd().Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

                    //textBox1.Text = strings.Length.ToString();

                    var res = new List<CtpInfo>(strings.Length);
                   

                    for (int i = 0; i < strings.Length; i++)
                    {
                        //string line = strings[i];
                        string[] subLines = strings[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        CtpInfo data = new CtpInfo();
                        //对每一行文本按<>结构进行数据转换
                        CtpTxt2Charts(subLines, out data);
                        DateTime date = data.date;
                        Double open = data.open;
                        Double high = data.high;
                        Double low = data.low;
                        Double close = data.close;
                        Double volume = data.volume;
                        Double hold = data.hold;

                        res.Add(
                            new CtpInfo
                            {
                                date = date,
                                open = open,
                                high = high,
                                low = low,
                                close = close,
                                volume = volume
                            });
                    }
                    return res;
                }
            }
        }

        //  C:\Users\Jack\Desktop\trader\KLine\rb1609_d1.txt
        public void OpenChartFile(string fileName)
        {
            if (!String.IsNullOrEmpty(fileName))
            {
                int m1 = fileName.LastIndexOf(@"\");
                int m2 = fileName.LastIndexOf(@"_");
                int m3 = fileName.IndexOf(@".txt");
                String pathCtp = fileName.Substring(0, fileName.LastIndexOf(@"\"));
                //  string[] subLines = pathCtp.Split('\\');
                stockName = fileName.Substring(m1 + 1, m2 - m1 - 1);
                String period = fileName.Substring(m2 + 1, m3 - m2 - 1);

                label_symbol.Text = stockName + @"   周期: " + period;

                DataStock = LoadCtpInfo(fileName);
                DataStock.Reverse(); //for last 300
                xEnd = 0;
                xBegin = Math.Min(xInitShowBars, DataStock.Count - 1);
                //xShowBars = xInitShowBars;
                ReFreshMe(ref xBegin, ref xEnd, ref xShowBars, 0);
            }
        }






        private System.Timers.Timer timer = new System.Timers.Timer(1000);

        ///<summary>

        /// /////////////////////////////成员

        ///</summary>

        public List<CtpInfo> DataStock { get; set; }

        public List<CtpInfo> DataStockReverse { get; set; }

        String period;

        trader.KLine.TimeFrame timeFrame = trader.KLine.TimeFrame.D1;

        String stockName;

        double xMin, xMax, yMin, yMax;

        int xInitShowBars = 300;

        int xShowBars = 300;//k线最大数

        int xBegin,xEnd;

        CandlePlot cp = new CandlePlot();


        string pathCtp { get; set; }

        string file { get; set; }

        public KLineForm()

        {

            InitializeComponent();

            //MessageBox.Show("PK");

        }

        public KLineForm(string file)

        {

            InitializeComponent();

            this.file = file;

            FormCtp_Load();


            //MessageBox.Show("PK");

        }







        //private void FormCtp_Load(object send//, EventArgs e)
        private void FormCtp_Load()
        {
            OpenChartFile(file);
            this.MouseWheel += new MouseEventHandler(FormCtp_MouseWheel); // 滚轮
            /*
            timer.Elapsed += new System.Timers.ElapsedEventHandler(timer_Elapsed);
            timer.Enabled = true;
            timer.AutoReset = true; //是否不断重复定时器操作
            */
        }

        // 根据滚轮放大或缩小
        void FormCtp_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                ChangeSize(1);
            }else if(e.Delta < 0){
                
                ChangeSize(-1);
            }
        }


        void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //用于实现K线图表自动读取文件数据,并定时刷新显示
            /*
            labelTime.Text = DateTime.Now.ToString();//调用内容，并用lable1显示出来。。。

            OpenChartFileLastBar(file);

            if (!isMove)

                KMove(ref xBegin, ref xEnd, ref xShowBars, 0);
            */


        }



        ///放大缩小

        private void ChangeSize(int opMode)

        {

            ReFreshMe(ref xBegin, ref xEnd, ref xShowBars, opMode);

        }

        /////////K线图绘制//////////

        public void PlotCandle(CandlePlot cp, List<DateTime> dates, trader.KLine.TimeFrame timeframe)
        {
            try
            {

                myPlot.Clear();
                // --- Grid Code ---
                Grid mygrid = new Grid();
                mygrid.HorizontalGridType = Grid.GridType.Fine;
                mygrid.VerticalGridType = Grid.GridType.Fine;
                myPlot.Add(mygrid);
                cp.BullishColor = Color.Red;
                //cp.Color = Color.Black;
                cp.Centered = false;
                cp.BearishColor = Color.Green;
                cp.Style = CandlePlot.Styles.Filled;
                this.myPlot.Add(cp);

                //////这里需要先添加图形后设置坐标轴
                /////字符坐标轴加入后会隐藏原来的x坐标轴
                LabelAxis la1 = new LabelAxis(this.myPlot.XAxis1);
                for (int i = 0; i < dates.Count; i++)
                {
                    switch (timeframe)
                    {
                        case trader.KLine.TimeFrame.M1:

                            if (Math.IEEERemainder(i, 30) == 0)

                                la1.AddLabel(dates[i].ToShortTimeString() + @" " + dates[i].ToShortDateString(), i);

                            break;

                        case trader.KLine.TimeFrame.M5:

                            if (Math.IEEERemainder(i, 12) == 0)

                                la1.AddLabel(dates[i].ToShortTimeString() + @" " + dates[i].ToShortDateString(), i + 00);

                            break;

                        default:

                            if (Math.IEEERemainder(i, 5) == 0)

                                la1.AddLabel(dates[i].ToShortTimeString() + @" " + dates[i].ToShortDateString(), i + 00);

                            break;

                    }

                }

                //la1.Label = "时间";
                la1.TickTextFont = new Font("Courier New", 8);
                la1.TicksBetweenText = false;
                this.myPlot.XAxis1 = la1;

                //////让日期斜45度。

                //myPlot.XAxis1.TicksLabelAngle = 45;

                myPlot.Refresh();

            }

            catch (Exception e)

            {

                //Console.WriteLine("{0} Exception caught.", e);

                //MessageBox.Show(e.ToString());

            }
        }
        void ReFreshMe(ref int xBegin, ref int xEnd, ref int xShowBars, int opMode)
        {
            int xDisLen = xBegin - xEnd;
            textBox1.Text = "e-b=" + xDisLen.ToString();
            int n, m;

            if (opMode > 0){
                n = xBegin - xEnd; //(int)(xShowBars) / 1;
                //MessageBox.Show(n.ToString());
                m = n / 2;
                m = Math.Max(2, m);
                xBegin = xDisLen = Math.Min(m, DataStock.Count - 1);
                xEnd = 0;// Math.Max(xEnd - m, 0);
            }else if(opMode < 0){
                n = xBegin - xEnd;
                m = n * 2;
                xBegin = xDisLen = Math.Min(m, DataStock.Count - 1);
                xEnd = 0;// Math.Max(xEnd - m, 0);
            }else{
                n = xInitShowBars;
                xBegin = xDisLen = Math.Min(n, DataStock.Count - 1);
                xEnd = 0;// Math.Max(xEnd - m, 0);
            }

            //判定要显示的数据数量

            List<Double> DataOpen = new List<Double>();

            List<Double> DataHigh = new List<Double>();

            List<Double> DataLow = new List<Double>();

            List<Double> DataClose = new List<Double>();

            List<DateTime> DataTime = new List<DateTime>();

            List<int> Time = new List<int>();

            for (int i = xBegin - 1; i >= xEnd; i--)

            {

                DataHigh.Add(DataStock[i].high);

                DataLow.Add(DataStock[i].low);

                DataClose.Add(DataStock[i].close);

                DataOpen.Add(DataStock[i].open);

                DataTime.Add(DataStock[i].date);

                //Time.Add(i);

            }

            //写横坐标轴数据

            for (int i = 0; i < xDisLen + 5; i++) Time.Add(i);

            cp.OpenData = DataOpen.ToArray();

            cp.CloseData = DataClose.ToArray();

            cp.HighData = DataHigh.ToArray();

            cp.LowData = DataLow.ToArray();

            cp.AbscissaData = Time.ToArray();

            PlotCandle(cp, DataTime, timeFrame);

        }
    }
}



