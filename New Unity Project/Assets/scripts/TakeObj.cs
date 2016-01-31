﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TakeObj : MonoBehaviour
{

	public PlayerController playerController;

	void Update() {
		transform.Rotate(3, 1, 0);
	}

	void OnTriggerStay() 
	{
		if (Input.GetKey (KeyCode.T)) {
			playerController.List.Add (gameObject.name);
			Destroy (this.gameObject);
		}
	}
}