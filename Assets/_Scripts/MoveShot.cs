using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShot : MonoBehaviour {
	
	public Transform target;
	public float speed;

	void Update() {
		float step = speed * Time.deltaTime;
		transform.position = Vector3.MoveTowards(transform.position, target.position, step);
		//transform.position += Vector3.forward * Time.deltaTime;
	}

	void OnCollisionEnter (Collider collision) {
		if (collision.gameObject.tag == "Wolf") {
			Destroy (collision.gameObject);
		}
	}
}
