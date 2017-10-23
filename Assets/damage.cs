using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damage : MonoBehaviour {

  //  int vis;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //vis = Random.Range(0, 2);
        Damage();
       // print(vis);
	}

    void Damage() {
        if (gameObject.GetComponent<SpriteRenderer>().enabled == true)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            return;
        }

        if (gameObject.GetComponent<SpriteRenderer>().enabled == false)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
            return;
        }
    }
}
