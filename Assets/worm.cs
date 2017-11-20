using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class worm : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.y<= -6.7f)
        {
            transform.position = new Vector3(Random.Range(-4, 5), 2.5f, 0);
        }
	}
}
