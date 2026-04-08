using DesignPatterns.Iterator.Implementation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.Models
{
    public class WordsCollection : IteratorAggregate
    {
        List<string> _collection = new List<string>();
        private bool _direction = false;

        public List<string> Items { get { return _collection; } }

        public void AddItem(string item)
        {
            _collection.Add(item);
        }

        public void ReverseDirection()
        {
            _direction = !_direction;
        }

        public override IEnumerator GetEnumerator()
        {
            return new AlphabeticalOrderIterator(this, _direction);
        }
    }
}
