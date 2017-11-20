using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class beardeath : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("bear03") == null)
        {
            transform.position= new Vector3(.926f,.59f,0);
        }
	}
}
