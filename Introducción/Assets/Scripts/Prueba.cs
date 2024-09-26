using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba : MonoBehaviour
{
    //Variables
    //El tipo de dato ==> nombre
    int numeroSaltos = 0;

    public int primerLogroSaltos = 5;
    public int segundoLogroSaltos = 10;
    public int terceroLogroSaltos = 15;

    void Start()
    {
        
        //Debug.Log("Hola mundo");
    }

    // Update is called once per frame
    void Update()
    {
       //miVariable = miVariable + 1;
       //Debug.Log("Valor de mi variable" + miVariable);
    }

    private void OnCollisionEnter(Collision infoChoque)
    {
        numeroSaltos = numeroSaltos + 1;
        /* Debug.Log("He chocado con" + infoChoque.gameObject.name);
         Debug.Log("Veces que a colisionado" + miVariable + " " + gameObject.name);
        */

        if (numeroSaltos == primerLogroSaltos || numeroSaltos == segundoLogroSaltos || numeroSaltos == terceroLogroSaltos)
        {
            Debug.Log(gameObject.name + "ha chocado" + numeroSaltos + "veces");

        }

       /* if (numeroSaltos == segundoLogroSaltos) // ha chocado 10 veces
        {
            Debug.Log(gameObject.name + "ha chocado" + numeroSaltos + "veces");

        }

        if (numeroSaltos == terceroLogroSaltos) // ha chocado 15 veces
        {
            Debug.Log(gameObject.name + "ha chocado" + numeroSaltos + "veces");

        }

        if (numeroSaltos == primerLogroSaltos) // ha chocado 5 veces
        {
            Debug.Log(gameObject.name + "ha chocado" + numeroSaltos + "veces");

        }
       */
    }
}
