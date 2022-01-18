using Newtonsoft.Json;

namespace Sentinels2.Models
{
    internal class GlobalsPathApplication : IDisposable
    {
        public string DatabasePath { get; set; }

        public string OfficeApplicationPath { get; set; }   

        public void Dispose()
        {
        }

        public void SaveFileJSON(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine(JsonConvert.SerializeObject(this, Formatting.Indented));
            }
        }

        public static GlobalsPathApplication ReaderFileJSON(string filename)
        {
            using (StreamReader sr = new StreamReader(filename))
            {
                string jsonstring = sr.ReadToEnd();
                return JsonConvert.DeserializeObject<GlobalsPathApplication>(jsonstring);
            }
        }
    }
}
