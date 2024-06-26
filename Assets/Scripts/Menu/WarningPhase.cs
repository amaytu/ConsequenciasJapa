using UnityEngine;
using UnityEngine.SceneManagement;

public class WarningPhase : MonoBehaviour
{
    void Start()
    {
        Invoke("LoadMenuScene", 3f);
    }

    void LoadMenuScene()
    {
        SceneManager.LoadScene("Menu");
    }
}

