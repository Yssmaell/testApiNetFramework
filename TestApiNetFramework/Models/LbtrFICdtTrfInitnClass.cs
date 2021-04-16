using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApiNetFramework.Models
{
    public class LbtrFICdtTrfInitnClass
    {
        public FICdtTrfInitnClass FICdtTrfInitn { get; set; }
    }

    public class FICdtTrfInitnClass
    {
        public GroupHeader GrpHdr { get; set; }
        public PaymentInformationM1[] PmtInf { get; set; }
    }

    public class PaymentInformationM1
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
        public DebitorAccout DbtrAcct { get; set; }
        public CreditorAccout CdtrAcct { get; set; }
        public string Rmtinf { get; set; }
        public UltimateDebitor UltmtDbtr { get; set; }
        public ReferedDocumentInformation RfrdDocInf { get; set; }

    }

    public class UltimateDebitor
    {
        public string Id { get; set; }
        public string SchmeNm { get; set; }
    }

    public class ReferedDocumentInformation
    {
        public string Nb { get; set; }
        public string RltdDt { get; set; }

    }
}