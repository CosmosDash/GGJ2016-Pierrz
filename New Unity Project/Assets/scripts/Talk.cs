using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Talk : MonoBehaviour {

	public string[] answer;
	public Text put;

	int a = 0;
	int b = 0;

	// Use this for initialization
	void Start () {
		put.enabled	= false;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.E) && b == 1) {
	//		DisplayDialog = true;
			put.enabled = true;
			a = Random.Range (1, 6);
		}
			

		if (b == 0)
			put.enabled = false;

		if (a == 1)
			put.text = answer [0];
		else if (a == 2)
			put.text = answer [1];
		else if (a == 3)
			put.text = answer [2];
		else if (a == 4)
			put.text = answer [3];
		else if (a == 5)
			put.text = answer [4];
		else if (a == 6)
			put.text = answer [5];
	}

	void OnTriggerEnter () {
		b = 1;
	}

	void OnTriggerExit () {
		b = 0;

	}
}
