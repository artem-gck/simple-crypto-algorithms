﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_1.Algorithms
{
    public static class CesarAlgorithm
    {
        private const int SizeOfAlphabet = 26;
        private const char FirstLetterOfAlphabet = 'a';

        public static string Encrypt(string input, int key)
            => Crypt(input, key);

        public static string Decrypt(string input, int key)
            => Crypt(input, -key);

        private static string Crypt(string input, int key)
        {
            var alphabets = Enumerable.Range(FirstLetterOfAlphabet, SizeOfAlphabet).Select(num => (char)num).ToList();

            return new string(input.Select(let => (char)(FirstLetterOfAlphabet + (alphabets.IndexOf(let) + key) % SizeOfAlphabet)).ToArray());
        }
    }
}
