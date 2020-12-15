using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPowerUp : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Block")
        {
            Destroy(gameObject);

        }
        if (collision.tag == "Player")
        {
            Destroy(gameObject);

        }

    }
}
