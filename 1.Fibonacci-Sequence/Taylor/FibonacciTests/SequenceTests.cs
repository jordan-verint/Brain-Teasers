using FibonacciSequence;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FibonacciTests {
	[TestClass]
	public class SequenceTests {

		[TestMethod]
		public void TestCorrectResultForZero() {
			SequenceCalulator seqCalc = new SequenceCalulator();
			int actual = seqCalc.Calc(0);
			Assert.AreEqual(0, actual);
		}

		[TestMethod]
		public void TestCorrectResultForOne() {
			SequenceCalulator seqCalc = new SequenceCalulator();
			int actual = seqCalc.Calc(1);
			Assert.AreEqual(1, actual);
		}


		[TestMethod]
		public void TestCorrectResultForTen()
		{
			SequenceCalulator seqCalc = new SequenceCalulator();
			int actual = seqCalc.Calc(10);
			Assert.AreEqual(55, actual);
		}

		[TestMethod]
		public void TestCorrectResultForEleven() {
			SequenceCalulator seqCalc = new SequenceCalulator();
			int actual = seqCalc.Calc(11);
			Assert.AreEqual(89, actual);
		}

		[TestMethod]
		public void TestCorrectResultForTwelve() {
			SequenceCalulator seqCalc = new SequenceCalulator();
			int actual = seqCalc.Calc(12);
			Assert.AreEqual(144, actual);
		}

	}
}
