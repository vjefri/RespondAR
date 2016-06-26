using UnityEngine;
using System.Collections;

public class BuildingCommands : MonoBehaviour
{
    public GameObject Build;
    public GameObject ScrollView;
    public GameObject GLOWCLICK_WTC;
    public GameObject GLOWCLICK_Entry;
    public GameObject GLOWCLICK_TOP;

    int i = 180;

    // Use this for initialization
    void Start()
    {
       Build.SetActive(false);
       GLOWCLICK_WTC.SetActive(false);
       GLOWCLICK_Entry.SetActive(false);
       GLOWCLICK_TOP.SetActive(false);
    }

    void Update()
    {
        /*
        if (!Build.active) { return; }
        i -= 1;
        if (i < 0)
        {
            var pos = ScrollView.transform.position;
            pos.y = i / 1000;
            ScrollView.transform.position = pos;
        }
        */
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
        Build.SetActive(true);
        GLOWCLICK_TOP.SetActive(true);

    }

    void Dispatch()
    {
        GLOWCLICK_WTC.SetActive(true);
    }

    void EntryPoint()
    {
        GLOWCLICK_Entry.SetActive(true);
    }
}

