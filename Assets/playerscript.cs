using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{


    public Transform bubble;
    public int health;
    public Transform sheild;

    int hit;


    // Use this for initialization
    void Start()
    {
        health = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if (hit > 0)
        {
            Damage();
            hit -= 1;
        }

        if (hit == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
      //  Debug.Log(hit);


       


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
            Instantiate(bubble, new Vector3(transform.position.x, transform.position.y + Random.Range(1,4), 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            Instantiate(bubble, new Vector3(transform.position.x, transform.position.y -Random.Range(1, 4), 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(bubble, new Vector3(transform.position.x - Random.Range(1, 4), transform.position.y, 0), Quaternion.identity);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            Instantiate(bubble, new Vector3(transform.position.x + Random.Range(1, 4), transform.position.y, 0), Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            Instantiate(sheild, new Vector3(transform.position.x , transform.position.y, 0), Quaternion.identity);
        }

        //Physics2D.IgnoreCollision(this.sheild.GetComponent<Collider2D>(), GetComponent<Collider2D>());





        //attacks



    }


    void Damage()
    {

            if (gameObject.GetComponent<SpriteRenderer>().enabled == true)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = false;
                return;
            }

            if (gameObject.GetComponent<SpriteRenderer>().enabled == false)
            {
                gameObject.GetComponent<SpriteRenderer>().enabled = true;
                return;
        }

        //print("damaging");
       // hit -= 1;
    }




    private void OnCollisionEnter2D(Collision2D coll)
    {


        if (coll.gameObject.name == "shark01")
        {
            if (GameObject.Find("shark01").GetComponent<shark>().moving == true)
            {
                health -= 10;
                transform.position -= new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
                hit = 100;


            }
        }
        if (coll.gameObject.name == "bear03")
            {
                health -= 1;
                transform.position -= new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
                hit = 100;
            }
       if (coll.gameObject.name == "bearattack01(clone)")
            {
                health -= 5;
                transform.position -= new Vector3(Random.Range(-6f, 6f), Random.Range(-6f, 6f), 0);
                hit = 100;
            }

        }


    }


