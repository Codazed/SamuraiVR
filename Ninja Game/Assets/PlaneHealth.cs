using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHealth : MonoBehaviour {

    Color mat;
    public PlayerHealth s;

	// Use this for initialization
	void Start () {
        mat = gameObject.GetComponent<Renderer>().material.color;
        s = GameObject.Find("SwordSpawn").GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        if (s.hp == 5) {
            mat.a = 0;
        } else {
            mat.a = 1f - (0.2f * s.hp);
        }
	}
}
