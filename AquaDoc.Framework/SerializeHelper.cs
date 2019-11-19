using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AquaDoc.Framework
{
    public class SerializeHelper
    {  
        public static string JSONSerialize(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public static T JSONDeserialize<T>(string jsonDatas)
        {
            if (string.IsNullOrEmpty(jsonDatas))
                return default(T);

            return JsonConvert.DeserializeObject<T>(jsonDatas);
        }

        public static string GetJsonValue(string jsonDatas, string key)
        {
            JObject jo = JObject.Parse(jsonDatas);
            return (string)jo[key];
        }

    }
}
