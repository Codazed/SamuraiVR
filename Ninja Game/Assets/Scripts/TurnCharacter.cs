using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Turns camera left
        if (Input.GetAxis("Fire2") > .2)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * 90);
        }

        //Turns camera right
        if (Input.GetAxis("Fire2") < -.2)
        {
            transform.Rotate(Vector3.down * Time.deltaTime * 90);
        }
    }
}
