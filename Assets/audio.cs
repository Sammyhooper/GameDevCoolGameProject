﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour {

	// Use this for initialization
	void Start () {
        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.Play(44100);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
