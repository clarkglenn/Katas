using System.Collections.Generic;

namespace Katas.Samples {
	public class NOTDONE_OpenClosed {
		//This method has a cyclomatic complexity of 4, we should fix that, we should also make this method open for extension but closed for modification. 
		//We have realized that we make up new discount for our customers as we go. We need a way of add these discount calculations without needing to modify this code every single time.
		public decimal CalculateDiscount(Customer customer) {
			var calculatedDiscount = 0;
			if(customer.BoughtLotsOfStuff)
				calculatedDiscount = 1000;
			else if(customer.BoughtSomeStuff)
				calculatedDiscount = 500;
			else if(customer.IsPrettyCheap) //Added 2017-01-03 - EB
				calculatedDiscount = 1;

			return calculatedDiscount;
		}
	}

	public class Customer {
		public bool BoughtLotsOfStuff { get; set; }
		public bool BoughtSomeStuff { get; set; }
		public bool IsPrettyCheap { get; set; }
	}
}