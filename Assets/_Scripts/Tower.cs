using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour {
	public Transform shotSpawn;
	public GameObject shot;

	private bool found = false;

	void Found () {
		found = true;

	}

	void Lost () {
		found = false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (!found) {
			return;
		}
		
	}

	IEnumerator CarrotShot() {
		Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		yield return new WaitForSeconds(2);

	}

	void OnCollisionEnter (Collision collision) {
		if (collision.collider.tag == "Wolf") {
			StartCoroutine (CarrotShot());

		}
	}
}
