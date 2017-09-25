using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bearbomb : MonoBehaviour {

    public int life;

    float rot;

    // Use this for initialization
    void Start () {
        life = 60;
        transform.rotation = Quaternion.Euler(0, 0, Random.Range(0, 360));
    }
	
	// Update is called once per frame
	void Update () {
      //  rot += 5;
       // transform.position = Vector3.Slerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, .01f);
         transform.position+=new Vector3(Random.Range(-10f,10), Random.Range(-10f, 10), 0);
       // transform.rotation *= Quaternion.Euler(0, 0, rot);

        life -= 1;
        if (life == 0)
        {
            Destroy(this.gameObject);
        }
    }

   

}
