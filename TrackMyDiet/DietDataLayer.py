class Diet:
	# Intent to use dictionary is in future it can contain other fiels like person, date & time food eaten etc.
	# All new items can be added as key.
	# {foodName: Banana
    #  person : test,
    #  dateTime: 03/10/2014}
    dietCollection = {}             
    # below method takes care of adding food eaten inside dictionary.
    def add_foodEaten(self, food):
        self.dietCollection['foodName'] = food
    # below method takes care of adding food eaten inside dictionary.
    def delete_foodEaten(self, food):
        del self.dietCollection['food']
    # below method takes care of adding food eaten inside dictionary.
    def update_foodEaten(self, food):
        self.dietCollection['foodName'] = food
    # below method takes care of adding food eaten inside dictionary.
    def complete_oneDayDiet():
    	count = Counter(dietCollection.values())
    	return c




