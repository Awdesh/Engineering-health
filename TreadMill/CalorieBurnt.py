# based on sex of the person method applies different mathematical formual and 
# determines calories burnt.
def determine_calories_burnt(personData):
	if personData.sex == "Male":
		calories = ((-55.0969 + (0.6309 x personData.heartRate) + (0.1988 x personData.weight) + (0.2017 x personData.age))/4.184) x 60 x personData.duration
	elif personData.sex == "Female":
		calories = ((-20.4022 + (0.4472 x personData.heartRate) - (0.1263 x personData.weight) + (0.074 x personData.age))/4.184) x 60 x personData.duration
	return calories

# below method determines maximum heart rate as per age of the User.
def determine_max_heart_rate(age):
	maximumHeartRate = 208 - (0.7 * age)
	return maximumHeartRate

# below function determines average speed with which ran/ walked.
def determine_average_speed(personData):
	distance = 1
	speed = distance / personData.duration
	return speed;