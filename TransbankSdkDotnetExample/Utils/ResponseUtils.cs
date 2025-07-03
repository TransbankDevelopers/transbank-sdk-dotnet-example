using System.Reflection;
using System.Text.Json;

namespace TransbankSdkDotnetExample.Utils
{
    public static class ResponseUtils
    {
        public static Dictionary<string, object?> ToMap(object obj)
        {
            if (obj == null)
                return new Dictionary<string, object?>();

            return obj.GetType()
                    .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                    .ToDictionary(
                        prop => prop.Name,
                        prop =>
                        {
                            var value = prop.GetValue(obj);
                            if ((prop.Name == "OriginalRequest" || prop.Name == "OriginalResponse") && value is string json)
                            {
                                try
                                {
                                    using var doc = JsonDocument.Parse(json);
                                    return JsonSerializer.Deserialize<object>(json);
                                }
                                catch
                                {
                                    return json;
                                }
                            }
                            return value;
                        }
                    );
        }
    }
}
