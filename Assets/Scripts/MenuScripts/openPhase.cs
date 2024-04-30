
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class openPhase : MonoBehaviour, IPointerClickHandler
{
    public string sceneName; // Nome da cena que você deseja carregar

    // Método chamado quando o usuário clica na imagem
    public void OnPointerClick(PointerEventData eventData)
    {
        // Carrega a cena com o nome especificado
        SceneManager.LoadScene(sceneName);
    }
}

