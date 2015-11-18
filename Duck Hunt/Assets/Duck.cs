using UnityEngine;
using System.Collections;

public class Duck : MonoBehaviour {

	// Use this for initialization
	//void Start () {
	
	//}@"
	
	// Update is called once per frame
	//void Update () {
	
	//}
	
	void OnTriggerEnter(Collider hit)
	{
	print ("test");
		if(hit.tag == "KillZone")
		{
			Destroy(this.gameObject);
		}
	}
}
