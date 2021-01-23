using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> myDictionary = new MyDictionary<string, int>();
            myDictionary.AddToMyDictionary("GS", 1);
            myDictionary.AddToMyDictionary("BJK", 2);
            myDictionary.AddToMyDictionary("FB", 3);
            myDictionary.AddToMyDictionary("TS", 4);
            myDictionary.AddToMyDictionary("BS", 5);
            for (int i = 0; i < myDictionary._keys.Length; i++)
            {
                Console.WriteLine(myDictionary._keys[i] + "--" + myDictionary._value[i]);
            }
        }
    }


    class MyDictionary<_Key, _Value>
    {
        public _Key[] _keys;
        public _Value[] _value;

        public MyDictionary()
        {
            _keys = new _Key[0];
            _value = new _Value[0];
               
        }
        public void AddToMyDictionary(_Key key, _Value value)
        {
            _Key[] temp_key = _keys;
            _Value[] temp_value = _value;

            _keys = new _Key[_keys.Length + 1];
            _value = new _Value[_value.Length + 1];

            for (int i = 0; i < temp_key.Length; i++)
            {
                _keys[i] = temp_key[i];
                _value[i] = temp_value[i];
            }
            _keys[_keys.Length - 1] = key;
            _value[_value.Length - 1] = value;
        }

    }
}
