using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : CreatureController
{
    private Vector2 MoveDir;
    [SerializeField] Transform fierPoint;
    Vector2 lookDir;
    float lookAngle;
    [SerializeField] GameObject bullet;
    private void Update()
    {
        Move();
        lookDir = Camera.main.WorldToScreenPoint(Input.mousePosition);
        lookAngle = Mathf.Atan2(lookDir.y, lookDir.x)*Mathf.Rad2Deg;
        fierPoint.rotation = Quaternion.Euler(0, 0, lookAngle);
        if (Input.GetKeyUp(KeyCode.Space))
        {
            GameObject go = Instantiate(bullet, fierPoint.position,Quaternion.Euler(0, 0, lookAngle));
            go.GetComponent<Bullet>().SetDir(fierPoint.right);
        }
      
    }

    private void Move()
    {

        if (Input.GetKey(KeyCode.A))
        {
            MoveDir = new Vector2(-1, 0);
            transform.localScale = new Vector2(-1, 1);
            fierPoint.localScale = new Vector2(-1, 1);
            fierPoint.GetComponent<SpriteRenderer>().flipY = true;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            MoveDir =  new Vector2(0,-1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MoveDir = new Vector2(1, 0);
            transform.localScale = new Vector2(1, 1);
            fierPoint.localScale = new Vector2(1, 1);
            fierPoint.GetComponent<SpriteRenderer>().flipY = false;
        }
        else if (Input.GetKey(KeyCode.W))
        {
            MoveDir = new Vector2(0, 1);
        }
        else  MoveDir = Vector2.zero;

        rb.velocity = MoveDir * speed *Time.deltaTime;
    }
}
