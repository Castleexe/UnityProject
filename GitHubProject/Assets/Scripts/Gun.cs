using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Rigidbody2D rb;
    [SerializeField] GameObject player;
    [SerializeField] GameObject gun;

    Vector2 mousePos;
    SpriteRenderer gunsp;

    float angle;

    // Start is called before the first frame update
    void Start()
    {
        gunsp = gun.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        moveGun();
    }

    private void FixedUpdate()
    {
        Vector2 lookDir = new Vector2(mousePos.x, mousePos.y)- new Vector2(rb.position.x, rb.position.y);
        angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
        rb.rotation = angle;    
    }

    void moveGun()
    {
        
        mousePos = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = player.transform.position;

        if (angle > -90 && angle < 90)
        {
            gunsp.flipY = false;
        }
        else
        {
            gunsp.flipY = true;
        }
        
    }
}
