using System.Collections.Generic;

namespace utils
{
    public class HashSetExt<T> : HashSet<T>
    {
        public bool this[T key]
        {
            get
            {
                return Contains(key);
            }
            set
            {
                if (value)
                {
                    Add(key);
                }
                else
                {
                    Remove(key);
                }
            }
        }
    }
}
