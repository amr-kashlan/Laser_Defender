using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public ParticleSystem hitEffect;
    public int health = 50;
    public bool applyCameraShake;
    CanvasShake canvasShake;
    private void Awake()
    {
        canvasShake = Camera.main.GetComponent<CanvasShake>();
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        DamageDealer damageDealer = other.GetComponent<DamageDealer>();
        if (damageDealer != null)
        {
            damageDealer.Hit();
            TakeDamage(damageDealer.GetDamage());
            PlayHitEffect();
            ShakeCamera();
        }
    }
    void ShakeCamera()
    {
        if (canvasShake != null && applyCameraShake)
        {
            canvasShake.Play();
        }
    }
    void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void PlayHitEffect()
    {
        if (hitEffect != null)
        {
            ParticleSystem instance = Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(instance.gameObject, instance.main.duration + instance.main.startLifetime.constantMax);
        }
    }
}
