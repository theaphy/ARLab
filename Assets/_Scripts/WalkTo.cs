using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkTo : MonoBehaviour {
	public float xSpeed = 0;
	public float zSpeed = 2;
	public float speed = 5;

	public string attackAnimName = "attack01";
	public float attackStrength = 1.2f;

	private bool attacking;

	private GameObject target;
	public Transform destination;

	void Start () {
		//GetComponent<Animator> ().SetBool ("attack03", true);
		GetComponent<Animator> ().SetBool ("walk", true);
		bool check = GetComponent<Animator> ().GetBool ("walk");
		Debug.Log (check);

	}
	
	// Update is called once per frame
	void Update () {
		GameObject tower = GameObject.FindWithTag("Tower");
		if (!attacking) {
			transform.LookAt(tower.transform);
			transform.Translate (xSpeed * Time.deltaTime, 0, zSpeed * Time.deltaTime);

		} else {
			bool standing = target.GetComponent<Building> ().TakeDamage (attackStrength);
			if (!standing) {
				GetComponent<Animator> ().SetBool (attackAnimName, false);
				GetComponent<Animator> ().SetBool ("walk", true);
			}

		}

	}

	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Building" || col.gameObject.tag == "Tower") {
			attacking = true;
			target = col.gameObject;
			GetComponent<Animator> ().SetBool (attackAnimName, true);
			GetComponent<Animator> ().SetBool ("walk", false);
		}
	}
}
