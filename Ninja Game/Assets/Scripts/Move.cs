using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
    

    private bool sliding = false;
    private Vector3 slidingDirection;
    public float gravity = 9.81f;
    private Vector3 moveDirection = Vector3.zero;
    public CharacterController controller;
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10, Input.GetAxis("Jump") * Time.deltaTime * 10, Input.GetAxis("Vertical") * Time.deltaTime * 10);
        //Fall
        if (moveDirection.y > gravity * -1)
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }
        controller.Move(moveDirection * Time.deltaTime);
        if (sliding)
        {
            controller.Move(slidingDirection * 2 * Time.deltaTime);
        }
    }
}
