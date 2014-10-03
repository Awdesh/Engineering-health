module.exports = {
	RecordGreenDiet: function() {
		var d = new Date();
		// below will give 
		// 0 for monday
		// 1 for tuesday.
		var n = d.getDay();
		if (n > 7) {
			return;
		}
		if (AteGreenToday.counter > n) {
			return n;
		} 
		else {
			AteGreenToday.counter = AteGreenToday + 1;
			return AteGreenToday.counter;
		}
	}
}