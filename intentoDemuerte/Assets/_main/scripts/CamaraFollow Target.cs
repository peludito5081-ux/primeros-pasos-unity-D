
using Unity.VisualScripting;
using UnityEngine;

public class CamaraFollowTarget : MonoBehaviour
{

    [SerializeField] private Transform _targert;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(_targert.position.x, this.transform.position.y, this.transform.position.z);

    }
}
