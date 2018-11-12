using UnityEngine;
using System.Collections;

public class Knife : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
    //AudioSource audioData;
    void Start(){
       // audioData = GetComponent<AudioSource>();
        //audioData.Play(0);
        transform.Translate(Vector3.up * 7);
        //Sets the shuriken to face correct orientation
        transform.Rotate(Vector3.right * 90);
        //Moves shuriken
        rb.velocity = ((GameObject.FindWithTag("MainCamera").transform.position - transform.position) * speed);
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector3.MoveTowards(transform.position, GameObject.FindWithTag("MainCamera").transform.position, speed);
        //Spins shuriken
        transform.Rotate(Vector3.forward * 20);
    }
}