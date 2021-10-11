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
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {
            dataCon db = new dataCon();
            DataTable table = new DataTable();
            db.openConnection();
            
            //создаем ридер и записываем в поле никнейм пользователя
            SqliteDataReader readerSqlCash = null;

            //SqliteCommand createCashForMonth = new SqliteCommand($"SELECT cash")
            //SqliteCommand userCashExtract = new SqliteCommand($"SELECT cashForMonth FROM '{usernameLabel}' ", db.getConnection());
            //readerSqlCash = userCashExtract.ExecuteReader();
            
            //while (readerSqlCash.Read())
            //{
                //usernameLabel.Text = (readerSql[0].ToString());
            //}
            
            usernameLabel.Text = PublicData.UserName;

        }

        public void CalcButton_Click(object sender, EventArgs e)
        {
            
            int textPrincipalAmount = Convert.ToInt32(principalAmount.Text); //Основной товар
            int textAksAmount = Convert.ToInt32(aksesAmount.Text);  //аксессуары
            double textPhoneOrder = Convert.ToInt32(phoneOrderCount.Text); //сумма телефонов под заказ
            double textSettings = Convert.ToInt32(settingsCount.Text); //настройки
            double textRepair30 = Convert.ToInt32(repairs30.Text); //ремонты 30%
            double textRepair50 = Convert.ToInt32(repairs50.Text); //ремонты 50%
            int textBonuses = Convert.ToInt32(bonusesCount.Text); //бонусы, симки, заказы и прочее

            string textMagazine = magazineCombo.Text; //магазин
            //int textExp = Convert.ToInt32(expBox); //стаж
            //int EmployeCountTemp = 
            //int textEpmloyeCount = Convert.ToInt32(); //количество сотрудников в смене ----------------- настроить через условие и булевую наверное
            double hours = Convert.ToDouble(hoursCount.Value); //количество часов с точкой

            double textSummAmount = textPrincipalAmount + textAksAmount + textPhoneOrder; //нужно вычитать сумму телефонов под заказ в других выражениях
            sumAmount.Text = Convert.ToString(textSummAmount);
            sumAmount.Update();
            double cashPerDay;

            int percentStair3;
            int percentStair2;
            int percentStair1;
            double percent1;
            double percent2;
            double percent3;
            int minAmoutPerDay;

            switch (textMagazine)
            {
                case "Артбухта":
                    percentStair3 = 20000;
                    percentStair2 = 18000;
                    percentStair1 = 13000;
                    minAmoutPerDay = 13000;
                    percent3 = 0.06;
                    percent2 = 0.05;
                    percent1 = 0.04;
                    getCashPerDay();
                    break;
                case "Меньшикова":
                    //if (textEmployeCount == 2)
                    //{ //-----------------------------------------------добавить выше условие для всех магазинов на количество сотрудников или
                    percentStair3 = 20000; //-----------------------------------------------сделать кейсы типа <магазин1чел> и <магазин2чел>
                    percentStair2 = 18000;
                    percentStair1 = 13000;
                    minAmoutPerDay = 13000;
                    percent3 = 0.06;
                    percent2 = 0.05;
                    percent1 = 0.04;
                    getCashPerDay();
                    break;
                case "Центр":
                    percentStair3 = 15000;
                    percentStair2 = 10000;
                    percentStair1 = 8000;
                    minAmoutPerDay = 10000;
                    percent3 = 0.05;
                    percent2 = 0.04;
                    percent1 = 0.03;
                    getCashPerDay();
                    break;
                case "Пожарова":
                    percentStair3 = 5000;
                    percentStair2 = 4000;
                    percentStair1 = 3000;
                    minAmoutPerDay = 4000;
                    percent3 = 0.05;
                    percent2 = 0.04;
                    percent1 = 0.03;
                    getCashPerDay();
                    break;
                case "Остряки":
                    percentStair3 = 5000;
                    percentStair2 = 4000;
                    percentStair1 = 3000;
                    minAmoutPerDay = 4000;
                    percent3 = 0.05;
                    percent2 = 0.04;
                    percent1 = 0.03;
                    getCashPerDay();
                    break;
                case "Юмашева":
                    percentStair3 = 12000;
                    percentStair2 = 8000;
                    percentStair1 = 6000;
                    minAmoutPerDay = 8000;
                    percent3 = 0.05;
                    percent2 = 0.04;
                    percent1 = 0.03;
                    getCashPerDay();
                    break;
                default:
                    MessageBox.Show("Выбери магазин");
                    break;
            }

            double getCashPerDay()
            {
                if (textSummAmount >= minAmoutPerDay)
                {
                    if (textAksAmount >= percentStair3)
                    {
                        cashPerDay = (textSummAmount-textPhoneOrder) * 0.02 + textAksAmount * percent3 + textSettings * 0.3 + textRepair30 * 0.3 + textRepair50 * 0.5 + textBonuses + hours * 100;
                        daySalary.Text = Convert.ToString(cashPerDay);
                        daySalary.Update();
                        return cashPerDay;
                    }
                    else if (textAksAmount >= percentStair2)
                    {
                        cashPerDay = (textSummAmount - textPhoneOrder) * 0.02 + textAksAmount * percent2 + textSettings * 0.3 + textRepair30 * 0.3 + textRepair50 * 0.5 + textBonuses + hours * 100;
                        daySalary.Text = Convert.ToString(cashPerDay);
                        return cashPerDay;
                    }
                    else if (textAksAmount >= percentStair1)
                    {
                        cashPerDay = (textSummAmount - textPhoneOrder) * 0.02 + textAksAmount * percent1 + textSettings * 0.3 + textRepair30 * 0.3 + textRepair50 * 0.5 + textBonuses + hours * 100;
                        daySalary.Text = Convert.ToString(cashPerDay);
                        return cashPerDay;
                    }
                    else if (textAksAmount < percentStair1)
                    {
                        cashPerDay = (textSummAmount - textPhoneOrder) * 0.02 + textAksAmount * 0.02 + textSettings * 0.3 + textRepair30 * 0.3 + textRepair50 * 0.5 + textBonuses + hours * 100;
                        daySalary.Text = Convert.ToString(cashPerDay);
                        return cashPerDay;
                    }
                }
                if ((textSummAmount - textPhoneOrder) < minAmoutPerDay)
                {
                    cashPerDay = textSettings * 0.3 + textRepair30 * 0.3 + textRepair50 * 0.5 + textBonuses + (hours * 100 - 300);
                    daySalary.Text = Convert.ToString(cashPerDay);
                    return cashPerDay;
                }
                cashPerDay = 0;
                daySalary.Text = Convert.ToString(cashPerDay);
                return cashPerDay;
            }
        }

        private void principalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void aksesAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void phoneOrderCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void settingsCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void repairs30_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void repairs50_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void bonusesCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number)) e.Handled = true;
        }

        private void principalAmount_Click(object sender, EventArgs e)
        {
            if(principalAmount.Text == "0")
            {
                principalAmount.Text = "";
                principalAmount.Update();
            }
        }
    }
}
