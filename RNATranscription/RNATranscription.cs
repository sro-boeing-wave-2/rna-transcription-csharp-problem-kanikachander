using System;

namespace RNATranscriptionModule
{
    public static class RnaTranscription
    {
        public static string ToRna(string nucleotide)
        {
            string rna = "";
            foreach(char c in nucleotide)
            {
                string str = "";
                switch (c)
                {
                    case 'G': str = "C";
                        break;
                    case 'C': str = "G";
                        break;
                    case 'T': str = "A";
                        break;
                    case 'A': str = "U";
                        break;
                }
                rna += str;
                
            }
            return rna;
            throw new NotImplementedException("You need to implement this function.");
            
        }
    }
}
