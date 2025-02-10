using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticEnemyController : CreatureController
{
    [SerializeField] EnemyFOV fov;
    
    private void FixedUpdate()
    {
        if (fov.Target != null)
           transform.position =  Vector2.MoveTowards(transform.position, fov.Target.position, speed*Time.deltaTime);
    }

  /*  private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.TryGetComponent<HealthComponent>(out HealthComponent health))
        {
            health.TakeDamage(1);
            Destroy(gameObject);
        }
    }*/
}
