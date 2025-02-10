using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatureController : MonoBehaviour
{
    [SerializeField] protected float speed;
    protected Rigidbody2D rb;
   

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
}
