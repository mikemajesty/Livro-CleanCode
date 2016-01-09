using System;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    public class HourlyEmployee : Employee
    {
        private EmployeeRecord r;

        public HourlyEmployee(EmployeeRecord r)
        {
            this.r = r;
        }

        public override decimal calculatePay()
        {
            throw new NotImplementedException();
        }

        public override void deliverPay(decimal pay)
        {
            throw new NotImplementedException();
        }

        public override bool isPayday()
        {
            throw new NotImplementedException();
        }
    }
}