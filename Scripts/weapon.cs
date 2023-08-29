using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class weapon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private CharacterInputs controls;

    // This sets up out controls as per usual V
    void Awake()
    {
        controls = new CharacterInputs();
    }

    void OnEnable()
    {
        controls.Enable();
    }
    void OnDisable()
    {
        controls.Disable();
    }

    // Update is called once per frame
    void Update()
    {
       if (controls.Player.Shoot.triggered)
        {
            Shoot();
        }
    }


    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}

