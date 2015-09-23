using UnityEngine;
using System.Collections;

public class WhileLoop : MonoBehaviour 

{
	int cupsInSink = 4;

	void Start()
	{
		while (cupsInSink > 0) 
		{
			Debug.Log ("I've washed a cup!");
		}
	}

}
