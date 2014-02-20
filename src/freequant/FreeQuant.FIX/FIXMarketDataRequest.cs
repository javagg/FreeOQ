using System;
using System.Collections;

namespace FreeQuant.FIX
{
    public class FIXMarketDataRequest : FIXMessage
    {
        private ArrayList DQehr3BXSn;
        private ArrayList w06hpr4a3K;
        private ArrayList t4nhMyJTee;
        private ArrayList e29hvGfn75;
        private ArrayList tcehdiDknj;

        [FIXField("144", EFieldOption.Optional)]
        public string OnBehalfOfLocationID
        {
            get
            {
                return this.GetStringValue(144);
            }
            set
            {
                this.SetStringValue(144, value);
            }
        }

        [FIXField("9", EFieldOption.Required)]
        public int BodyLength
        {
            get
            {
                return this.GetIntValue(9);
            }
            set
            {
                this.SetIntValue(9, value);
            }
        }

        [FIXField("35", EFieldOption.Required)]
        public string MsgType
        {
            get
            {
                return this.GetStringValue(35);
            }
            set
            {
                this.SetStringValue(35, value);
            }
        }

        [FIXField("49", EFieldOption.Required)]
        public string SenderCompID
        {
            get
            {
                return this.GetStringValue(49);
            }
            set
            {
                this.SetStringValue(49, value);
            }
        }

        [FIXField("56", EFieldOption.Required)]
        public string TargetCompID
        {
            get
            {
                return this.GetStringValue(56);
            }
            set
            {
                this.SetStringValue(56, value);
            }
        }

        [FIXField("115", EFieldOption.Optional)]
        public string OnBehalfOfCompID
        {
            get
            {
                return this.GetStringValue(115);
            }
            set
            {
                this.SetStringValue(115, value);
            }
        }

        [FIXField("128", EFieldOption.Optional)]
        public string DeliverToCompID
        {
            get
            {
                return this.GetStringValue(128);
            }
            set
            {
                this.SetStringValue(128, value);
            }
        }

        [FIXField("90", EFieldOption.Optional)]
        public int SecureDataLen
        {
            get
            {
                return this.GetIntValue(90);
            }
            set
            {
                this.SetIntValue(90, value);
            }
        }

        [FIXField("91", EFieldOption.Optional)]
        public string SecureData
        {
            get
            {
                return this.GetStringValue(91);
            }
            set
            {
                this.SetStringValue(91, value);
            }
        }

        [FIXField("34", EFieldOption.Required)]
        public int MsgSeqNum
        {
            get
            {
                return this.GetIntValue(34);
            }
            set
            {
                this.SetIntValue(34, value);
            }
        }

        [FIXField("50", EFieldOption.Optional)]
        public string SenderSubID
        {
            get
            {
                return this.GetStringValue(50);
            }
            set
            {
                this.SetStringValue(50, value);
            }
        }

        [FIXField("142", EFieldOption.Optional)]
        public string SenderLocationID
        {
            get
            {
                return this.GetStringValue(142);
            }
            set
            {
                this.SetStringValue(142, value);
            }
        }

        [FIXField("57", EFieldOption.Optional)]
        public string TargetSubID
        {
            get
            {
                return this.GetStringValue(57);
            }
            set
            {
                this.SetStringValue(57, value);
            }
        }

        [FIXField("8", EFieldOption.Required)]
        public string BeginString
        {
            get
            {
                return this.GetStringValue(8);
            }
            set
            {
                this.SetStringValue(8, value);
            }
        }

        [FIXField("116", EFieldOption.Optional)]
        public string OnBehalfOfSubID
        {
            get
            {
                return this.GetStringValue(116);
            }
            set
            {
                this.SetStringValue(116, value);
            }
        }

        [FIXField("129", EFieldOption.Optional)]
        public string DeliverToSubID
        {
            get
            {
                return this.GetStringValue(129);
            }
            set
            {
                this.SetStringValue(129, value);
            }
        }

        [FIXField("145", EFieldOption.Optional)]
        public string DeliverToLocationID
        {
            get
            {
                return this.GetStringValue(145);
            }
            set
            {
                this.SetStringValue(145, value);
            }
        }

        [FIXField("43", EFieldOption.Optional)]
        public bool PossDupFlag
        {
            get
            {
                return this.GetBoolValue(43);
            }
            set
            {
                this.SetBoolValue(43, value);
            }
        }

        [FIXField("97", EFieldOption.Optional)]
        public bool PossResend
        {
            get
            {
                return this.GetBoolValue(97);
            }
            set
            {
                this.SetBoolValue(97, value);
            }
        }

        [FIXField("52", EFieldOption.Optional)]
        public DateTime SendingTime
        {
            get
            {
                return this.GetDateTimeValue(52);
            }
            set
            {
                this.SetDateTimeValue(52, value);
            }
        }

        [FIXField("122", EFieldOption.Optional)]
        public DateTime OrigSendingTime
        {
            get
            {
                return this.GetDateTimeValue(122);
            }
            set
            {
                this.SetDateTimeValue(122, value);
            }
        }

        [FIXField("212", EFieldOption.Optional)]
        public int XmlDataLen
        {
            get
            {
                return this.GetIntValue(212);
            }
            set
            {
                this.SetIntValue(212, value);
            }
        }

        [FIXField("213", EFieldOption.Optional)]
        public string XmlData
        {
            get
            {
                return this.GetStringValue(213);
            }
            set
            {
                this.SetStringValue(213, value);
            }
        }

        [FIXField("347", EFieldOption.Optional)]
        public string MessageEncoding
        {
            get
            {
                return this.GetStringValue(347);
            }
            set
            {
                this.SetStringValue(347, value);
            }
        }

        [FIXField("369", EFieldOption.Optional)]
        public int LastMsgSeqNumProcessed
        {
            get
            {
                return this.GetIntValue(369);
            }
            set
            {
                this.SetIntValue(369, value);
            }
        }

        [FIXField("627", EFieldOption.Optional)]
        public int NoHops
        {
            get
            {
                return this.GetIntValue(627);
            }
            set
            {
                this.SetIntValue(627, value);
            }
        }

        [FIXField("143", EFieldOption.Optional)]
        public string TargetLocationID
        {
            get
            {
                return this.GetStringValue(143);
            }
            set
            {
                this.SetStringValue(143, value);
            }
        }

        [FIXField("262", EFieldOption.Required)]
        public string MDReqID
        {
            get
            {
                return this.GetStringValue(262);
            }
            set
            {
                this.SetStringValue(262, value);
            }
        }

        [FIXField("263", EFieldOption.Required)]
        public char SubscriptionRequestType
        {
            get
            {
                return this.GetCharValue(263);
            }
            set
            {
                this.SetCharValue(263, value);
            }
        }

        [FIXField("264", EFieldOption.Required)]
        public int MarketDepth
        {
            get
            {
                return this.GetIntValue(264);
            }
            set
            {
                this.SetIntValue(264, value);
            }
        }

        [FIXField("265", EFieldOption.Optional)]
        public int MDUpdateType
        {
            get
            {
                return this.GetIntValue(265);
            }
            set
            {
                this.SetIntValue(265, value);
            }
        }

        [FIXField("266", EFieldOption.Optional)]
        public bool AggregatedBook
        {
            get
            {
                return this.GetBoolValue(266);
            }
            set
            {
                this.SetBoolValue(266, value);
            }
        }

        [FIXField("286", EFieldOption.Optional)]
        public string OpenCloseSettlFlag
        {
            get
            {
                return this.GetStringValue(286);
            }
            set
            {
                this.SetStringValue(286, value);
            }
        }

        [FIXField("546", EFieldOption.Optional)]
        public string Scope
        {
            get
            {
                return this.GetStringValue(546);
            }
            set
            {
                this.SetStringValue(546, value);
            }
        }

        [FIXField("547", EFieldOption.Optional)]
        public bool MDImplicitDelete
        {
            get
            {
                return this.GetBoolValue(547);
            }
            set
            {
                this.SetBoolValue(547, value);
            }
        }

        [FIXField("267", EFieldOption.Required)]
        public int NoMDEntryTypes
        {
            get
            {
                return this.GetIntValue(267);
            }
            set
            {
                this.SetIntValue(267, value);
            }
        }

        [FIXField("146", EFieldOption.Required)]
        public int NoRelatedSym
        {
            get
            {
                return this.GetIntValue(146);
            }
            set
            {
                this.SetIntValue(146, value);
            }
        }

        [FIXField("386", EFieldOption.Optional)]
        public int NoTradingSessions
        {
            get
            {
                return this.GetIntValue(386);
            }
            set
            {
                this.SetIntValue(386, value);
            }
        }

        [FIXField("815", EFieldOption.Optional)]
        public int ApplQueueAction
        {
            get
            {
                return this.GetIntValue(815);
            }
            set
            {
                this.SetIntValue(815, value);
            }
        }

        [FIXField("812", EFieldOption.Optional)]
        public int ApplQueueMax
        {
            get
            {
                return this.GetIntValue(812);
            }
            set
            {
                this.SetIntValue(812, value);
            }
        }

        [FIXField("10", EFieldOption.Required)]
        public string CheckSum
        {
            get
            {
                return this.GetStringValue(10);
            }
            set
            {
                this.SetStringValue(10, value);
            }
        }

        [FIXField("89", EFieldOption.Optional)]
        public string Signature
        {
            get
            {
                return this.GetStringValue(89);
            }
            set
            {
                this.SetStringValue(89, value);
            }
        }

        [FIXField("93", EFieldOption.Optional)]
        public int SignatureLength
        {
            get
            {
                return this.GetIntValue(93);
            }
            set
            {
                this.SetIntValue(93, value);
            }
        }

        public FIXMarketDataRequest() : base()
        {
            this.DQehr3BXSn = new ArrayList();
            this.w06hpr4a3K = new ArrayList();
            this.t4nhMyJTee = new ArrayList();
            this.e29hvGfn75 = new ArrayList();
            this.tcehdiDknj = new ArrayList();
            this.NoRelatedSym = 0;
        }

        public FIXMarketDataRequest(string MDReqID, char SubscriptionRequestType, int MarketDepth, int NoMDEntryTypes, int NoRelatedSym)
    : base()
        {

            this.DQehr3BXSn = new ArrayList();
            this.w06hpr4a3K = new ArrayList();
            this.t4nhMyJTee = new ArrayList();
            this.e29hvGfn75 = new ArrayList();
            this.tcehdiDknj = new ArrayList();

            this.MDReqID = MDReqID;
            this.SubscriptionRequestType = SubscriptionRequestType;
            this.MarketDepth = MarketDepth;
            this.NoMDEntryTypes = NoMDEntryTypes;
            this.NoRelatedSym = NoRelatedSym;
        }

        public FIXHopRefIDGroup GetHopRefIDGroup(int i)
        {
            return (FIXHopRefIDGroup)this.DQehr3BXSn[i];
        }

        public void AddGroup(FIXHopRefIDGroup group)
        {
            this.DQehr3BXSn.Add((object)group);
        }

        public FIXHopsGroup GetHopsGroup(int i)
        {
            if (i < this.NoHops)
                return (FIXHopsGroup)this.w06hpr4a3K[i];
            else
                return (FIXHopsGroup)null;
        }

        public void AddGroup(FIXHopsGroup group)
        {
            this.w06hpr4a3K.Add((object)group);
            ++this.NoHops;
        }

        public FIXMDEntryTypesGroup GetMDEntryTypesGroup(int i)
        {
            if (i < this.NoMDEntryTypes)
                return (FIXMDEntryTypesGroup)this.t4nhMyJTee[i];
            else
                return (FIXMDEntryTypesGroup)null;
        }

        public void RemoveMDEntryTypesGroup(int i)
        {
            if (i >= this.NoMDEntryTypes)
                return;
            this.t4nhMyJTee.RemoveAt(i);
            --this.NoMDEntryTypes;
        }

        public void AddGroup(FIXMDEntryTypesGroup group)
        {
            this.t4nhMyJTee.Add((object)group);
            ++this.NoMDEntryTypes;
        }

        public FIXRelatedSymGroup GetRelatedSymGroup(int i)
        {
            if (i < this.NoRelatedSym)
                return (FIXRelatedSymGroup)this.e29hvGfn75[i];
            else
                return (FIXRelatedSymGroup)null;
        }

        public void AddGroup(FIXRelatedSymGroup group)
        {
            this.e29hvGfn75.Add((object)group);
            ++this.NoRelatedSym;
        }

        public FIXTradingSessionsGroup GetTradingSessionsGroup(int i)
        {
            if (i < this.NoTradingSessions)
                return (FIXTradingSessionsGroup)this.tcehdiDknj[i];
            else
                return (FIXTradingSessionsGroup)null;
        }

        public void AddGroup(FIXTradingSessionsGroup group)
        {
            this.tcehdiDknj.Add((object)group);
            ++this.NoTradingSessions;
        }
    }
}
