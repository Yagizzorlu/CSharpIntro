namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");
            sehirler.Add("İzmir");

            Console.WriteLine(sehirler.Count);     //metot olsa (sehirler.Count()) olurdu.


            MyList<string> sehirler2 = new MyList<string>();
            
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");
            sehirler2.Add("Ankara");                      //MyList'imizde ekleme yapabilmek ve bunun sayısını tutabilmek için öyle bir kod yazdık.
            Console.WriteLine(sehirler2.Count);
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;
        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            _tempArray = _array;    //Bu yaptığımızda tempArray, array'in referansını tutuyor.Yani altta yaptığımız yenilemede önceki elemanlar uçup gitmesin diye burada saklıyoruz.
            _array = new T[_array.Length + 1];        //Eklediğimizde eleman sayısını 1 arttırdık.Yenilediğimizde başka bir adrese sahip olur ve öncekiler gider.
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];              //_tempArray'i baştan sona dolaşıyoruz ve oradaki tüm elemanları _array'e aktarıyoruz.
            }

            _array[_array.Length - 1] = item;   //Yeni eklediğimiz item sona yerleşecek.Bir dizide sonuncu sıra,uzunluğun bir eksisine eşittir. 6 elemanlı dizinin son elemanı 5 tir.
        }
        public int Count
        {
            get { return _array.Length; }        //propfull ile yazdık.
        }

    }
}
