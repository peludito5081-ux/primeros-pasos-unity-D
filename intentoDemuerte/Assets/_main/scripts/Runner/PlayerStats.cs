using UnityEngine;


public class PlayerStats : MonoBehaviour
{
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
}
