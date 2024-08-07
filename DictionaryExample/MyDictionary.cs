﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryExample
{
    class MyDictionary<K, V>
    {
        K[] _key;
        V[] _value;
        K[] _tempKey;
        V[] _tempValue;



        public MyDictionary()
        {
            _key = new K[0];
            _value = new V[0];

        }
        public void Add(K k, V v)
        {
            _tempKey = _key;
            _tempValue = _value;
            _key = new K[_key.Length + 1];
            _value = new V[_value.Length + 1];
            for (int i = 0; i < _tempKey.Length; i++)
            {
                _key[i] = _tempKey[i];
            }

            for (int i = 0; i < _tempValue.Length; i++)
            {
                _value[i] = _tempValue[i];
            }

            _key[_key.Length - 1] = k;
            _value[_value.Length - 1] = v;

            Console.WriteLine("Added :" + " " + k+" , "+v);

        }
        
        
        public int Count
        {
            get { return _key.Length; }
            
            
        }

       
    }
}
