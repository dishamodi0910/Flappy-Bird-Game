using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D myRigidbody;

    public float speed;
    public float jumpspeed;
    int coinCounter;

    [SerializeField]
    public  UnityEngine.UI.Text cointext;
    // Start is called before the first frame update
    void Start()
    {
        //myRigidbody = GetComponent<Rigidbody2D>();
        //cointext = GetComponent<Text>().(UnityEngine.UI.Text);
    }

    // Update is called once per frame
    void Update()
    {
        myRigidbody.velocity = new Vector2(speed,myRigidbody.velocity.y);
        if(Input.anyKeyDown)
        {
            myRigidbody.velocity = new Vector2(myRigidbody.velocity.x,jumpspeed);        //changing the y velocity to bounce speed
        }        
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Obstacle")   //as soon as the obstacle TAGGED object is spotted game will end and the home page will be loaded.
        SceneManager.LoadScene(0);
        //UIManager.inst.GameOver();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Coin")
        {
            coinCounter++;  // Update the score
            this.cointext.text = coinCounter.ToString();
            Destroy(collision.gameObject);        //destroy the coins after it is collected.
            
        }
    }
}
