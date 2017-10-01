using Excel;
using log4net;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;

namespace AUDIT
{
    public class LoadData
    {
        private readonly ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public IExcelDataReader getExcelReader(String _path)
        {
            // ExcelDataReader works with the binary Excel file, so it needs a FileStream
            // to get started. This is how we avoid dependencies on ACE or Interop:
            FileStream stream = File.Open(_path, FileMode.Open, FileAccess.Read);

            // We return the interface, so that
            IExcelDataReader reader = null;
            try
            {
                if (_path.EndsWith(".xls"))
                {
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);
                }
                if (_path.EndsWith(".xlsx"))
                {
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }
                return reader;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<AuditData> Analyze(String filePath)
        {
            IExcelDataReader excelReader = getExcelReader(filePath);

            var workbook = excelReader.AsDataSet();

            //5. Data Reader methods
            List<AuditData> ListOfData = new List<AuditData>();
            for (int i = 0; i < excelReader.AsDataSet().Tables.Count; i++)
            {
                IEnumerable<DataRow> dataRows = excelReader.AsDataSet().Tables[i].AsEnumerable();
                String unitCode = String.Empty;
                String comCode = String.Empty;
                int rowIndex = 0;
                foreach (DataRow row in dataRows.ToList())
                {
                    if (row[0] != null)
                    {
                        if (row[0].ToString().IndexOf("Page No.") != -1)
                        {
                        }
                        else if (row[0].ToString().IndexOf("Program") != -1)
                        {

                            if (row[0].ToString().IndexOf("รหัสหน่วยงาน") > 0)
                            {
                                comCode = row[0].ToString().Substring(row[0].ToString().IndexOf("รหัสหน่วยงาน")).Substring("รหัสหน่วยงาน".Length, 5).Trim();
                            }
                        }
                        else if (row[0].ToString().IndexOf("User") != -1)
                        {
                            Console.WriteLine();
                            if (row[0].ToString().IndexOf("หน่วยเบิกจ่าย") > 0)
                            {
                                unitCode = row[0].ToString().Substring(row[0].ToString().IndexOf("หน่วยเบิกจ่าย")).Substring("หน่วยเบิกจ่าย".Length, 17).Trim();
                            }
                        }
                        else if (row[0].ToString().IndexOf("ประจำงวด") != -1)
                        {

                        }
                        else if (row[0].ToString().IndexOf("บัญชีแยกประเภท") != -1)
                        {

                        }
                        else if (row[0].ToString().IndexOf("รหัสบัญชี") != -1)
                        {

                        }
                        else if (String.IsNullOrEmpty(row[0].ToString()))
                        {

                        }
                        else {
                            if (!String.IsNullOrEmpty(row[1].ToString()))
                            {
                                if (row[0].ToString().Length > 10)
                                {
                                    AuditData auditData = new AuditData();
                                    auditData.CompanyCode = comCode;
                                    auditData.UnitCode = unitCode;//รหัสหน่วยเบิกจ่าย  ผิดอยู่
                                    auditData.LedgerCode = row[0].ToString().Substring(0, 10);
                                    auditData.LedgerName = row[0].ToString().Substring(10, row[0].ToString().Length - 10).Trim();
                                    auditData.BringForward = ConvertToDouble(rowIndex, excelReader.Name, row[1].ToString());//
                                    auditData.Debit = ConvertToDouble(rowIndex, excelReader.Name, row[2].ToString());//
                                    auditData.Credit = ConvertToDouble(rowIndex, excelReader.Name, row[3].ToString());//
                                    auditData.CarrayForward = ConvertToDouble(rowIndex, excelReader.Name, row[4].ToString());//


                                    //if (auditData.UnitCode.Equals("000002500700327"))
                                    //{
                                        ListOfData.Add(auditData);
                             
                                }
                            }
                        }
                    }
                    rowIndex++;
                }
            }



            //6. Free resources (IExcelDataReader is IDisposable)
            excelReader.Close();
            #region "Analyze"
            List<String> zeroBalanceList = new List<String>();
            zeroBalanceList.Add("1101010112");
            zeroBalanceList.Add("1101010113");
            zeroBalanceList.Add("1101010110");
            zeroBalanceList.Add("1213010104");
            zeroBalanceList.Add("2101020106");
            zeroBalanceList.Add("2102040103");
            zeroBalanceList.Add("2102040104");
            zeroBalanceList.Add("2102040106");
            zeroBalanceList.Add("2116010104");
            zeroBalanceList.Add("5212010103");
            zeroBalanceList.Add("5301010101");
            zeroBalanceList.Add("5301010103");
            zeroBalanceList.Add("1102050125");
            zeroBalanceList.Add("1206010102");
            zeroBalanceList.Add("1206030102");
            zeroBalanceList.Add("1206040102");
            zeroBalanceList.Add("1206100102");
            zeroBalanceList.Add("1211010102");
            //zeroBalanceList.Add("1209030102");
            zeroBalanceList.Add("1206110102");
            zeroBalanceList.Add("1205010102");
            zeroBalanceList.Add("1205010107");
            zeroBalanceList.Add("1205020102");
            zeroBalanceList.Add("1205020105");
            zeroBalanceList.Add("1205030102");
            zeroBalanceList.Add("1205030107");
            zeroBalanceList.Add("1205030110");
            zeroBalanceList.Add("1205040102");
            zeroBalanceList.Add("1205040107");
            zeroBalanceList.Add("1206020102");
            zeroBalanceList.Add("1206050102");
            zeroBalanceList.Add("1206060102");
            zeroBalanceList.Add("1206070102");
            zeroBalanceList.Add("1206080102");
            zeroBalanceList.Add("1206090102");
            zeroBalanceList.Add("1206120102");
            zeroBalanceList.Add("1206130102");
            zeroBalanceList.Add("1206140102");
            zeroBalanceList.Add("1206150102");
            zeroBalanceList.Add("1206160102");
            zeroBalanceList.Add("1209010102");
            zeroBalanceList.Add("1209020102");
            zeroBalanceList.Add("3102010102");
            zeroBalanceList.Add("3101010101");

            List<String> ignoreRevenue = new List<String>();
            ignoreRevenue.Add("4207010101");
            ignoreRevenue.Add("4207010102");
            ignoreRevenue.Add("4207010103");
            ignoreRevenue.Add("4207010199");

            List<String> ignoreExpend = new List<String>();
            ignoreExpend.Add("5210101112");

            //มียอดยกไปเท่ากับยอดยกมา
            List<String> ignore2 = new List<String>();
            ignore2.Add("5210101112");
            ignore2.Add("1205010101");
            ignore2.Add("1205020101");
            ignore2.Add("1205030101");
            ignore2.Add("1206010101");
            ignore2.Add("1206040101");
            ignore2.Add("1206160101");
            ignore2.Add("1206160103");
            ignore2.Add("1206170101");
            ignore2.Add("1206170102");
            ignore2.Add("1205040101");
            ignore2.Add("1206030101");
            ignore2.Add("1206050101");
            ignore2.Add("1206060101");
            ignore2.Add("1206100101");
            ignore2.Add("1101010104");
            ignore2.Add("2202010101");
            ignore2.Add("1205030106");
            ignore2.Add("1206020101");
            ignore2.Add("1206120101");
            ignore2.Add("1206180101");
            ignore2.Add("1206180102");
            ignore2.Add("1209010101");
            ignore2.Add("1209020101");
            ignore2.Add("1205060101");
            ignore2.Add("1205060102");
            ignore2.Add("1206060103");
            ignore2.Add("1206070101");
            ignore2.Add("1206080101");
            ignore2.Add("1206090101");
            ignore2.Add("1206130101");
            ignore2.Add("1209040101");
            ignore2.Add("1209040102");

            ignore2.Add("1209020103");
            ignore2.Add("1205060102");
            ignore2.Add("1209040102");
            //ignore2.Add("2213010101");
            ignore2.Add("1206090103");
            ignore2.Add("1206070103");
            ignore2.Add("1206080103");
            ignore2.Add("1206120103");
            ignore2.Add("1206130103");
            ignore2.Add("1206050103");
            ignore2.Add("1206130103");

            ignore2.Add("1205030108");
            ignore2.Add("1205040106");


            ignore2.Add("1205030103");
            ignore2.Add("1205040103");
            ignore2.Add("1102050129");
            ignore2.Add("1106010103");
            ignore2.Add("1201050120");
            ignore2.Add("1203010304");
            ignore2.Add("1203010305");
            ignore2.Add("1203010404");
            ignore2.Add("1203010405");
            ignore2.Add("1203010407");
            ignore2.Add("1203010408");
            ignore2.Add("1101020803");
            ignore2.Add("1101020807");
            ignore2.Add("1102020101");
            ignore2.Add("1102030101");
            ignore2.Add("1106010113");
            ignore2.Add("1201020101");
            ignore2.Add("1209010103");
            ignore2.Add("2102020103");
            ignore2.Add("2110010109");
            ignore2.Add("2110020103");
            ignore2.Add("2112010102");
            ignore2.Add("1203020199");
            ignore2.Add("2110010103");
            ignore2.Add("2112010102");
            ignore2.Add("2206010103");
            ignore2.Add("1206040103");
            ignore2.Add("1206020103");
            ignore2.Add("1206150101");
            ignore2.Add("1206150103");
            ignore2.Add("2105010199");
            ignore2.Add("1206140101");
            ignore2.Add("1206140103");
            ignore2.Add("1204040101");
            ignore2.Add("1206110101");
            ignore2.Add("1206110103");
            ignore2.Add("1206010103");
            ignore2.Add("1206030103");

            ignore2.Add("1206100103");
            ignore2.Add("1205050102");
            ignore2.Add("1204030101");
            ignore2.Add("1205050101");
            ignore2.Add("1211010103");
            ignore2.Add("2111020199");

            //ignore2.Add("1105010105");
            //ignore2.Add("5104010104");
            ignore2.Add("1101030112");

            ignore2.Add("1208050101");
            ignore2.Add("1208070101");
            ignore2.Add("1208070102");

            //ยอดยกไปจะต้องเป็น +
            List<String> ignore3 = new List<String>();
            ignore3.Add("1206170102");
            ignore3.Add("1205030108");
            ignore3.Add("1206180102");
            ignore3.Add("1205030108");
            ignore3.Add("1209020103");

            ignore3.Add("1205060102");
            ignore3.Add("1209040102");
            ignore3.Add("1205040108");
            ignore3.Add("1205050102");
            ignore3.Add("1102050123");
            ignore3.Add("1208070102");

            //ignore3.Add("3101010101");
            //ignore3.Add("3102010102");
            //ignore3.Add("2101020106");



            // ยอดยกไปจะต้องเป็น + (ขึ้นต้นด้วย 5)
            List<String> ignore4 = new List<String>();
            ignore4.Add("5210010112");
            //ขึ้นต้นด้วย 4 ยกเว้นค่าเหล่าหนี้ให้เป็น + ได้
            List<String> ignore5 = new List<String>();
            ignore5.Add("4207010102");
            ignore5.Add("4207010103");
            ignore5.Add("4207010199");
            ignore5.Add("4207010101");



            //
            foreach (AuditData data in ListOfData)
            {

                switch (data.LedgerCode[0])
                {

                    case '1'://ยอดยกไปต้องเป็น +
                        if (data.LedgerCode.StartsWith("12") && data.LedgerCode.EndsWith("03") && !data.LedgerCode.Equals("1211010103"))
                        {
                            if (data.CarrayForward > 0)
                            {
                                data.remark = "ยอดยกไปจะต้องเป็น -";
                            }
                        }
                        else
                        {
                            if (!ignore3.Contains(data.LedgerCode))
                            {
                                if (data.CarrayForward < 0)
                                {
                                    data.remark = "ยอดยกไปจะต้องเป็น +";
                                }
                            }
                        }

                        if (data.LedgerCode.Equals("1102050123"))
                        {
                            if (data.CarrayForward > 0)
                            {
                                data.remark = "ยอดยกไปจะต้องเป็น -";
                            }
                        }

                        if (data.BringForward == data.CarrayForward)
                        {
                            if (data.BringForward != 0)
                            {
                                if (!ignore2.Contains(data.LedgerCode))
                                {
                                    data.remark = "มียอดยกไปเท่ากับยอดยกมา";
                                    data.remark2 = "ตรวจสอบเพิ่ม";
                                }
                            }
                        }

                        break;
                    case '5':
                        if (data.CarrayForward < 0 && !ignoreExpend.Contains(data.LedgerCode))
                        {
                            if (!ignore4.Contains(data.LedgerCode))
                            {
                                data.remark = "ยอดยกไปจะต้องเป็น +";
                            }
                        }
                        break;
                    case '2':
                        if (data.CarrayForward > 0)
                        {
                            data.remark = "ยอดยกไปจะต้องเป็น -";
                        }
                        if (ignoreRevenue.Contains(data.LedgerCode))
                        {
                            if (data.CarrayForward < 0)
                            {
                                data.remark = "ยอดยกไปจะต้องเป็น +";
                            }
                        }
                        if (data.BringForward == data.CarrayForward)
                        {
                            if (data.BringForward != 0)
                            {
                                if (!ignore2.Contains(data.LedgerCode))
                                {
                                    data.remark = "มียอดยกไปเท่ากับยอดยกมา";
                                    data.remark2 = "ตรวจสอบเพิ่ม";
                                }
                            }
                        }
                        break;
                    case '4':
                        //4207010102,4207010103,4207010199,4207010101
                        if (data.CarrayForward > 0 && !ignore5.Contains(data.LedgerCode))
                        {
                            data.remark = "ยอดยกไปจะต้องเป็น -";
                        }

                        if (ignoreRevenue.Contains(data.LedgerCode))
                        {
                            if (data.CarrayForward < 0)
                            {
                                data.remark = "ยอดยกไปจะต้องเป็น +";
                            }
                        }
                        break;
                    case '6':
                        if (data.CarrayForward == 0)
                        {

                        }
                        else
                        {
                            data.remark = "ให้แสดงยอดยกไปด้วย";
                        }
                        break;
                    default:
                        break;
                }
            }

            foreach (AuditData data in ListOfData)
            {
                if (zeroBalanceList.Contains(data.LedgerCode))
                {
                    if (data.CarrayForward != 0)
                    {
                        data.remark = "ยอดยกไปต้องเท่ากับ 0";
                    }
                }

                if (data.LedgerCode != null && data.LedgerName != null)
                {
                    if (data.LedgerName.IndexOf("ราชพัสดุ") >= 0)
                    {
                        if (!String.IsNullOrEmpty(data.UnitCode))
                        {
                            if (!data.UnitCode.StartsWith("03003"))
                            {
                                if (data.CarrayForward != 0)
                                {
                                    if (data.CarrayForward != 0)
                                    {
                                        data.remark = "ห้ามใช้";
                                    }
                                }
                            }
                        }
                    }


                    if (data.LedgerCode.StartsWith("1208"))
                    {
                        if (!String.IsNullOrEmpty(data.UnitCode))
                        {
                            if (data.CompanyCode.Equals("1502") || data.UnitCode.Substring(5).StartsWith("08006") || data.UnitCode.Substring(5).StartsWith("07003"))
                            {

                            }
                            else {
                                if (data.CarrayForward != 0)
                                {
                                    data.remark = "ห้ามใช้";
                                }
                            }
                        }
                        else
                        {
                            if (data.CarrayForward != 0)
                            {
                                data.remark = "ห้ามใช้";
                            }
                        }
                    }
                }
            }

            foreach (AuditData data in ListOfData)
            {
                if (data.LedgerName.IndexOf("ที่ดิน") >= 0)
                {
                    //if (!String.IsNullOrEmpty(data.UnitCode))
                    //{
                    if (!data.CompanyCode.Equals("0303") && !data.CompanyCode.StartsWith("A"))
                    {
                        if (data.CarrayForward != 0)
                        {
                            data.remark = "ห้ามใช้";

                        }
                    }
                    //}
                }
            }
            foreach (AuditData original in ListOfData)
            {
                AuditData match = new AuditData();
                switch (original.LedgerCode)
                {
                    case "1205020101"://1205020103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1205020103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1205030101"://1205030103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1205030103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1205040101"://1205040103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1205040103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206010101"://1206010103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206010103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206020101"://1206020103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206020103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206030101"://1206030103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206030103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206040101"://1206040103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206040103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206050101"://1206050103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206050103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206060101"://1206060103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206060103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206070101"://1206070103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206070103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206090101"://1206090103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206090103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206100101"://1206100103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206100103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206110101"://1206110103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206110103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1206120101"://1206120103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1206120103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1209010101"://1209010103
                        if (original.CarrayForward > 0)
                        {
                            match = ListOfData.Where(x => x.LedgerCode.Equals("1209010103") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                            if (match != null)
                            {
                                if (match.CarrayForward < 0)
                                {
                                    Double diff = Math.Abs(original.CarrayForward) - Math.Abs(match.CarrayForward);
                                    if (diff < 0)
                                    {
                                        match.remark = "ค่าเสื่อมราคาสะสมมากกว่าสินทรัพย์";
                                        original.remark = match.remark;
                                    }
                                }
                            }
                        }
                        break;
                    case "1101010104"://2202010101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("2202010101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match != null)
                        {
                            if (Math.Abs(original.CarrayForward) == Math.Abs(match.CarrayForward))
                            {

                            }
                            else
                            {

                                AuditData match2 = ListOfData.Where(x => x.LedgerCode.Equals("2105010199") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                                if (match2 != null)
                                {
                                    if (Math.Abs(original.CarrayForward) == Math.Abs((match.CarrayForward + match2.CarrayForward)))
                                    {

                                    }
                                    else {

                                        match.remark = "บัญชีเงินทดรองราชการไม่เท่ากับบัญชีเงินทดรองราชการรับจากคลัง";
                                        original.remark = match.remark;
                                        match2.remark = match.remark;

                                    }
                                }
                            }
                        }
                        break;

                    case "5107030101":
                        match = ListOfData.Where(x => x.LedgerCode.Equals("4302040101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match != null)
                        {
                            if ((original.CarrayForward + match.CarrayForward) == 0)
                            {

                            }
                            else
                            {
                                match.remark = "มียอดพักเบิกไม่เท่ากับพักรับ";
                                original.remark = match.remark;
                            }
                        }
                        break;
                        //case "1101010112":
                        //    match = ListOfData.Where(x => x.LedgerCode.Equals("1101010113") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();

                        //    if (match != null)
                        //    {
                        //        if ((original.CarrayForward + match.CarrayForward) == 0)
                        //        {

                        //        }
                        //        else
                        //        {
                        //            match.remark = "ยอดยกไปต้องเท่ากับ 0";
                        //            original.remark = match.remark;
                        //        }
                        //    }
                        //    break;
                }
            }

            //

            foreach (AuditData original in ListOfData)
            {
                AuditData match = new AuditData();
                switch (original.LedgerCode)
                {
                    case "1205020103"://1205020101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1205020101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1205030103"://1205030101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1205030101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1205040103"://1205040101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1205040101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206010103"://1206010101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206010101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206020103"://1206020101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206020101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206030103"://1206030101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206030101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;

                    case "1206040103"://1206040101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206040101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206050103"://1206050101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206050101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206060103"://1206060101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206060101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206070103"://1206070101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206070101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206090103"://1206090101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206090101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206100103"://1206100101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206100101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206110103"://1206110101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206110101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1206120103"://1206120101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1206120101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;
                    case "1209010103"://1209010101
                        match = ListOfData.Where(x => x.LedgerCode.Equals("1209010101") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match == null)
                        {
                            original.remark = "มีค่าเสื่อมสะสม แต่ไม่มีสินทรัพย์";
                        }
                        break;

                    case "1105010105"://5104010104 //ไม่ควรมียอดยกไปทั้งสองบัญชี
                        match = ListOfData.Where(x => x.LedgerCode.Equals("5104010104") && x.CompanyCode.Equals(original.CompanyCode) && x.UnitCode.Equals(original.UnitCode)).FirstOrDefault();
                        if (match != null)
                        {
                            if (original.Debit != 0 && match.Debit != 0)
                            {
                                Boolean con1 = false;
                                if (original.Debit == match.Credit)
                                {
                                    con1 = true;
                                }
                                Boolean con2 = false;
                                if (match.Credit == original.Debit)
                                {
                                    con1 = true;
                                }
                                if (con1 || con2)
                                {

                                }
                                else
                                {
                                    original.remark = "บันทึกบัญชีไม่ถูกต้อง";
                                    match.remark = original.remark;
                                }



                            }

                        }
                        break;
                    case "1207010105":
                    case "1206180101":
                    case "1206180102":
                        if (original.CarrayForward != 0)
                        {
                            original.remark = "ยอดยกไปต้องเท่ากับ 0";
                        }
                        break;
                    case "ไม่ระบุรายละเอียด":
                        original.remark = "ตรวจสอบเพิ่ม";
                        break;
                }
            }

            foreach (AuditData auditData in ListOfData)
            {
                if (auditData.LedgerCode.Equals("1102010101") || auditData.LedgerCode.Equals("1102010102"))
                {
                    if (Math.Abs(auditData.Credit) < auditData.BringForward)
                    {
                        auditData.remark = "มียอดค้างนาน";
                        auditData.remark2 = "ให้ตรวจสอบกับสัญญายืมเงิน";
                    }
                }
            }

            foreach (AuditData auditData in ListOfData)
            {
                if (auditData.LedgerName != null)
                {
                    if (auditData.LedgerName.IndexOf("Inf") >= 0)
                    {
                        //ignore
                        if (auditData.CompanyCode.StartsWith("A") ||
                         auditData.CompanyCode.StartsWith("02") ||
                         auditData.CompanyCode.StartsWith("1607"))
                        {

                        }
                        else
                        {
                            if (auditData.CarrayForward != 0)
                            {
                                auditData.remark = "ใช้บัญชีไม่ถูกต้อง";
                            }
                        }
                    }
                }
            }


            foreach (AuditData auditData in ListOfData.Where(x => zeroBalanceList.Contains(x.LedgerCode)))
            {
                if (auditData.CarrayForward > 0)
                {

                }
                else
                {
                    //zeroBalanceList.Add("1101010112");
                    //zeroBalanceList.Add("1101010113");
                    if (auditData.LedgerCode.Equals("1101010112") || auditData.LedgerCode.Equals("1101010113"))
                    {
                        auditData.remark2 = "ยอดยกไปจะต้องเป็น +";
                    }
                }

            }


            ///////////
            List<AuditData> listOfIssue = new List<AuditData>();





            List<String> group1 = new List<string>();
            group1.Add("1101020603");
            group1.Add("1101020604");
            group1.Add("1101020605");
            group1.Add("1102050124");
            List<String> group2 = new List<string>();
            group2.Add("2101010101");
            group2.Add("2101010102");
            group2.Add("2101020198");
            group2.Add("2101020102");
            group2.Add("2102040102");
            List<String> group3 = new List<string>();
            group3.Add("1101020601");
            group3.Add("1101020606");
            group3.Add("1101010101");
            group3.Add("1101020501");
            group3.Add("1101030101");
            group3.Add("1101030112");
            group3.Add("1101030102");
            group3.Add("1101030199");
            group3.Add("1104010101");
            group3.Add("1104010104");
            group3.Add("1104010199");
            List<String> group4 = new List<string>();
            group4.Add("2111020199");
            group4.Add("2112010199");

            var groupOfUnitCode = from audit in ListOfData
                                  group audit by audit.CompanyCode + ":" + audit.UnitCode into newGroup
                                  orderby newGroup.Key
                                  select newGroup;


            foreach (var nameGroup in groupOfUnitCode)
            {
                String[] tmp = nameGroup.Key.Split(':');
                String _comCode = tmp[0];
                String _unitCode = tmp[1];

                List<AuditData> groupByUnitCode01 = ListOfData.Where(x => group1.Contains(x.LedgerCode) && x.CompanyCode.Equals(_comCode) && x.UnitCode.Equals(_unitCode)).ToList();
                List<AuditData> groupByUnitCode02 = ListOfData.Where(x => group2.Contains(x.LedgerCode) && x.CompanyCode.Equals(_comCode) && x.UnitCode.Equals(_unitCode)).ToList();
                List<AuditData> groupByUnitCode03 = ListOfData.Where(x => group3.Contains(x.LedgerCode) && x.CompanyCode.Equals(_comCode) && x.UnitCode.Equals(_unitCode)).ToList();
                List<AuditData> groupByUnitCode04 = ListOfData.Where(x => group4.Contains(x.LedgerCode) && x.CompanyCode.Equals(_comCode) && x.UnitCode.Equals(_unitCode)).ToList();

                Double sumGroup1 = groupByUnitCode01.Sum(x => x.CarrayForward);
                Double sumGroup2 = groupByUnitCode02.Sum(x => x.CarrayForward);

                if (Math.Abs(sumGroup1) <= Math.Abs(sumGroup2))
                {
                }
                else
                {
                    foreach (AuditData data in groupByUnitCode01)
                    {
                        AuditData auditData = new AuditData();
                        auditData.CompanyCode = data.CompanyCode;
                        auditData.UnitCode = data.UnitCode;
                        auditData.LedgerCode = data.LedgerCode;
                        auditData.LedgerName = data.LedgerName;
                        auditData.BringForward = data.BringForward;
                        auditData.Debit = data.Debit;
                        auditData.Credit = data.Credit;
                        auditData.CarrayForward = data.CarrayForward;
                        auditData.remark = "มีเงินมากกว่าหนี้";
                        listOfIssue.Add(auditData);
                    }
                    if (groupByUnitCode01.Count > 0)
                    {
                        AuditData sumRow01 = new AuditData();
                        sumRow01.CompanyCode = groupByUnitCode01[0].CompanyCode;
                        sumRow01.UnitCode = groupByUnitCode01[0].UnitCode;
                        sumRow01.CarrayForward = sumGroup1;
                        sumRow01.remark = "มีเงินมากกว่าหนี้";
                        listOfIssue.Add(sumRow01);
                    }
                    foreach (AuditData data in groupByUnitCode02)
                    {
                        AuditData auditData = new AuditData();
                        auditData.CompanyCode = data.CompanyCode;
                        auditData.UnitCode = data.UnitCode;
                        auditData.LedgerCode = data.LedgerCode;
                        auditData.LedgerName = data.LedgerName;
                        auditData.BringForward = data.BringForward;
                        auditData.Debit = data.Debit;
                        auditData.Credit = data.Credit;
                        auditData.CarrayForward = data.CarrayForward;
                        auditData.remark = "มีเงินมากกว่าหนี้";
                        listOfIssue.Add(auditData);
                    }
                    if (groupByUnitCode02.Count > 0)
                    {
                        AuditData sumRow02 = new AuditData();
                        sumRow02.CompanyCode = groupByUnitCode02[0].CompanyCode;
                        sumRow02.UnitCode = groupByUnitCode02[0].UnitCode;
                        sumRow02.CarrayForward = sumGroup2;
                        sumRow02.remark = "มีเงินมากกว่าหนี้";
                        listOfIssue.Add(sumRow02);
                    }
                    Console.WriteLine();
                }
                Double sumGroup3 = groupByUnitCode03.Sum(x => x.CarrayForward);
                Double sumGroup4 = groupByUnitCode04.Sum(x => x.CarrayForward);
                if (Math.Abs(Convert.ToDouble(sumGroup3.ToString("N2"))) >= Math.Abs(Convert.ToDouble( sumGroup4.ToString("N2"))))
                {

                }
                else
                {
                    foreach (AuditData data in groupByUnitCode03)
                    {
                        AuditData auditData = new AuditData();
                        auditData.CompanyCode = data.CompanyCode;
                        auditData.UnitCode = data.UnitCode;
                        auditData.LedgerCode = data.LedgerCode;
                        auditData.LedgerName = data.LedgerName;
                        auditData.BringForward = data.BringForward;
                        auditData.Debit = data.Debit;
                        auditData.Credit = data.Credit;
                        auditData.CarrayForward = data.CarrayForward;
                        auditData.remark = "มีเงินน้อยกว่าหนี้";
                        listOfIssue.Add(auditData);
                    }
                    if (groupByUnitCode03.Count > 0)
                    {
                        AuditData sumRow03 = new AuditData();
                        sumRow03.CompanyCode = groupByUnitCode03[0].CompanyCode;
                        sumRow03.UnitCode = groupByUnitCode03[0].UnitCode;
                        sumRow03.CarrayForward = sumGroup3;
                        sumRow03.remark = "มีเงินน้อยกว่าหนี้";
                        listOfIssue.Add(sumRow03);
                    }
                    foreach (AuditData data in groupByUnitCode04)
                    {
                        AuditData auditData = new AuditData();
                        auditData.CompanyCode = data.CompanyCode;
                        auditData.UnitCode = data.UnitCode;
                        auditData.LedgerCode = data.LedgerCode;
                        auditData.LedgerName = data.LedgerName;
                        auditData.BringForward = data.BringForward;
                        auditData.Debit = data.Debit;
                        auditData.Credit = data.Credit;
                        auditData.CarrayForward = data.CarrayForward;
                        auditData.remark = "มีเงินน้อยกว่าหนี้";
                        listOfIssue.Add(auditData);
                    }
                    if (groupByUnitCode04.Count > 0)
                    {
                        AuditData sumRow04 = new AuditData();
                        sumRow04.CompanyCode = groupByUnitCode04[0].CompanyCode;
                        sumRow04.UnitCode = groupByUnitCode04[0].UnitCode;
                        sumRow04.CarrayForward = sumGroup4;
                        sumRow04.remark = "มีเงินน้อยกว่าหนี้";
                        listOfIssue.Add(sumRow04);
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }





            #endregion


            Console.WriteLine();
            List<AuditData> returnResult = new List<AuditData>();
            int seq = 1;
            foreach (AuditData item in ListOfData)
            {
                item.seq = seq;
                returnResult.Add(item);
                seq++;
            }
            seq++;
            foreach (AuditData item in listOfIssue)
            {
                item.seq = seq;
                returnResult.Add(item);
                seq++;
            }
            Console.WriteLine();



            return returnResult.OrderBy(x => x.seq).ToList();
        }


        public List<AuditData2> AnaylyzePivot(String filePath)
        {
            //List<AuditData2> listOfData = new List<AuditData2>();
            IExcelDataReader excelReader = getExcelReader(filePath);

            var workbook = excelReader.AsDataSet();

            //5. Data Reader methods
            List<AuditData2> listOfData = new List<AuditData2>();
            //List<AuditData2> listOfDataTmp = new List<AuditData2>();

            List<AuditData2> ListOfDataError = new List<AuditData2>();

            for (int i = 0; i < excelReader.AsDataSet().Tables.Count; i++)
            {
                IEnumerable<DataRow> dataRows = excelReader.AsDataSet().Tables[i].AsEnumerable();
                String unitCode = String.Empty;
                String comCode = String.Empty;
                int rowIndex = 0;
                foreach (DataRow row in dataRows.ToList())
                {
                    if (rowIndex > 0)
                    {
                        if (!String.IsNullOrEmpty(row[0].ToString()))
                        {
                            AuditData2 audit2 = new AuditData2();
                            audit2.id = rowIndex + 1;
                            audit2.col1 = row[0].ToString();
                            audit2.col2 = row[1].ToString();
                            audit2.col3 = row[2].ToString();
                            audit2.col4 = row[3].ToString();
                            audit2.col5 = row[4].ToString();
                            audit2.col6 = row[5].ToString();
                            audit2.col7 = row[6].ToString();
                            audit2.col8 = row[7].ToString();
                            audit2.col9 = row[8].ToString();
                            audit2.col10 = row[9].ToString();
                            audit2.col11 = row[10].ToString();
                            audit2.col12 = row[11].ToString();
                            audit2.col13 = row[12].ToString();
                            audit2.col14 = row[13].ToString();
                            audit2.col15 = row[14].ToString();
                            audit2.col16 = row[15].ToString();
                            audit2.col17 = row[16].ToString();
                            audit2.amt = Convert.ToDouble(row[17].ToString());
                            audit2.amtAbs = Math.Abs(audit2.amt);
                            listOfData.Add(audit2);
                            //listOfDataTmp.Add(audit2);
                            Console.WriteLine();
                        }
                    }
                    rowIndex++;
                }
            }

            //Alnayze
            var results = from p in listOfData
                          group p by p.amtAbs into g
                          select new
                          {
                              amt = g.Key,
                          };
            foreach (var item in results)
            {
                Console.WriteLine();
                double _amt = Convert.ToDouble(item.amt);
                if (_amt == 405860)
                {
                    Console.WriteLine();
                }
                List<AuditData2> match = listOfData.Where(x => x.amtAbs == _amt).ToList();
                if (match.Count > 0)
                {

                    double result = 0;
                    foreach (AuditData2 tmp in match)
                    {
                        result += tmp.amt;
                    }
                    if (result != 0)
                    {

                        foreach (AuditData2 tmp in match)
                        {
                            ListOfDataError.Add(tmp);
                        }
                    }
                }


                //if (match.Count > 0)
                //{
                //    double result = 0;
                //    foreach (AuditData2 tmp in match)
                //    {
                //        result += tmp.amt;
                //    }
                //    if ((data2.amt + result) != 0)
                //    {
                //        ListOfDataError.Add(data2);

                //        foreach (AuditData2 tmp in match)
                //        {
                //            ListOfDataError.Add(tmp);
                //        }
                //    }
                //}
                //else
                //{
                //    ListOfDataError.Add(data2);

                //}

                Console.WriteLine();

                //for (int i = 1; i < 13; i++)
                //{
                //    String[] key = ConfigurationManager.AppSettings["GRP_" + i.ToString("00") + "_1"].Split(',');
                //    String[] map = ConfigurationManager.AppSettings["GRP_" + i.ToString("00") + "_2"].Split(',');
                //    if (key.Length > 1)
                //    {
                //        for (int j = 0; j < key.Length; j++)
                //        {
                //            if (data2.col4.Equals(key[j]))
                //            {
                //                String[] mapData = map[j].Split('/');
                //                List<AuditData2> match = listOfDataTmp.Where(x => mapData.Contains(x.col4) && x.amtAbs == data2.amtAbs && data2.id != x.id).ToList();
                //                if (match.Count > 0)
                //                {
                //                    double result = 0;
                //                    if (match.Count > 0)
                //                    {
                //                        foreach (AuditData2 tmp in match)
                //                        {
                //                            result += tmp.amt;
                //                            //ListOfDataError.Add(tmp);
                //                        }
                //                        Console.WriteLine();
                //                    }


                //                    if ((data2.amt + result) != 0)
                //                    {
                //                        ListOfDataError.Add(data2);

                //                        foreach (AuditData2 tmp in match)
                //                        {
                //                            ListOfDataError.Add(tmp);
                //                        }
                //                    }
                //                    //else
                //                    //{
                //                    //    if (data2.amt + match[0].amt == 0)
                //                    //    {

                //                    //    }
                //                    //    else
                //                    //    {
                //                    //        ListOfDataError.Add(data2);
                //                    //        ListOfDataError.Add(match[0]);
                //                    //        Console.WriteLine();
                //                    //    }
                //                    //}



                //                }

                //                Console.WriteLine();
                //            }
                //        }
                //    }

                //}

            }





            return ListOfDataError;
        }


        public Double ConvertToDouble(int rowIndex, String sheet, String value)
        {
            try
            {
                Boolean isNegativeValue = value.IndexOf("(") != -1;
                String tmp = value.Trim().Replace("(", "").Replace(")", "").Replace(",", "");

                return (isNegativeValue) ? Double.Parse(tmp) * -1 : Double.Parse(tmp);

            }
            catch (Exception ex)
            {
                return -9999999999;
            }

        }

    }
}
