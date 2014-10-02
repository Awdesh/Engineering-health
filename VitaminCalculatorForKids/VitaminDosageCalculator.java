/* Program returns collection which contains vitamins as key and their intake as value.
 * Due to limitation of 32 lines this program only calculate vitamin needs for kids,
 * but other methods like geVitaminNeedsForAdults(int age) can be created
 * to measure daily vitamin intake for adults.
 * NOTE-: program doesn't support vitamin measurements for kids less than 1 year.

 * Program intentionally created in 32 lines.
 * Author-: Awdesh Sharma
 * Date-: 10/01/2014
 */
public static VitaminDosageCalculator
{
	public static HashMap<String,String> getVitaminNeedsForKidsUpToEight(int age)
	{
		HashMap vitaCollection<String, String> = new HashMap<String, String>();
		switch (age)
		{
			// Kids less than 1 year have different dietary requirements, so they aren't considered.
			case : (age > 1 && age <= 3)
			{
				// IU is the "International Unit" which commonly used to measure vitamins, medications and vaccines.
				//  There is no standard formula to convert IU to mcg, conversion changes for every vitamin.
				vitaCollection.put("Vitamin-A", "1000 IU");
				vitaCollection.put("Vitamin-B-9", "150 mcg");
				vitaCollection.put("Vitamin-C", "2000 IU");
				vitaCollection.put("Vitamin-D", "1000 IU");
				break;
			}
			case : (age > 3 && age <= 8)
			{
				vitaCollection.put("Vitamin-A", "1300 IU");
				vitaCollection.put("Vitamin-B-9", "200 mcg");
				vitaCollection.put("Vitamin-C", "300 mcg");
				vitaCollection.put("Vitamin-D", "400 mcg");
				break;
			}
			// Adults.
			default:
			{
				System.out.println("please provide age in lesser or equal to 8, or call another method getVitaminNeedsForAdults() if age is greater then 8");
				break;
			}
		}
		return vitaCollection;
	}
}