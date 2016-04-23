using UnityEngine;
using System.Collections;

public class ColisionEnemigo : MonoBehaviour {

    public Transform SpawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            print("Te han Matado");
            other.transform.position = SpawnPoint.position;
        }
    }

}
