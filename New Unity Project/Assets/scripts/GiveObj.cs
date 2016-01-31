using UnityEngine;
using System.Collections;

public class GiveObj : MonoBehaviour {

	public PlayerController playerController;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(Collider other) {
	if (Input.GetKey (KeyCode.E)) {

		playerController.List.Remove (gameObject.name);
		}
	}
}
