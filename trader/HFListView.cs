using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace trader
{
	public class HFListView : ListView, IComparer
	{
		/// <summary>
		/// 构造函数
		/// </summary>
		public HFListView()
		{
			this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
			// 初始化CaseInsensitiveComparer类对象
			ObjectCompare = new CaseInsensitiveComparer();
			this.ListViewItemSorter = this;
			this.SortColumn = 0;

		}

        private CheckBox checkBox1;

        /// <summary>
        /// 获取或设置按照哪一列排序.
        /// </summary>
        public int SortColumn
		{ get; set; }

		/// <summary>
		/// 声明CaseInsensitiveComparer类对象，
		/// 参见ms-help://MS.VSCC.2003/MS.MSDNQTR.2003FEB.2052/cpref/html/frlrfSystemCollectionsCaseInsensitiveComparerClassTopic.htm
		/// </summary>
		private CaseInsensitiveComparer ObjectCompare;

		protected override void OnColumnClick(ColumnClickEventArgs e)
		{
			this.SortColumn = e.Column;
			if (this.Sorting == SortOrder.None || this.Sorting == SortOrder.Descending)
				this.Sorting = SortOrder.Ascending;
			else
				this.Sorting = SortOrder.Descending;
			this.Sort();
			//base.OnColumnClick(e);
		}

		/// <summary>
		/// 重写IComparer接口.
		/// </summary>
		/// <param name="x">要比较的第一个对象</param>
		/// <param name="y">要比较的第二个对象</param>
		/// <returns>比较的结果.如果相等返回0，如果x大于y返回1，如果x小于y返回-1</returns>
		int IComparer.Compare(object x, object y)
		{
			int compareResult;
			ListViewItem listviewX, listviewY;

			// 将比较对象转换为ListViewItem对象
			listviewX = (ListViewItem)x;
			listviewY = (ListViewItem)y;

			// 比较
			compareResult = ObjectCompare.Compare(listviewX.SubItems[SortColumn].Text, listviewY.SubItems[SortColumn].Text);

			// 根据上面的比较结果返回正确的比较结果
			if (this.Sorting == SortOrder.Ascending)
			{
				return compareResult;
			}
			else if (this.Sorting == SortOrder.Descending)
			{
				return (-compareResult);
			}
			else
			{
		
				return 0;
			}
		}

        private void InitializeComponent()
        {
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.ResumeLayout(false);

        }

    }
}
