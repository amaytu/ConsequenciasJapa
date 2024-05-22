using Assets.Scripts.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadInteractibleLevelTemplate : MonoBehaviour
{
    public EItems itemToPassToNextScene;
    public string nextScene;
    public Vector3 finalAngle;
    public Color backgroundColor;

    void OnEnable()
    {
        if (itemToPassToNextScene == EItems.Monitor) 
        {
            SceneManager.LoadScene("Pergunta 1", LoadSceneMode.Single); 
        }
        else if (itemToPassToNextScene == EItems.StrawCup)
        {
            SceneManager.LoadScene("Pergunta 2", LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("InteractibleLevel", LoadSceneMode.Single); 
        }

        Utils.CurrentItem = itemToPassToNextScene;
        Utils.FinalAngle = finalAngle;
        Utils.NextScene = nextScene;
        Utils.Color = backgroundColor;
    }
}
