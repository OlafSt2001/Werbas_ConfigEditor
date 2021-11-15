using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

namespace Werbas_ConfigEditor
{
    /**
     * Ja, ich weiß. Path ist in beiden Klassen vorhanden und sollte in eine eigene übergeordnete Klasse
     * gepackt werden. Aber dann sieht das XML nicht mehr aus wie vorgegeben, denke ich ;)
     */

    /// <summary>
    /// Klasse für einen Server
    /// Path: Pfad zum Server
    /// ConnectionString: Verbindungszeichenfolge für den Server
    /// </summary>
    public class Server
    {
        [XmlAttribute]
        public string Path { get ; set; }
        public string ConnectionString { get; set; }
        
        public Server()
        {
            Path = string.Empty;
            ConnectionString = string.Empty;
        }

        public Server(string ThePath, string TheConnString)
        {
            Path = ThePath; 
            ConnectionString = TheConnString;
        }
    }

    /// <summary>
    /// Klasse für einen Client
    /// Path: Pfad zum Client
    /// TSClient: Ist ein TSClient ja/nein
    /// </summary>
    public class Client
    {
        public bool TSClient { get; set; }
        [XmlAttribute]
        public string Path { get; set; }

        public Client()
        {
            TSClient = false;
            Path = string.Empty;
        }

        public Client(bool TheTS, string ThePath)
        {
            TSClient = TheTS;
            Path = ThePath;
        }
    }

    /// <summary>
    /// Klasse für unsere Config
    /// Servers: Liste aller konfigurierten Server
    /// Clients: Liste aller konfigurierten Clients
    /// </summary>
    public class Config
    {
        public List<Server> Servers = new();
        public List<Client> Clients = new();
    }
}
