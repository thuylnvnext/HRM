using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using Database;

namespace Attendance.Classes
{
    public class PollingData
    {
        private DateTime dateTime;
        private string cardID;

        public PollingData(DateTime dateTime, string cardID)
        {
            this.dateTime = dateTime;
            this.cardID = cardID;
        }
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }
        public string CardID
        {
            get
            {
                return cardID;
            }
            set
            {
                cardID = value;
            }
        }
    }

    public class PollList : ArrayList
    {
        public PollList()
            : base()
        {
        }
        public new PollingData this[int index]
        {
            get
            {
                return (PollingData)base[index];
            }
        }
    }

    public class LogData
    {
        private DateTime dateTime;
        private string cardID;

        public LogData(DateTime dateTime, string cardID)
        {
            this.dateTime = dateTime;
            this.cardID = cardID;
        }
        public DateTime DateTime
        {
            get
            {
                return dateTime;
            }
        }
        public string CardID
        {
            get
            {
                return cardID;
            }
            set
            {
                cardID = value;
            }
        }
    }

    public class LogDataList : ArrayList
    {
        public LogDataList()
            : base()
        {
        }
        public new LogData this[int index]
        {
            get
            {
                return (LogData)base[index];
            }
        }
    }

    public class Reader
    {
        [DllImport("HTA8.dll")]
        private static extern int htaOpenChannel(out IntPtr hComm, string sComm, UInt32 iPort);

        [DllImport("HTA8.dll")]
        private static extern int htaCloseChannel(IntPtr hComm);

        [DllImport("HTA8.dll")]
        private static extern int htaPolling(IntPtr hComm, int iNodeID, int iPrevRecord, out byte stRecord, out int iRecord, int iCardType, UInt32 iTimeOut);

        [DllImport("HTA8.dll")]
        private static extern int htaGetLogData(IntPtr hComm, int iNodeID, out byte sLogData, out int iLogLen, int iBank, int iCompress, UInt32 iTimeOut);

        [DllImport("HTA8.dll")]
        private static extern int htaDeleteAllLog(IntPtr hComm, int iNodeID, UInt32 iTimeOut);

        [DllImport("HTA8.dll")]
        private static extern int htaGetDateTime(IntPtr hComm, int iNodeID, out byte bDate, out byte bTime, UInt32 iTimeOut);

        [DllImport("HTA8.dll")]
        private static extern int htaSetDateTime(IntPtr hComm, int iNodeID, string sDate, string sTime, UInt32 iTimeOut);

        [DllImport("HTA8.dll")]
        private static extern int htaGetMemoryData(IntPtr hComm, int iNodeID, out byte bMemData, out int iReceiveLen, int iMemAddr, int iMemLen, UInt32 iTimeOut);

        private const int TIMEOUT = 1000;

        private IntPtr handle = IntPtr.Zero;
        private int iD;
        private string comm;
        private UInt32 port;
        private bool compress;

        public Reader(int iD, string comm, UInt32 port, bool compress)
        {
            this.iD = iD;
            this.comm = comm;
            this.port = port;
            this.compress = compress;
        }

        public int Open()
        {
            return htaOpenChannel(out handle, comm, port);
        }

        public DateTime GetDateTime()
        {
            byte[] date = new byte[9], time = new byte[6];
            int year = 0, month = 0, day = 0, hour = 0, minute = 0, second = 0;

            if (htaGetDateTime(handle, iD, out date[0], out time[0], TIMEOUT) == 0)
            {
                year = Convert.ToInt32(((char)date[0]).ToString() + ((char)date[1]).ToString() + ((char)date[2]).ToString() + ((char)date[3]).ToString());
                month = Convert.ToInt32(((char)date[4]).ToString() + ((char)date[5]).ToString());
                day = Convert.ToInt32(((char)date[6]).ToString() + ((char)date[7]).ToString());
                hour = Convert.ToInt32(((char)time[0]).ToString() + ((char)time[1]).ToString());
                minute = Convert.ToInt32(((char)time[2]).ToString() + ((char)time[3]).ToString());
                second = Convert.ToInt32(((char)time[4]).ToString() + ((char)time[5]).ToString());
            }

            return new DateTime(year, month, day, hour, minute, second);
        }

        public int SetDateTime(DateTime dateTime)
        {
            string date = string.Empty, time = string.Empty, dayOfWeek = string.Empty;

            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dayOfWeek = "2";
                    break;
                case DayOfWeek.Tuesday:
                    dayOfWeek = "3";
                    break;
                case DayOfWeek.Wednesday:
                    dayOfWeek = "4";
                    break;
                case DayOfWeek.Thursday:
                    dayOfWeek = "5";
                    break;
                case DayOfWeek.Friday:
                    dayOfWeek = "6";
                    break;
                case DayOfWeek.Saturday:
                    dayOfWeek = "7";
                    break;
                case DayOfWeek.Sunday:
                    dayOfWeek = "1";
                    break;
            }
            date = dateTime.Year.ToString() + dateTime.Month.ToString("00") + dateTime.Day.ToString("00") + dayOfWeek;
            time = dateTime.Hour.ToString("00") + dateTime.Minute.ToString("00") + dateTime.Second.ToString("00");

            return htaSetDateTime(handle, iD, date, time, TIMEOUT);
        }

        public int Close()
        {
            return htaCloseChannel(handle);
        }

        public int GetSwipedCards()
        {
            byte[] memData = new byte[2];
            int receiveLen;
            htaGetMemoryData(handle, iD, out memData[0], out receiveLen, 226, 2, TIMEOUT);

            return Convert.ToInt32(Convert.ToString(memData[0], 16) + Convert.ToString(memData[1], 16), 16);
        }

        public LogDataList GetLogData()
        {
            LogDataList logDataList = new LogDataList();
            byte[] logData = new byte[512];
            int retVal, logLen = 0, bank = 0, year = 0, month = 0, day = 0, hour = 0, minute = 0, second = 0;
            DateTime dateTime;
            string data = string.Empty, binary = string.Empty, cardID = string.Empty, endData = string.Empty;
            bool error = false;
            while (endData != "FFFFFFFFFFFFFFFFFF")
            {
                retVal = htaGetLogData(handle, iD, out logData[0], out logLen, bank++, compress ? 1 : 0, TIMEOUT);
                for (int i = 0; i < logLen; i++)
                {
                    if (logData[i] == 255)
                        endData += "FF";
                    else
                        endData = string.Empty;
                    if (endData == "FFFFFFFFFFFFFFFFFF") break;
                    data += logData[i].ToString("X2");
                }
            }
            string[] _data = data.Split(new string[] { "FFFF" }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string d in _data)
            {
                error = false;
                try
                {
                    binary = Convert.ToString(Convert.ToInt32(d.Substring(8, 2) + d.Substring(6, 2) + d.Substring(4, 2) + d.Substring(2, 2), 16), 2).PadLeft(32, '0');
                    year = Convert.ToInt32(binary.Substring(0, 6), 2) + 2000;
                    month = Convert.ToInt32(binary.Substring(6, 4), 2);
                    day = Convert.ToInt32(binary.Substring(10, 5), 2);
                    hour = Convert.ToInt32(binary.Substring(15, 5), 2);
                    minute = Convert.ToInt32(binary.Substring(20, 6), 2);
                    second = Convert.ToInt32(binary.Substring(26, 6), 2);
                }
                catch
                {
                    error = true;
                }
                try
                {
                    dateTime = new DateTime(year, month, day, hour, minute, second);
                }
                catch
                {
                    dateTime = DateTime.MinValue;
                    error = true;
                }
                try
                {
                    cardID = d.Substring(10, 10);
                }
                catch
                {
                    error = true;
                }
                if (!error) logDataList.Add(new LogData(dateTime, cardID));
            }

            return logDataList;
        }

        public bool DeleteAllLog()
        {
            if (htaDeleteAllLog(handle, iD, TIMEOUT) == 0)
                return true;
            else
                return false;
        }

        public PollList Polling()
        {
            PollList pollList = new PollList();
            byte[] buf = new byte[255 * 60];
            int retVal, record = 0, year, month, day, hour, minute, second;
            DateTime dateTime;
            string cardID = string.Empty;

            try
            {
                retVal = htaPolling(handle, iD, record, out buf[0], out record, 1, TIMEOUT);
                while (retVal == 0)
                {
                    for (int r = 0; r < record; r++)
                    {
                        year = Convert.ToInt32(((char)buf[r * 60 + 8]).ToString() + ((char)buf[r * 60 + 9]).ToString() + ((char)buf[r * 60 + 10]).ToString() + ((char)buf[r * 60 + 11]).ToString());
                        month = Convert.ToInt32(((char)buf[r * 60 + 13]).ToString() + ((char)buf[r * 60 + 14]).ToString());
                        day = Convert.ToInt32(((char)buf[r * 60 + 16]).ToString() + ((char)buf[r * 60 + 17]).ToString());
                        hour = Convert.ToInt32(((char)buf[r * 60 + 19]).ToString() + ((char)buf[r * 60 + 20]).ToString());
                        minute = Convert.ToInt32(((char)buf[r * 60 + 22]).ToString() + ((char)buf[r * 60 + 23]).ToString());
                        second = Convert.ToInt32(((char)buf[r * 60 + 25]).ToString() + ((char)buf[r * 60 + 26]).ToString());
                        dateTime = new DateTime(year, month, day, hour, minute, second);
                        cardID = string.Empty;
                        for (int i = 28; i <= 47; i++)
                            if ((char)buf[r * 60 + i] != '\0') cardID += ((char)buf[r * 60 + i]).ToString();

                        pollList.Add(new PollingData(dateTime, cardID));
                    }
                    retVal = htaPolling(handle, iD, record, out buf[0], out record, 1, TIMEOUT);
                }
            }
            catch
            {
            }
            return pollList;
        }
    }
}
