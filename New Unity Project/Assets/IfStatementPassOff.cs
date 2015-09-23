using UnityEngine;
using System.Collections;

public class IfStatementPassOff : MonoBehaviour 
{
	float hotchocTemperature = 50.0f;
	float hotLimitTemperature = 70.0f;
	float coldLimitTemperature = 40.0f;

	void Start()
	{
		if (hotchocTemperature > hotLimitTemperature)
		{
			print("The Hot Chocolate is too hot!");
		}
		else if (hotchocTemperature < coldLimitTemperature)
		{
			print("The Hot Chocolate is too cold!");
		}
		else
		{
			print("The Hot Chocolate is just right.");
		}
	}		
}
