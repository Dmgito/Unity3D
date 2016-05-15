using UnityEngine;
using System.Collections;

public class PasarEscenaInicial : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.V))
		{
			Application.LoadLevel("EscenaInicial");
		}
	}
}
