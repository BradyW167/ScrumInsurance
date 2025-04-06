using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrumInsurance
{
    public class DatabaseConfig
    {
        [JsonPropertyName("DatabaseConfig")]
        public DatabaseInfo Database { get; set; }
    }

    public class DatabaseInfo
    {
        [JsonPropertyName("ServerName")]
        public string ServerName { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Username")]
        public string Username { get; set; }

        [JsonPropertyName("Password")]
        public string Password { get; set; }
    }
}