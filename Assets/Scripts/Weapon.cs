using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public float damage = 21;
    public float fireRate = 1;
    public float range = 15;
    public ParticleSystem muzzleFlash;
    public Transform bulletSpawn;
    public AudioClip shotSFX;
    public AudioSource _audioSource;

    public Camera _cam;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        _audioSource.PlayOneShot(shotSFX);
        // Instantiate(muzzleFlash, bulletSpawn.position, bulletSpawn.rotation);
        muzzleFlash.Play();
        
        RaycastHit hit;

        if (Physics.Raycast(_cam.transform.position, _cam.transform.forward, out hit, range))
        {
            Debug.Log("Hi: " + hit.collider);
        }
    }
}
