using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    bool locked = true;
    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening = false;

    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up
        if (transform.position.y > 10.0f)
        {
            opening = false;
        }
        if (opening)
        {
            transform.Translate(0, 2.5f * Time.deltaTime, 0, Space.World);
        }
 
    }

    public void OnDoorClicked() {
        // If the door is clicked and unlocked
        if (!locked)
        {
            // Set the "opening" boolean to true
            opening = true;
        }
        else
        {
            // (optionally) Else
            // Play a sound to indicate the door is locked
            this.GetComponent<AudioSource>().Play();
        }
    }

    public void Unlock()
    {
        Debug.Log("Door unlocked");
        // You'll need to set "locked" to false here
        locked = false;
    }
}
