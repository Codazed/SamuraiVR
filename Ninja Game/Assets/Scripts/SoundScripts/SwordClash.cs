﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class SwordClash : MonoBehaviour
{
    public AudioSource audioData;
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
        if (otherObj.gameObject.tag == "Sword")
        {
            audioData = GetComponent<AudioSource>();
            audioData.Play(0);
        }
    }
}