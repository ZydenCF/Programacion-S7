using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fabrica : Edificio
{
    protected override void Producir()
    {
        int dineroProducido = 20;
        GameManager.GetInstance().ActualizarRecursos(0, dineroProducido);
    }
}
