using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sheild : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = GameObject.Find("Player").GetComponent<Transform>().position;
		if (Input.GetKey(KeyCode.X) != true)
        {
            Destroy(this.gameObject);
        }
	}
}
