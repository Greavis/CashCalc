using Community.CsharpSqlite.SQLiteClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace CashCalc
{
    public partial class AurizationForm : Form
    {
        public AurizationForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseBtn_MouseEnter(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.FromArgb(239, 9, 55);
            CloseBtn.ForeColor = Color.White;
        }

        private void CloseBtn_MouseLeave(object sender, EventArgs e)
        {
            CloseBtn.BackColor = Color.Transparent;
            CloseBtn.ForeColor = Color.Black;
        }

        Point lastPoint;
        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void regBtn_Click(object sender, EventArgs e)
        {
            string SqlExpression = $"INSERT INTO Users (login, password) VALUES ('{loginField.Text}', '{passField.Text}')";
            string SqlCreateDB = $"CREATE TABLE '{loginField.Text}' ('id' INTEGER NOT NULL UNIQUE,'data' TEXT NOT NULL,'cash' INTEGER NOT NULL,PRIMARY KEY('id' AUTOINCREMENT))";

            dataCon db = new dataCon();
            if (loginField.Text == "")
            {
                MessageBox.Show("Поле логин должно быть заполнено");
                return;
            }
            else if (passField.Text == "")
            {
                MessageBox.Show("Поле пароль должно быть заполнено");
                return;
            }

            if (CheckUser())
            {
                MessageBox.Show("Пользователь уже существует");
                return;
            }

            db.openConnection();
            DataTable table = new DataTable();
            SqliteDataAdapter adapter = new SqliteDataAdapter();
            SqliteCommand loginMatch = new SqliteCommand($"SELECT * FROM Users WHERE login='{loginField.Text}' AND password='{passField.Text}'", db.getConnection());
            adapter.SelectCommand = loginMatch;
            adapter.Fill(table);
            
            if (table.Rows.Count == 0)
            {
                SqliteCommand commandCreateUser = new SqliteCommand(SqlExpression, db.getConnection());
                commandCreateUser.ExecuteNonQuery();
                SqliteCommand commandCreateDB = new SqliteCommand(SqlCreateDB, db.getConnection());
                commandCreateDB.ExecuteNonQuery();
                MessageBox.Show("OK");
            }
            else if(table.Rows.Count > 0)
            {
                MessageBox.Show("Юзер уже есть");
                return;
            }
            else
            {
                MessageBox.Show("хз.. сделай скрин");
                return;
            }
            db.closeConnection();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            dataCon db = new dataCon();
            if (loginField.Text == "")
            {
                MessageBox.Show("Поле логин должно быть заполнено");
                return;
            }
            else if (passField.Text == "")
            {
                MessageBox.Show("Поле пароль должно быть заполнено");
                return;
            }
                
            if (CheckUser())
            {
                PublicData.UserName = loginField.Text;

                this.Hide();
                CalcForm mainWondow = new CalcForm();
                mainWondow.Show();
                return;
            }
            else MessageBox.Show("Хуй");
        }
        public Boolean CheckUser()
        {
            dataCon db = new dataCon();

            DataTable table = new DataTable();
            SqliteDataAdapter adapter = new SqliteDataAdapter();
            SqliteCommand loginMatch = new SqliteCommand($"SELECT * FROM Users WHERE login='{loginField.Text}' AND password='{passField.Text}'", db.getConnection());

            adapter.SelectCommand = loginMatch;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return true;
            }
            else return false;
        }
    }
}
