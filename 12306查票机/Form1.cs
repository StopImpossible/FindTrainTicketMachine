using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12306查票机
{

    public partial class LookInto : Form
    {
        public LookInto()
        {
            InitializeComponent();
            
            Second = new List<CheckBox>();
            Second.Add(FirstSeat);
            Second.Add(SecondSeat);
            Second.Add(rw_num);
            Second.Add(yw_num);
            Second.Add(yz_num);
            Second.Add(wz_num);

            First = new List<CheckBox>();
            First.Add(GTrain);
            First.Add(DTrain);
            First.Add(ZTrain);
            First.Add(TTrain);
            First.Add(KTrain);
            First.Add(OTrain);

            stationList = new List<Station>();
            FileStream file = File.OpenRead("trainStation.txt");
            StreamReader sr = new StreamReader(file, Encoding.GetEncoding("gb2312"));
            string s, final = "";
            while ((s = sr.ReadLine()) != null)
            {
                final += s;
            }
            
            string name, code;
            int position1 = 0, position2 = 0, position3 = 0, number;
            Station station1;
            number = final.LastIndexOf('；');
            position1 = final.IndexOf('、');
            position2 = final.IndexOf('；');
            name = final.Substring(0, position1);
            code = final.Substring(position1 + 1, position2 - position1 - 1);
            station1 = new Station(name, code);
            stationList.Add(station1);
            for (; ; )
            {
                position3 = position2 + 1;
                position1 = final.IndexOf('、', position3);
                position2 = final.IndexOf('；', position3);
                name = final.Substring(position3, position1 - position3);
                code = final.Substring(position1 + 1, position2 - position1 - 1);
                station1 = new Station(name, code);
                stationList.Add(station1);
                if (position2 == number)
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Height = 500;
            this.Width = 1050;
            trainTicket.BackgroundColor = Color.LightBlue;
            trainTicket.BorderStyle = BorderStyle.None;
            yz_num.Visible = false;
            yw_num.Visible = false;
            rw_num.Visible = false;
            wz_num.Visible = false;
        }

        private void LeaveDate_TextChanged(object sender, EventArgs e)
        {
            monthCalendar1.Visible = true;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            string date1 = e.Start.ToString();
            int position1 = date1.IndexOf(' ');
            string date2 = date1.Substring(0, position1);
            int position2, position3;
            position2 = date1.IndexOf('/');
            position3 = date2.LastIndexOf('/');
            date2 = date2.Replace('/', '-');
            if (date2.Count() - position3 == 2)
                date2 = date2.Insert(position3 + 1, "0");
            if (position3 - position2 == 2)
                date2 = date2.Insert(position2 + 1, "0");
            LeaveDate.Text = date2;
            monthCalendar1.Visible = false;
        }

        private void look_Click(object sender, EventArgs e)
        {
            trainTicket.RowCount = 0;
            State.Text = "";
            LeaveStation.Text = LeaveStation.Text.Replace(" ", "");
            AimStation.Text = AimStation.Text.Replace(" ", "");
            if (LeaveStation.Text == string.Empty || AimStation.Text == string.Empty || LeaveDate.Text == string.Empty)
            {
                State.Text = "请输入相应参数";
                return;
            }
            int count1 = 0, count2 = 0;
            string fromStation = "";
            string toStation = "";
            for (int i = 0; i < stationList.Count; i++)
            {
                if (stationList[i].chinese == LeaveStation.Text)
                {
                    fromStation = stationList[i].code;
                    count1++;
                }
                if (stationList[i].chinese == AimStation.Text)
                {
                    toStation = stationList[i].code;
                    count2++;
                }
                if (count1 == 1 && count2 == 1)
                    break;
            }
            if (count1 == 0 && count2 == 0)
            {
                State.Text = "输入的出发地和出发地均不存在";
                LeaveStation.Text = string.Empty;
                AimStation.Text = string.Empty;
            }
            else if (count2 == 0)
            {
                State.Text = "输入的目的地不存在";
                AimStation.Text = string.Empty;
            }
            else if (count1 == 0)
            {
                State.Text = "输入的出发地不存在";
                LeaveStation.Text = string.Empty;
            }
            int BJFirst = 0;
            for (int i = 0; i < First.Count(); i++)
            {
                if (First[i].Checked)
                    BJFirst = 1;
            }


            string Url;
            Url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + LeaveDate.Text + "&from_station=" + fromStation + "&to_station=" + toStation;
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(Url);
            req.Method = "GET";
            System.Net.ServicePointManager.ServerCertificateValidationCallback += (se, cert, chain, sslerror) =>
            {
                return true;
            };
            HttpWebResponse res = (HttpWebResponse)req.GetResponse();
            Stream resst = res.GetResponseStream();
            StreamReader sr = new StreamReader(resst);
            string str = sr.ReadToEnd();
            State.Text = "开始处理";

            int site1 = 0, site2 = 1, lastSite;
            string getString = "";
            lastSite = str.LastIndexOf("station_train_code");
            List<TrainInformation> show = new List<TrainInformation>();
            TrainInformation trainInformation;
            for (; ; )
            {
                site1 = str.IndexOf("station_train_code", site2 - 1);
                if (site1 == lastSite)
                {
                    getString = str.Substring(site1, str.Count() - site1);
                    trainInformation = new TrainInformation(getString);
                    if (BJFirst == 1)
                    {
                        for (int number1 = 0; number1 < 6; number1++)
                        {
                            if (First[number1].Checked && number1 == 0)
                            {
                                if (trainInformation.trainCode[0] == 'G' && trainInformation.trainCode[0] == 'C')
                                {
                                    show.Add(trainInformation);
                                    break;
                                }
                            }
                            else if (First[number1].Checked && number1 == 5)
                            {
                                if (trainInformation.trainCode[0] != 'G' ||
                                    trainInformation.trainCode[0] != 'C' ||
                                    trainInformation.trainCode[0] != 'T' ||
                                    trainInformation.trainCode[0] != 'Z' ||
                                    trainInformation.trainCode[0] != 'k' ||
                                    trainInformation.trainCode[0] != 'D')
                                {
                                    show.Add(trainInformation);
                                    break;
                                }
                            }
                            else
                            {
                                if (First[number1].Checked && trainInformation.trainCode[0] == First[number1].Name[0])
                                {
                                    show.Add(trainInformation);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        show.Add(trainInformation);
                    }
                    break;
                }
                else
                {
                    site2 = str.IndexOf("station_train_code", site1 + 20);
                    getString = str.Substring(site1, site2 - site1 - 1);
                    trainInformation = new TrainInformation(getString);
                    if (BJFirst == 1)
                    {
                        for (int number1 = 0; number1 < 6; number1++)
                        {
                            if (First[number1].Checked && number1 == 0)
                            {
                                if (trainInformation.trainCode[0] == 'G' || trainInformation.trainCode[0] == 'C')
                                {
                                    show.Add(trainInformation);
                                    break;
                                }
                            }
                            else if (First[number1].Checked && number1 == 5)
                            {
                                if (trainInformation.trainCode[0] != 'G' ||
                                    trainInformation.trainCode[0] != 'C' ||
                                    trainInformation.trainCode[0] != 'T' ||
                                    trainInformation.trainCode[0] != 'Z' ||
                                    trainInformation.trainCode[0] != 'k' ||
                                    trainInformation.trainCode[0] != 'D')
                                {
                                    show.Add(trainInformation);
                                    break;
                                }
                            }
                            else
                            {
                                if (First[number1].Checked && trainInformation.trainCode[0] == First[number1].Name[0])
                                {
                                    show.Add(trainInformation);
                                    break;
                                }
                            }
                        }
                    }
                    else
                    {
                        show.Add(trainInformation);
                    }
                }

            }


            if (DeepSearch.Checked == false)
            {
                for (int i = 0; i < show.Count(); i++)
                {
                    trainTicket.Rows.Add(show[i].trainCode,
                        show[i].fromStationName + " " + show[i].toStationName,
                        show[i].startTime + " " + show[i].arriveTime,
                        show[i].spendTime,
                        show[i].BusinessTicket,
                        show[i].TopGradeTicket,
                        show[i].FirstClassTicket,
                        show[i].SecondClassTicket,
                        show[i].AdvancedSoftSleeperTicket,
                        show[i].SoftSleeperTicket,
                        show[i].HardSleeperTicket,
                        show[i].SoftSeatTicket,
                        show[i].HardSeatTicket,
                        show[i].NoneSeatTicket,
                        show[i].Other);
                }
            }
            else
            {
                int m = 0;
                foreach (var s in show)
                {
                    List<string> ticket = new List<string>();
                    ticket.Add(s.FirstClassTicket);
                    ticket.Add(s.SecondClassTicket);
                    ticket.Add(s.SoftSleeperTicket);
                    ticket.Add(s.HardSleeperTicket);
                    ticket.Add(s.HardSeatTicket);
                    ticket.Add(s.NoneSeatTicket);
                    for (int j = 0; j < 6; j++)
                    {
                        if (ticket[j] != "--" && Second[j].Checked)
                        {
                            trainTicket.Rows.Add(
                        s.trainCode,
                        s.fromStationName + " " + s.toStationName,
                        s.startTime + " " + s.arriveTime,
                        s.spendTime,
                        s.BusinessTicket,
                        s.TopGradeTicket,
                        s.FirstClassTicket,
                        s.SecondClassTicket,
                        s.AdvancedSoftSleeperTicket,
                        s.SoftSleeperTicket,
                        s.HardSleeperTicket,
                        s.SoftSeatTicket,
                        s.HardSeatTicket,
                        s.NoneSeatTicket,
                        s.Other);
                            m = 1;
                        }
                    }
                }
                if (m == 1)
                    return;




            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (DeepSearch.Checked == true)
            {
                trainTicket.Location = new Point(12, 200);
                FirstSeat.Visible = true;
                SecondSeat.Visible = true;
                rw_num.Visible = true;
                yz_num.Visible = true;
                yw_num.Visible = true;
                yw_num.Checked = true;
                wz_num.Visible = true;
            }
            else
            {
                trainTicket.Location = new Point(12, 170);
                FirstSeat.Visible = false;
                SecondSeat.Visible = false;
                rw_num.Visible = false;
                yz_num.Visible = false; 
                yw_num.Visible = false;
                wz_num.Visible = false;
            }
        }

    }
}
