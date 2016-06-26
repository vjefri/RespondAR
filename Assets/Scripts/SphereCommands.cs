using UnityEngine;

public class SphereCommands : MonoBehaviour
  
{
    Vector3 originalPosition;

    //public GameObject initialObject;
    //public GameObject swapObject;

    // Mesh initialMesh;
    //Mesh swapMesh;

    //GameObject theTarget;

    public GameObject targetchild;

    // Use this for initialization
    void Start()
    {
        // Grab the original local position of the sphere when the app starts.
        originalPosition = this.transform.localPosition;

        //stuff from internet
        //theTarget = initialObject;


    }

    // Called by GazeGestureManager when the user performs a Select gesture
    void OnSelect()
    {

        //initialMesh = initialObject.GetComponent<MeshFilter>().mesh;
        //swapMesh = swapObject.GetComponent<MeshFilter>().mesh;

        //theTarget.GetComponent<MeshFilter>().mesh = swapMesh;

        targetchild.SetActive(true);
    }

    // Called by SpeechManager when the user says the "Reset world" command
    void OnReset()
    {
        // If the sphere has a Rigidbody component, remove it to disable physics.
        var rigidbody = this.GetComponent<Rigidbody>();
        if (rigidbody != null)
        {
            DestroyImmediate(rigidbody);
        }

        // Put the sphere back into its original local position.
        this.transform.localPosition = originalPosition;
    }

    // Called by SpeechManager when the user says the "Drop sphere" command
    void OnDrop()
    {
        // Just do the same logic as a Select gesture.
        OnSelect();
    }
}
