using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    private Vector3 offsetProjectile = new Vector3(3, 0, 0);

    public GameObject projectilePrefab;

        void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var projectile = GameObject.Instantiate(
                projectilePrefab,
                transform.position + offsetProjectile,
                projectilePrefab.transform.rotation);
        }
    }
}
