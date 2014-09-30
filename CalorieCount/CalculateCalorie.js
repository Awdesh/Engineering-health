/* Program Calculates Calorie required for a person.
 * personData must contain age, weight, height., sex and activityType of the person.
 * Sample Client call
   function knowYourCalorieNeeds() {
	var myData = new Object();
	myData.age = 26;
	myData.weight = 170;
	myData.height = 70;
	myData.sex = 'male';
	myData.activityType = lightlyactive;
	var myCalorie = calories(myData);
	console.log("Amount of calorie you need to maintain your current weight is-: " + myCalorie);
}
 * Program intentionally created in 32 lines.
 * Author-: Awdesh Sharma
 * Date-: 09/29/2014
 */
function getCalorieNeeded(personData) {
	// basal metabolic rate.
	var calorieNeeded = 0.0;
	if (personData.sex === 'male') {
		calorieNeeded = 66 + (6.3 * personData.weight) + (12.9 * personData.height) - (6.8 * personData.age)
	}
	if (personData.sex === 'female') {
		calorieNeeded = 655 + (4.3 * personData.weight) + (4.7 * personData.height) - (4.7 * personData.age)
	}
	function() {
		switch (personData.activityType) {
			// Person with little or no activity during the day.
			case sedentary:
				calorieNeeded = calorieNeeded * 1.2;
				break;
			case lightlyactive:
				calorieNeeded = calorieNeeded * 1.375;
				break;
			case moderatelyactive:
				calorieNeeded = calorieNeeded * 1.55;
				break;
			case veryactive:
				calorieNeeded = calorieNeeded * 1.725;
				break;
			case superactive:
				calorieNeeded = calorieNeeded * 1.9;
				break;
			default:
				console.log("No activityType is defined, Please enter your activityType.");
		}
	}
	return calorieNeeded;
}

