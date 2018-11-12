using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
public class Knife : MonoBehaviour
{

    public Rigidbody rb;
    public float speed;
   public AudioSource audioData;
    void Start(){
      
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
            Debug.Log("Hit");
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
    }
}