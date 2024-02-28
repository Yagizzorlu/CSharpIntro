namespace Constructors

{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer {Id = 1, FirstName = "Yağız", LastName = "Zorlu", City = "İzmir" }; //Süslü parantez ise içine bilgileri propları ile yazarız.
            //new'leme yaptığımızda Constructor bloğu çalışır ve oradaki yazıyı yazdırır. (yazı varsa)

            Customer customer3 = new Customer();
            customer3.Id = 2;
            customer3.FirstName = "Mehmet";           //İki farklı yazım türü
            customer3.LastName = "Kılıç";
            customer3.City = "Eskişehir";


            Customer customer2 = new Customer(2,"Ahmet","Yılmaz","Bursa");   //() ise bu metot anlamına gelir.

            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {
        public Customer()     //Bu customer ve customer3 e uygun.
        {
            
        }
        public Customer(int id,string firstName,string lastName,string city)     //Bu customer2 ye uygun.
            //Burada parantez içinde özellikler giriliyor o yüzden customer new'lerken direkt bu özelliklerin karşılığını tanımlıyoruz.
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;                    //Constructorda değerlerimizi set ettik ve main kısmında ismi yazdırdık.
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
