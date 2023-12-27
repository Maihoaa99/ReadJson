using ReadJson;
using System.Collections.Generic;

class Program 
{
    static void Main(string[] args)
    {
        List<SinhVien> sinhViens = new List<SinhVien>();
        ImportJs(sinhViens);
    }

    static void ImportJs(List<SinhVien> sinhViens)
    {
        var content = System.IO.File.ReadAllText(@"MOCK_DATA.json");
        sinhViens = Newtonsoft.Json.JsonConvert.DeserializeObject<List<SinhVien>>(content);
        Display(sinhViens);
    }

    static void Display(List<SinhVien> list)
    {
        foreach (var sinhVien in list)
        {
            sinhVien.Display();
        }
    }
}
