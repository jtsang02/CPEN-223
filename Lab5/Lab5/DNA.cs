//Student name:     Josiah Tsang
//Student number:   74191248
// ADD DOCUMENTATION!!

using System;
using System.Collections.Generic;

namespace Lab5 {
    public class Program {
        static void Main () {

            DNA test = new DNA("ATGCCAxCTATGGTAG");
            test.MutateCodon("ATG", "TAG");
            
            //You could mainly use unit tests for testing.
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class DNA {

        private string dna; //this is the only allowed field for this class

        /// <summary>
        /// Constructor that takes a string param and sets it to field.
        /// </summary>
        /// <param name="dna"></param>
        public DNA (string dna) {

            //if (!IsValidDNA(dna)) {
            //    throw new ArgumentException("Invalid DNA sequence");
            //}
            this.dna = dna;
        }

        //public bool IsProtein () {
        //    // protein if all are met:
        //    // ignore junk regions mutatecodon()
        //    // first 3 letters are ATG
        //    // last 3 letters are TAA, TAG, TGA
        //    // NucleotideCount(C) / count.string || NucleotideCount(G) / count.string >= 0.3
            
        //}
        //public double TotalMass () {

        //}
        /// <summary>
        /// Returns count of a valid nucleotide in the DNA sequence.
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int NucleotideCount (char c) {

            if (c == 'A' || c == 'C' || c == 'G' || c == 'T') {
                int count = 0;
                foreach (char ch in dna) {
                    if (ch == c)
                        count++;
                }
                return count;
            }              
            else
                return 0;
        }
        //public HashSet<string> CodonSet () {

        //}
        public void MutateCodon (string originalCodon, string newCodon) {       // assumed System.text is not allowed
            // remove junk
            for (int i = 0; i < dna.Length; i++)
                if (!(dna[i] == 'A' || dna[i] == 'C' || dna[i] == 'G' || dna[i] == 'T'))
                    dna = dna.Remove(i,1);
            
            // replace original with new
            dna = dna.Replace(originalCodon, newCodon);
        }
        //public string getsequence () {

        //}
        //public bool isvaliddna (string dnasequence) {

        //}
    }
}