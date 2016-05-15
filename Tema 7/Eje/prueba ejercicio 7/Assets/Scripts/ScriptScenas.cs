using UnityEngine;
using System.Collections;

public class ScriptScenas : MonoBehaviour {

	public void AbrirEscenaTanqueRojo ()
	{

		Application.LoadLevel("TanqueRojo");
	}

	public void AbrirEscenaTanqueAzul ()
	{

		Application.LoadLevel("TanqueAzul");
	}


}
