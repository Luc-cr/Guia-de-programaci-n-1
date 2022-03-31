using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej_07 : MonoBehaviour
{
    public int numero;
    public int numero2;
    public int numero3;
    string signo;

    void Start()
    {
        if (numero > numero2 && numero > numero3) { signo = "Numero 1"; }
        else if (numero2 > numero && numero2 > numero3) { signo = "Numero 2"; }
        else if (numero3 > numero2 && numero3 > numero) { signo = "Numero 3"; }
        else
        {
            signo = "todos iguales";
        }

        Debug.Log("El mayor numero es:" + signo);

    }

    // Update is called once per frame
    void Update()
    {

    }
}
