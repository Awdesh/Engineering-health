/*******************Breath Counter***************************
* Fun App to calculate how many breath user have taken since birth.
* As per online research average user takes 8-16 breath per minute
* so inside this app we consider 12 breath per minute.
* C++ console application
* Auhtor- Awdesh Sharma
* Date- 10/12/2014
***************************************************************/

#include <iostream>
#include <ctime>
#include "BreathCounter.h"
using namespace std;

/* Method takes user date of birth, then calculate time difference from current time
* then calculates total breath count user have taken.
*<param>user date of birth</param>
* returns number of breaths.
*/
int BreathCounter::count_Breath(time_t userDob){
	time_t now;
	time(&now);

	time(&userDob);

	time_t diff = userDob - now;
	time_t timeInMins = diff / 60;

	// Average user takes 8-16 breath per mins.
	int noOfBreaths = timeInMins * 12;
	return noOfBreaths;
}

/*
Client function which will call count_Breath.
*/
int main(){
	BreathCounter breathCounter;
	time_t dob;
	cout << "Enter your date of birth: ";
	cin >> dob;

	int count = breathCounter.count_Breath(dob);
	printf("Total Breath since your birth is %s", count);
}
