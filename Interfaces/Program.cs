namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();  Interfaceler kendisini implement eden classın referansını tutabilir.
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());         //Bunun Add methodunun içinde IPersonManager personManager yazdık.Yani burada Add derken de içini doldurmamız lazım.
            projectManager.Add(new EmployeeManager());         // IPersonManager personManager yaptığımız için customerManager ve employeeManager'i de barındırıyor.
            projectManager.Add(new InternManager());     //Bunu eklediğimizde başka hiçbir şeyle oynamadık.Bu yöntemle yapmasaydık tüm kodumuzu baştan düzenlemek gerekebilirdi.

        }
    }

    interface IPersonManager
    {
        void Add();
        void Update();
    }

    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager
    {
        //public void Add(CustomerManager customerManager)
        //{
        //    customerManager.Add();             böyle yaparsak müşteriye bağımlı oluruz. Sadece müşteri ekleyebiliriz.
        //}

        public void Add(IPersonManager personManager) 
        {
            personManager.Add();
        }
    }

}
