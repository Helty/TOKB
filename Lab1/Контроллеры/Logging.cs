using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TOKB
{
    internal class Logging
    {
        private void InsertDescriptionDataForUser(string Login, string message)
        {
            DataBase dataBase = new DataBase();
            DateTime timeNow = DateTime.Now;

            dataBase.OpenConnection();

            SqlCommand idUserCommand = new SqlCommand("SELECT TOKB.dbo.Users.id FROM TOKB.dbo.Users WHERE login = @UserLogin", dataBase.GetConnection());
            idUserCommand.Parameters.AddWithValue("UserLogin", Login);

            SqlDataReader idUserReader = idUserCommand.ExecuteReader();

            if (idUserReader.Read())
            {
                SqlCommand command = new SqlCommand("INSERT INTO TOKB.dbo.Logging (id_user, time, description) VALUES (@UserId, @LogTime, @LogDescription)", dataBase.GetConnection());

                command.Parameters.AddWithValue("UserId", idUserReader.GetValue(0));
                command.Parameters.AddWithValue("LogTime", timeNow);
                command.Parameters.AddWithValue("LogDescription", message);
                idUserReader.Close();

                command.ExecuteNonQuery();

                //try
                //{
                //    command.ExecuteNonQuery();

                //}
                //catch
                //{
                //    MessageBox.Show("Ошибка логирования command.ExecuteNonQuery();", "Уведомление", MessageBoxButtons.OK);
                //}
            }
            else
            {
                MessageBox.Show("Ошибка логирования idUserReader.Read()", "Уведомление", MessageBoxButtons.OK);
            }
            dataBase.CloseConnection();
        }

        public void UserAddFromAdmin(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Админ добавил пользователя");
        }
        public void UserTryLoginInFrozenAccount(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь попытался войти в замороженный аккаунт");
        }
        public void UserFirstlyLoginInAccount(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь впервые вошёл в аккаунт");
        }
        public void UserTryLoginWithOldPassword(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь пытается войти со старым поролем");
        }
        public void UserLoginInAccount(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь вошёл в аккаунт");
        }
        public void UserLogoutFromAccount(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь вышел из аккаунта");
        }
        public void UserChangePasswordInAccount(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь сменил пароль в аккаунте");
        }
        public void AdminFrozenUser(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь заблокирован Администратором");
        }
        public void AdminUnFrozenUser(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Пользователь разблокирован Администратором");
        }
        public void AdminUpdateDateTimeExpiredAndSizePasswordAndHardestPassword(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Админ обновил время истечения пароля, размер пароля и установил усложнённый пароль");
        }
        public void AdminUpdateDateTimeExpiredAndSizePassword(string LoginUser)
        {
            InsertDescriptionDataForUser(LoginUser, "Админ обновил время истечения пароля и размер пароля");
        }
    }
}
