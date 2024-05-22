using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class LoadLevel : MonoBehaviour
    {
        public string nextLevel;
        public bool faseterminada = false;

        void OnEnable() {
            SceneManager.LoadScene(nextLevel, LoadSceneMode.Single);
        }
    }
}