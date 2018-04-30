using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour {

	// we should get rid of the menu when they press enter
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			Destroy(gameObject);
		}
	}
	
}
