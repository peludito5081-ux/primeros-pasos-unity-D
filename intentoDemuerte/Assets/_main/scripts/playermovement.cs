using UnityEngine;

public class playermovement : MonoBehaviour
{
    // Variables
  
    [SerializeField] private int _edad = 17;
    private float _velocidad = 15.5f;
    public string nombre = "Peludito";
    public bool isjumping = false;

    public float fuerza = 500f;

    [SerializeField] private Rigidbody2D _rigidbody2D;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D.AddForce(Vector2.right * fuerza);
       
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }
}
