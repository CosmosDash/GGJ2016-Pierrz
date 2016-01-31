using UnityEngine;
using System.Collections;
using System.Collections.Generic;

[RequireComponent(typeof(CharacterController))]
public class PnjController : MonoBehaviour
{
    public float MoveSpeed;
    public float RotationSpeed;

    public GameObject objectToFollow = null;

    CharacterController cc;

    Animator m_anim;
	AudioSource audioSource;

    // Use this for initialization
    void Start()
    {
		audioSource = GetComponent<AudioSource> ();
        m_anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = Vector3.zero;

        if (objectToFollow != null)
        {
            transform.LookAt(new Vector3(objectToFollow.transform.position.x, transform.position.y, objectToFollow.transform.position.z));

            forward = transform.forward * MoveSpeed;

            float speed = forward.magnitude;

            if (Vector3.Distance(transform.position, objectToFollow.transform.position) > 1.5f)
            {
                cc.Move(forward * Time.deltaTime);
            }
            else
            {
                speed = Mathf.Min(0, speed - 1);
            }

            cc.SimpleMove(Physics.gravity);

            m_anim.SetFloat("Speed", speed);
        }

/*        if (forward == Vector3.zero)
        {
            audioSource.Stop();
        }
        else if (!audioSource.isPlaying)
        {
            audioSource.Play();
        }*/
    }

}
