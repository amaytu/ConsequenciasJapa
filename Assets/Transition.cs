using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
        // Método para iniciar a transição de cena
        public void LoadSceneWithDelay(string Menu)
        {
            StartCoroutine(LoadSceneAfterDelay(Menu, 1f)); // 1 segundo de delay
        }

        // Corrotina para carregar a cena após um delay
        private IEnumerator LoadSceneAfterDelay(string Menu, float delay)
        {
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene(Menu);
        }
    
}
