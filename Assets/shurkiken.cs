using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shurkiken : MonoBehaviour {

    public int life;
    Vector3 direct;

    // Use this for initialization
    void Start()
    {
        //  life = 100;
        direct = GameObject.Find("Player").GetComponent<playerscript>().shurikenVect;
        
    }

    // Update is called once per frame
    void Update()
    {


        //if (Input.GetKeyDown(KeyCode.W))
        //{
        //    distY += (.000001f / Time.deltaTime);
        //    transform.position += new Vector3(transform.position.x + distX, transform.position.y + distY, transform.position.z);
        //   // return;
        //}
        //if (Input.GetKeyDown(KeyCode.S))
        //{
        //    distY -= (.000001f / Time.deltaTime);
        //    transform.position += new Vector3(transform.position.x + distX, transform.position.y + distY, transform.position.z);
        //   // return;
        //}
        //if (Input.GetKeyDown(KeyCode.A))
        //{
        //    distX -= (.000001f / Time.deltaTime);
        //    transform.position += new Vector3(transform.position.x + distX, transform.position.y + distY, transform.position.z);
        //  //  return;
        //}
        //if (Input.GetKeyDown(KeyCode.D))
        //{
        //    distX += (.000001f/Time.deltaTime);
        //    transform.position += new Vector3(transform.position.x + distX, transform.position.y + distY, transform.position.z);
        //  //  return;
        //}


        

        this.transform.position += direct - new Vector3 (0,0,Time.deltaTime);


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
