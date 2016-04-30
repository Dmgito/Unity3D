using UnityEngine;
using System.Collections;

public class DetectarPlayerPasillo : MonoBehaviour {

	public Transform miEnemigoVerde;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Player")
		{
			Ataque script = miEnemigoVerde.GetComponent<Ataque>();
			script.Atacar();
		}
	}
}
