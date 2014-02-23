using System;
using System.Collections.Generic;

namespace FreeQuant.QuantRouterLib.Data
{
    public class BrokerPosition
    {
        private string w4Bu6TX4jY;
        private string jIyuaxH31X;
        private string WAouGOUGDd;
        private string Va4uk7htSh;
        private DateTime rlKu3i5Hq2;
        private int Ku8uRTIaXL;
        private double iulufI5D1D;
        private double h6bu00fIoi;
        private double lxduUlk6Q3;
        private double lpCuONpjxD;
        private SortedList<string, string> Qebu97XTcP;

        public string Symbol
        {
             get
            {
                return this.w4Bu6TX4jY;
            }
             set
            {
                this.w4Bu6TX4jY = value;
            }
        }

        public string SecurityType
        {
             get
            {
                return this.jIyuaxH31X;
            }
             set
            {
                this.jIyuaxH31X = value;
            }
        }

        public string SecurityExchange
        {
             get
            {
                return this.WAouGOUGDd;
            }
             set
            {
                this.WAouGOUGDd = value;
            }
        }

        public string Currency
        {
             get
            {
                return this.Va4uk7htSh;
            }
             set
            {
                this.Va4uk7htSh = value;
            }
        }

        public DateTime MaturityDate
        {
             get
            {
                return this.rlKu3i5Hq2;
            }
             set
            {
                this.rlKu3i5Hq2 = value;
            }
        }

        public int PutOrCall
        {
             get
            {
                return this.Ku8uRTIaXL;
            }
             set
            {
                this.Ku8uRTIaXL = value;
            }
        }

        public double Strike
        {
             get
            {
                return this.iulufI5D1D;
            }
             set
            {
                this.iulufI5D1D = value;
            }
        }

        public double Qty
        {
             get
            {
                return this.h6bu00fIoi;
            }
             set
            {
                this.h6bu00fIoi = value;
            }
        }

        public double LongQty
        {
             get
            {
                return this.lxduUlk6Q3;
            }
             set
            {
                this.lxduUlk6Q3 = value;
            }
        }

        public double ShortQty
        {
             get
            {
                return this.lpCuONpjxD;
            }
             set
            {
                this.lpCuONpjxD = value;
            }
        }

        
        public BrokerPosition() : base()
        {
            this.w4Bu6TX4jY = string.Empty;
            this.jIyuaxH31X = string.Empty;
            this.WAouGOUGDd = string.Empty;
            this.Va4uk7htSh = string.Empty;
            this.rlKu3i5Hq2 = DateTime.MinValue;
            this.Ku8uRTIaXL = 0;
            this.iulufI5D1D = 0.0;
            this.h6bu00fIoi = 0.0;
            this.lxduUlk6Q3 = 0.0;
            this.lpCuONpjxD = 0.0;
            this.Qebu97XTcP = new SortedList<string, string>();
        }

        
        public void AddCustomField(string name, string value)
        {
            this.Qebu97XTcP.Add(name, value);
        }

        
        public BrokerPositionField[] GetCustomFields()
        {
            List<BrokerPositionField> list = new List<BrokerPositionField>();
            foreach (KeyValuePair<string, string> keyValuePair in this.Qebu97XTcP)
                list.Add(new BrokerPositionField(keyValuePair.Key, keyValuePair.Value));
            return list.ToArray();
        }
    }
}
