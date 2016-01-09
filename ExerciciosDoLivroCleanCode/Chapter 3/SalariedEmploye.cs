using System;

namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    internal class SalariedEmploye : Employee
    {
        private EmployeeRecord r;

        public SalariedEmploye(EmployeeRecord r)
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