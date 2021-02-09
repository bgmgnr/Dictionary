using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()//constructor
        {
            keys = new K[0];
            values = new V[0]; 
        }

        public void Add(K key,V value)
        {
            K[] tempkeys = keys;
            V[] tempvalues = values;

            keys = new K[keys.Length + 1];
            values = new V[values.Length + 1];

            for (int i = 0; i < tempkeys.Length; i++)
            {
                keys[i] = tempkeys[i];
                values[i] = tempvalues[i];
            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;

        }

        public void Show()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i]+" "+values[i]);
            }
        }




    }
}
