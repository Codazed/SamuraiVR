using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Knife : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
   public AudioSource audioData;
    Vector3 aPos;
    void Start(){
        aPos = transform.position;
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
    private void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Sword")
        {
            //Tried to Get the bounce back working
            //rb.velocity = ((GameObject.FindWithTag("Enemy").transform.position - transform.position) * (speed/10));
            //transform.position = Vector3.MoveTowards(transform.position, aPos, speed);
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
            rb.AddForce(new Vector3(speed * 2, speed * 2, speed * 2), ForceMode.VelocityChange);
        }
        if (otherObj.gameObject.tag == "Floor")
        {
            Destroy(gameObject);
        }
    }
    
}