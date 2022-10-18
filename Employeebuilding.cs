using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWag_4
{
    
    
        public class Employeebuilding: IComputeEmpWage
        {
            public const int IS_PART_TIME = 1;
            public const int IS_FULL_TIME = 2;

            private int numOfCompany = 0;
            private CompanyEmpWage[] companyEmpWageArray;

            public Employeebuilding()
            {
                this.companyEmpWageArray = new CompanyEmpWage[5];
            }

            public void addCompanyEmpWage(string Name, int PerHour, int WorkingDays, int hour)
            {
                companyEmpWageArray[this.numOfCompany] = new CompanyEmpWage(Name, PerHour, WorkingDays, hour);
                numOfCompany++;
            }

            public void computeEmpWage()
            {
                for (int i = 0; i<numOfCompany; i++)
                {
                    int val = this.computeEmpWage(this.companyEmpWageArray[i]);
                    companyEmpWageArray[i].setTotalEmpWage(val);
                    Console.WriteLine(this.companyEmpWageArray[i].toString());
                }
            }

            private int computeEmpWage(CompanyEmpWage companyEmpWage)
            {
                int empHr = 0, totalHrs = 0, totalWorkingDays = 0;
                while (totalHrs <= companyEmpWage.hour && totalWorkingDays < companyEmpWage.WorkingDays)
                {
                    totalWorkingDays++;
                    Random random = new Random();
                    int emp = random.Next(0, 3);
                    switch (emp)
                    {
                        case IS_PART_TIME:
                            empHr = 4;
                            break;
                        case IS_FULL_TIME:
                            empHr = 8;
                            break;
                        default:
                            empHr = 0;
                            break;
                    }
                    totalHrs += empHr;
                    Console.WriteLine("Day# :" + totalWorkingDays + " Emp Hrs: " + empHr);
                }
                return totalHrs * companyEmpWage.PerHour;
            }

            public int getTotalEmpWage(int value)
            {
                return this.companyEmpWageArray[value].totalEmpWage;
            }
        }
    
}
