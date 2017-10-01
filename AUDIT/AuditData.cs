using System;

namespace AUDIT
{
    public class AuditData
    {
        public int seq { get; set; }
        public String CompanyCode { get; set; }//รหัสกรม 
        public String UnitCode { get; set; }//รหัสหน่วยเบิกจ่าย
        public String LedgerCode { get; set; }//บัญชีแยกประเภท
        public String LedgerName { get; set; }//บัญชีแยกประเภท
        public Double BringForward { get; set; }//ยอดยกมา
        public Double Debit { get; set; }
        public Double Credit { get; set; }
        public Double CarrayForward { get; set; }//ยอดยกไป

        public String remark { get; set; }
        public String remark2 { get; set; }
    }
}
