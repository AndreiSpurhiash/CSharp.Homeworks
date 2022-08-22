using System;

namespace Patterns.Singleton
{
    public class Singleton
    {
        private static  Singleton _instance;

        private string _data;
        public string Data => _data;
        private Singleton(string data)
        {
            _data = data;
        }

        public static Singleton GetInstance(string data)
        {
            if (string.IsNullOrEmpty(data))
            {
                throw new ArgumentNullException(nameof(data));
            }

            if (_instance == null)
            {
                    if (_instance == null)
                    {
                        _instance = new Singleton(data);
                    }
            }

            return _instance;
        }

        public override string ToString()
        {
            return Data;
        }
    }
}
