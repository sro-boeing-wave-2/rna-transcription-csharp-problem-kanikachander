using System;
using System.Collections.Generic;
using System.Linq;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            Dictionary<char, char> myDictionary = new Dictionary<char, char>();
            myDictionary.Add('G', 'C');
            myDictionary.Add('C', 'G');
            myDictionary.Add('T', 'A');
            myDictionary.Add('A', 'U');
            string rna = "";

            foreach (char c in nucleotide)
            {
                rna += myDictionary[c];
            }
            return rna;
        }
    }
}
