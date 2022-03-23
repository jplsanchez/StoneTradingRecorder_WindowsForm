using System.Reflection;

namespace LA.Economy.Infra.Utility
{
    public static class CommaSeparatedValuesHelper
    {
        public static async Task InsertIntoFileAsync(object data, string path)
        {
            using (var writer = new StreamWriter(path, true))
            {
                string buffer = "";
                foreach (PropertyInfo property in data.GetType().GetProperties())
                {
                    buffer += $"{property.GetValue(data, null)}, ";
                }

                if (!buffer.Equals(""))
                    await writer.WriteLineAsync(buffer);
            }
        }
    }
}