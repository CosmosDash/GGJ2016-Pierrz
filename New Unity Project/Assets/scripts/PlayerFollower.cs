using UnityEngine;
using System.Collections;

public class PlayerFollower : MonoBehaviour
{
    /// <summary>
    /// the player
    /// </summary>
    public GameObject player = null;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 translation = (player.transform.position - 4 * player.transform.forward + 4 * player.transform.up + -4 * player.transform.right * Input.GetAxis("Horizontal")) - transform.position;
        if (translation.magnitude > 0.1f)
        {
            transform.Translate((translation.magnitude > 1 ? translation.normalized : translation) * Time.deltaTime * 11, Space.World);
        }
        transform.LookAt(player.transform.position + Vector3.up * 1.5f);
    }
}
