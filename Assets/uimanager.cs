using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class uimanager : MonoBehaviour
{
    public TextMeshProUGUI txtSaludo;
    public TMP_InputField inputNombre;
    string nombreIngresado;
    string saludo;

    // Start is called before the first frame update
    void Start()
    {
        txtSaludo.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sludar()
    {
        // Obtener el nombre del inputfild

        nombreIngresado = inputNombre.text;

        // Concatenar el nombre con saludo

        saludo = "Hola " + nombreIngresado + "!";

        // Mostrar el saludo en txtSaludo
        txtSaludo.text = saludo;
    }
}
