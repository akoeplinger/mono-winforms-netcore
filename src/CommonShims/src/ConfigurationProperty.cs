namespace System.Configuration
{
    public class ConfigurationProperty
    {
        private Type type;
        private string v1;
        private bool v2;

        public ConfigurationProperty(string v1, Type type, bool v2)
        {
            this.v1 = v1;
            this.type = type;
            this.v2 = v2;
        }
    }
}