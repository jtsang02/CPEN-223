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

        //[TestMethod()]
        //[ExpectedException(typeof(ArgumentException), "")]
        //public void Test3_cutAndSplice () {
        //    DNA dna14 = new DNA("ASDLKJEWER");
        //    DNA actual = dna14.CutAndSplice(null, 2, null);
        //    Assert.ThrowsException();
        //}
    }
}
