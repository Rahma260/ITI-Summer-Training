using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using enumeration1;
using static System.Net.Mime.MediaTypeNames;
namespace c__day3_2
{
    public struct HireDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HireDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Day}/{Month}/{Year}";
        }
    }
    public class employee
    {
        int id;
        int security_level;
        int salary;
        enumeration.gender gender1;
        HireDate hiring_date;
        public employee(int id, int security_level, int salary, enumeration.gender gender1, HireDate hiring_date)
        {
            this.id = id;
            this.security_level = security_level;
            this.salary = salary;
            this.gender1 = gender1;
            this.hiring_date = hiring_date;

        }
        public int getId()
        {
            return id;
        }
        public int getSecurityLevel()
        {
            return security_level;
        }
        public int getSalary()
        {
            return salary;
        }
        public enumeration.gender getGender()
        {
            return gender1;
        }
        public HireDate getHiringDate()
        {
            return hiring_date;
        }
        public void setId(int id)
        {
            this.id = id;
        }
        public void setSecurityLevel(int security_level)
        {
            this.security_level = security_level;
        }
        public void setGender(enumeration.gender gender1)
        {
            this.gender1 = new enumeration.gender();
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public void setHiringDate(HireDate hiring_date)
        {
            this.hiring_date = new HireDate();
        }
        public override string ToString()
        {
            return $"id: {id}\nsecurity level: {security_level}\nsalary: {salary}\ngender: {gender1}\nhiring date: {hiring_date}";
        }
    }
}
