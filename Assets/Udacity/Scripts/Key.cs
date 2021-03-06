﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
    GameObject KeyPoofPrefab;
    GameObject door;

	void Update()
	{
		//Not required, but for fun why not try adding a Key Floating Animation here :)
	}

	public void OnKeyClicked(GameObject keyPoof)
	{
        // Instatiate the KeyPoof Prefab where this key is located
        // Make sure the poof animates vertically
        Object.Instantiate(keyPoof, transform.position, Quaternion.Euler(new Vector3(-90, 0, 0)));
        // Call the Unlock() method on the Door
        door = GameObject.Find("DoorObject");
        Door doorScript = door.GetComponent<Door>();
        doorScript.Unlock();
        // Set the Key Collected Variable to true

        // Destroy the key. Check the Unity documentation on how to use Destroy
        Destroy(this.gameObject);
        
    }

}
