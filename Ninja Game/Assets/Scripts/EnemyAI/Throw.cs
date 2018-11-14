using UnityEngine;
using System.Collections;
[RequireComponent(typeof(AudioSource))]
[RequireComponent(typeof(Animator))]
public class Throw : MonoBehaviour {

    public GameObject knife;
    public GameObject shuriken;
    public AudioSource audioData;
    private bool isWaiting = false;
    private int choice;
    public Animator anim;


    void Start() {
       // transform.LookAt(GameObject.FindWithTag("MainCamera").transform);
    }

    void Update(){



        if (isWaiting == false) {
            isWaiting = true;
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {

        Vector3 playerPos = transform.position;
        Vector3 playerDirection = transform.forward;
        Quaternion playerRotation = transform.rotation;
        float spawnDistance = 3;
        Vector3 spawnPos = playerPos + playerDirection * spawnDistance;
        
        yield return new WaitForSeconds(5);
        //Instantiate(knife, transform.position, Quaternion.LookRotation(new Vector3(0,0,0)));
        choice = Random.Range(0, 2);
        /* if (choice == 0)
         {
             Instantiate(knife, transform.position, transform.rotation);
         }
         else
         {*/
        //Instantiate(shuriken);
      
       

        Instantiate(knife, spawnPos, transform.rotation);
        
        audioData = GetComponent<AudioSource>();
        audioData.Play(0);
        // }
        isWaiting = false;
    }
}
