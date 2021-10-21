using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
     Transform transf;

    float shakeDuration = 0f;

    float shakeMagnitude = 0.7f;

    float dampingSpeed = 1.0f;

    Vector3 initialPosition;

    void Awake()
    {
        if (transf == null)
        {
            transf = GetComponent(typeof(Transform)) as Transform;
        }
    }
    void OnEnable()
    {
        initialPosition = transf.localPosition;
    }
    void Update()
    {
        if (shakeDuration > 0)
        {
            transf.localPosition = initialPosition + Random.insideUnitSphere * shakeMagnitude;

            shakeDuration -= Time.deltaTime * dampingSpeed;
        }
        else
        {
            shakeDuration = 0f;
            transf.localPosition = initialPosition;
        }
    }
    public void TriggerShake()
    {
        shakeDuration = 2.0f;
    }
}
