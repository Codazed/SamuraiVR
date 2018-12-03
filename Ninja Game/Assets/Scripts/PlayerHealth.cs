using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int hp = 5;
    int count = 1201;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("Health= " + hp);
        if (count == 1200){
            hp = hp + 1;
        }
        if (count <= 1250)
        {
            count++;
        }
    }
    void OnTriggerEnter(Collider otherObj) {
        if (otherObj.gameObject.tag == "Shuriken") {
            hp = hp - 1;
            count = 0;
        }
        
    }
}
