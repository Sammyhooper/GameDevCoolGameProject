using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level01 : MonoBehaviour {
    bool moving;
    bool check;

	// Use this for initialization
	void Start () {
        check = false;
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.Find("shark01")==null){
            check = true;
            moving = true;
        }

        if (moving == true&&check==true)
        {
            move();
        }
	}


    void move()
    {
        transform.position += new Vector3(.1f, 0, 0);
        if (transform.position.x >= 5)
        {
            transform.position = new Vector3(5, -30.39f, 0);
            check = false;
        }
    }
}
