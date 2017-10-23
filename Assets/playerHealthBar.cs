using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerHealthBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("Player") != null)
        {
            transform.localScale = new Vector3((1.1f - (100 - GameObject.Find("Player").GetComponent<playerscript>().health) /15f), transform.localScale.y, transform.localScale.z);
        }

    
    }
}
