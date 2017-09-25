using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shark : MonoBehaviour {

    public states state;
    public bool moving;
    public int health;
    float recharge;
    public bool attackingPlayer;
    public Animator A;
    public Transform blood;

	// Use this for initialization
	void Start () {
        health = 100;
        //SetState(states.shark02anim);
	}
	
	// Update is called once per frame
	void Update () {
       // Debug.Log(moving);
        if (moving == true)
        {
            transform.position = Vector3.Slerp(transform.position, GameObject.Find("Player").GetComponent<Transform>().position, .01f);
        }

        if (health <= 0)
        {
            Destroy(gameObject);
        }
        if (moving == false)
        {
          //  Debug.Log(recharge);
            recharge -= Time.deltaTime*200;
            if (recharge <= 0)
            {
                moving = true;
            }
        }

       // Debug.Log(Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position));

        if (Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position) < 4)
        {
            SetState(states.shark01);
        }

        if (Vector3.Distance(transform.position, GameObject.Find("Player").GetComponent<Transform>().position) > 4)
        {
            SetState(states.shark02anim);
        }

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "Bubble(Clone)")
        {
            moving = false;
            health -= 5;
            recharge = 100;
            transform.position+=new Vector3(-.1f,-.1f,0);
            Instantiate(blood,new Vector3(transform.position.x + .1f, transform.position.y, 0), Quaternion.identity);
            transform.position -= new Vector3(Random.Range(-.1f, .1f), Random.Range(-.1f, .1f), 0);
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
