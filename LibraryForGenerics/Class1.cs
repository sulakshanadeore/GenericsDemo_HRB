
namespace LibraryForGenerics
{
    public class Employee:IComparable<Employee>
    {

        

        public int Empid { get; set; }
        public string EmpName { get; set; }

        public int BasicSal { get; set; }

        public double TotalSal { get; private set; }

        public void CalculateSalary()
        {
            TotalSal = BasicSal + (BasicSal * 10);
        
        }



        public int CompareTo(Employee other)
        {
            return this.BasicSal.CompareTo(other.BasicSal);  
        }
    }
}
