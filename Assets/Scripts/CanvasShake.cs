using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasShake : MonoBehaviour
{
    public float shakeDuration = 1;
    public float Megnitude = 0.5f;
    Vector3 initialPosition;
    // Start is called before the first frame update
    void Start()
    {
        initialPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Play()
    {
        StartCoroutine(Shake());
    }
    IEnumerator Shake()
    {
        float elapsedTime = 0;
        while (elapsedTime < shakeDuration)
        {

            transform.position = initialPosition + (Vector3)Random.insideUnitCircle * Megnitude;
            elapsedTime += Time.deltaTime;
            yield return new WaitForEndOfFrame();
        }
        transform.position = initialPosition;

    }
}
