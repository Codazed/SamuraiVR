using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour {
    public float gravity = 9.81f;
    private Vector3 moveDirection = Vector3.zero;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //Fall
        if (moveDirection.y > gravity * -1)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        transform.Translate(moveDirection * Time.deltaTime);
    }
}
