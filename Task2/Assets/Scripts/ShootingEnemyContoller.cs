using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class ShootingEnemyContoller : CreatureController
{
    [SerializeField] EnemyFOV fov;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform fierPoint;
    Vector2 lookDir;
    float lookAngle;
    [SerializeField]float delay;
    float timeToShoot;

    private void Start()
    {
        timeToShoot = delay;
    }

    private void Update()
    {
        if (fov.Target != null)
        {
            timeToShoot -= Time.deltaTime;
            lookDir = fov.Target.transform.position.normalized;
            //lookAngle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;
            lookAngle = Mathf.Clamp(Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg, -90, 90);
            fierPoint.rotation = Quaternion.Euler(0, 0, lookAngle);
            if (timeToShoot <=0)
            {
                GameObject go = Instantiate(bullet, fierPoint.position, Quaternion.Euler(0, 0, lookAngle));
                go.GetComponent<Bullet>().SetDir(fierPoint.right);
                timeToShoot = delay;
            }
        }
    }


}
