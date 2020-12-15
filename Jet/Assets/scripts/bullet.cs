using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 10000f;

    private Rigidbody2D rb;

    private Vector2 screenBounds;

    public GameObject boom;
    //public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 13)
        {
            Destroy(this.gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Block")
        {
            //GameObject e = Instantiate(Explosion) as GameObject;
            //e.transform.position = transform.position;
            Destroy(collision.gameObject);
            Destroy(gameObject);
            Instantiate(boom, transform.position, Quaternion.identity);

        }
    }
}

