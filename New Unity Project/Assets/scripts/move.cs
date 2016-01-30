using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    public Rigidbody2D player;
    public float force;
    public float force_jump;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey(KeyCode.D))
            player.AddForce(Vector2.right * force, ForceMode2D.Impulse);
        else if (Input.GetKey(KeyCode.Q))
           player.AddForce(Vector2.left * force, ForceMode2D.Impulse);
        else if(Input.GetKeyDown(KeyCode.Space))
           player.AddForce(Vector2.up * force_jump, ForceMode2D.Impulse);
    }
}
