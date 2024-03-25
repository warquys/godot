using System;
using System.Diagnostics;

namespace Godot.Collections
{
    internal sealed class ArrayDebugView
    {
        private readonly Array _array;

        public ArrayDebugView(Array array)
        {
            ArgumentNullException.ThrowIfNull(array);

            _array = array;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public Variant[] Items
        {
            get
            {
                var items = new Variant[_array.Count];
                _array.CopyTo(items, 0);
                return items;
            }
        }
    }

    internal sealed class DictionaryDebugView
    {
        private readonly Dictionary _dictionary;

        public DictionaryDebugView(Dictionary dictionary)
        {
            ArgumentNullException.ThrowIfNull(dictionary);

            _dictionary = dictionary;
        }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public Dictionary[] Items
        {
            get
            {
                Dictionary[] items = new Dictionary[_dictionary.Count];
                //_dictionary.CopyTo(items, 0);
                return items;
            }
        }
    }
}
