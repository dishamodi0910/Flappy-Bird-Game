using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform TargetPosition;
    public Vector3 offset;                //Vector3 is like a vector in 3D...We use this variable to make camera behind the bird
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = TargetPosition.position + offset;
        newPosition.y = 0;
        newPosition.z = -10;

        transform.position=newPosition;
    }
}
