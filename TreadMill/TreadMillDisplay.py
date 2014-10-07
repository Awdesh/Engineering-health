# TreadMill View which will display necessary informations like calories burnt by user
# over the exercise duration, maximum heart beat rate per mins of User age.
# average speed with which user walked/ran over treadmill.
# Author -: Awdesh Sharma
# Date-: 06/10/2014

# View class that will call "CaloriesBurnt module" to determine values.
# personData of the user can be passes as a person Object which would contain-:
#  personData{ 
#	heartRate,
#	age,
#	sex,
#	duration,
#	weight
# } 
import CalorieBurnt.py
class TreadMillDisplay(object):
	def __init__(self, arg):
		self.arg = arg
	 # this will call "determine_calories"
	 def get_calories_brunt(personData):
	 	calories_burnt = CalorieBurnt.determine_calories_burnt(personData);
	 	print("Nice Work.. You burnt", calories_burnt, "calories")

	 def get_max_heart_rate(personData):
	 	heart_rate = CalorieBurnt.determine.max_heart_rate(personData.age);
	 	print("Maximum Heart Beat per min. for your age is", heart_rate, "beats per mins")

	 def get_average_speed(personData):
	 	speed = CalorieBurnt.determine_average_speed(personData.duration);
	 	print("Your workout is done!! you ran with an average speed of", speed, "miles per hour");