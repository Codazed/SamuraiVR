using UnityEngine;
using System.Collections;

public class Throw : MonoBehaviour {

    public GameObject knife;
    public GameObject shuriken;

    private bool isWaiting = false;
    private int choice;

    void Update()
    {
        if (isWaiting == false) {
            isWaiting = true;
            StartCoroutine(Timer());
        }
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(5);
        choice = Random.Range(0, 2);
        if (choice == 0)
        {
            Instantiate(knife);
        }
        else
        {
            //Instantiate(shuriken);
            Instantiate(knife);
        }
        isWaiting = false;
    }
}
