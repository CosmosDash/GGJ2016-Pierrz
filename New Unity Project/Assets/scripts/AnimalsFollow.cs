using UnityEngine;
using System.Collections;

public class AnimalsFollow : MonoBehaviour {

	Transform leader;
	float speed = 10;
	float distMax = 10;
	float distMin = 2;

	// Use this for initialization
	void Start () {
		leader = GameObject.FindGameObjectWithTag("plaine").transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (leader);
		MoveIA();
	}

	void MoveIA () {
		if (Vector3.Distance (transform.position, leader.position) >= distMin ) {
			transform.position += transform.forward * speed * Time.deltaTime;
		}
	}
}
