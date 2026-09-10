using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    [SerializeField] private UIManager _uiManager;
    [SerializeField] private float _puntosVida = 100.0f;
    // Start is called before the first frame update
    public void RestarVida(int daño)
    {
        _puntosVida = _puntosVida - daño;
    }
    public void SumarVida(int daño)
    {
        _puntosVida = _puntosVida + daño;
    }
    private void Update()
    {
        if (_puntosVida >= 80)
        {
           _uiManager.ColorBarra(Color.green);
        }
        if ((40 <= _puntosVida) && (40 < 80))
        {
            _uiManager.ColorBarra(Color.yellow);
        }
        if (_puntosVida < 40)
        {
            _uiManager.ColorBarra(Color.red);
        }
    }
}
