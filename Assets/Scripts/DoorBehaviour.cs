﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehaviour : MonoBehaviour
{
    string PLAYER_TAG = "Player";
    [SerializeField] GameObject cameraLocation;
    [SerializeField] GameObject playerLocation;
    public bool isDoorUnlocked = true;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Hit a thing with door");
        if (other.gameObject.tag == PLAYER_TAG)
        {
            if (!isDoorUnlocked)
            {
                InputCodeTrigger minigame = GetComponent<InputCodeTrigger>();
                if (minigame != null)
                {
                    minigame.StartMinigame();
                }
                else
                {
                    return;
                }
            }
            else
            {
                Debug.Log("Went there");
                Camera.main.transform.position = cameraLocation.transform.position;
                other.gameObject.transform.position = playerLocation.transform.position;
            }
        }

    }
}
