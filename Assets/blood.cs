using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blood : MonoBehaviour {

    public int life;

    // Use this for initialization
    void Start () {
        life = 100;
        float scl = Random.Range(0.06f, 0.8f);
        transform.localScale = new Vector3(scl, scl, 1);

    }
	
	// Update is called once per frame

	void Update () {

        

        life -= 1;
        if (life == 0)
        {
            Destroy(this.gameObject);
        }
    }

}


