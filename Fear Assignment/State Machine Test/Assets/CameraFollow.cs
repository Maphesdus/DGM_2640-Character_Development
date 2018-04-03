using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	GameObject player;

	// START:
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// LATE UPDATE:
	void LateUpdate () {
		transform.position = player.transform.position;
	}
}