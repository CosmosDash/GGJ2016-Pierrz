using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{
	public List<string> List = new List<string> ();

    public float MoveSpeed;
    public float RotationSpeed;

    public GameObject followedBy = null;

    CharacterController cc;

    Animator m_anim;
	AudioSource source;

    // Use this for initialization
    void Start()
    {
		source = GetComponent<AudioSource> ();
        m_anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward =  transform.forward * Input.GetAxis("Vertical") * MoveSpeed;

		Debug.Log (forward.x + " " + forward.y + " " + forward.z);

        if (Input.GetAxis("Vertical") < 0)
        {
            forward /= 3;
        }
			
		if (forward == Vector3.zero)
			source.Stop();
		else if (!source.isPlaying)
			source.Play ();
			
        cc.Move(forward * Time.deltaTime);
        cc.SimpleMove(Physics.gravity);

        if (Camera.main != null && Input.GetAxis("Vertical") != 0)
        {
            Vector3 cameraForward = Camera.main.transform.forward;
            transform.LookAt(transform.position + new Vector3(cameraForward.x, 0, cameraForward.z).normalized);
        }

        float speed = forward.magnitude;
        m_anim.SetFloat("Speed", speed * Input.GetAxis("Vertical"));

    }

}
