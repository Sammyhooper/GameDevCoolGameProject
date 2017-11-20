using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{

    public states state;
    public Animator A;
    public Transform bubble;
    public int health;
    public Transform sheild;
    public Vector3 shurikenVect;
    public float shurkvel;
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
            SetState(states.walkUp);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += new Vector3(0, -.1f, 0);
            SetState(states.idle);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += new Vector3(-.1f, 0, 0);
            SetState(states.walkLeft);

        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(.1f, 0, 0);
            SetState(states.moveRight);
        }

        //move


        //

        if (Input.GetKeyDown(KeyCode.W) && GameObject.Find("shurkin01(Clone)") == null)
        {
            Instantiate(bubble, new Vector3(transform.position.x, transform.position.y + Random.Range(1,4), 0), Quaternion.identity);
            shurikenVect = new Vector3(0,shurkvel,0);
            return;
        }
        if (Input.GetKeyDown(KeyCode.S) && GameObject.Find("shurkin01(Clone)") == null)
        {
            Instantiate(bubble, new Vector3(transform.position.x, transform.position.y -Random.Range(1, 4), 0), Quaternion.identity);
            shurikenVect = new Vector3(0, -shurkvel, 0);
            return;
        }
        if (Input.GetKeyDown(KeyCode.A) && GameObject.Find("shurkin01(Clone)") == null)
        {
            Instantiate(bubble, new Vector3(transform.position.x - Random.Range(1, 4), transform.position.y, 0), Quaternion.identity);
            shurikenVect = new Vector3(-shurkvel, 0, 0);
            return;
        }
        if (Input.GetKeyDown(KeyCode.D) && GameObject.Find("shurkin01(Clone)") == null)
        {
            Instantiate(bubble, new Vector3(transform.position.x + Random.Range(1, 4), transform.position.y, 0), Quaternion.identity);
            shurikenVect = new Vector3(shurkvel, 0, 0);
            return;
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
            
                health -= 10;
                transform.position -= new Vector3(Random.Range(-10f, 10f), Random.Range(-10f, 10f), 0);
                hit = 100;


            
        }

        if (coll.gameObject.name == "crabAttack(clone)")
        {
            health -= 5;
            hit = 100;
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


    public enum states
    {
        none,
        idle,
        moveRight,
        walkUp,
        walkLeft
    }

    public void SetState(states S)
    {

        state = S;
        switch (state)
        {
            case states.idle:
                A.SetTrigger("idle");
                return;
            case states.moveRight:
                A.SetTrigger("moveRight");
                return;
            case states.walkUp:
                A.SetTrigger("walkUp");
                return;
            case states.walkLeft:
                A.SetTrigger("walkLeft");
                return;
        }
    }


}


