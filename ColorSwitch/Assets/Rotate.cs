using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float rotateAmount;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0, 0, transform.position.z * rotateAmount);
        transform.RotateAround(transform.position, Vector3.forward, rotateAmount * Time.deltaTime);
    }
}
