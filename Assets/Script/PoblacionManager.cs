using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoblacionManager : MonoBehaviour, IObserver
{
    public void Execute(GameManager subject)
    {
        int comidaDisponible = subject.GetComida();
        int nuevaPoblacion = Mathf.Max(1, comidaDisponible / 2);  
        UIManager.Instance.ActualizarPoblacion(nuevaPoblacion);
    }

    void Start()
    {
        GameManager.GetInstance().Attach(this);
    }
}
