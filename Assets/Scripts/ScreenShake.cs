using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{

    public float duration = 1f;
    public AnimationCurve curve;
    public bool start = false;


    // Update is called once per frame
    private void Awake ( )
    {
        start = true;
    }

    private void Update ( )
    {
        if(start)
        {
            start = false;
            StartCoroutine (Shaking ());
        }
    }

    IEnumerator Shaking()
    {
        Vector2 startPosition = transform.position;
        float elapsedTime = 0f;


        while (elapsedTime < duration)
        {
            elapsedTime += Time . deltaTime;
            float strength = curve.Evaluate(elapsedTime/duration);
            transform . position = startPosition + Random . insideUnitCircle * strength;
            yield return null;
        }

        transform . position = startPosition;

    }
    
}
