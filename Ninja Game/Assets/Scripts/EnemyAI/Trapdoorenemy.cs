using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trapdoorenemy : MonoBehaviour {
    int count = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (count < 400) {
            transform.Translate(Vector3.up * 2 * Time.deltaTime);
            count = count + 1;
        }
        else if (count >= 800)
        {
            count = 0;
        }
        else if (count >=400)
        {
            transform.Translate(Vector3.down * 2 * Time.deltaTime);
            count = count + 1;
        }
        
        }
}
