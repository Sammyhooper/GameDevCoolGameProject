using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark : MonoBehaviour {

    public states state;
  //  public bool moving;
    public int health;
    float recharge;
    public bool attackingPlayer;
    public Animator A;
    public Transform blood;
    public Transform water;
    public Transform explosion;
    public Transform firebreath;

    // Use this for initialization
    void Start () {
     
        //SetState(states.shark02anim);
	}
	
	// Update is called once per frame
	void Update () {
        // Debug.Log(moving);
        if (transform.position.x > 15)
        {
            transform.position = new Vector3(Random.Range(5,15), Random.Range(0, 10), transform.position.z);
        }
        if (transform.position.x < -15)
        {
            transform.position = new Vector3(Random.Range(-15,-5), Random.Range(0, 10), transform.position.z);
        }
        if (transform.position.y > 10)
        {
            transform.position = new Vector3(Random.Range(0, 10), Random.Range(0,10), transform.position.z);
        }
        if (transform.position.y < -10)
        {
            transform.position = new Vector3(Random.Range(0, -10), Random.Range(0,-10), transform.position.z);
        }

        transform.position += new Vector3(Mathf.Sin(Time.deltaTime)*8,0,0);

        Instantiate(water, new Vector3(transform.position.x, transform.position.y, 0), Quaternion.identity);
    //    if (moving == true)
   //     {
         transform.position = Vector3.Slerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, .1f);
       //     transform.position = new Vector3(transform.position.x, transform.position.y, 0);
   //     }

        if (health <= 0)
        {
            Destroy(gameObject);
            Instantiate(explosion, transform.position, Quaternion.identity); 
        }




            
        
     //   Debug.Log("recharge:" + recharge);
       // Debug.Log(moving);
        // Debug.Log(Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position));

        if (Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position) < .2f)
        {
            SetState(states.shark01);

        }
        if (Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position) < 1f)
        {
            transform.position -= Vector3.Slerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, Random.Range(.01f, .07f));
            print("touching");
        }


        if (Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position) > .2f)
        {
            SetState(states.shark02anim);
        }

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "shuriken01(Clone)")
        {
           // moving = false;
            health -= 5;
            recharge = Random.Range(10,50);
           // transform.position+=new Vector3(-.1f,-.1f,0);
            Instantiate(blood,new Vector3(transform.position.x + .01f, transform.position.y, 0), Quaternion.identity);
         
          //  transform.position -= new Vector3(Random.Range(-.1f, .1f), Random.Range(-.1f, .1f), 0);
        }



    }

    public enum states
    {
        none,
        shark01,
        shark02anim
    }

    public void SetState(states S)
    {
     
        state = S;
        switch (state)
        {
            case states.shark01:
                A.SetTrigger("Shark01");
                break;
            case states.shark02anim:
                A.SetTrigger("shark02anim");
                break;
        }
    }

}
