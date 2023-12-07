using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyShoot : MonoBehaviour
{
    
    
    [SerializeField] private float timer = 5;
    private float bulletTime;
    public int TimeBeforeFirstShoot;
    public GameObject enemyBullet;
    public Transform spawnEnemyBulletPoint;
    public float enemySpeed;
    public GameObject GunFire;
    AudioSource laser;
    void Start()
    {
        laser = GetComponent<AudioSource>();

    }
    void Update()
    {
        if (spawnEnemyBulletPoint != null)
        {
            Invoke("ShootAtPlayer", timer); 
        }
    }
    void ShootAtPlayer()
    {
      
        bulletTime -= Time.deltaTime;
        if (bulletTime > 0) return;
        bulletTime = timer;
        GameObject bulletObj = Instantiate(enemyBullet, spawnEnemyBulletPoint.transform.position, spawnEnemyBulletPoint.transform.rotation) as GameObject;
        
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 5f); 
        fired();
        PlaySound();
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            Destroy(collision.gameObject);
         }
    }
    void fired()
    {
        GunFire.SetActive(true);
        Invoke("outofire", 1f);


    }
    void outofire()
    {
        GunFire.SetActive(false);

    }
    void PlaySound()
	{
        laser.Play();

    }
}
