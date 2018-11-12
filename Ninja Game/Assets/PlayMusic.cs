using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMusic : MonoBehaviour {
    public GameObject gameObjectToEnable;
    public GameObject Music2;
    private int choice;
    // Use this for initialization
    void Start () {

        //This script picks a random song from our playlist
        choice = Random.Range(0, 2);
        Debug.Log(choice);
        if (choice == 0)
        {
            gameObjectToEnable.SetActive(true);
        }
        else
        {
            Music2.SetActive(true);
        }
    
}

// Update is called once per frame
void Update() {
}
}
