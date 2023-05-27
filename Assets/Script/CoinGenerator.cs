using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public GameObject coinobj;
    public Transform CoinGenPoint;
    float distance;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Random.Range(1,4);           //give any random value from 1 to 4 ---> Inbuilt function
        if(transform.position.x < CoinGenPoint.transform.position.x)
        {
            transform.position = new Vector3(transform.position.x + Random.Range(2,4), distance,transform.position.z);       //We add only in x coordinate and y coordinate as we have to RANDOMLY generate coins till the journey ends
            Instantiate(coinobj,transform.position,transform.rotation);         //Used to have duplicacy of coins throughout the path.
        }
    }
}
