﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeChildren : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
       // Debug.Log("trigger");
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Collision Enter");
    }
}
