using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneHealth : MonoBehaviour {

    Color mat;
    float newAlpha;
    public PlayerHealth s;

	// Use this for initialization
	void Start () {
        mat = GetComponent<MeshRenderer>().material.color;
        s = GameObject.Find("SwordSpawn").GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log(s.hp);
        Debug.Log(mat.a);
        if (s.hp == 5) {
            newAlpha = 0;
        } else {
             newAlpha = 1 - (0.2f * s.hp);
        }
        GetComponent<Renderer>().material.color = new Color(GetComponent<Renderer>().material.color.r, GetComponent<Renderer>().material.color.g, GetComponent<Renderer>().material.color.b, newAlpha);
    }
}
