using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace _12306查票机
{
    public class SearchTrain
    {
        public string fromStation { get; set; }
        public string fromStationCode { get; set; }
        public string toStation { get; set; }
        public string toStationCode { get; set; }
        public string Date { get; set; }
        public string trainNo { get; set; }
        public List<string> UpTrain { get; set; }
        public List<string> DownTrain { get; set; }

        public SearchTrain(string fromStation, string toStation, string trainNo, string fromStationCode, string toStationCode,string Date)
        {
            this.fromStation = fromStation;
            this.toStation = toStation;
            this.trainNo = trainNo;
            this.fromStationCode = fromStationCode;
            this.toStationCode = toStationCode;
            this.Date = Date;
        }

        public TrainInformation GetTrain(List<Station> stationList)
        {
            string Url1 = "https://kyfw.12306.cn/otn/czxx/queryByTrainNo?train_no=" + trainNo + "&from_station_telecode=" + fromStationCode + "&to_station_telecode=" + toStationCode + "&depart_date=" + Date;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url1);
            req.Method = "GET";
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
            {
                return true;
            };
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream resst = res.GetResponseStream();
            StreamReader sr = new StreamReader(resst);
            string str = sr.ReadToEnd();

            List<String> stationNameList = new List<string>();
            JSON GetName = new JSON("station_name");
            for (; ; )
            {

            }
        }
    }
}
