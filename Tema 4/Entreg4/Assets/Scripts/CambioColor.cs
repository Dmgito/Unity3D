using UnityEngine;
using System.Collections;

public class CambioColor : MonoBehaviour {
	void OnTriggerEnter (Collider other)
	
	{
		if(other.tag == "Player")
		{
			
			GetComponent<Renderer>().material.SetColor("_Color", Color.green);
		}
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
