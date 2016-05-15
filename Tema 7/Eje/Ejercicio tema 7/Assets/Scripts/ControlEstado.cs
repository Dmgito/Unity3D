using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class ControlEstado : MonoBehaviour {
	private int puntos;
	public Text puntuacion;


	// Use this for initialization
	void Start () {
		puntos = 0;

	}
	
	public void AddPuntos(int p)
	{

		puntos = puntos + p; // puntos += p;
		puntuacion.text = puntos.ToString();
	}
	public void RemovePuntos(int p)
	{

		puntos = puntos - p; // puntos -= p;
		puntuacion.text = puntos.ToString();
	}
}
