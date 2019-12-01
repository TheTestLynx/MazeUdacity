using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontDoors : MonoBehaviour 
{
    // Create a boolean value called "locked" that can be checked in OnDoorClicked() 
    // Create a boolean value called "opening" that can be checked in Update() 
    bool opening = false;

    void Update() {
        // If the door is opening and it is not fully raised
        // Animate the door raising up

    }

    public void OnDoorClicked() {
            Debug.Log("door clicked " + opening);
        if (opening)
        {
            this.transform.Rotate(0, 90, 0);
            this.transform.Translate(0f, 0.2f, 0f);
        }
        else
        {

            this.transform.Rotate(0, -90, 0);
            this.transform.Translate(0f, -0.2f, 0f);
        }
        opening = !opening;
    }
    
}
