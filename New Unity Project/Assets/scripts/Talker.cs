using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Talker : MonoBehaviour
{
    public string[] lines;
    public bool isTalking = false;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider p_other)
    {
       if (p_other.tag == "Player")
        {
            isTalking = true;
        }
    }

    void OnTriggerExit(Collider p_other)
    {
        if (p_other.tag == "Player")
        {
            isTalking = false;
        }
    }
}
