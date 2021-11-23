using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TFCS__FirstWork
{
    public partial class UserActionsForm : Form
    {
        static string loginGglobal;
        public UserActionsForm(string login)
        {
            InitializeComponent();
            loginGglobal = login;
            LoadDate();
        }
        private void LoadDate()
        {
            DataBase DataBase = new DataBase();

            DataBase.OpenConnection();

            SqlCommand idUserCommand = new SqlCommand("SELECT TOKB.dbo.Users.id_user FROM TOKB.dbo.Users WHERE login = @UserLogin", DataBase.GetConnection());
            idUserCommand.Parameters.AddWithValue("UserLogin", loginGglobal);

            SqlDataReader idUserReader = idUserCommand.ExecuteReader();

            SqlCommand Command = new SqlCommand("SELECT TOKB.dbo.Logging.time, TOKB.dbo.Logging.description FROM TOKB.dbo.Logging JOIN TOKB.dbo.Users ON TOKB.dbo.Users.id_user = @idUser AND TOKB.dbo.Logging.id_user = @idUser", DataBase.GetConnection());
            idUserReader.Read();
            Command.Parameters.AddWithValue("idUser", idUserReader.GetValue(0));
            idUserReader.Close();

            SqlDataReader Reader = Command.ExecuteReader();

            SortedDictionary<DateTime, string> Data = new SortedDictionary<DateTime, string>();

            while (Reader.Read())
            {
                Data.Add(Convert.ToDateTime(Reader[0]), Reader[1].ToString());
            }
            Reader.Close();

            DataBase.CloseConnection();

            foreach (KeyValuePair<DateTime, string> pair in Data)
            {
                dataGridView.Rows.Add(pair.Key, pair.Value);
            }
        }
    }
}
