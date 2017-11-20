using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fruitscript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position) < .1f)
        {
            GameObject.Find("Player").GetComponent<playerscript>().health += 10;
            Destroy(gameObject);
        }
	}
}
