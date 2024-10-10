using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Edificio : MonoBehaviour
{
    public delegate void ProduccionRecurso(int cantidad);
    public event ProduccionRecurso OnRecursoProducido;

    protected abstract void Producir();

    protected void NotificarProduccion(int cantidad)
    {
        if (OnRecursoProducido != null)
        {
            OnRecursoProducido.Invoke(cantidad);
        }
    }
}

