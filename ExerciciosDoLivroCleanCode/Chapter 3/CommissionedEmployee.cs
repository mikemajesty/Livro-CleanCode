using System;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    internal class CommissionedEmployee : Employee
    {
        private EmployeeRecord r;

        public CommissionedEmployee(EmployeeRecord r)
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