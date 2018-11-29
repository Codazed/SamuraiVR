using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsEnemy : MonoBehaviour {
    int count = 0;

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        count = count + 1;
        if (count >= 1200) {
            if (transform.position.y > .1) {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y - 7, transform.position.z), 50 * Time.deltaTime);
            }
        }
    }
}
