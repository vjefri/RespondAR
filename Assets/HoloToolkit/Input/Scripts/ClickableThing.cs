using UnityEngine;
using System.Collections;

public class ClickableThing : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnSelect();
        }
	
	}

    public void OnSelect()
    {
        this.gameObject.transform.position += Vector3.up * 0.1f;
    }
}
