using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApiNetFramework.Models
{
    #region FIToFICstmrCdtTrfInitn
    public class LbtrFIToFICstmrCdtTrfInitnClass
    {
        public FIToFICstmrCdtTrfInitnClass FIToFICstmrCdtTrfInitn { get; set; }
    }



    public class FIToFICstmrCdtTrfInitnClass
    {
        public GroupHeader GrpHdr { get; set; }
        public PaymentInformation[] PmtInf { get; set; }
    }


    public class GroupHeader
    {
        public string MsgId { get; set; }
        public DateTime CreDtTm { get; set; }
        public int NbOfTxs { get; set; }
        public ControlSum CtrlSum { get; set; }
        public DateTime IntrBkSttlmDt { get; set; }
        public string LclInstrm { get; set; }
        public string Channel { get; set; }
    }

    public class ControlSum
    {
        public string Ccy { get; set; }
        public decimal Amt { get; set; }
    }

    public class PaymentInformation
    {
        public int RegId { get; set; }
        public DateTime AccptncDtTm { get; set; }
        public string EndToEndId { get; set; }
        public string ClrSysRef { get; set; }
        public string TxId { get; set; }
        public AmountClass Amount { get; set; }
        public int Purp { get; set; }
        public string DbtrAgt { get; set; }
        public string CdtrAgt { get; set; }
        public DebitorAgent Dbtr { get; set; }
        public DebitorAccout DbtrAcct { get; set; }
        public DebitorAgentAccout DbtrAgtAcct { get; set; }
        public CreditorAgent Cdtr { get; set; }
        public CreditorAccout CdtrAcct { get; set; }
        public CreditorAgentAccout CdtrAgtAcct { get; set; }
    }

    public class AmountClass
    {
        public string Ccy { get; set; }
        public decimal Amt { get; set; }
    }

    public class DebitorAgent
    {
        public string Nm { get; set; }
        public string Id { get; set; }
        public string SchmeNm { get; set; }
    }

    public class DebitorAccout
    {
        public string Tp { get; set; }
        public string Id { get; set; }
    }

    public class DebitorAgentAccout
    {
        public string Tp { get; set; }
        public string Id { get; set; }
    }

    public class CreditorAgent
    {
        public string Nm { get; set; }
        public string Id { get; set; }
        public string SchmeNm { get; set; }
    }

    public class CreditorAccout
    {
        public string Tp { get; set; }
        public string Id { get; set; }
    }

    public class CreditorAgentAccout
    {
        public string Tp { get; set; }
        public string Id { get; set; }
    }
    #endregion

    #region FIToFIPmtStsRpt
    public class LbtrFIToFIPmtStsRpt
    {
        public LbtrFIToFIPmtStsRpt()
        {
            FIToFIPmtStsRpt = new FIToFIPmtStsRptClass();
        }

        public FIToFIPmtStsRptClass FIToFIPmtStsRpt { get; set; }
    }

    public class FIToFIPmtStsRptClass
    {
        public FIToFIPmtStsRptClass()
        {
            GrpHdr = new GroupHeaderReport();
            OrgnlGrpInfAndSts = new OriginalGroupInformationAndStatus();
            OrgnlPmtInfAndSts = new OriginalPaymentInformationAndStatus[] { new OriginalPaymentInformationAndStatus() };
        }

        public GroupHeaderReport GrpHdr { get; set; }
        public OriginalGroupInformationAndStatus OrgnlGrpInfAndSts { get; set; }
        public OriginalPaymentInformationAndStatus[] OrgnlPmtInfAndSts { get; set; }
    }

    public class GroupHeaderReport
    {
        public string MsgId { get; set; }
        public DateTime CreDtTm { get; set; }
    }

    public class OriginalGroupInformationAndStatus
    {
        public OriginalGroupInformationAndStatus()
        {
            OrgnlCtrlSum = new ControlSum();
        }

        public string OrgnlMsgId { get; set; }
        public DateTime OrgnlCreDtTm { get; set; }
        public int OrgnlNbOfTxs { get; set; }
        public ControlSum OrgnlCtrlSum { get; set; }
        public DateTime IntrBkSttlmDt { get; set; }
        public string LclInstrm { get; set; }
        public string GrpSts { get; set; }
    }

    public class OriginalPaymentInformationAndStatus
    {
        public OriginalPaymentInformationAndStatus()
        {
            Amount = new AmountClass();
            DbtrAcct = new DebitorAccout();
            CdtrAcct = new CreditorAccout();
        }

        public int OrgnlRegId { get; set; }
        public string OrgnlEndToEndId { get; set; }
        public DateTime AccptncDtTm { get; set; }
        public string ClrSysRef { get; set; }
        public string OrgnlTxId { get; set; }
        public string TxSts { get; set; }
        public string Rsn { get; set; }
        public AmountClass Amount { get; set; }
        public string Purp { get; set; }
        public string DbtrAgt { get; set; }
        public string CdtrAgt { get; set; }
        public DebitorAccout DbtrAcct { get; set; }
        public CreditorAccout CdtrAcct { get; set; }
        public string RmtInf { get; set; }
    }
    #endregion
}