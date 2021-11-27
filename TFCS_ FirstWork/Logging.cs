using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace TFCS__FirstWork
{
    internal class Logging
    {
        private void InsertDescriptionDataForUser(string Login, string message)
        {
            DataBase dataBase = new DataBase();
            DateTime timeNow = DateTime.Now;

            dataBase.OpenConnection();

            SqlCommand idUserCommand = new SqlCommand("SELECT TOKB.dbo.Users.id_user FROM TOKB.dbo.Users WHERE login = @UserLogin", dataBase.GetConnection());
            idUserCommand.Parameters.AddWithValue("UserLogin", Login);

            SqlDataReader idUserReader = idUserCommand.ExecuteReader();

            if (idUserReader.Read())
            {
                SqlCommand command = new SqlCommand("INSERT INTO TOKB.dbo.Logging (id_user, time, description) VALUES (@UserId, @LogTime, @LogDescription)", dataBase.GetConnection());

                command.Parameters.AddWithValue("UserId", idUserReader.GetValue(0));
                command.Parameters.AddWithValue("LogTime", timeNow);
                command.Parameters.AddWithValue("LogDescription", message);
                idUserReader.Close();

                try
                {
                    command.ExecuteNonQuery();

                }
                catch
                {
                    MessageBox.Show("Ошибка логирования", "Уведомление", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show("Ошибка логирования", "Уведомление", MessageBoxButtons.OK);
            }
            dataBase.CloseConnection();
        }

        public void UserAddFromAdmin(string LoginUser)
        {
            string msg = "Админ добавил пользователя";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void UserTryLoginInFrozenAccount(string LoginUser)
        {
            string msg = "Пользователь попытался войти в замороженный аккаунт";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void UserFirstlyLoginInAccount(string LoginUser)
        {
            string msg = "Пользователь впервые вошёл в аккаунт";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void UserTryLoginWithOldPassword(string LoginUser)
        {
            string msg = "Пользователь пытается войти со старым поролем";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void UserLoginInAccount(string LoginUser)
        {
            string msg = "Пользователь вошёл в аккаунт";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void UserLogoutFromAccount(string LoginUser)
        {
            string msg = "Пользователь вышел из аккаунта";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void UserChangePasswordInAccount(string LoginUser)
        {
            string msg = "Пользователь сменил пароль в аккаунте";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void AdminFrozenUser(string LoginUser)
        {
            string msg = "Пользователь заблокирован Администратором";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void AdminUnFrozenUser(string LoginUser)
        {
            string msg = "Пользователь разблокирован Администратором";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void AdminUpdateDateTimeExpiredAndSizePasswordAndHardestPassword(string LoginUser)
        {
            string msg = "Админ обновил время истечения пароля, размер пароля и установил усложнённый пароль";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
        public void AdminUpdateDateTimeExpiredAndSizePassword(string LoginUser)
        {
            string msg = "Админ обновил время истечения пароля и размер пароля";
            InsertDescriptionDataForUser(LoginUser, msg);
        }
    }
}
