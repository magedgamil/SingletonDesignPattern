using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDesignPattern;
public class ConfigurationManager
{
    private static readonly Lazy<ConfigurationManager> _instance = new Lazy<ConfigurationManager>(() => new ConfigurationManager());

    private ConfigurationManager()
    {

    }
    public static ConfigurationManager Instance
    {
        get
        {
            return _instance.Value;
        }

    }
    public string GetConfiguration(string key)
    {
        // Return configuration value based on key
        return "SomeValue";
    }
}
