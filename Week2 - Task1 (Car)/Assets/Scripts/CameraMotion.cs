using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotion : MonoBehaviour
{
    public GameObject Car;
    public Vector3 offset = new Vector3(0,10,-6);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Car.transform.position + offset;
        
    }
}
