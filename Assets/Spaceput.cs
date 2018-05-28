using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaceput : MonoBehaviour {

	public GameObject box;

	// Use this for initialization
	void Update ()
	{
		

		if (Input.GetKey (KeyCode.Space)) {
			print ("ooooo");
			Instantiate (box, new Vector3 (0, 0, 0), Quaternion.identity);
		}
	}
}

			
			
       
		

	
