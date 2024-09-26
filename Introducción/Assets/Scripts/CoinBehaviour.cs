using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour
{
    // vector 3 es y x z
    public Vector3 speedRotation;

    void Update()
    {
        //Timedeltatime se usa para que la velocodad del objeto sea igual en cualquier ordenador
        transform.Rotate(speedRotation * Time.deltaTime, Space.World);
    }
}
