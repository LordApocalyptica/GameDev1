using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_CarBrain : MonoBehaviour
{
    public float speedModifier = 30.0f;
    void Start()
    {
        
    }

    
    void Update()
    {
        speedModifier -= Time.deltaTime;
        if (speedModifier < 1.0)
        {
            speedModifier = 1.0f;
        }
        transform.Translate(Vector3.forward * Time.deltaTime * speedModifier);
    }
    void OnTriggerEnter(Collider other)
    {
        speedModifier = speedModifier + 10;
    }

}
 