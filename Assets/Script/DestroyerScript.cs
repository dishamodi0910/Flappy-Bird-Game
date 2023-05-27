using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyerScript : MonoBehaviour
{
    GameObject Destroyerobject;
    // Start is called before the first frame update
    void Start()
    {
        Destroyerobject = GameObject.Find("Destroyer");           //    To find the object that is to be destroyed
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x<Destroyerobject.transform.position.x)
        {
            Destroy(gameObject);            //Inbuilt function coming up with the parent that is MonoBehaviour
        }
    }
}
