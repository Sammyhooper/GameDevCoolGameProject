using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = GameObject.Find("shark01").GetComponent<Transform>().position;
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 70));
	}
}
