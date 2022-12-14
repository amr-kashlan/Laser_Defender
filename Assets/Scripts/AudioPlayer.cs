using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip shot;
    public float value = 1;
    public AudioClip hit;

    static AudioPlayer instance;

    void Awake()
    {
        ManageSingleton();
    }

    void ManageSingleton()
    {
        if (instance != null)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void PlayShotClip()
    {
        if (shot != null)
        {
            AudioSource.PlayClipAtPoint(shot, Camera.main.transform.position, value);
        }
    }
    public void PlayHitClip()
    {
        if (hit != null)
        {
            AudioSource.PlayClipAtPoint(hit, Camera.main.transform.position, value);
        }
    }
}
