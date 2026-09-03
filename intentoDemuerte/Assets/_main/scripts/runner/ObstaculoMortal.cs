using UnityEngine;

public class ObstaculoMortal : MonoBehaviour
{
    [SerializeField] private PlayerStats _playerStats;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "player");
        {
            _playerStats.RestarVida(10);
        }
    }
}

