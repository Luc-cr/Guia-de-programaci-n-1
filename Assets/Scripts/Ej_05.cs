using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*5. Realizá un programa que, dados dos números enteros num1 y num2 cargados desde  
 * el Inspector muestre el resultado de la división del primero por el segundo en la consola siguiendo el formato num1 + “ / “ + num2 + “ = “ + resultado.  
 * En el caso de que el segundo valor num2 sea cero, mostrar el siguiente mensaje de error:  “No se puede dividir por cero”. */


public class Ej_05 : MonoBehaviour
{

    public Text texto;
    public int dividendo;
    public int divisor;
    private float resultado;
    void Start()
    {
        if(divisor == 0)
        {
            Debug.LogError("El divisor no puede ser 0");
            texto.text = "El divisor no puede ser 0";
        }
        else
        {
            resultado = dividendo / divisor;
            texto.text = $"{dividendo} dividido {divisor} es {resultado}";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
