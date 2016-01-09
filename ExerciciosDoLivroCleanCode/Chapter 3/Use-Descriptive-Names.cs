namespace ExerciciosDoLivroCleanCode.Chapter_3
{
    class Use_Descriptive_Names
    {
    }
    public abstract class Employee
    {
        public abstract bool isPayday();
        public abstract decimal calculatePay();
        public abstract void deliverPay(decimal pay);
    }

    public interface EmployeeFactory
    {
        Employee makeEmployee(EmployeeRecord r);
    }

    public class EmployeeFactoryImpl: EmployeeFactory
    {
        public Employee makeEmployee(EmployeeRecord r)
        {
            switch (r.type)
            {
                case EmployeeRecord.COMMISSIONED:
                    return new CommissionedEmployee(r);
                case EmployeeRecord.HOURLY:
                    return new HourlyEmployee(r);
                case EmployeeRecord.SALARIED:
                    return new SalariedEmploye(r);
                default:
                    throw new InvalidEmployeeType(r.type);
            }
        }
    }
}


