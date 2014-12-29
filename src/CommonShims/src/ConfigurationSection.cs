namespace System.Configuration
{
    public class ConfigurationSection
    {
        protected virtual ConfigurationPropertyCollection Properties { get; set; }

        protected bool this[ConfigurationProperty o]
        {
            get
            {
                return false;
            }
            set
            {

            }
        }
    }
}