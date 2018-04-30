using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float lifetime = 10.0f;
	public float speed = 10.0f;
	
	void Start () {
		StartCoroutine(SelfDestruct());
	}
	
	void Update () {
 		transform.position += transform.right * Time.deltaTime * speed;
	}

	// memento mori
	IEnumerator SelfDestruct() {
		yield return new WaitForSeconds(lifetime);
		Destroy(gameObject);
	}
}
