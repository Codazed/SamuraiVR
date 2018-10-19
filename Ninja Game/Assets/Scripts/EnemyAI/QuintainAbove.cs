using UnityEngine;
using System.Collections;

public class QuintainAbove : MonoBehaviour {

    private bool directionup = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    if (directionup == true)
        {
            transform.Rotate(50 * Time.deltaTime, 0, 0);
            if (transform.rotation.x >= 85)
            {
                directionup = false;
            }
        }
        else
        {
            transform.Rotate(-50 * Time.deltaTime, 0, 0);
            if (transform.rotation.x <= 0)
            {
                directionup = true;
            }
        }
	}
}
