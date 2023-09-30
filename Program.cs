namespace HashTableDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hash Table ");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");
            hash.GetFrequency("To");
            string hash5 = hash.Get("5");
            Console.WriteLine("Fifth index value is :" + hash5);
        }
    }
 }
    
    
    
    
