using System.Collections.Generic;

namespace MinecraftLogSearcherGUI
{
    public class LogCache
    {
        private Dictionary<string, List<string>> _cache = new Dictionary<string, List<string>>();
        
        public void AddLine(string file, string line)
        {
            if (_cache.ContainsKey(file))
            {
                _cache[file].Add(line);
                return;
            }
            _cache.Add(file, new List<string>());
            _cache[file].Add(line);
        }

        public List<string> GetLines(string file)
        {
            return _cache.ContainsKey(file) ? _cache[file] : null;
        }
    }
}