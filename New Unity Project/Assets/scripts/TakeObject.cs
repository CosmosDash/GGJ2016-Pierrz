﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TakeObject : MonoBehaviour
{
    public PlayerController playerController;

    void Update()
    {
        transform.Rotate(3, 1, 2);
    }

    void OnTriggerStay()
    {
        if (Input.GetKey(KeyCode.E) || Input.GetKey(KeyCode.JoystickButton0))
        {
            playerController.List.Add(gameObject.name);
            Destroy(this.gameObject);
        }
    }
}
