using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealthBar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("shark01") != null)
        {
            transform.localScale = new Vector3((4.88f -(100- GameObject.Find("shark01").GetComponent <shark> ().health)/18f), transform.localScale.y, transform.localScale.z);
        }

        if (GameObject.Find("shark01") == null)
        {
            transform.localScale = new Vector3((4.88f - (100 - GameObject.Find("bear03").GetComponent<bear>().health) / 18f), transform.localScale.y, transform.localScale.z);
        }


    }
}
