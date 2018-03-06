using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeY : MonoBehaviour {

	// Use this for initialization
	void Update () {
		transform.position = new Vector3(transform.position.x, 0, transform.position.z);	
	}

}
