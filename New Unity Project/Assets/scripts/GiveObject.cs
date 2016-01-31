using UnityEngine;
using System.Collections;

public class GiveObject : MonoBehaviour
{

    public PlayerController playerController;
    public string questObjectName;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
			if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.JoystickButton0))
            {
                if (playerController.List.Contains(questObjectName))
                {
                    playerController.List.Remove(questObjectName);
                    if (GetComponent<PnjController>() != null)
                    {
                        GetComponent<Talker>().lines = new string[0];
                        GetComponent<PnjController>().objectToFollow = other.gameObject;
                        
                        if(other.GetComponent<PlayerController>().followedBy != null)
                        {
                            GetComponent<PnjController>().objectToFollow = other.GetComponent<PlayerController>().followedBy;
                            while (GetComponent<PnjController>().objectToFollow.GetComponent<PnjController>().followedBy != null)
                            {
                                GetComponent<PnjController>().objectToFollow = GetComponent<PnjController>().objectToFollow.GetComponent<PnjController>().followedBy;
                            }

                            GetComponent<PnjController>().objectToFollow.GetComponent<PnjController>().followedBy = gameObject;
                        }
                        else
                        {
                            other.GetComponent<PlayerController>().followedBy = gameObject;
                        }
                    }
                }
            }
        }
    }
}
