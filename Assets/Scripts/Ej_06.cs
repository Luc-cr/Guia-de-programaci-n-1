using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*6. Realizá un programa que permita el ingreso por Inspector de un valor entero mayor que 0 en una variable llamada num1 y muestre 
 * un mensaje por pantalla indicando "el  número es par" o "el número es impar". 
 * Deberá utilizar el operador “módulo” es el caracter  %.*/

public class Ej_06 : MonoBehaviour
{
    public int num1; 
   
    string checker(int num1)
    {
        bool esPar = num1 % 2 == 0;

        if (esPar)
        {
            return "El numero es par";
        }
        else
        {
            return "El numero es impar";
        }
    }

    void Start()
    {
        if (num1 <= 0)
        {
            Debug.Log("No se pueden ingresar numeros menores a o iguales 0");
        }
        else
        {
            Debug.Log(checker(num1));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
