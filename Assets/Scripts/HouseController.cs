using UnityEngine;
using System.Collections;

public class HouseController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    // Called by SpeechManager
    public void OnBigger()
    {
        this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.x * 2, this.gameObject.transform.localScale.y * 2, this.gameObject.transform.localScale.z * 2);
    }

    // Called by SpeechManager 
    public void OnSmaller()
    {
        this.gameObject.transform.localScale = new Vector3(this.gameObject.transform.localScale.x / 2, this.gameObject.transform.localScale.y / 2, this.gameObject.transform.localScale.z / 2);
    }


}
