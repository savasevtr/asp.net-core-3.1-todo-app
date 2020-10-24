using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace SEProje.ToDo.Web.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session, string key, object deger)
        {
            string gelenData = JsonConvert.SerializeObject(deger);
            session.SetString(key, gelenData);
        }

        public static T GetObject<T>(this ISession session, string key) where T : class, new()
        {
            string gelenData = session.GetString(key);

            if (gelenData != null)
            {
                return JsonConvert.DeserializeObject<T>(gelenData);
            }

            return null;
        }
    }
}
