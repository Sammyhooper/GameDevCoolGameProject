using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascript : MonoBehaviour {

    
    
	// Use this for initialization
	void Start () {
        //trans = new vector3(GameObject.Find("Player").GetComponent<Transform>().position);

    }
	
	// Update is called once per frame
	void Update () {
		transform.position= new Vector3(GameObject.Find("Player").GetComponent<Transform>().position.x, GameObject.Find("Player").GetComponent<Transform>().position.y,-20);
    }
}
