using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace FibonacciSequence {
	public class SequenceCalulator {



		public int Calc(int pos) {

			List<int> fibSeq = FillList(new List<int>(), pos + 1);

			return fibSeq[pos];

		}

		private List<int> FillList(List<int> fibSeq, int requiredLength) {

			if (fibSeq.Count == 0) {
				fibSeq.Add(0);
			} else if (fibSeq.Count < 2) {
				fibSeq.Add(1);
			} else {
				fibSeq.Add(fibSeq[fibSeq.Count - 2] + fibSeq[fibSeq.Count - 1]);
			}


			if (fibSeq.Count < requiredLength) {
				return FillList(fibSeq, requiredLength);
			} else {
				return fibSeq;
			}

		}
	}
}
