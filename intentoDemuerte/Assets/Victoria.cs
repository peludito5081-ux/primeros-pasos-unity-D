using UnityEngine;

public class Victoria : MonoBehaviour
{
    public GameObject panelVictoria;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            panelVictoria.SetActive(true);

        }

        if (collision.CompareTag("Player"))
        {
            Time.timeScale = 0;

        }

    }
}
