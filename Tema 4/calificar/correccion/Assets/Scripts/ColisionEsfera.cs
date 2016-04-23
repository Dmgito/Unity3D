﻿using UnityEngine;
using System.Collections;

public class ColisionEsfera : MonoBehaviour {
    
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.yellow);
        }
    }

}