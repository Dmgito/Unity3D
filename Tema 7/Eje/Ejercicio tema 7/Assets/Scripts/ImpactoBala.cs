using UnityEngine;
using System.Collections;

public class ImpactoBala : MonoBehaviour {
	private GameObject estado;

	void Start ()
	{
		estado = GameObject.Find ("Estado");
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "Enemy") {
			estado.GetComponent<ControlEstado> ().AddPuntos (100);

		} else if (other.tag == "Player") {
			estado.GetComponent<ControlEstado> ().RemovePuntos (100);
		}
	}
}
