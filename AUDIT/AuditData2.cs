using System;

namespace AUDIT
{
    public class AuditData2
    {
/*
  0|ปี	
  1|บัญชี G/L	
  2|เลขเอกสาร	
  3|ปร	
  4|ข้อความส่วนหัวเอกสาร	
  5|การอ้างอิง	
  6|คีย์อ้างอิง1	
  7|คีย์การอ้างอิง 3	
  8|การกำหนด	
  9|ว/ทเอกสาร	
  10|Postg Date	
  11|Clrng doc.	
  12|การหักล้าง	
  13|วันคิดค่า	
  14|ศ.ต้นทุน	
  15|หน่วยเบิกจ่าย	
  16|PK	
  17|จำนวนเงินในสกุลในปท.	
  18|แหล่งของเง
*/

        public static String[] colIndex =
        {
                    "ปี",
                    "บัญชี G/L",
                    "เลขเอกสาร",
                    "ปร",
                    "ข้อความส่วนหัวเอกสาร",
                    "การอ้างอิง",
                    "คีย์อ้างอิง1",
                    "คีย์การอ้างอิง 3",
                    "การกำหนด",
                    "ว/ทเอกสาร",
                    "Postg Date",
                    "Clrng doc.",
                    "การหักล้าง",
                    "วันคิดค่า",
                    "ศ.ต้นทุน",
                    "หน่วยเบิกจ่าย",
                    "PK",
                    "จำนวนเงินในสกุลในปท.",
                    "แหล่งของเง",
                    "abs",

        };
        public int id { get; set; }
        public String col1 { get; set; }//ปี
        public String col2 { get; set; }//บัญชี G/L
        public String col3 { get; set; }//เลขเอกสาร
        public String col4 { get; set; }//ปร
        public String col5 { get; set; }//ข้อความส่วนหัวเอกสาร
        public String col6 { get; set; }//การอ้างอิง
        public String col7 { get; set; }//คีย์อ้างอิง1
        public String col8 { get; set; }//คีย์การอ้างอิง 3	
        public String col9 { get; set; }//การกำหนด
        public String col10 { get; set; }//ว/ทเอกสาร
        public String col11 { get; set; }//Postg Date
        public String col12 { get; set; }//Clrng doc.
        public String col13 { get; set; }//การหักล้าง
        public String col14 { get; set; }//วันคิดค่า
        public String col15 { get; set; }//ศ.ต้นทุน
        public String col16 { get; set; }//หน่วยเบิกจ่าย
        public String col17 { get; set; }//PK
        public double amt { get; set; }//จำนวนเงินในสกุลในปท.
        public String col19 { get; set; }//แหล่งของเง
        public String col20 { get; set; }//abs
        public double amtAbs { get; set; }




        //public String year { get; set; }
        //public String companyCode { get; set; }
        //public String doc_no { get; set; }
        //public String gl_code { get; set; }
        //public String ref_no { get; set; }
        //public String doc_date { get; set; }
        //public String post_date { get; set; }
        //public String unitCode { get; set; }
        //public String pk { get; set; }
        //public Double amout { get; set; }
        //public Double amout_abs { get; set; }
    }
}
