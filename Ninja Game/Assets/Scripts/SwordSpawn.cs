using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(GameObject))]
public class SwordSpawn : MonoBehaviour
{
    public GameObject katana;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.tag == "Head")
        {
            Instantiate(katana, transform.position, transform.rotation);
            
        }
    }
}