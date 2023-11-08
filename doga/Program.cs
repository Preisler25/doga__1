namespace doga;

class Program
{
    static void Print(string txt){
        Console.WriteLine(txt);
    }

    static void PrintInt(int num){
        Console.WriteLine(num);
    }

    static void PrintDouble(double num){
        Console.WriteLine(num);
    }

    static void PrintList(List<int> lista){
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }

    static void Wait(){
        Console.WriteLine("press any key to continue...");
        Console.ReadKey();
    }

    static int[] GetIntArray(int[] tomb)
    {
        
        List<int> listOfInts = new List<int>();
        foreach (int num in tomb)
        {
            int temp = num;
            while(temp > 0)
                {
                    listOfInts.Add(temp % 10);
                    temp = temp / 10;
                }
        }
        return listOfInts.ToArray();
    }

    static void PrintTömb(int[] tomb){
        foreach (var item in tomb)
        {
            Console.WriteLine(item);
        }
    }

    static void Masodik(int[] tomb){
        int paros = 0;
        int paratlan = 0;
        int legnagyobb = 0;
        int legkisebb = 100;
        foreach (var item in tomb)
        {
            if(item % 2 == 0){
                paros++;
            }else{
                paratlan++;
            }
            if(item > legnagyobb){
                legnagyobb = item;
            }
            if(item < legkisebb){
                legkisebb = item;
            }
        }
        Console.WriteLine("Páros: " + paros);
        Console.WriteLine("Páratlan: " + paratlan);
        Console.WriteLine("Legnagyobb: " + legnagyobb);
        Console.WriteLine("Legkisebb: " + legkisebb);
    }

    static List<int> Harmadik(List<int> lista){
        Random rnd = new Random();
        for (int i = 0; i < 10; i++)
        {
            lista.Add(rnd.Next(1, 101));
        }
        return lista;
    }

    static void Negyedik(List<int> lista){
        int legnagyobb = 0;
        foreach (var item in lista)
        {
            if(item % 2 == 0 && item > legnagyobb){
                legnagyobb = item;
            }
        }
        Console.WriteLine("Legnagyobb páros: " + legnagyobb);
    }

    static void Otodik(List<int> lista){
        Console.WriteLine("Darab: " + lista.Count);
    }

    static int Hatodik(int[] tomb){
        int osszeg = 0;
        foreach (var item in tomb)
        {
            if(item % 2 == 0){
                osszeg += item;
            }
        }
        PrintInt(osszeg);
        return osszeg;
    }

    static double Hetedik(int[] tomb){
        int osszeg = 0;
        int darab = 0;
        foreach (var item in tomb)
        {
            if(item % 2 != 0){
                osszeg += item;
                darab++;
            }
        }
        PrintDouble(osszeg / darab);
        return osszeg / darab;
    }

    static int Nyolcadik(int[] tomb){
        int[] array_of_ints = GetIntArray(tomb);
        PrintTömb(array_of_ints);
        int osszeg = 0;
        foreach (var item in array_of_ints)
        {
            osszeg += item;
        }
        PrintInt(osszeg);
        return osszeg;
    }

    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] tomb = new int[10];
        for (int i = 0; i < tomb.Length; i++)
        {
            tomb[i] = rnd.Next(1, 101);
        }
        Masodik(tomb);
        PrintTömb(tomb);
        Wait();
        List<int> lista = new List<int>();
        lista = Harmadik(lista);
        PrintList(lista);
        Negyedik(lista);
        Wait();
        Otodik(lista);
        Wait();
        Hatodik(tomb);
        Wait();
        Hetedik(tomb);
        Wait();
        Nyolcadik(tomb);
        Wait();
    }
}

