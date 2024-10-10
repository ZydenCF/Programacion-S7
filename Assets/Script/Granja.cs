using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Granja : Edificio
{
    protected override void Producir()
    {
        int comidaProducida = 10;
        GameManager.GetInstance().ActualizarRecursos(comidaProducida, 0);
        Debug.Log("Producida comida: " + comidaProducida); 
    }
}
