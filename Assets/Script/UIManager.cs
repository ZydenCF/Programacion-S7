using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public TextMeshProUGUI comidaText; 
    public TextMeshProUGUI dineroText;
    public TextMeshProUGUI poblacionText;

    void Awake()
    {
        if (Instance == null) Instance = this;
        else Destroy(gameObject);
    }

    public void ActualizarRecursos(int comida, int dinero)
    {
        Debug.Log($"Actualizando recursos: Comida: {comida}, Dinero: {dinero}");
        comidaText.text = "Comida: " + comida;
        dineroText.text = "Dinero: " + dinero;
    }

    public void ActualizarPoblacion(int poblacion)
    {
        poblacionText.text = "Población: " + poblacion;
    }
}
