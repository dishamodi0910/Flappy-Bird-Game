using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    public GameObject Platform;
    public Transform PlateformGenPoint;
    private float width;
    // Start is called before the first frame update
    void Start()
    {
        width=Platform.GetComponent<BoxCollider2D>().size.x;        //Get component from the editor.
       // Debug.Log("Width is "+width);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < PlateformGenPoint.position.x)                //like this pointer 
        {
            transform.position = new Vector3 (transform.position.x+width,transform.position.y,transform.position.z);
            Instantiate(Platform,transform.position,transform.rotation);  //Duplication of the ground and the sky sprite.
        }
    }
}
