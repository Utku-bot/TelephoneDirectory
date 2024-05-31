


using System.Data.SqlClient;
using System.Net.Mail;
using TelephoneDirectory.Entities;

namespace TelephoneDirectory.DatabaseLogicLayer
{
    public class DLL
    {
        SqlConnection sqlConnection;
        SqlCommand cmd;
        SqlDataReader reader;
        int returnValues; // etlilenen sütün adedi için

        public DLL()
        {
            sqlConnection = new SqlConnection("Server=DESKTOP-SPA75NF\\SQLEXPRESS;Database=phoneBook;User Id=sa;Password=12345");
        }

        public void ConnectionSet()
        {
            if (sqlConnection.State==System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
            else
            {
                sqlConnection.Close();
            }
        }

        public int SystemControl(User user )
        {
            try
            {
                cmd = new SqlCommand("select count(*) from PhoneUser where PhoneUserName =@PhoneUserName and PhoneUserPassword = @PhoneUserPassword", sqlConnection);
                cmd.Parameters.Add("@PhoneUserName", System.Data.SqlDbType.NVarChar).Value = user.userName;
                cmd.Parameters.Add("@PhoneUserPassword", System.Data.SqlDbType.NVarChar).Value = user.password;

                ConnectionSet();
                returnValues = (int)cmd.ExecuteScalar();
            }

            catch (Exception)
            {

                throw;
            }
            finally { 

                ConnectionSet();

            } 
            return returnValues;
        }
        public int AddRecord(PhoneDirectory phoneDirectory)
        {
            try
            {
                cmd = new SqlCommand("insert into Directory (ID,PersonName,PersonSurname,PhoneNumberI,PhoneNumberII,PhoneNumberIII,EmailAddress,WebAddress,Addresss,Descriptions) " +
                    "values(@ID,@PersonName,@PersonSurname,@PhoneNumberI,@PhoneNumberII,@PhoneNumberIII,@EmailAddress,@WebAddress,@Addresss,@Descriptions)" +
                    "",sqlConnection);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = phoneDirectory.ID;
                cmd.Parameters.Add("@PersonName", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.name;
                cmd.Parameters.Add("@PersonSurName", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.surname;
                cmd.Parameters.Add("@PhoneNumberI", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.phoneNumberI;
                cmd.Parameters.Add("@PhoneNumberII", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.phoneNumberII;
                cmd.Parameters.Add("@PhoneNumberIII", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.phoneNumberIII;
                cmd.Parameters.Add("@EmailAddress", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.emailAddress;
                cmd.Parameters.Add("@WebAddress", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.webAddress;
                cmd.Parameters.Add("@Descriptions", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.description;
                cmd.Parameters.Add("@Addresss", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.webAddress;
                ConnectionSet(); // .Net ile Sql arasındaki bağlantıyı al
              returnValues =  cmd.ExecuteNonQuery(); // Insert sorgusunu Sql'e göndermek için

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConnectionSet(); // İşlem bittikten sonra aradaki bağlantıyı kapatmak için
            }
            return returnValues;

        }
        public int UpdateRecord(PhoneDirectory phoneDirectory)
        {
            try
            {
                cmd = new SqlCommand(@"update Directory set PersonName = @PersonName,PersonSurname = @PersonSurname,PhoneNumberI = @PhoneNumberI,PhoneNumberII = @PhoneNumberII,PhoneNumberIII = @PhoneNumberIII,EmailAddress = @EmailAddress,Addresss = @Addresss, Descriptions = @Descriptions where ID =@ID", sqlConnection);
                cmd.Parameters.Add("@PersonName", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.name;
                cmd.Parameters.Add("@PersonSurname", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.surname;
                cmd.Parameters.Add("@PhoneNumberI", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.phoneNumberI;
                cmd.Parameters.Add("@PhoneNumberII", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.phoneNumberII;
                cmd.Parameters.Add("@PhoneNumberIII", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.phoneNumberIII;
                cmd.Parameters.Add("@EmailAddress", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.emailAddress;
                cmd.Parameters.Add("@WebAddress", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.webAddress;
                cmd.Parameters.Add("@Addresss", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.address;

                cmd.Parameters.Add("@Descriptions", System.Data.SqlDbType.NVarChar).Value = phoneDirectory.description;
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = phoneDirectory.ID;

                ConnectionSet(); // .Net ile Sql arasındaki bağlantıyı al
                returnValues = cmd.ExecuteNonQuery(); // Insert sorgusunu Sql'e göndermek için

            }




            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConnectionSet(); // İşlem bittikten sonra aradaki bağlantıyı kapatmak için
            }
            return returnValues;

        }
        public int DeleteRecord(Guid id)
        {
            try
            {
                cmd = new SqlCommand(@"delete Directory where ID =@ID ", sqlConnection);
                cmd.Parameters.Add("@ID", System.Data.SqlDbType.UniqueIdentifier).Value = id;
                ConnectionSet(); // .Net ile Sql arasındaki bağlantıyı al
                returnValues = cmd.ExecuteNonQuery(); // Insert sorgusunu Sql'e göndermek için

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                ConnectionSet(); // İşlem bittikten sonra aradaki bağlantıyı kapatmak için
            }
            return returnValues;

        }

        public SqlDataReader RecordList()
        {
            cmd = new SqlCommand("Select * from Directory",sqlConnection);
            ConnectionSet();
            return cmd.ExecuteReader();
            }


        public SqlDataReader RecordById(Guid id)
        {
            cmd = new SqlCommand("Select * from Directory where ID = @ID", sqlConnection);
            cmd.Parameters.Add("@ID",System.Data.SqlDbType.UniqueIdentifier).Value = id;
            ConnectionSet();
            return cmd.ExecuteReader();
        }




    }


   

}

