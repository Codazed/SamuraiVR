using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int hp = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Health= " + hp);
    }
    void OnTriggerEnter(Collider otherObj) {
        if (otherObj.gameObject.tag == "Shuriken") {
            hp = hp - 1;
           
        }
    }
}
