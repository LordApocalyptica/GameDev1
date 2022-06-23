using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_ObjectSpawner : MonoBehaviour
{
    public float elapsedChron = 0.0f; //Timer. Using "Chron" instead of "time" in variable names to avoid autofill annoyances
    public float spawnChron = 1.0f;
    public GameObject spawnObject;
    public float randOffset = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedChron += Time.deltaTime;
        Debug.Log(string.Format("elapsed Timer  = {0}", elapsedChron));
        if (elapsedChron >= spawnChron)
        {
            randOffset = Random.Range(-5, 5);

            elapsedChron = 0;
            Instantiate(spawnObject, new Vector3(transform.position.x + randOffset, 0, transform.position.z), Quaternion.identity);
           
        }
    }
}
