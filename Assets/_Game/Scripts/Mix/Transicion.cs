using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Transicion : MonoBehaviour
{
    public float fadeDuration = 2;
    public Color fadeColor;
    private Renderer rend;
    public bool fadeOnStart = true;
    void Start()
    {
        rend = GetComponent<Renderer>();
        if (fadeOnStart)
            FadeIn();
    }
    public void FadeIn()
    {
        Fade(1, 0);
    }
    public void FadeOut()
    {
        Fade(0, 1);
    }

    public void Fade(float alphaIN, float alpahaOut)
    {
        StartCoroutine(FadeRoutine(alphaIN, alpahaOut));
    }

    public IEnumerator FadeRoutine( float alphaIn, float alphaOut)
    {
        float timer = 0;
        while (timer <= fadeDuration)
        {
            Color newColor = fadeColor;
            newColor.a = Mathf.Lerp(alphaIn, alphaOut, timer/fadeDuration);
            rend.material.SetColor("_Color", newColor);
            timer += Time.deltaTime;
            yield return null;
        }
        Color newColor2 = fadeColor;
        newColor2.a = alphaOut;
        rend.material.SetColor("_Color", newColor2);
        
    }
    
}
