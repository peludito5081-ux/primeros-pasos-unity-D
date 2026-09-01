using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    
    [SerializeField] private Image Barra;
    void Start()
    {
        Barra.color = Color.red;
        Barra.fillAmount = 0.5f;
    }

    void Update()
    {
        
    }
}
