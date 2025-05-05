using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClaveManager : MonoBehaviour
{
    public TextMeshProUGUI txtResultado;
    public TMP_InputField inputClave;
    string claveIngresada;
    string clave;

    // Start is called before the first frame update
    void Start()
    {
        txtResultado.text = "";
        clave = "amorypaz";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Clave()
    {
        // Obtener lo ingresado del inputfild

        claveIngresada = inputClave.text;

        // Chequear la clave

        if (claveIngresada == clave)
        {
            txtResultado.text = "La clave ingresada es correcta";
        }
        else
        {
            txtResultado.text = "La clave ingresada es incorrecta";
        }

        // Mostrar el estado de la clave
    }
}
