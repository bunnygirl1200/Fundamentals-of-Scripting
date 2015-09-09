using UnityEngine;
using System.Collections;

public class Behaviour : MonoBehaviour {
	int myInt = 5;

	void Start()
	{
		myInt = MultiplyByTwo (myInt);
	}
	int MultiplyByTwo(int number)
	{
		int ret;
		ret = number * 2;
		return ret;
	}
}
