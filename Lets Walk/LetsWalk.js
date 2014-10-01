/* Program returns time(mins) required by a person to walk to lead active lifestyle.
 * 
 * Sample Client call
   function getRemainingTimeNeedToWalk() {
   	var timeWalkedInMins = 30;
	var time = FitBit.timeRequiredToStayActive(timeWalkedInMins);
}
 * Program intentionally created in 32 lines.
 * Author-: Awdesh Sharma
 * Date-: 09/30/2014
 */
var FitBit = function() {
	return {
		// method that will return time in minutes required for a person to stay active.
		//<param>timeWalkedInMins-: time in mins that person already walked.</param>
		timeRequiredToStayActive: function(timeWalkedInMins){
			var numberOfSteps = timeWalkedInMins * 100;
			// An Active person walks 10000 steps or more in a day.
			var stepsNeeded = 10000 - numberOfSteps;
			// A Person walks 100 steps in a minute, so dividing steps by 100 
			// will give more minutes required for person to walk.
			var timeNeedToWalk = 0;
			if(stepsNeeded > 0){
				timeNeedToWalk = (stepsNeeded / 100);
			}
			return timeNeedToWalk;
		},
		getRemainingTimeNeedToWalk: function(){
			var minsWalkedAlready = prompt("Please enter time in mins you think you have walked already today!!");
			var timeNeedToWalk = FitBit.timeRequiredToStayActive(minsWalkedAlready);
			var numberOfSteps = minsWalkedAlready * 100;
			switch (true) {
			case :(numberOfSteps < 5000)
				// Below is what should show inside client function, below just demonstrates how it looks like.
				console.log("You are leading Sedentary lifestyle , Get up from your couch you need to walk " + timeNeedToWalk + "mins today");
				break;
			case :(numberOfSteps >= 5000 && numberOfSteps < 7499)
				console.log("You are leading Low Active lifestyle, We believe in you, you can do better, just need to walk" + timeNeedToWalk + "mins today");
				break;
			case :(numberOfSteps >= 7500 && numberOfSteps < 9999)
				console.log("Good Job, Nearly there!!You are leading Moderate Active lifestyle, just walk" + timeNeedToWalk + "mins today");
				break;
			case :(numberOfSteps >= 10000)
				console.log("BRAVO!! you are leading active lifestyle. Keep up the good");
				break;
			}
		}
	}
}

