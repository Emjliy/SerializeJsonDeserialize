using Newtonsoft.Json;
using System;
using System.IO;

namespace SerializeJsonDeserialize
{
    class Program
    {
        static void Main(string[] args)
        {
            #region firstTask
            //Directory.CreateDirectory(@"C:/Users/Emilia/Desktop\Gmail");
            //File.Create(@"C:/Users/Emilia/Desktop\Gmail/mail.txt");
            //StreamWriter streamWriter = new StreamWriter(@"C:/Users/Emilia/Desktop\Gmail\mail.txt");
            //streamWriter.WriteLine("Using yazmadan");
            //streamWriter.Close();


            //using (StreamWriter streamWriter = new StreamWriter(@"C:/Users/Emilia/Desktop\Gmail\test.txt"))
            //{
            //    streamWriter.WriteLine("usingin closedan ferqi ");
            //}
            #endregion
            #region secondTask
            Accounts account1 = new Accounts { Id = 1, Instagram = "emily", Linkedn = "mily" };
            var accountJson = JsonConvert.SerializeObject(account1);
            using (StreamWriter streamWriter = new StreamWriter(@"C:\Users\Emilia\Desktop\MyAllProjects\SerializeJsonDeserialize\SerializeJsonDeserialize\json1.json"))
            {
                streamWriter.WriteLine(accountJson);
            }
            string result;
            using (StreamReader streamReader = new StreamReader(@"C:\Users\Emilia\Desktop\MyAllProjects\SerializeJsonDeserialize\SerializeJsonDeserialize\json1.json"))
            {
                result = streamReader.ReadToEnd();
            }

            var json = JsonConvert.DeserializeObject(result);
            Console.WriteLine(result);
            Console.WriteLine(json);
            #endregion
            //using (StreamReader streamReader = new StreamReader(@"C:/Users/Emilia/Desktop\Bp210\test.txt"))
            //{
            //    var result = streamReader.ReadLine();
            //    Console.WriteLine(result);
            //}
            //Directory.CreateDirectory(@"C:/Users/Emilia/Desktop\bp201/HighStudent");
            //File.Create(@"C:/Users/Emilia/Desktop\Bp201/HighStudent/Milya.txt");
            //File.Create(@"C:/Users/Emilia/Desktop\Bp201/Mily.txt");
            //File.Create(@"C:/Users/Emilia/Desktop\Bp201/Milyy.txt");
        }
    }
}
