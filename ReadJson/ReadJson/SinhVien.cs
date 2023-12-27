namespace ReadJson
{
    public class SinhVien
    {
        public int id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }

        public void Display()
        {
            Console.WriteLine("id: {0}, first_name: {1}, last_name: {2}", id, first_name, last_name);
        }
    }
}
