using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textdisplay : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameObject.GetComponent<TextMesh>().text = "health: " + GameObject.Find("Player").GetComponent<playerscript>().health;
	}
}
