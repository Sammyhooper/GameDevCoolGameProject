using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurkiken : MonoBehaviour {

    public int life;
    float distX;
    float distY; 

    // Use this for initialization
    void Start()
    {
      //  life = 100;
    }

    // Update is called once per frame
    void Update()
    {


        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    distY += .0001f;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    distY -= .0001f;
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    distX -= .0001f;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    distX += .0001f;
        //}

      //  transform.position += new Vector3(transform.position.x + distX, transform.position.y + distY, transform.position.z);
        life -= 1;
        if (life == 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
       // Destroy(this.gameObject);
    }
}
