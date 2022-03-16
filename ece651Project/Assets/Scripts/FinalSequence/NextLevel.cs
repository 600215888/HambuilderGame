using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel : MonoBehaviour
{
    private AudioSource goalReachSound;
    
    
    // Start is called before the first frame update
    private void Start()
    {
        goalReachSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            goalReachSound.Play();
            StartCoroutine(GoToNextLevel());
        }
    }


    IEnumerator GoToNextLevel()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene("Level 4");
    }
}
