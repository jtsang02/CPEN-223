﻿//Student name:     Josiah Tsang
//Student number:   74191248
// ADD DOCUMENTATION!!

using System;
using System.Collections.Generic;

namespace Lab5 {
    public class Program {
        static void Main () {

            DNA dna5 = new DNA("AAAGGTTACTGA");
            HashSet<string> expectedSet = new HashSet<string>();
            dna5.CodonSet();
            
            //You could mainly use unit tests for testing.
        }
    }

    /// <summary>
    /// Class of DNA and its methods.
    /// </summary>
    public class DNA {

        private string dna; //this is the only allowed field for this class

        /// <summary>
        /// Constructor that takes a string param and sets it to field.
        /// </summary>
        /// <param name="dna"></param>
        public DNA (string dna) {

            if (!isValidDNA(dna)) {
                throw new ArgumentException("invalid dna sequence");
            }
            this.dna = dna;
        }

        public bool IsProtein () {
            // protein if all are met:
            // ignore junk regions mutatecodon()
            // first 3 letters are ATG
            // last 3 letters are TAA, TAG, TGA
            // NucleotideCount(C) / count.string || NucleotideCount(G) / count.string >= 0.3
            return false;
        }

        /// <summary>
        /// Calculates the total mass of the dna sequence.
        /// </summary>
        /// <returns>Returns the total mass in grams of the dna sequence.</returns>
        public double TotalMass () {

            double a = 135.128, c = 111.103, g = 151.128, t = 125.107, j = 100.000;

            return Math.Round((NucleotideCount('A') * a + NucleotideCount('C') * c +
                    NucleotideCount('G') * g + NucleotideCount('T') * t +
                    (dna.Length - (NucleotideCount('A') + NucleotideCount('C')
                    + NucleotideCount('G') + NucleotideCount('T'))) * j), 1);
        }
        /// <summary>
        /// Returns count of a valid nucleotide in the DNA sequence.
        /// </summary>
        /// <param name="c"></param>
        /// <returns>Returns the count of the given nucleotide.</returns>
        public int NucleotideCount (char c) {

            if (c == 'A' || c == 'C' || c == 'G' || c == 'T') {
                int count = 0;
                foreach (char ch in dna)
                    if (ch == c)
                        count++;
                return count;
            }
            else
                return 0;
        }
        public HashSet<string> CodonSet () {

            // remove junk
            for (int i = 0; i < dna.Length; i++)
                if (!(dna[i] == 'A' || dna[i] == 'C' || dna[i] == 'G' || dna[i] == 'T'))
                    dna = dna.Remove(i, 1);

            // create new hashset
            HashSet<string> codonSet = new HashSet<string>();
            int count = 0;
            for (int i = 0; i < dna.Length; i++) { 
                count++;
                if (count == 3) {
                    codonSet.Add(dna.Substring(i - 2, 3));
                    count = 0;
                }
            }
            return codonSet;
        }
        /// <summary>
        /// Swaps a new codon with the original codon and clears junk.
        /// </summary>
        /// <param name="originalCodon"></param>
        /// <param name="newCodon"></param>
        public void MutateCodon (string originalCodon, string newCodon) {       // assumed System.text is not allowed

            if (originalCodon.Length != 3 || newCodon.Length != 3)              // check length of codons is 3
                return;

            // verify new and old codons are valid
            foreach (char ch in originalCodon)
                if (!(ch == 'A' || ch == 'C' || ch == 'G' || ch == 'T'))
                    return;

            foreach (char ch in newCodon)
                if (!(ch == 'A' || ch == 'C' || ch == 'G' || ch == 'T'))
                    return;

            // remove junk
            for (int i = 0; i < dna.Length; i++)
                if (!(dna[i] == 'A' || dna[i] == 'C' || dna[i] == 'G' || dna[i] == 'T'))
                    dna = dna.Remove(i, 1);

            dna = dna.Replace(originalCodon, newCodon);     // replace original with new                                               
        }

        /// <summary>
        /// Returns original unaltered DNA sequence.
        /// </summary>
        /// <returns>Returns the unaltered DNA sequence</returns>
        public string GetSequence () {
            return dna;
        }

        /// <summary>
        /// Checks if DNA sequence is valid.
        /// </summary>
        /// <param name="dnasequence"></param>
        /// <returns>Returns true if the sequence is valid, false if it is not. </returns>
        public bool isValidDNA (string dnasequence) {
            // remove junk
            for (int i = 0; i < dnasequence.Length; i++)
                if (!(dnasequence[i] == 'A' || dnasequence[i] == 'C' || dnasequence[i] == 'G' || dnasequence[i] == 'T'))
                    dnasequence = dnasequence.Remove(i, 1);

            //check
            return (dnasequence.Length >= 3) ? true : false;
        }
    }
}