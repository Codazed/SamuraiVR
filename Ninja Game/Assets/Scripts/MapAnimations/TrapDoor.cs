using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Rotate(Vector3.up * 90);
        
    }
    void OnTriggerEnter(Collider otherObj)
    {
        if (otherObj.gameObject.tag == "Enemy")
        {
            
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
