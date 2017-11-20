using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crabscript : MonoBehaviour
{


    public Transform attack;
    public Animator A;
    public states state;
    int hold;
    public int health;
    public Transform blood;

    // Use this for initialization
    void Start()
    {
        hold = 0;
        health = 800;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            Destroy(gameObject);
        }

        if (hold == 0)
        {
            hold = 100;
        }
        if (hold > 0)
        {
            hold -= 1;
            print(hold);
        }

        if (state == states.none)
        {
            SetState(states.crab);

        }

        if (state == states.crab && hold % 10 == 0)
        {
            Instantiate(attack, transform.position, Quaternion.identity);
        }

        if (state == states.crab && hold == 1)
        {
            SetState(states.trans);


        }

        // SetState(states.trans);


        if (state == states.trans)
        {
            transform.position = new Vector3(Random.Range(-71.8f, -62.3f), Random.Range(5.5f, 46.8f), -1.24f);
            SetState(states.crab);
        }


    }


    public enum states
    {
        none,
        crab,
        trans

    }

    public void SetState(states S)
    {

        state = S;
        switch (state)
        {
            case states.crab:
                A.SetTrigger("crab01");
                return;
            case states.trans:
                A.SetTrigger("switch");
                return;
        }

    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.name == "shuriken01(Clone)")
        {

            health -= 5;


            Instantiate(blood, new Vector3(transform.position.x + .01f, transform.position.y, 0), Quaternion.identity);

        }
    }
}
