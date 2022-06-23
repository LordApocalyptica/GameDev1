using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ObjectBrain : MonoBehaviour
{
    public float speedModifier = 1.0f;
    public float tilDeathChron = 30.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tilDeathChron -= Time.deltaTime;
        if (tilDeathChron <= 0)
        {
            Destroy(gameObject);
        }
    }
  
}
