using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag_4
{
       // interface = comapering the three  method 
    
        public interface IComputeEmpWage
        {
            public void addCompanyEmpWage(string Name, int PerHour, int WorkingDays, int hour);
            public void computeEmpWage();
            public int getTotalEmpWage(int value);

        }
        public class CompanyEmpWage
        {
            public string Name;
            public int PerHour;
            public int WorkingDays;
            public int hour;
            public int totalEmpWage;

            public CompanyEmpWage(string Name, int PerHour, int WorkingDays, int hour)
            {
                this.Name = Name;
                this.PerHour = PerHour;
                this.WorkingDays = WorkingDays;
                this.hour = hour;
            }

            public void setTotalEmpWage(int totalEmpWage)
            {
                this.totalEmpWage = totalEmpWage;
            }

            public string toString()
            {
                return "Total Emp Wage for company: " + this.Name + " is : " + this.totalEmpWage;
            }
        }
    
}
