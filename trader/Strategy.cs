using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trader.KLine;

namespace trader
{
    public class Strategy
    {
        const int N = 100 + 7;
        const int TICKINTEVAL = 5;

        //ArrayList TradeContractList = new ArrayList();
        string which;
        int[] tradestrategy = new int[N];
        int[] winstoparr = new int[N];
        int[] losestoparr = new int[N];
        double[] buyprice = new double[N];
        double[] sellprice = new double[N];

        //double[,] TradeTickPrice = new double[N, TICKINTEVAL];
        double[] tickprice = new double[N];

        int[] TradeHave = new int[N];
        public int AutoTrade;

        public Strategy() {
            for (int i = 0; i < 100; ++i)
            {
                TradeHave[i] = 0;
            }
            AutoTrade = 0;
        }

        // public void AddContract(string instrumentID) {
        //     TradeContractList.Add(instrumentID);
        // }
        public void ITick(FormTrade formTrade, ref CThostFtdcDepthMarketDataField pDepthMarketData)
        {
            if(which == pDepthMarketData.InstrumentID)
            {
                Console.WriteLine("strategy tick tradestrategy[0] = " + tradestrategy[0]);
                if (tradestrategy[0] == 1)
                {
                    tickprice[3] = tickprice[2];
                    tickprice[2] = tickprice[1];
                    tickprice[1] = tickprice[0];
                    tickprice[0] = pDepthMarketData.LastPrice;

                    //Console.WriteLine(tickprice[0] + "," + tickprice[1] + "," + tickprice[2]);

                    if (tickprice[0] > tickprice[1] && tickprice[1] > tickprice[2]
                        && tickprice[2] > tickprice[3])
                    {
                        if (TradeHave[0] == 0)
                        {
                            //3 TICK up，buy
                            formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Buy,
                                pDepthMarketData.LastPrice + 10,    //价格
                                1);
                            buyprice[0] = pDepthMarketData.LastPrice;
                            TradeHave[0] = 1;
                        }
                    }
                    else if (tickprice[0] < tickprice[1] && tickprice[1] < tickprice[2]
                        && tickprice[2] < tickprice[3])
                    {
                        //3 TICK down，Sell
                        if (TradeHave[0] == 1)
                        {
                        
                            formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Sell,
                                pDepthMarketData.LastPrice - 10,    //价格
                                1);

                            TradeHave[0] = 0;
                        }
                    }
                }
                else if (tradestrategy[0] == 2) {
                    List<CtpInfo> lists = formTrade.dbConn.QueryMarketInfo(which, 1);

                    //Console.WriteLine("database: " + lists.Count);

                    CtpInfo ctpInfo = lists[0];
                    if (lists.Count == 0)
                    {
                        return;
                    }
                    double v1 = ctpInfo.high - ctpInfo.close, v2 = ctpInfo.close - ctpInfo.low;
                    double mx = Math.Max(v1, v2);
                    double offset = mx * 0.7;

                    double todayOpen = pDepthMarketData.OpenPrice;

                    //Console.WriteLine("LastPrice = " + pDepthMarketData.LastPrice + ", " + todayOpen + "+" + offset);

                    if (TradeHave[0] == 0)
                    {    
                        if (pDepthMarketData.LastPrice > todayOpen + offset)
                        { // buy
                            buyprice[0] = pDepthMarketData.LastPrice;
                            formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Buy,
                                pDepthMarketData.LastPrice + 10,    //价格
                                1);
                            TradeHave[0] = 1;
                        }
                    }
                    else if (TradeHave[0] == 1)
                    {
                        if (pDepthMarketData.LastPrice < todayOpen - offset)
                        {
                            formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Sell,
                                pDepthMarketData.LastPrice - 10,    //价格
                                1);
                            TradeHave[0] = 0;
                        }
                        else if (pDepthMarketData.LastPrice > buyprice[0] + winstoparr[0]) { // 盈利大于预设
                            formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Sell,
                                pDepthMarketData.LastPrice - 10,    //价格
                                1);
                            TradeHave[0] = 0;
                        }
                    }
                }
            }
        }
        /*
    public void ITick(FormTrade formTrade ,ref CThostFtdcDepthMarketDataField pDepthMarketData) {
        for (int i = 0; i < TradeContractList.Count; ++i)
        {
            if (TradeContractList[i].Equals(pDepthMarketData.InstrumentID))
            {
                //formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Buy,
                //         pDepthMarketData.LastPrice + 10,    //价格
                //         1);//手数
                //Console.WriteLine(TradeContractList[i]);

                TradeTickPrice[i, 3] = TradeTickPrice[i, 2];
                TradeTickPrice[i, 2] = TradeTickPrice[i, 1];
                TradeTickPrice[i, 1] = TradeTickPrice[i, 0];
                TradeTickPrice[i, 0] = pDepthMarketData.LastPrice;

                Console.WriteLine(TradeTickPrice[i, 0] + "," + TradeTickPrice[i, 1] + "," + TradeTickPrice[i, 2]);

                if (TradeTickPrice[i, 0] > TradeTickPrice[i, 1] && TradeTickPrice[i, 1] > TradeTickPrice[i, 2]
                    && TradeTickPrice[i, 2] > TradeTickPrice[i, 3])
                {
                    if (TradeHave[i] == 0)
                    {
                        //3 TICK up，buy
                        formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Buy,
                         pDepthMarketData.LastPrice + 10,    //价格
                         1);
                        TradeHave[i] = 1;
                    }
                }
                else if (TradeTickPrice[i, 0] < TradeTickPrice[i, 1] && TradeTickPrice[i, 1] < TradeTickPrice[i, 2]
                    && TradeTickPrice[i, 2] < TradeTickPrice[i, 3])
                {
                    //3 TICK down，Sell
                    if (TradeHave[i] == 1)
                    {
                        //连续3个TICK涨，buy
                        formTrade.tradeApi.OrderInsert(pDepthMarketData.InstrumentID, EnumOffsetFlagType.Open, EnumDirectionType.Sell,
                         pDepthMarketData.LastPrice - 10,    //价格
                         1);//手数

                        TradeHave[i] = 0;
                    }
                }
            }
        }
    }
    */

        public void StartAutoTrade(string instrument, int winstopnum, int lossstopnum, int strategy)
        {
            //Console.WriteLine("Start Auto Trader:" + instrument + "  " + winstopnum + "  " + lossstopnum + "  " + strategy);
            //TradeContractList.Add(instrument);
            which = instrument;
            winstoparr[0] = winstopnum;
            losestoparr[0] = lossstopnum;
            tradestrategy[0] = strategy;
        }
    }
}
