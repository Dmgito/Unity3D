using UnityEngine;
using System.Collections;

public class Ataque : MonoBehaviour {

    public Transform proyectil;
    public Transform posicionInicialBala;
    public int velocidadDisparo = 3;
    public bool detector = false;

    private float tiempoUltimoDisparo = 0;
    private float tiempoEntreDisparos = 5; 

    public void Atacar()
    {
        Transform bala = (Transform)Instantiate(proyectil, posicionInicialBala.position, transform.rotation);
        bala.GetComponent<Rigidbody>().AddForce(this.transform.forward * 1000 * velocidadDisparo);
        Destroy(bala.gameObject, 2);

    }

    void Update()
    {
        if(detector == true)
        {
            if ((Time.time - tiempoUltimoDisparo > tiempoEntreDisparos) & (detector == true))
                { 
                    Atacar();
                    //print("Sirvio el Codicional");
                    tiempoUltimoDisparo = Time.time;
                    detector = false;    
                }
        }

    }
}
