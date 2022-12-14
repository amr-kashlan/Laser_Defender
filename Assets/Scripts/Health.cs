using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public ParticleSystem hitEffect;
    public int health = 50;
    public bool applyCameraShake;
    CanvasShake canvasShake;
    AudioPlayer audioPlayer;
    ScoreKeeper scoreKeeper;
    GameManager gameManager;

    private void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
        audioPlayer = FindObjectOfType<AudioPlayer>();
        gameManager = FindObjectOfType<GameManager>();

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
    public float GetHealth()
    {
        return health;
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
            audioPlayer.PlayHitClip();
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
            if (applyCameraShake == false)
            {
                scoreKeeper.AddScore();
            }
            else
            {
                gameManager.LoadGameOver();
            }
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
