using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ControlEscena : MonoBehaviour
{
    public Transicion transicion;

    public  void GoToScene( int sceneIndex)
    {
        StartCoroutine(GoToSceneRoutine(sceneIndex));
    }

    IEnumerator GoToSceneRoutine(int sceneIndex)
    {
        transicion.FadeOut();
        yield return new WaitForSeconds(transicion.fadeDuration);
        SceneManager.LoadScene(sceneIndex);
        
        
        

    }
    
}
