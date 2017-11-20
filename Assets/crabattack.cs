using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabattack : MonoBehaviour {
    int life;

	// Use this for initialization
	void Start () {
        life = 100;
	}
	
	// Update is called once per frame
	void Update () {
        life -= 1;
        transform.position += new Vector3(.4f, 0, 0);
        //transform.position += Vector3.Lerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, Random.Range(.01f, .03f));
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        if (life == 0)
        {
            Destroy(this.gameObject);
        }
	}
}
