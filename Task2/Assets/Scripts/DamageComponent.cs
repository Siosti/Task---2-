using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageComponent : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision != null)
        {
            if(collision.TryGetComponent<HealthComponent>(out HealthComponent health))
            {
                health.TakeDamage(damage);
                if(!gameObject.CompareTag("Enemy"))
                Destroy(gameObject);
            }
        }
    }
}
