using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WSB_Projekt_Szpital_Logic
{
    [Serializable]
    public class DatePlaner
    {
        [XmlArrayItem(typeof(List<User>[])), XmlArrayItem(typeof(List<User>)), XmlArrayItem(typeof(User)), XmlArrayItem(typeof(Admin)), XmlArrayItem(typeof(Doctor)), XmlArrayItem(typeof(Nurse))]
        public List<User>[] dataDay;
        public int days;
        public int month;
        public int year;

        public string CheckInfo { get; private set; }

        public DatePlaner()
        {
            DateTime date = DateTime.Now;

            this.dataDay = new List<User>[DateTime.DaysInMonth(date.Year, date.Month)];
            this.days = DateTime.DaysInMonth(date.Year, date.Month);
            this.month = date.Month;
            this.year = date.Year;

            this.CheckInfo = "";

            for (int i = 0; i < this.dataDay.Length; i++)
            {
                this.dataDay[i] = new List<User>();
            }
        }

        public DatePlaner(int month, int year)
        {
            this.dataDay = new List<User>[DateTime.DaysInMonth(year, month)];
            this.days = DateTime.DaysInMonth(year, month);
            this.month = month;
            this.year = year;

            this.CheckInfo = "";

            for (int i = 0; i < this.dataDay.Length; i++)
            {
                this.dataDay[i] = new List<User>();
            }
        }

        public static DatePlaner Copy(DatePlaner alfa)
        {
            int year = alfa.year;
            int month = (alfa.month + 1) % 13;
            if (month == 0)
            {
                month++;
                year++;
            }

            DatePlaner buff = new DatePlaner(month,year);

            for (int i = 0; i < buff.dataDay.Length; i++)
            {
                try
                {
                    for (int j = 0; j < alfa.dataDay[i].Count; j++)
                    {
                        buff.dataDay[i].Add(alfa.dataDay[i][j]);
                    }
                }
                catch
                {
                    break;
                }
            }
            return buff;
        }

        public static DatePlaner RewerseCopy(DatePlaner alfa)
        {
            int year = alfa.year;
            int month = alfa.month - 1;
            if (month == 0)
            {
                month = 12;
                year--;
            }

            DatePlaner buff = new DatePlaner(month, year);

            for (int i = 0; i < buff.dataDay.Length; i++)
            {
                try
                {
                    for (int j = 0; j < alfa.dataDay[i].Count; j++)
                    {
                        buff.dataDay[i].Add(alfa.dataDay[i][j]);
                    }
                }
                catch
                {
                    break;
                }
            }
            return buff;
        }

        public void Add(int day, User user)
        {
            if (day <= 0 || day > this.days) return;

            for (int i = 0; i < this.dataDay[day - 1].Count; i++)
            {
                if (this.dataDay[day - 1][i].MinEquals(user))
                {
                    return;
                }
            }
            this.dataDay[day - 1].Add(user);
        }

        public void Remove(int day, User user)
        {
            if (day <= 0 || day > this.days) return;

            for (int i = 0; i < this.dataDay[day - 1].Count; i++)
            {
                if (this.dataDay[day - 1][i].MinEquals(user))
                {
                    this.dataDay[day - 1].RemoveAt(i);
                }
            }
        }

        public bool Check()
        {
            CheckInfo = "";

            bool fail = false;

            List<User> howUser_users = new List<User>();
            List<int> howUser_number = new List<int>();

            List<string> howDoctorSpec_spec = new List<string>();
            List<int> howDoctorSpec_number = new List<int>();

            for (int day = 0; day < this.dataDay.Length; day++)
            {
                for (int user = 0; user < this.dataDay[day].Count; user++)
                {
                    if (howUser_users.Exists(x => x.MinEquals(this.dataDay[day][user])))
                    {
                        howUser_number[howUser_users.FindIndex(x => x.MinEquals(this.dataDay[day][user]))]++;
                    }
                    else
                    {
                        howUser_users.Add(this.dataDay[day][user]);
                        howUser_number.Add(1);
                    }

                    if (this.dataDay[day][user] is Doctor)
                    {
                        if (howDoctorSpec_spec.Exists(x => x == (this.dataDay[day][user] as Doctor).TypeDoctor))
                        {
                            howDoctorSpec_number[howDoctorSpec_spec.FindIndex(x => x == (this.dataDay[day][user] as Doctor).TypeDoctor)]++;
                        }
                        else
                        {
                            howDoctorSpec_spec.Add((this.dataDay[day][user] as Doctor).TypeDoctor);
                            howDoctorSpec_number.Add(1);
                        }
                    }

                    if (day != 0)
                    {
                        if (this.dataDay[day - 1].Exists(x => x.MinEquals(this.dataDay[day][user])))
                        {
                            CheckInfo += $"{day + 1}.{this.month}.{this.year} - {this.dataDay[day][user].Name} {this.dataDay[day][user].Surname} - pracuje 2 dni z rzędu\n";
                            fail = true;
                        }
                    }
                }

                for (int i = 0; i < howDoctorSpec_number.Count; i++)
                {
                    if (howDoctorSpec_number[i] > 1)
                    {
                        CheckInfo += $"{day + 1}.{this.month}.{this.year} - Specjalizacja {howDoctorSpec_spec[i]} występuje więcej niż raz tego dnia ({howDoctorSpec_number[i]})\n";
                        fail = true;
                    }
                }

                howDoctorSpec_number.Clear();
                howDoctorSpec_spec.Clear();
                //CheckInfo += "+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n";
            }

            for (int i = 0; i < howUser_number.Count; i++)
            {
                if (howUser_number[i] > 10)
                {
                    CheckInfo += $"Pracownik {howUser_users[i].Name} {howUser_users[i].Surname} {howUser_users[i].Role} ma więcej niż 10 dyżurów w miesiącu ({howUser_number[i]})\n";
                    fail = true;
                }
            }

            return !fail;
        }

        public List<User> GetDayUserList(int day)
        {
            if (day <= 0 || day > this.days) return null;

            List<User> buff = new List<User>();

            for (int i = 0; i < this.dataDay[day - 1].Count; i++)
            {
                buff.Add(this.dataDay[day - 1][i]);  
            }
            return buff;
        }

        public List<StringModulDataTime> GetDataTimeFromUser(User user)
        {
            List<StringModulDataTime> list = new List<StringModulDataTime>();

            for (int i = 0; i < this.dataDay.Length; i++)
            {
                for (int j = 0; j < this.dataDay[i].Count; j++)
                {
                    if (this.dataDay[i][j].MinEquals(user))
                    {
                        list.Add(new StringModulDataTime($"{i + 1}.{this.month}.{this.year}r"));
                    }
                }
            }
            return list;
        }
    }

    public class StringModulDataTime
    {
        public string Data { get; set; }

        public StringModulDataTime(string data)
        {
            this.Data = data;
        }
    }
}
