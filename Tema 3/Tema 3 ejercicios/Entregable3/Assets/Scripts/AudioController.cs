using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {
    private AudioSource audio;

	// Use this for initialization
	void Start () {
        audio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

        if(Input.GetKeyDown(KeyCode.S))
        {
            if (audio.isPlaying)
            {
                audio.Stop();
            }

            else if (!audio.isPlaying)
            {

                audio.Play();
            }
        }
	
	}
}
