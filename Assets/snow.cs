using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Slerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, .1f);
    }
}
