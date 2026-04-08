using DesignPatterns.Iterator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Iterator.Implementation
{
    public class AlphabeticalOrderIterator : Iterator
    {
        private WordsCollection _wordsCollection;

        private int _position = -1;

        private bool _reverse = false;

        public AlphabeticalOrderIterator(WordsCollection wordsCollection, bool reverse)
        {
            _wordsCollection = wordsCollection;
            _reverse = reverse;

            if (reverse)
            {
                _position = _wordsCollection.Items.Count;
            }
        }

        public override object Current()
        {
            return _wordsCollection.Items[_position];
        }

        public override int Key()
        {
            return this._position;
        }

        public override bool MoveNext()
        {
            int updatedPosition = _position + (_reverse ? -1 : 1);

            if (updatedPosition >= 0 && updatedPosition < _wordsCollection.Items.Count)
            {
                _position = updatedPosition;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            _position = _reverse ? _wordsCollection.Items.Count - 1 : 0;
        }
    }
}
