using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trader.KLine;

namespace trader
{
    public class DBConn
    {
        public void testfile()
        {
            StreamReader sr = new StreamReader("C:\\Users\\Jack\\Desktop\\ag1805out.txt", Encoding.Default);
            string line;
            try
            {
                sqlConnection.Open();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] info = line.Split(' ');
                    AddMarketInfo("ag1805", info[0], Convert.ToDouble(info[1]), Convert.ToDouble(info[2]),
                        Convert.ToDouble(info[3]), Convert.ToDouble(info[4]));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
        }


        private static DBConn DBinstance;

        string connetStr = "server=118.25.104.17;port=3306;user=root;password=snqwyy; database=trader;SslMode=none";
        public MySqlConnection sqlConnection;
        public DBConn() {
            sqlConnection = new MySqlConnection(connetStr);
            //QueryMarketInfo("ag1805", 3);
        }

        public void AddMarketInfo(string instrument_id, string data, double open, double high, double low, double close) {
         
            string olddata = "null";
            string sql;
            try
            {
                sqlConnection.Open();
                sql = "SELECT * FROM market WHERE instrument_id = '" + instrument_id + "' ORDER BY m_data DESC LIMIT 0, 1";
                //Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())//init index -1
                {
                    /*Console.WriteLine(reader.GetString("instrument_id") + "  " + reader.GetString("m_data") +
                        " " + reader.GetDouble("m_open") +
                        " " + reader.GetDouble("m_high") +
                        " " + reader.GetDouble("m_low") +
                        " " + reader.GetDouble("m_close"));*/
                    olddata = reader.GetString("m_data");
                    olddata = olddata.Split(' ')[0];
                }
                //Console.WriteLine("data = " + data + ", olddata = " + olddata);
            }
            finally
            {
                 
                sqlConnection.Close();
            }

            try
            {
                sqlConnection.Open();
                /*
                int same = 1;
                string[] dataarr = data.Split('-');
                string[] olddataarr = data.Split('/');
                for (int i = 0; i < 3; ++i) {
                    if (Convert.ToInt32(dataarr[i]) != Convert.ToInt32(olddataarr[i])) {
                        same = 0;
                        break;
                    }
                }
                */
                if (olddata != data)
                {
                    //Console.WriteLine("insert = " + instrument_id + "','" + data + "'," + open + ", " + high + "," + low + "," + close);
                    sql = "insert into market(instrument_id, m_data, m_open, m_high, m_low, m_close) values ('" +
                        instrument_id + "','" + data + "'," + open + ", " + high + "," + low + "," + close + ")";
                    //Console.WriteLine(sql);
                    //MySqlCommand command = new MySqlCommand(sql, sqlConnection);
                    //command.ExecuteNonQuery();
                }
            }finally{
                sqlConnection.Close();
            }
            
            
        }
        public void AddAcountInfo(string brokerID, string accountID, double closeProfit, double positionProfit, double balance, string v)
        {
            try
            {
                sqlConnection.Open();
                string sql = "insert into account_info(Broker_ID, Account_ID, Close_Profit, Position_Profit, Balance, m_date) values ('" +
                        brokerID + "','" + accountID + "'," + closeProfit + ", " + positionProfit + "," + balance + ",'" + v + "')";
                //Console.WriteLine(sql);
                MySqlCommand command = new MySqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();
            }
            finally {
                sqlConnection.Close();
            }
        }
   

        public List<CtpInfo> QueryMarketInfo(string instrument_id, int count) {
            List<CtpInfo> lists = new List<CtpInfo>();
            try
            {
                sqlConnection.Open();
                string sql = "SELECT * FROM market WHERE instrument_id = '" + instrument_id + "' ORDER BY m_data DESC LIMIT 0, " + count;
                //Console.WriteLine(sql);
                MySqlCommand cmd = new MySqlCommand(sql, sqlConnection);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())//init index -1
                {
                    /*Console.WriteLine(reader.GetString("instrument_id") + "  " + reader.GetString("m_data") +
                        " " + reader.GetDouble("m_open") +
                        " " + reader.GetDouble("m_high") +
                        " " + reader.GetDouble("m_low") +
                        " " + reader.GetDouble("m_close"));*/
                    string data = reader.GetString("m_data");
                    double m_open = reader.GetDouble("m_open");
                    double m_high = reader.GetDouble("m_high");
                    double m_low = reader.GetDouble("m_low");
                    double m_close = reader.GetDouble("m_close");
                    CtpInfo info = new CtpInfo();
                    info.date = Convert.ToDateTime(data);
                    info.open = m_open;
                    info.high = m_high;
                    info.low = m_low;
                    info.close = m_close;
                    lists.Add(info);

                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                sqlConnection.Close();
            }
            return lists;
        }

        public void AddTrader(string investorID, string instrumentID, string tradeTime, string orderRef, string tradeID, double price, int volume, EnumOffsetFlagType offsetFlag, EnumDirectionType direction, CThostFtdcTradeField pTrade)
        {
            try
            {
                sqlConnection.Open();
                string sql = "insert into trader(investorID, instrumentID, tradeTime, orderRef, tradeID, price, volume" +
                    ",offsetFlag,direction) values ('" +
                        investorID + "','" + instrumentID + "','" + tradeTime + "', '" + orderRef + "','" + tradeID + "'," + price + "," +
                        volume + "," + (offsetFlag == EnumOffsetFlagType.Open ? 0 : 1) + "," + (direction == EnumDirectionType.Buy ? 0 : 1) + ")";
                //Console.WriteLine(sql);
                MySqlCommand command = new MySqlCommand(sql, sqlConnection);
                command.ExecuteNonQuery();

            }
            finally {
                sqlConnection.Close();
            }

        }

        public void AddTraderResult(CThostFtdcTradeField pTrade)
        {
            try
            {
                sqlConnection.Open();
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}
