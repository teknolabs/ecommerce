using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Teknolabs.ECommerce.MvcWebUI.ExtensionMethods
{
    public static class SessionExtensionMethods
    {
        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObject<T>(this ISession session, string key) where T : class
        {
            string value = session.GetString(key);
            if (string.IsNullOrEmpty(value)) return null;
            return JsonConvert.DeserializeObject<T>(value);
        }
    }
}
