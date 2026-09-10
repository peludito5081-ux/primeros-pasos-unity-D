

using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    [SerializeField] private Image _barra;
    [SerializeField] int _puntosVida;
    [SerializeField] private PlayerStats playerStats;
    [SerializeField] private UIManager _uiManager;
    public void SumarFillAmount(float amount)
    {
        _barra.fillAmount += amount;
    }

    public void RestarFillAmount(float amount)
    {
        _barra.fillAmount = _barra.fillAmount - amount;
        
    }
    public void ColorBarra(Color color)
    {
        if (_puntosVida >= 0.8)
        {
            _uiManager.ColorBarra(Color.green);
        }

        if ((_puntosVida <= 0.4) && (_puntosVida >= 0.8))
        {
            _uiManager.ColorBarra(Color.yellow);
        }
;
        if (_puntosVida >= 0.4)
        {
            _uiManager.ColorBarra(Color.red);
        }
;
    }


}
