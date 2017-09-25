using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bear : MonoBehaviour {

    //bool hit;
    public Transform bearbomb;
    float rot;
    bool fwd;
    bool bwd;
    bool moving;
    bool attacking;

    public float health;
    float modeswitch;
    public Transform blood;

	// Use this for initialization
	void Start () {
        //moving = true;
        health = 300;
	}

    // Update is called once per frame
    void Update() {
        if (GameObject.Find("shark01") == null)
        {
            awake();
        }

    }

    void awake(){

            if (transform.position.y <= 30)
            {
                transform.position = new Vector3(transform.position.x, 30, transform.position.z);
            }
            if (transform.position.y >= 42)
            {
                transform.position = new Vector3(transform.position.x, 42, transform.position.z);
            }
            if (transform.position.x <= -22)
            {
                transform.position = new Vector3(-22f, transform.position.y, transform.position.z);
            }
            if (transform.position.x >= 10)
            {
                transform.position = new Vector3(10, transform.position.y, transform.position.z);
            }


            if (health <= 0)
            {
                Destroy(gameObject);
            }


            if (moving == false && attacking == false)
            {
                moving = true;
                modeswitch = 100;
            }

            //  Debug.Log("mode"+ modeswitch);

            if (modeswitch == 1)
            {
                if (moving == true)
                {
                    moving = false;
                    attacking = true;
                    modeswitch = 100;
                    return;
                }
                if (attacking == true)
                {
                    moving = true;
                    attacking = false;
                    modeswitch = 100;
                    return;
                }
            }


            rot += 5;
        

       // transform.position += new Vector3(Mathf.Sin(transform.position.x)*2, 0, 0);

        if (moving == true)
        {
            if (transform.position.x <=-15)
            {
                fwd = true;
                bwd = false;
            }
             if (transform.position.x >= 4)
            {
                bwd = true;
                fwd = false;
            }


            if (fwd == true)
            {
                transform.position += new Vector3(.1f, 0, 0);
            }
            if (bwd==true)
            {
                transform.position -= new Vector3(.1f, 0, 0);
            }
            if (fwd == false && bwd == false)
            {
                fwd = true;
            }


            modeswitch -= .5f;
            
        }

        if (attacking == true)
        {
            modeswitch -= .5f;
            if (rot % 20 == 0)
            {


                Instantiate(bearbomb, new Vector3(transform.position.x + Random.Range(-1,1), transform.position.y, 0), Quaternion.identity);

            }
        }

        
    }


    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Bubble(Clone)")
        {
            moving = false;
            health -= 5;
            transform.position += new Vector3(-.1f, -.1f, 0);
            Instantiate(blood, new Vector3(transform.position.x + .1f, transform.position.y, 0), Quaternion.identity);
        }

       // Physics2D.IgnoreCollision(GameObject.Find("bearattack01(Clone)").GetComponent<Collider2D>(), gameObject.GetComponent<Collider2D>());

    }
}
