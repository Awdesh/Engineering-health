import DietDataLayer.py
class ClassName(object):
	# constructor which intializes "foodEaten" disctionary.
	def __init__(self, arg):
		self.arg = arg
		# foodEaten is the dictionary been used 
		self.foodEaten = {}
	# When user presses add button on View(UI) we'l call this action which in turn call data layer to add data inside collection or db 
	def add_foodEatenAction():
		DietDataLayer.add_foodEaten('Banana')
	# When user presses delete button on View(UI) we'l call this action which in turn call data layer to add data inside collection or db 
	def delete_foodEatenAction():
		DietDataLayer.delete_foodEaten('Banana')
	# When user presses modify button on View(UI) we'l call this action which in turn call data layer to add data inside collection or db 
	def update_foodEatenAction():
		DietDataLayer.update_foodEaten('Banana and cereals')
	# Once user is done with adding all his/her diet and presses "complete for today" button we'll call this action which will call its corresponding action in data layer.	
	def complete_oneDayDietAction():
		self.foodEaten = DietDataLayer.complete_oneDayDiet()
	# complete_oneDayDietAction will give us filled dictionary which we can use to return back to UI and display the summary of food eaten by user. 
	def summary_ofOneDayDiet():
		return self.foodEaten




		


