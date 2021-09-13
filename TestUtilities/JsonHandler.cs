using System.Text.Json;

namespace TestUtilities
{
    public class JsonHandler
    {
        public JsonHandler()
        {
        }

        public string Serialize<TEntity>(TEntity entityToBeSerialized)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
                IgnoreNullValues = true,
            };

            return System.Text.Json.JsonSerializer.Serialize(entityToBeSerialized, options);
        }

        public TEntity Deserialize<TEntity>(string content)
        {
            var options = new JsonSerializerOptions
            {
                AllowTrailingCommas = true,
                IgnoreNullValues = true,
            };

            return System.Text.Json.JsonSerializer.Deserialize<TEntity>(content, options);
        }
    }
}
