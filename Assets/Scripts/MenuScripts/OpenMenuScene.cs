using UnityEngine.SceneManagement;
using UnityEngine;

public class OpenMenuScene : MonoBehaviour
{

    public string sceneToLoad;
   
    void OnEnable()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
