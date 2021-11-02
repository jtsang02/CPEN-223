using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab6.Tests {
    [TestClass()]
    public class DNATests {
        [TestMethod()]
        public void Test1_cutAndSplice () {
            DNA dna12 = new DNA("ATCGGGCATGTA");
            DNA expected = new DNA("ATCGGATTGATGCATGTA");
            DNA actual = dna12.CutAndSplice("GGGCAT", 2, "ATTGAT");
            Assert.AreEqual(expected.GetSequence(), actual.GetSequence());
        }

        [TestMethod()]
        public void Test2_cutAndSplice () {
            DNA dna13 = new DNA("ATCGGGCATGTAGGGCAT");
            DNA expected = new DNA("ATCGGATTGATGCATGTAGGATTGATGCAT");
            DNA actual = dna13.CutAndSplice("GGGCAT", 2, "ATTGAT");
            Assert.AreEqual(expected.GetSequence(), actual.GetSequence());
        }
    }
}