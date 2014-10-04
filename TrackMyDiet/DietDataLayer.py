# Data Layer of the applcation which populdates colleciton or call databse
# In an ideal world this should call databse and populate it but 32 lines like Collection 
# more. 
# Author -: Awdesh Sharma
# Date-: 03/10/2014

# Intent to use dictionary is in future it can contain other fiels like person, date & time food eaten etc.
# All new items can be added as key.
# {foodId: Banana
#  person : test,
#  dateTime: 03/10/2014}
dietCollection = {}             
# below method takes care of adding food eaten inside dictionary.
def add_foodEaten(self, food):
    dietCollection['foodId'] = food
# below method deletes food eaten based on foodId inside dictionary.
def delete_foodEaten(self, foodId):
    del dietCollection['foodId']
# below method takes care of updating/modifying food eaten inside dictionary.
def update_foodEaten(self, food):
    dietCollection['foodId'] = food
# below method will return filled dictionary back to the caller function.
def complete_oneDayDiet():
	return dietCollection




