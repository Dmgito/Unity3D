using UnityEngine;
using System.Collections;

public class ShootingController : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 2;

	public Transform enemigo; 
	private MovimientoEnemigo scriptEnemigo; 
	// Use this for initialization
	void Start () {
		scriptEnemigo =	enemigo.GetComponent<MovimientoEnemigo>(); 
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
            bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
            Destroy(bala.gameObject, 5);

			scriptEnemigo.setPersiguiendo(true);
			scriptEnemigo.cambiarObjetivo(transform);

        }
	}
}
