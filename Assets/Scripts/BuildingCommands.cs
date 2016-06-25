using UnityEngine;
using System.Collections;

using UnityEngine;

public class BuildingCommands : MonoBehaviour
{
    Vector3 originalPosition;
    public GameObject Build;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the building when the app starts.
        originalPosition = this.transform.localPosition;
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
        Instantiate(Build);
        Debug.Log(Build);

    }
}

