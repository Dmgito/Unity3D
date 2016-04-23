using UnityEngine;
using System.Collections;

public class ColisionCambioColor : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<Renderer>().material.SetColor("_Color", Color.green);
        }
    }
}
