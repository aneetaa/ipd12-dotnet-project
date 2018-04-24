using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    private IEnumerator coroutine;
    private void OnTriggerEnter(Collider other)
    {
        AudioSource source = GetComponent<AudioSource>();
        source.Play();
        new WaitForSeconds(2f);
        coroutine = WaitAndDestroy(0.5f);
        StartCoroutine(coroutine);
        ScoreCount.gScore += 1;
        //string OtherSceneName = "Level-02";
        //SceneManager.LoadScene(OtherSceneName, LoadSceneMode.Additive);
        if (ScoreCount.gScore==8)
        {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
    }
    private IEnumerator WaitAndDestroy(float waitTime)
    {
        while (true)
        {
            yield return new WaitForSeconds(waitTime);
            Destroy(gameObject);
        }
    }
}
