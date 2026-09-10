
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] int _puntosVida = 100;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private PlayerStats playerStats;
    public void SumarVida(int vida)
    {
        _puntosVida = _puntosVida + vida;

    }

    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;

    }

    public void Update()
    {
        if (_puntosVida >= 80) 
        {
            _uiManager.ColorBarra(Color.green);
        }

        if ((_puntosVida <= 40 )&&(_puntosVida>= 80)) 
        {
            _uiManager.ColorBarra(Color.yellow);
        }
;
        if (_puntosVida >= 40) 
        {
            _uiManager.ColorBarra(Color.red);
        }
;
    }

}

