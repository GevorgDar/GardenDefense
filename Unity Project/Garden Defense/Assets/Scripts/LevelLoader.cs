using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    [SerializeField] private int timeToWait = 4;
    private int curruntSceneIndex;

    // Start is called before the first frame update
    void Start()
    {
        curruntSceneIndex = SceneManager.GetActiveScene().buildIndex;
        if (curruntSceneIndex == 0)
        {
            StartCoroutine(WaitForTime());
        }
    }

    private IEnumerator WaitForTime()
    {
        yield return new WaitForSeconds(timeToWait);
        LoadNextScene();
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(curruntSceneIndex + 1);
    }
}
