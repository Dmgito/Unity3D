using UnityEngine;
using System.Collections;

public class detectaJugador : MonoBehaviour {
	public Transform jugador;
	private Ataque scriptDeAtaque;

	void Start(){
		scriptDeAtaque = jugador.GetComponent<Ataque>();
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			scriptDeAtaque.Atacar();
		}
	}

}
