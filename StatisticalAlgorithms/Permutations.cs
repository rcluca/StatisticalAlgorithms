using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatisticalAlgorithms
{
    // Notes
    //
    // - Add ability to get Permutations for case-insensitive
    // - Add speed up for repeated permutations in GetUnique (ie: "AAAA" should return immediately with only "AAAA")

    public class Permutations
    {
        ICollection<string> _combos;
        char[] _wordChrs;
        bool _isNegativeInt;
        Dictionary<int, HashSet<char>> _restrictions;

        public List<int> GetPermutations(int num)
        {
            _combos = new List<string>();
            _wordChrs = GetDigitChars(num);
            SetDefaultIntRestrictions();

            GetPermutationsHelper(0);

            return StringListToIntList();
        }

        public List<int> GetPermutations(int num, Dictionary<int, HashSet<char>> restrictions)
        {
            _restrictions = restrictions;

            return GetPermutations(num);
        }

        public List<string> GetPermutations(string word)
        {
            if (word == null)
                throw new NullReferenceException();

            if (word.Length == 0)
                return new List<string>();

            _combos = new List<string>();
            _wordChrs = word.ToCharArray();
            SetDefaultStringRestrictions();

            GetPermutationsHelper(0);

            return _combos.ToList();
        }

        public List<string> GetPermutations(string word, Dictionary<int, HashSet<char>> restrictions)
        {
            if (word == null)
                throw new NullReferenceException();

            if (word.Length == 0)
                return new List<string>();

            _restrictions = restrictions;

            return GetPermutations(word);
        }

        public List<int> GetUniquePermutations(int num)
        {
            _combos = new HashSet<string>();
            _wordChrs = GetDigitChars(num);
            SetDefaultIntRestrictions();

            GetPermutationsHelper(0);

            return StringListToIntList();
        }

        public List<int> GetUniquePermutations(int num, Dictionary<int, HashSet<char>> restrictions)
        {
            _restrictions = restrictions;

            return GetPermutations(num);
        }

        public List<string> GetUniquePermutations(string word)
        {
            if (word == null)
                throw new NullReferenceException();

            if (word.Length == 0)
                return new List<string>();

            _combos = new HashSet<string>();
            _wordChrs = word.ToCharArray();
            SetDefaultStringRestrictions();

            GetPermutationsHelper(0);

            return _combos.ToList();
        }

        public List<string> GetUniquePermutations(string word, Dictionary<int, HashSet<char>> restrictions)
        {
            if (word == null)
                throw new NullReferenceException();

            if (word.Length == 0)
                return new List<string>();

            _restrictions = restrictions;

            return GetPermutations(word);
        }

        private void GetPermutationsHelper(int start)
        {
            if (start == _wordChrs.Length - 1)
                _combos.Add(new string(_wordChrs));
            else
            {
                for (int i = start; i < _wordChrs.Length; i++)
                {
                    // Only take combination path if not restricted
                    if (!Restricted(start, _wordChrs[i]))
                    {
                        Swap(_wordChrs, start, i);
                        GetPermutationsHelper(start + 1);
                        Swap(_wordChrs, start, i);
                    }
                }
            }
        }

        private void Swap(char[] wordChrs, int thisIdx, int thatIdx)
        {
            char temp = wordChrs[thisIdx];
            wordChrs[thisIdx] = wordChrs[thatIdx];
            wordChrs[thatIdx] = temp;
        }

        // Gets the digits in the number, removing the negative sign
        // and noting it by setting _isNegativeInt to true
        private char[] GetDigitChars(int num)
        {
            if (num < 0)
            {
                _isNegativeInt = true;
                string numStr = num.ToString();
                return numStr.ToCharArray(1, numStr.Length - 1);
            }
            else
            {
                _isNegativeInt = false;
                return num.ToString().ToCharArray();
            }
        }

        // Convert Permutations string list to integer list and
        // add back minus sign if original number was negative
        private List<int> StringListToIntList()
        {
            List<int> intCombos = new List<int>();
            foreach (var combo in _combos)
            {
                if (_isNegativeInt)
                    intCombos.Add(int.Parse("-" + combo));
                else
                    intCombos.Add(int.Parse(combo));
            }

            return intCombos;
        }

        // Return whether or not the character at the specified index
        // is in the _restricted dictionary
        private bool Restricted(int idx, char c)
        {
            if (_restrictions != null && _restrictions.ContainsKey(idx))
            {
                if (_restrictions[idx].Contains(c))
                    return true;
            }

            return false;
        }

        private void SetDefaultIntRestrictions()
        {
            if (_restrictions == null)
            {
                _restrictions = new Dictionary<int, HashSet<char>>(1);

                // 0 should not appear at the beginning of a number
                _restrictions.Add(0, new HashSet<char>() { '0' });
            }
            else
            {
                if (!_restrictions.ContainsKey(0) || (_restrictions.ContainsKey(0) && !_restrictions[0].Contains('0')))

                    // 0 should not appear at the beginning of a number
                    _restrictions.Add(0, new HashSet<char>() { '0' });
            }
        }

        private void SetDefaultStringRestrictions()
        {

        }
    }
}
