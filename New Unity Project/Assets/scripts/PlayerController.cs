using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour
{

    public float MoveSpeed;
    public float RotationSpeed;
    CharacterController cc;

    Animator m_anim;

    // Use this for initialization
    void Start()
    {

        m_anim = GetComponent<Animator>();
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 forward =  transform.forward * Input.GetAxis("Vertical") * MoveSpeed;

        if (Input.GetAxis("Vertical") < 0)
        {
            forward /= 3;
        }

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
