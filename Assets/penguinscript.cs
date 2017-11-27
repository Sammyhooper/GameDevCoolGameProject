using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class penguinscript : MonoBehaviour {

    public Transform bomb;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(GameObject.Find("Player").GetComponent<Transform>().position, transform.position) < 3)
        {
            transform.position= Vector3.Lerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, .8f);
            Instantiate(bomb, transform.position,Quaternion.identity);
            Destroy(gameObject);
        }
	}
}
