using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using WF.Entities;

namespace WF.BLL
{
    public class BusinessLogicLayer
    {
        WF.Core.DatabaseLogicLayer DLL;

        public BusinessLogicLayer()
        {
            DLL = new WF.Core.DatabaseLogicLayer();
        }

        public int UserControl(string userName, string password)
        {
            int Result = 0;

            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {
                User user = new User();
                user.ID = Guid.NewGuid();
                user.UserName = userName;
                user.Password = password;

                Result = DLL.UserControl(user);


            }
            else
            {
                Result = -100; // Eksik sonuc.
            }
            return Result;
        }

        public int RecordUpdate(Guid id, string name, string surname, string phone1, string phone2, string phone3,
            string email, string adress, string webAdress, string explanation)
        {
            int result = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(phone1))
            {
                ContactRecord CR = new ContactRecord();
                CR.ID = id;
                CR.Name = name;
                CR.Surname = surname;
                CR.Phone1 = phone1;
                CR.Phone2 = phone2;
                CR.Phone3 = phone3;
                CR.Email = email;
                CR.Address = adress;
                CR.WebAddress = webAdress;
                CR.Explanation = explanation;
                result = DLL.RecordUpdate(CR);
            }
            else
            {
                result = -100;
            }
            return result;
        }

        public int DeleteRecord(Guid id)
        {
            return DLL.DeleteRecord(id);
        }

        // Kayıt bilgilerini "XML" olarak çekme."
        public int XMLSent()
        {
            int result = 0;

            try
            {

                List<ContactRecord> Records = DLL.Bringcontactrecords();

                XDocument Doc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"),
                                new XElement("ContactRecord", Records.Select
                                (I => new XElement("Record",
                                new XElement("ID", I.ID),
                                new XElement("Name", I.Name),
                                new XElement("Surname", I.Surname),
                                new XElement("Phone1", I.Phone1),
                                new XElement("Phone2", I.Phone2),
                                new XElement("Phone3", I.Phone3),
                                new XElement("EmailAddress", I.Email),
                                new XElement("Address", I.Address),
                                new XElement("Explanation", I.Explanation),
                                new XElement("WebAddress", I.WebAddress)))));
                Doc.Save(@"c:\PhoneBookDB\XMLSent");
                result = 1;
            }
            catch (Exception)
            {
                result = 0;
            }

            return result;
        }


        // Kayıt bilgilerini "CSV" olarak çekme."
        public int CSVSent()
        {
            int result = 0;

            try
            {
                List<ContactRecord> Records = DLL.Bringcontactrecords();

                StreamWriter SW = new StreamWriter(@"c:\PhoneBookDB\CSVSent.csv");
                CsvHelper.CsvWriter Write = new CsvHelper.CsvWriter(SW);
                Write.WriteHeader(typeof(ContactRecord));
                foreach (var item in Records)
                {
                    Write.WriteRecord<ContactRecord>(item);
                }
                SW.Close();
                result = 1;

            }
            catch (Exception)
            {

                result = 0;
            }

            return result;
        }

        // Kayıt bilgilerini "JSON" olarak çekme."
        public int JsonSent()
        {
            int result = 0;
            try
            {
                List<ContactRecord> Records = DLL.Bringcontactrecords();
                string JsonText = Newtonsoft.Json.JsonConvert.SerializeObject(Records);
                File.WriteAllText(@"c:\PhoneBookDB\JsonSent.json", JsonText);
                result = 1;

            }
            catch (Exception)
            {
                result = 0;

            }


            return result;
        }

        public int NewRecord(Guid id, string name, string surname, string phone1, string phone2, string phone3,
            string email, string adress, string webAdress, string explanation)
        {
            int result = 0;
            if (id != Guid.Empty && !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && !string.IsNullOrEmpty(phone1))
            {
                ContactRecord CR = new ContactRecord();

                CR.ID = id;
                CR.Name = name;
                CR.Surname = surname;
                CR.Phone1 = phone1;
                CR.Phone2 = phone2;
                CR.Phone3 = phone3;
                CR.Email = email;
                CR.Address = adress;
                CR.WebAddress = webAdress;
                CR.Explanation = explanation;

                result = DLL.NewRecord(CR);

            }
            else
            {
                result = -100; // Eksik değer.
            }


            return result;

        }

        public List<ContactRecord> Bringcontactrecords()
        {
            return DLL.Bringcontactrecords();
        }


    }
}
