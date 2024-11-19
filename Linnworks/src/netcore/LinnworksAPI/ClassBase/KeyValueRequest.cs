using System.Collections.Generic;
using System.Text;
using System;

namespace LinnworksAPI
{
    public class KeyValueRequest<KeyType, ValueType> : LinnObject
    {
        public KeyType Key { get; set; }

        public ValueType Value { get; set; }
    }
}