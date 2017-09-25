using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{


    public Transform bubble;
    public int health;

    // Use this for initialization
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += new Vector3(0, .1f, 0);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -.1f, 0);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-.1f, 0, 0);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(.1f, 0, 0);
        }

        //move


        //

        if (Input.GetKeyDown(KeyCode.W))
        {
            Instantiate(bubble, new Vector3(transform.position.x, transform.position.y + .2f, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(bubble, new Vector3(transform.position.x, transform.position.y + -.1f, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(bubble, new Vector3(transform.position.x - .1f, transform.position.y, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(bubble, new Vector3(transform.position.x + .1f, transform.position.y, 0), Quaternion.identity);
        }




        //attacks





    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "shark01")
        {
            if (GameObject.Find("shark01").GetComponent<shark>().moving == true)
            {
                health -= 10;
                transform.position -= new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
            }

        }
        if (coll.gameObject.name == "bear03")
        {
            health -= 1;
            transform.position -= new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        }
        if (coll.gameObject.name == "bearattack01(clone)")
        {
            health -= 5;
            transform.position -= new Vector3(Random.Range(-6f, 6f), Random.Range(-6f, 6f), 0);
        }

    }
}

