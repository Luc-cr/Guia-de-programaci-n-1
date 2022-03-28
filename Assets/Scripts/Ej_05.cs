using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
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
