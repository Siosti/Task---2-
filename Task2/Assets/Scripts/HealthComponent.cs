using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthComponent : MonoBehaviour
{
    [SerializeField] float hp;
    [SerializeField] TextMeshProUGUI hpText;
    private void Awake()
    {
        SetHPText(hp);
    }
    public void TakeDamage(float dmg)
    {
        hp -= dmg;
        SetHPText(hp);
        if (hp <= 0)Death();
    }
    private void SetHPText(float hp)
    {
        if(hpText!=null)
        hpText.text = $"{hp}";
    }

    public void Death()
    {
        Destroy(gameObject);
    }
}
