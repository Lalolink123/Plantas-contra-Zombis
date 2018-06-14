using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSound : MonoBehaviour {

    public AudioClip gunSound;
    public AudioClip disparo;

    AudioSource fuenteAudio;

	// Use this for initialization
	void Start () {

        fuenteAudio = GetComponent<AudioSource>();



		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.A)) {
            fuenteAudio.clip = disparo;
            fuenteAudio.Play();
              
                
        }
	}
}
