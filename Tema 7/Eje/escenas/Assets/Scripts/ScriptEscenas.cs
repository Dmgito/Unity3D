using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ScriptEscenas : MonoBehaviour {

	public void cargarEscenaCubos()

	{
		//Application.LoadLevel (2); // o un identificador
		SceneManager.LoadScene(2);
	}
	public void cargarEscenaEsferas()

	{
		SceneManager.LoadScene(1);

	}

}
