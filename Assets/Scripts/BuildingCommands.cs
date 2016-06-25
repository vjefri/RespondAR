using UnityEngine;
using System.Collections;

using UnityEngine;

public class BuildingCommands : MonoBehaviour
{
    public GameObject Build;

    // Use this for initialization
    void Start()
    {
       
    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {
        // If the sphere has no Rigidbody component, add one to enable physics.
        if (!this.GetComponent<Rigidbody>())
        {
            var rigidbody = this.gameObject.AddComponent<Rigidbody>();
            rigidbody.collisionDetectionMode = CollisionDetectionMode.Continuous;
        }
    }

    // Called by SpeechManager when the user says the "Get Address" command
    void OnAddress()
    {
        // spawn the building into the scene
          //Instantiate(Build, new Vector3(2, 2, 0), Quaternion.identity);

        Debug.Log("on address");

    }
}

