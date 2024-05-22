using UnityEngine;

public class FinalSceneController : MonoBehaviour
{
    public string finalKey = "Final1Completed";

    private void Start()
    {
        // Supondo que o jogador tenha terminado a fase, você pode chamar esta função ao término
        MarkFinalAsCompleted();
    }

    public void MarkFinalAsCompleted()
    {
        PlayerPrefs.SetInt(finalKey, 1);
        PlayerPrefs.Save();
    }
}
