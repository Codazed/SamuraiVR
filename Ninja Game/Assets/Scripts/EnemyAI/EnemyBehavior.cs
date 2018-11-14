using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class EnemyBehavior : MonoBehaviour
{
    public float gravity = 9.81f;
    private Vector3 moveDirection = Vector3.zero;
    public GameObject otherObject;
    public Animator anim;

    // Use this for initialization
    void Start()
    {
        anim.Play("Standard_Idle");
    }

    // Update is called once per frame
    void Update()
    {
        // anim = GetComponent<Animator>();
        transform.LookAt(GameObject.FindWithTag("MainCamera").transform.position);
        anim.Play("Standard_Idle");
        //Fall
        /*  if (moveDirection.y > gravity * -1)
          {
              moveDirection.y -= gravity * Time.deltaTime;
          }
          transform.Translate(moveDirection * Time.deltaTime);
      }*/
    }
}
