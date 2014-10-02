Instructions-:

Java API implementaiton to calculate vitamins required for kids.
Call function like this-:
Sample Client call
   HashMap collection<String, String> = new HashMap<String, String>();	
  	collection = VitaminDosageCalculator.getVitaminNeedsForKidsUpToEight(5);
  	// Get a set of the entries
    Set set = collection.entrySet();
   // Get an iterator
   Iterator i = set.iterator();
   // Display elements
   while(i.hasNext())
    {
     Map.Entry me = (Map.Entry)i.next();
     System.out.print(me.getKey() + ": ");
     System.out.println(me.getValue());
	}

You'll see time in mins need to maintain active lifestyle.