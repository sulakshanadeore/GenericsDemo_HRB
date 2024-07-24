using LibraryForGenerics;
internal class Program
{
    private static void Main(string[] args)
    {

        Dictionary<int,string> dic = new Dictionary<int,string>();
        dic.Add(1, "HEllo");
        dic.Add(2, "Good day");
        dic.Add(3, "Bye");

       Dictionary<int,string>.Enumerator dic1= dic.GetEnumerator();
        while (dic1.MoveNext()) {
            Console.WriteLine(dic1.Current.Key);
            Console.WriteLine(dic1.Current.Value);

        }





        List<Products> products = new List<Products>();
        products.Add(new Products() { Prodid = 110, Price = 245000, Prodname = "Laptop" });
        products.Add(new Products() { Prodid = 10, Price = 55000, Prodname = "Laptop" });
        products.Add(new Products() { Prodid = 1, Price = 15000, Prodname = "Laptop" });
        products.Add(new Products() { Prodid = 190, Price = 25000, Prodname = "Laptop" });

        products.Sort(products[0]);

        foreach (var item in products)
        {
            Console.WriteLine(item.Prodid);
            Console.WriteLine(item.Prodname);
            Console.WriteLine(item.Price);
            Console.WriteLine();
        }




        //SortedSet<Employee> employees = new SortedSet<Employee>();
        //Employee emp1 = new Employee() { Empid = 1, EmpName = "Zeeshan", BasicSal = 10000 };
        //Employee emp2 = new Employee() { Empid = 12, EmpName = "Ira", BasicSal = 20000 };
        //Employee emp3 = new Employee() { Empid = 3, EmpName = "Harry", BasicSal = 30000 };
        //employees.Add(emp1);
        //employees.Add(emp2);
        //employees.Add(emp3);
        //employees.Add(new Employee() { Empid = 4, EmpName = "Tina", BasicSal = 29000 });





        //foreach (Employee emp in employees)
        //{
        //    Console.WriteLine(emp.Empid);
        //    Console.WriteLine(emp.EmpName);
        //    Console.WriteLine(emp.BasicSal);


        //}



        //SortedDictionary<int, Employee> empdict = new SortedDictionary<int, Employee>();
        //Employee emp1 = new Employee() { Empid = 1, EmpName = "Jack", BasicSal = 10000 };
        ////empdict.Add(1, emp1);
        //empdict.Add(emp1.Empid, emp1);
        //Employee emp2 = new Employee() { Empid = 2, EmpName = "Jill", BasicSal = 20000 };
        //empdict.Add(emp2.Empid, emp2);
        //Employee emp3 = new Employee() { Empid = 3, EmpName = "Harry", BasicSal = 30000 };
        //empdict.Add(emp3.Empid, emp3);



        //SortedDictionary<int,Employee>.Enumerator sorted= empdict.GetEnumerator();

        // while (sorted.MoveNext()) 
        // {
        //     Console.WriteLine(sorted.Current.Key);
        //     Console.WriteLine(sorted.Current.Value.Empid);
        //     Console.WriteLine(sorted.Current.Value.EmpName);
        //     Console.WriteLine(sorted.Current.Value.BasicSal);


        // }


        // foreach (Employee emp in empdict.Values) 
        // {
        //     Console.WriteLine(emp.Empid);
        //     Console.WriteLine(emp.EmpName);
        //     Console.WriteLine(emp.BasicSal);

        // }


        //List<Employee> empList = new List<Employee>();

        //Employee emp1 = new Employee() { Empid = 1, EmpName = "Jack", BasicSal = 10000 };
        //emp1.CalculateSalary();
        //empList.Add(emp1);

        //empList.Add(new Employee() { EmpName = "Sunil", Empid = 2, BasicSal = 12000 });
        //empList.Add(new Employee() { Empid = 3, EmpName = "Hari" });
        



        //foreach (var item in empList)
        //{
        //    Console.WriteLine(item.Empid);
        //    Console.WriteLine(item.EmpName);
        //    Console.WriteLine(item.BasicSal);
        //    Console.WriteLine(item.TotalSal);
        //    Console.WriteLine();

        //}




        //Stack<int> s=new Stack<int>();
        //s.Push(1);

        //Stack<Employee> e=new Stack<Employee>();//Last in first out for employee objects on the stack

        //Employee e1=new Employee();
        //e1.Empid = 1;
        //e1.EmpName = "Anand";

        //e.Push(e1);

        //e.Push(new Employee { EmpName="Sunil",Empid=2});

        //foreach (var item in e)
        //{

        //    Console.WriteLine(item.Empid);
        //    Console.WriteLine(item.EmpName);
        //    Console.WriteLine();
        //}
        Console.ReadLine();





    }
}











