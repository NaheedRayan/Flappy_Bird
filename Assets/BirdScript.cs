using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStreangth = 20;

    public LogicScript logic;
    public bool birdIsAlive = true;


    public GameObject up_wing;
    public GameObject down_wing;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 14 || transform.position.y < -14)
        {
            logic.gameOver();
            birdIsAlive = false;
        }
        else if(Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            //flipWing();
            myRigidbody.velocity = Vector2.up * flapStreangth ;
        }


        //for flipping the wings
        down_wing.SetActive(true);
        up_wing.SetActive(false);

        if (myRigidbody.velocity.y < 0)
        {
            //print("falling");
            down_wing.SetActive(false);
            up_wing.SetActive(true);
        }


    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
