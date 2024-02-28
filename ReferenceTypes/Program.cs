namespace ReferenceTypes
{
    public class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;

            sayi1 = sayi2;

            sayi2 = 100;

            Console.WriteLine(sayi1);  //20 yazar. Sonradan sayi2 nin değişmesi sayi1'i etkilemez. int bir değer tiptir çünkü.

            int[] sayilar1 = new int[] { 1, 2, 3 };
            int[] sayilar2 = new int[] { 10, 20, 30 };

            sayilar1 = sayilar2;
            sayilar2[0] = 1000;

            Console.WriteLine(sayilar1[0]);       //Array,class,interface   referans tiptir. sayilar1 = sayilar2 dediğimizde ikisi aynı adrese bakmış oluyor.
            //Bu yüzden sayilar2 nin ilk elemanı 1000 olduğunda sayilar1 de o adrese baktığı için ilk elemanı 1000 haline gelir.

            Person person1 = new Person();
            Person person2 = new Person();
            person1.FirstName = "Yağız";

            person2 = person1;
            person1.FirstName = "Ahmet";
            Console.WriteLine(person2.FirstName);   //Ahmet yazar.  person2 ile person1 aynı adrese bakar ve sonra person1 in ismini değiştirdik.

            Customer customer = new Customer();
            customer.FirstName = "Metehan";
            customer.CreditCardNumber = "242362328";
            Employee employee = new Employee();
            employee.FirstName = "Veli";


            Person person3 = customer;    //person3,customer'in adresini tutuyor.

            Console.WriteLine(((Customer)person3).CreditCardNumber);   //Bu şekilde yazarsak customer'in person3 ü gibi olur ve artık customer'a ait özellikleri de gösterir.
            //Console.WriteLine(person3.FirstName);  Metehan yazar. customer'i person3'e atadık. customer'in ismi neyse bu da odur.
            //customer ile employee yi birbirine atayamayız ama Person base classtır. O yüzden Base sınıfa inherit eden sınıflara referansını atayabiliriz.

            PersonManager personManager = new PersonManager();
            personManager.Add(employee); //Add içine employee,customer,person hepsini yazabiliriz.PersonManager içine base sınıf yazdığımız için hepsini kapsıyor artık.
            //Burada employee'nin ismini yazdıracak.Çünkü metoda gidiyor ve orada Add kısmında FirstName yazdırmak var.
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person)  //Person,customer,employee hepsini kullanabiliriz.
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
