using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WF.Entities;

namespace WF.Core
{
    public class DatabaseLogicLayer
    {
        List<ContactRecord> Records;

        public DatabaseLogicLayer()
        {
            Records = new List<ContactRecord>();
            DatabaseControl();
        }

        private void DatabaseControl()
        {
            // Dosya varmı?
            bool control = Directory.Exists(@"c:\PhoneBookDB\");

            if (!control)
            {
                // Yoksa oluştur !
                Directory.CreateDirectory(@"c:\PhoneBookDB\");

                //Demo hesap.
                
                User Demo = new User();
                Demo.ID = Guid.NewGuid();
                Demo.UserName = "Demo";
                Demo.Password = "Demo";



                string JsonUserTxt = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"c:\PhoneBookDB\user.json", JsonUserTxt);
            }
        }

        public int RecordUpdate(ContactRecord R)
        {
            int result = 0;

            try
            {
                Bringcontactrecords();
                int Index = Records.FindIndex(I => I.ID == R.ID);
                if(Index > -1) 
                {
                    Records[Index].Name = R.Name;
                    Records[Index].Email = R.Email;
                    Records[Index].Surname = R.Surname;
                    Records[Index].Phone1 = R.Phone1;
                    Records[Index].Phone2 = R.Phone2;
                    Records[Index].Phone3 = R.Phone3;
                    Records[Index].Address = R.Address;
                    Records[Index].WebAddress = R.WebAddress;
                    Records[Index].Explanation = R.Explanation;
                }
                JsonDbUpdate();
                result = 1;
            }
            catch (Exception ) 
            {

            }
            return result;
        }

        public int DeleteRecord(Guid ID)
        {
         int result = 0;

            try
            {
                Bringcontactrecords();
                ContactRecord DeleteValue = Records.Find(I => I.ID == ID);
                if(DeleteValue != null)
                {
                    Records.Remove(DeleteValue);
                }
                JsonDbUpdate();
                result = 1;

            }
            catch(Exception )
            {

            }
            return result;

        }

        public int NewRecord(ContactRecord L)
        {
            int result = 0;
            try
            {
                Bringcontactrecords();
                Records.Add(L); // Koleksiyona değer eklendi.
                JsonDbUpdate(); //Var ise üzerine yazdı , yoksa yeni json oluşturdu.
                result = 1;
            }
            catch (Exception)
            {
                result = 0;
            }
            return result;
        }

        public List<ContactRecord> Bringcontactrecords()
        {
            if (File.Exists(@"c:\PhoneBookDB\directory.json"))
            {
                string JsonText = File.ReadAllText(@"c:\PhoneBookDB\directory.json");
                Records = Newtonsoft.Json.JsonConvert.DeserializeObject<List<ContactRecord>>(JsonText);
            }
            return Records;
        }


        public int UserControl(User _User)
        {
            int userResult = 0;

            if(File.Exists(@"c:\PhoneBookDB\user.json"))
            {
                string JsonUserTxt = File.ReadAllText(@"c:\PhoneBookDB\user.json");
                List<User> Users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>(JsonUserTxt);

                userResult = Users.FindAll(I => I.UserName == _User.UserName && I.Password == _User.Password).ToList().Count();

            }

            return userResult;
        }


        #region helper methods

        private void JsonDbUpdate()
        {
            if (Records.Count > 0 && Records != null)
            {
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(Records);

                File.WriteAllText(@"c:\PhoneBookDB\directory.json", JsonDB);
            }
        }


        #endregion


    }
}
