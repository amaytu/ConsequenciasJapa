using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Transition : MonoBehaviour
{
        // M�todo para iniciar a transi��o de cena
        public void LoadSceneWithDelay(string Menu)
        {
            StartCoroutine(LoadSceneAfterDelay(Menu, 1f)); // 1 segundo de delay
        }

        // Corrotina para carregar a cena ap�s um delay
        private IEnumerator LoadSceneAfterDelay(string Menu, float delay)
        {
            yield return new WaitForSeconds(delay);
            SceneManager.LoadScene(Menu);
        }
    
}
