using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private AudioSource goalReachSound;
    private bool activate;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        goalReachSound = GetComponent<AudioSource>();
        activate = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && !activate)
        {
            activate = true;
            goalReachSound.Play();
            StartCoroutine(GoToNextLevel());
        }
    }


    IEnumerator GoToNextLevel()
    {
        
        yield return new WaitForSeconds(2);
        if (SceneManager.GetActiveScene().buildIndex == 5)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
