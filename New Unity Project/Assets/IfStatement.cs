using UnityEngine;
using System.Collections;

public class IfStatement : MonoBehaviour 

{
	float hotchocTemperature = 85.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;

	void TemperatureTest()
	{
		if (hotchocTemperature > hotLimitTemperature) 
		{
			print ("The Hot Chocolate is too hot!");
		} 

		else if (hotchocTemperature < coldLimitTemperature)
		{
			print ("The Hot Chocolate is too cold!");
		}

		// If neither
		else 
		{
			print ("The Hot Chocolate is just right.");
		}
	}


}
