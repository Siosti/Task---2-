using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        StartCoroutine(this.Destroy());
    }

    public void SetDir(Vector2 dir)
    {
        rb.velocity = dir*speed*Time.deltaTime;
    }

   IEnumerator Destroy()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }
}
