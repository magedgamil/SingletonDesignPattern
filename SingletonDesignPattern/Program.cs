using SingletonDesignPattern;

var configManager1 = ConfigurationManager.Instance;
var configManager2 = ConfigurationManager.Instance;
if (configManager1 == configManager2)
{
    Console.WriteLine("Both instances are the same.");
}
string configValue = configManager1.GetConfiguration("SomeKey");
Console.WriteLine("Configuration Value: " + configValue);
Console.ReadLine();