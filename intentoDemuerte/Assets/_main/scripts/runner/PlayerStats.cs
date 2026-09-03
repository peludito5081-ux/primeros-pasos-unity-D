
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int _puntosVida = 100;

    public void SumarVida(int vida)
    {
        _puntosVida = _puntosVida + vida;

    }

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida + daño;

    }
}

