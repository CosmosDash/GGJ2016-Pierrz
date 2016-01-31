using UnityEngine;
using System.Collections;

public class MonolithComponent : MonoBehaviour
{
    int colliders = 0;
    // Use this for initialization
    void Start()
    {

    }

    IEnumerator waitAndLoad()
    {
        AudioSource audioSource = GetComponents<AudioSource>()[1];

        audioSource.Play();

        yield return new WaitForSeconds(5);

        Application.LoadLevel(3);
    }

    // Update is called once per frame
    void Update()
    {
        if (colliders >= 6)
        {
            StartCoroutine(waitAndLoad());
        }
    }

    void OnTriggerEnter()
    {
        ++colliders;
    }

    void OnTriggerExit()
    {
        --colliders;
    }
}
