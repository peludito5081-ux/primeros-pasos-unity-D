
using UnityEngine;

public class TampaMortal : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.CompareTag("player")) ;
        {

            Destroy(collision.gameObject);
        }



    }







}
