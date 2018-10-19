using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;

    // Use this for initialization
    void Start()
    {
        rb.AddForce((GameObject.FindWithTag("Player").transform.position - transform.position) * speed);
    }

    // Update is called once per frame
    void Update()
    {

    }
}