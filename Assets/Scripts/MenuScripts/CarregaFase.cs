using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts.MenuScripts
{
    public class CarregaFase : MonoBehaviour
    {
        [SerializeField] private Animator transicao;

        void Update()
        {

        }

        public IEnumerator IniciaFase(string nomefase)
        {
            transicao.SetTrigger("Iniciar");

            yield return new WaitForSeconds(1);

            SceneManager.LoadScene(nomefase);

        }

    }
}