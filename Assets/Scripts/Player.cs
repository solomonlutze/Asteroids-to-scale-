using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	public float rotationSpeed = 5;
	public GameObject Bullet;

	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {
		OrientTowardsMouse();
		HandleInputs();
	}

	// look at the mouse, rotating according to a fixed speed
	void OrientTowardsMouse() {
		Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		float angle = Mathf.Atan2(target.y, target.x) * Mathf.Rad2Deg;
		Quaternion targetDirection = Quaternion.AngleAxis(angle, Vector3.forward);
		transform.rotation = Quaternion.Slerp(transform.rotation, targetDirection, rotationSpeed * Time.deltaTime);
	}

	// look for button presses. or, just the one button press.
	void HandleInputs() {
		if (Input.GetKeyDown(KeyCode.Space)) {
			Fire();
		}
	}


	// shooty shoot
	void Fire() {
		Instantiate(Bullet, transform.position, transform.rotation);
	}
}
