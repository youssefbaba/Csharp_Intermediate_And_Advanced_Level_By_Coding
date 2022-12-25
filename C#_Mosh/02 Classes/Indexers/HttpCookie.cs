namespace Indexers
{
    public class HttpCookie
    {
        // Fields
        private readonly Dictionary<string, string> _cookies;


        // Constructors
        public HttpCookie()
        {
            _cookies = new Dictionary<string, string>();
        }


        // Properties
        public DateTime Expiry { get; set; }


        // Methods
        /*
        
        // - In case if there is not indexers
        public void SetItem(string key, string value)
        {
            _cookies[key] = value;
        }
        public string GetItem(string key)
        {
            return _cookies[key];
        }

        */

        // Indexers
        public string this[string key]
        {
            get
            {
                return _cookies[key];
            }
            set
            {
                _cookies[key] = value;
            }
        }

    }
}
