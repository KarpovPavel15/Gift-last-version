using System.Collections.Generic;
using System.IO;

using Newtonsoft.Json;
namespace Proga
{
    class JSON
    {
            static public void SerializationSweet(List<Sweet> obj)
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };
                string serialized = JsonConvert.SerializeObject(obj, settings);

                StreamWriter streamWriter = new StreamWriter("input.txt");
                using (streamWriter)
                {
                    streamWriter.WriteLine(serialized);
                }

            }

            static public List<Sweet> DeserializationSweet()
            {
                JsonSerializerSettings settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };
                string fileContents = "";
                StreamReader streamReader = new StreamReader("input.txt");
                using (streamReader)
                {
                    fileContents = streamReader.ReadToEnd();
                }
                List<Sweet> newList = JsonConvert.DeserializeObject<List<Sweet>>(fileContents, settings);
                return newList;
            }

        }
    }