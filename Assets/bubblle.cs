using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubblle : MonoBehaviour {

    public int life;

	// Use this for initialization
	void Start () {
       // life = 100;
	}
	
	// Update is called once per frame
	void Update () {
        life -= 1;
        if (life == 0)
        {
            Destroy(this.gameObject);
        }
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
