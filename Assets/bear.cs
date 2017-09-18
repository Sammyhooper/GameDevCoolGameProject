using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bear : MonoBehaviour {

    bool hit;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
         
        transform.position += new Vector3(Mathf.Sin(transform.position.x)*2, 0, 0);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // hit=
    }
}
