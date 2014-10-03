// Requires WeeklyConsumption module in order to keep count of green intake by person.
var greenDietMonitor = require('./WeeklyConsumption');
// static variable of WeeklyConsumption module below which will get increased with every call.
greenDietMonitor.AteGreenToday.counter = 0;
var consumedGreenInCups = greenDietMonitor.RecordGreenDiet();
if (consumedGreenInCups === 6) {
	console.log("you consumed" + consumedGreenInCups + "cups of green in last week");
}
var age = prompt("Please enter you age");
if (age > 19) {
	var idealGreen = 14;
	var need = idealGreen - consumedGreenInCups;
	if(need > 0){
	console.log("you need 20 cups of Green in a month, you need " + need + "more");
	}
}