using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trader.KLine
{
    public class CtpInfo
    {
        /// <summary>
        /// 时间
        /// </summary>
        public DateTime date { get; set; }

        /// <summary>
        /// 开盘价
        /// </summary>
        public double open { get; set; }
        /// <summary>
        /// 最高价
        /// </summary>
        public double high { get; set; }
        /// <summary>
        /// 最低价
        /// </summary>
        public double low { get; set; }
        /// <summary>
        /// 收盘价
        /// </summary>
        public double close { get; set; }

        /// <summary>
        /// 成交量
        /// </summary>
        public double volume { get; set; }
        /// <summary>
        /// 持仓量
        /// </summary>
        public double hold { get; set; }
    }
    public enum TimeFrame { tick = 0, M1, M5, M15, M30, H1, D1, W1, Mn1, Y1 };



}
