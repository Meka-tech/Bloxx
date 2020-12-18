using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class movement : MonoBehaviour
{
    public float speed = 15f;
    private Rigidbody2D rb;
    public float mapWidth = 5f;
    public GameObject bulletPrefab;
    private float dirx;
    
    
    Collider2D playerCollider;
    SpriteRenderer playerC;
    

    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<Collider2D>();
        playerC = GetComponent<SpriteRenderer>();
        
    }
    private void FixedUpdate()
    {
        float x =CrossPlatformInputManager.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;

        Vector2 newPosition = rb.position + Vector2.right * x;

        newPosition.x = Mathf.Clamp(newPosition.x,- mapWidth, mapWidth);
        //clamp Position

        rb.MovePosition(newPosition);

        speed += Time.timeSinceLevelLoad / 100000f;
        //to increase speed

        dirx = CrossPlatformInputManager.GetAxis("Horizontal") * speed;

        if (Input.GetKeyDown("space"))
        {
            ShootBullet();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        FindObjectOfType<GameManager>().EndGame();
    }

    //powerUps
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //passes through Obstacles
        if (collision.tag == "Blue")
        {
            
           playerCollider.enabled = false;
            playerC.color = Color.blue;
            Invoke("Blue", 5);
           
        }
        //turns vertical
        if (collision.tag == "Yellow")
        {
            rb.transform.Rotate(Vector3.forward * 90);
            playerC.color = Color.yellow;
            Invoke("Yellow", 5);

        }
        //ShootsBullet
        if (collision.tag == "Green")
        {   
            ShootBullet();
            Invoke("ShootBullet", 1.5f);
            Invoke("ShootBullet", 2.5f);
            Invoke("ShootBullet", 3.5f);
            Invoke("ShootBullet", 4.5f);
            playerC.color = Color.green;

            Invoke("Green", 5);
        }
    }

    public void ShootBullet()
    {
        GameObject b = Instantiate(bulletPrefab) as GameObject;
        b.transform.position = rb.transform.position;
    }

    private void Blue()
    {
        playerCollider.enabled = true;
        playerC.color = Color.white;
    }
    private void Yellow()
    {
        rb.transform.Rotate(Vector3.forward * 90);
        playerC.color = Color.white;
    }
    private void Green()
    {
        playerC.color = Color.white;
    }
    public void revived()
    {
        playerCollider.enabled = false;
        playerC.color = Color.red;

        Invoke("isToRevive", 3);
       
    }

    public void isToRevive()
    {
        playerCollider.enabled = true;
        playerC.color = Color.white;
    }

}
