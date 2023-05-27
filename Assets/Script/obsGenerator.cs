using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsGenerator : MonoBehaviour
{

    public Transform GenPoint;
    public GameObject Obstacle;
    float difference;

    public float mindif,maxdif;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        difference = Random.Range(mindif,maxdif);
        if(transform.position.x < GenPoint.position.x)
        {
            transform.position = new Vector3(transform.position.x+difference,Random.Range(1,3),transform.position.z);      /*Use to generate obstacles throughout the journey. We add in x direction but not in y as in y we have to move forward but if we will add throughout in y then it will move upwards and won't be available linearly.  */
            Instantiate(Obstacle,transform.position,transform.rotation);        //Duplicacy of obstacle
        }
    }
}
