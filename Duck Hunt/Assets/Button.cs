﻿using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {
	public GameObject duck;
	
	// Use this for initialization
	//void Start () {
	
	//}
	
	// Update is called once per frame
	//void Update () {
	
	//}
	
	public void SpawnDuck()
	{
		Debug.Log ("Spawn Duck");
		Instantiate (duck, transform.position, Quaternion.identity);
	}
}
