using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearbomb : MonoBehaviour {

    public int life;

    // Use this for initialization
    void Start () {
        life = 100;
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Slerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, .01f);
        transform.position+=new Vector3(Random.Range(.1f,4),Mathf.Cos(Time.deltaTime),0);

        life -= 1;
        if (life == 0)
        {
            Destroy(this.gameObject);
        }
    }

   

}
