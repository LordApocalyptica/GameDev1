using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_PlayerController : MonoBehaviour
{
    public GameObject playerCar;
    private SC_CarBrain carBrainScript;
    void Start()
    {
        carBrainScript = playerCar.GetComponent<SC_CarBrain>(); // fetch for "handling" of the car when controlling
    }

   
    void Update()
    {
        if (carBrainScript.speedModifier < 2)
        {
            carBrainScript.speedModifier = 2; //Prevent the handling from becoming ridiculously poor
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * (carBrainScript.speedModifier/2));
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * (carBrainScript.speedModifier/2));
        }
    }
}
