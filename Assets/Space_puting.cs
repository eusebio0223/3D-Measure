using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_puting : MonoBehaviour {
	
	public GameObject box;


	
	// Update is called once per frame
	void Update () {
		Vector2 touchScreenPosition = Input.mousePosition;
		touchScreenPosition.x = Mathf.Clamp (touchScreenPosition.x, 0.0f, Screen.width);
		touchScreenPosition.y = Mathf.Clamp (touchScreenPosition.y, 0.0f, Screen.width);

		Camera gamecamera = Camera.main;
		Ray touchPointToRay = gamecamera.ScreenPointToRay (touchScreenPosition);



		
	}
}
