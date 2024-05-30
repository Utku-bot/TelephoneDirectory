using System.Data.SqlClient;
using System.Net;
using System.Reflection.PortableExecutable;
using System.Xml.Linq;
using TelephoneDirectory.Entities;

namespace TelephoneDirectory.BusinessLogicLayer
{
    public class BLL
    {

        DatabaseLogicLayer.DLL dll;
        public BLL()
        {
            dll = new DatabaseLogicLayer.DLL();
        }


        public int SystemControl(string userName, string password)
        {
            if (!string.IsNullOrEmpty(userName) && !string.IsNullOrEmpty(password))
            {

                return dll.SystemControl(new User()
                {
                    userName = userName,
                    password = password



                });

            }
            else
            {
                return -1;
            }
        }

        public int AddRecord(string name, string surName, string phoneNumberI, string phoneNumberII, string phoneNumberIII,
            string email, string address, string webAddress, string description)
        {
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surName) && !string.IsNullOrEmpty(phoneNumberI))
            {

                return dll.AddRecord(new PhoneDirectory()
                {
                    ID = Guid.NewGuid(),
                    name = name,
                    surname = surName,
                    phoneNumberI = phoneNumberI,
                    phoneNumberII = phoneNumberII,
                    phoneNumberIII = phoneNumberIII,
                    emailAddress = email,
                    address = address,
                    webAddress = webAddress,
                    description = description

                });

            }
            else
            {
                return -1;
            }




        }





        public int UpdateRecord(Guid id, string name, string surName, string phoneNumberI, string phoneNumberII, string phoneNumberIII,
            string email, string address, string webAddress, string description)
        {

            if (id != Guid.Empty)
            {
                return dll.UpdateRecord(new PhoneDirectory()
                {

                    ID = id,
                    name = name,
                    surname = surName,
                    phoneNumberI = phoneNumberI,
                    phoneNumberII = phoneNumberII,
                    phoneNumberIII = phoneNumberIII,
                    emailAddress = email,
                    address = address,
                    webAddress = webAddress,
                    description = description




                });
            }
            else
            {
                return -1;
            }

        }



        public int DeleteRecord(Guid id)
        {
            if (id != Guid.Empty)
            {
                return dll.DeleteRecord(id);
            }
            else
            {
                return -1;
            }
        }


        public List<PhoneDirectory> RecordList()
        {
            List<PhoneDirectory> phoneDirectories = new List<PhoneDirectory>();

            try
            {
                SqlDataReader sqlDataReader = dll.RecordList();
                while (sqlDataReader.Read())
                {
                    phoneDirectories.Add(new PhoneDirectory()
                    {

                        ID = sqlDataReader.IsDBNull(0) ? Guid.Empty : sqlDataReader.GetGuid(0),
                        name = sqlDataReader.IsDBNull(1) ? string.Empty : sqlDataReader.GetString(1),
                        surname = sqlDataReader.IsDBNull(2) ? string.Empty : sqlDataReader.GetString(2),
                        phoneNumberI = sqlDataReader.IsDBNull(3) ? string.Empty : sqlDataReader.GetString(3),
                        phoneNumberII = sqlDataReader.IsDBNull(4) ? string.Empty : sqlDataReader.GetString(4),
                        phoneNumberIII = sqlDataReader.IsDBNull(5) ? string.Empty : sqlDataReader.GetString(5),
                        emailAddress = sqlDataReader.IsDBNull(6) ? string.Empty : sqlDataReader.GetString(6),
                        webAddress = sqlDataReader.IsDBNull(7) ? string.Empty : sqlDataReader.GetString(7),
                        address = sqlDataReader.IsDBNull(8) ? string.Empty : sqlDataReader.GetString(8),
                        description = sqlDataReader.IsDBNull(9) ? string.Empty : sqlDataReader.GetString(9)

                    });
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {

                throw;
            
            }
            finally
            {
                dll.ConnectionSet();
            }
            return phoneDirectories;










        }

        public PhoneDirectory RecordById(Guid id)
        {
            PhoneDirectory phoneDirectorie = new PhoneDirectory();

            try
            {
                SqlDataReader sqlDataReader = dll.RecordById(id);
                while (sqlDataReader.Read())
                {
                    phoneDirectorie = new PhoneDirectory()
                    {

                        ID = sqlDataReader.IsDBNull(0) ? Guid.Empty : sqlDataReader.GetGuid(0),
                        name = sqlDataReader.IsDBNull(1) ? string.Empty : sqlDataReader.GetString(1),
                        surname = sqlDataReader.IsDBNull(2) ? string.Empty : sqlDataReader.GetString(2),
                        phoneNumberI = sqlDataReader.IsDBNull(3) ? string.Empty : sqlDataReader.GetString(3),
                        phoneNumberII = sqlDataReader.IsDBNull(4) ? string.Empty : sqlDataReader.GetString(4),
                        phoneNumberIII = sqlDataReader.IsDBNull(5) ? string.Empty : sqlDataReader.GetString(5),
                        emailAddress = sqlDataReader.IsDBNull(6) ? string.Empty : sqlDataReader.GetString(6),
                        webAddress = sqlDataReader.IsDBNull(7) ? string.Empty : sqlDataReader.GetString(7),
                        address = sqlDataReader.IsDBNull(8) ? string.Empty : sqlDataReader.GetString(8),
                        description = sqlDataReader.IsDBNull(9) ? string.Empty : sqlDataReader.GetString(9)

                    };
                }
                sqlDataReader.Close();
            }
            catch (Exception)
            {

                throw;

            }
            finally
            {
                dll.ConnectionSet();
            }
            return phoneDirectorie;




        }
    }
}
