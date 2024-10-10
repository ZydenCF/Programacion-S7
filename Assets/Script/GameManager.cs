using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager GetInstance()
    {
        if (instance == null)
        {
            instance = new GameManager();
        }
        return instance;
    }
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);  
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private int comida;
    private int dinero;

    public void ActualizarRecursos(int comidaProducida, int dineroProducido)
    {
        comida += comidaProducida;
        dinero += dineroProducido;
        NotifyRecursos();
    }

    public int GetComida() { return comida; }
    public int GetDinero() { return dinero; }

    private void NotifyRecursos()
    {
        foreach (var observer in observers)
        {
            observer.Execute(this);
        }
    }

    private List<IObserver> observers = new List<IObserver>();

    public void Attach(IObserver observer) { observers.Add(observer); }
    public void Detach(IObserver observer) { observers.Remove(observer); }
}
