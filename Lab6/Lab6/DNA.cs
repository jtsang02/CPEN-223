//Student name:     Josiah Tsang
//Student number:   74191248

using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6 {
    public class Program {
        static void Main () {

            //// canvas example
            //DNA test = new DNA("ATCGGGAXTT");
            //test.CutAndSplice("GGGATT", 3, "CCATCT");
            //Console.WriteLine("ATCGGGCCATCTATT");

        }
    }

    public class DNA {

        private string dna;

        /// <summary>
        /// Constructor that takes a string param and sets it to field.
        /// </summary>
        /// <param name="dna"></param>
        public DNA (string dna) //Constructor from Lab 5
        {
            this.dna = dna; //For this lab's constructor, checking for dna validity is optional 
        }

        /// <summary>
        /// Getter method to return the original unaltered DNA sequence.
        /// </summary>
        /// <returns>Returns the unaltered DNA sequence</returns>
        public string GetSequence () {
            return dna;
        }

        /// <summary>        
        /// Generates a new DNA by cutting and splicing the DNA sequence. 
        /// The new DNA should not have any junk (*this dna* though should 
        /// not change). If the restriction enzyme is not found in the 
        /// DNA sequence then the DNA sequence created is identical to
        /// the original sequence without any junk.
        /// See the lab description for details about the cut-and-splice operation.
        /// </summary>
        /// <param name="restrictionEnzyme">
        /// restrictionEnzyme is not null, not "", and is a sequence of codons with 
        /// no junk. This is the codon sequence that will be cleaved.
        /// </param>
        /// <param name="splicePosition">
        /// splicePosition is the position within the restriction enzyme where the 
        /// splicee is added.
        /// 0 &lt splicePosition &lt length of restriction enzyme.
        /// </param>
        /// <param name="splicee">
        /// splicee is not null, not "", and is a sequence of codons with no junk. 
        /// This is the enzyme to splice in to the DNA sequence where the restriction
        /// enzyme is cleaved.
        /// </param>
        /// <returns>DNA object created by the cut-and-splice operation</returns>
        /// <exception cref="ArgumentException"> 
        /// Thrown if restrictionEnzyme or splicee is not valid, or
        ///        if splicePosition is not valid
        /// </exception>
        public DNA CutAndSplice (string restrictionEnzyme, int splicePosition, string splicee) {
            
            bool isValidSequence (string sequence) { // local function

                if (String.IsNullOrEmpty(sequence)) // check if null or empty
                    return false;

                foreach (char ch in sequence) // check if sequence contains junk                                  
                    if (!(ch == 'A' || ch == 'C' || ch == 'G' || ch == 'T'))
                        return false;

                return true;
            }
            
            if (!isValidSequence(restrictionEnzyme) || !isValidSequence(splicee) || splicePosition > restrictionEnzyme.Length)
                throw new ArgumentException("Invalid restriction enzyme, splicee, or splice position.");

            RemoveJunk();

            if (dna.Contains(restrictionEnzyme)) {  // to implement

                // this only finds first occurance
                splicePosition += dna.IndexOf(restrictionEnzyme);   // first index of restriction enzyme
                StringBuilder splicedDNA = new StringBuilder();
                splicedDNA.Append(dna.Substring(0, splicePosition));   // add Left substring at splice
                splicedDNA.Append(splicee);                                // add splicee in middle
                splicedDNA.Append(dna.Substring(splicePosition));      // add right substring at splice
                
                return new DNA(splicedDNA.ToString());
                                   
            }

            else
                return new DNA(dna);
        }

        /// <summary>
        /// Removes junk from DNA sequence.
        /// </summary>
        public void RemoveJunk () {

            StringBuilder tmp = new StringBuilder();
            foreach (char c in dna)
                if (c == 'A' || c == 'C' || c == 'G' || c == 'T')
                    tmp.Append(c);
            dna = tmp.ToString();
        }
    }
}