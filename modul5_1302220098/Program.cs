using System.Numerics;

class penjumlahan
{
    public static T JumlahTigaAngka <T> (T angka1, T angka2, T angka3) where T : IAdditionOperators<T, T, T>
    {

        return angka1 + angka2 + angka3;
    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Masukan NIM anda");
        string nim = Console.ReadLine();

        Console.WriteLine("Jumlah 3 angka nim anda : " + JumlahTigaAngka<int>(13, 02, 22));
    }
}

class simpleDataBase<T>
{
    public List<T> storeData;
    public List<DateTime> inputDates;

    public void AddNewData(T Data)
    {
        this.storeData.Add(Data);
        this.inputDates.Add(DateTime.Now);  
    }

    public void printAllData()
    {
        for (int i = 0; i < this.storeData.Count; i++)
        {
            Console.WriteLine("Data" + i + "Berisi" + this.storeData[1] + "yang dismpan pada saat UTC:3/10/2022 5:32:01 AM");
            simpleDataBase<double> Data = new simpleDataBase<double>();
            Data.printAllData();
        }
    }
}
