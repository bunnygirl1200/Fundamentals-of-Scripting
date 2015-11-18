using UnityEngine;
using System.Collections;

public class Arrays : MonoBehaviour {

	public GameObject[] players;
	
	void Start () 
	{
		players = GameObject.FindGameObjectWithTag("Player");
		
		for(int i = 0; i < players.Length; i++)
		{
			Debug.Log("Player number "+i+" is named "+players[i].name);
		}
	
	}
}



public GameObject[] players;

void Start()
{
	players = GameObject.FindGameObjectWithTag("Player");
	
	for(int i = 0; i < players.Length; i++)
	{
		Debug.Log("Player number "+i+" is named "+players[i].name);
	}
}






public GameObject[] players;

void Start()
{
	players = GameObject.FindGameObjectWithTag("Player");
	
	for(int i = 0; i < players.Length; i++)
	{
		Debug.Log("Player number "+i+" is named "+players[i].name);
	}
}

public int[] myArray = {24, 66, 77};
































