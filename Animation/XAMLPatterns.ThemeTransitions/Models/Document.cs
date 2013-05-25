using System;
using System.Collections.Generic;
using UpdateControls.Collections;

namespace XAMLPatterns.ThemeTransitions.Models
{
    public class Document
    {
        private IndependentList<int> _numbers = new IndependentList<int>();
        private Random _random = new Random();

        public IEnumerable<int> Numbers
        {
            get { return _numbers; }
        }

        public void NewNumber()
        {
            _numbers.Add(_random.Next(1000));
        }

        public void DeleteNumber(int number)
        {
            _numbers.Remove(number);
        }
    }
}
