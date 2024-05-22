using UnityEngine;

public class FinalSceneController : MonoBehaviour
{
    public string finalKey = "Final1Completed";

    private void Start()
    {
        // Supondo que o jogador tenha terminado a fase, voc� pode chamar esta fun��o ao t�rmino
        MarkFinalAsCompleted();
    }

    public void MarkFinalAsCompleted()
    {
        PlayerPrefs.SetInt(finalKey, 1);
        PlayerPrefs.Save();
    }
}
