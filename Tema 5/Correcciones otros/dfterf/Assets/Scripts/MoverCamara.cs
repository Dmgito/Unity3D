﻿using UnityEngine;
using System.Collections;

public class MoverCamara : MonoBehaviour {
    private Animator anim;
	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.J))
        {
            anim.SetTrigger("movercamara");
        }
	}
}
