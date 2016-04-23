using UnityEngine;
using System.Collections;

public class ColisionEnemigo : MonoBehaviour {

	public Transform posicionInicial;

	void OnTriggerEnter (Collider other)
	
	{
		if(other.tag == "Player")
		{
			
			other.transform.position = posicionInicial.position;
		}
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
