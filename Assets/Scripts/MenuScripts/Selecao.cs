using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Selecao : MonoBehaviour
{
    [SerializeField] private Button[] botoes;
    [SerializeField] private Slider[] sliders;
    [SerializeField] private TextMeshProUGUI mensagemTela;
    [SerializeField] private CarregaFase carregaFase;
    [SerializeField] private GameObject[] setas;
    [SerializeField] private string[] fase;


    private int botaoSelecionadoIndice = 0;
    private bool botaoSendoPressionado = false;
    private float tempoPressionado = 0f;
    private float tempoPressionadoNecessario = 2.5f;
    private bool bloqueiaBotao;
    private bool carregandoFase = false;

    private void Update()
    {
        // verifica clique na tela
        if (Input.GetMouseButtonDown(0))
        {
            botaoSendoPressionado = true;
        }

        if (botaoSendoPressionado && botoes[botaoSelecionadoIndice].interactable)
        {
            mensagemTela.gameObject.SetActive(false);
            // tempo botao pressionado
            tempoPressionado += Time.deltaTime;

            float progresso = tempoPressionado / tempoPressionadoNecessario;
            sliders[botaoSelecionadoIndice].value = progresso;

            // carrega cena
            if (tempoPressionado >= tempoPressionadoNecessario)
            {
                switch (botaoSelecionadoIndice)
                {
                    case 0:
                        StartCoroutine(carregaFase.IniciaFase(fase[0]));
                        carregandoFase = true;
                        break;
                    case 1:
                        StartCoroutine(carregaFase.IniciaFase(fase[1]));
                        carregandoFase = true;
                        break;

                }
            }
            else
            {
                bloqueiaBotao = false;
            }
        }

        if (!bloqueiaBotao && Input.GetMouseButtonUp(0) && !carregandoFase)
        {
            botaoSendoPressionado = false;
            tempoPressionado = 0f;
            sliders[botaoSelecionadoIndice].value = 0;
            botaoSelecionadoIndice = (botaoSelecionadoIndice + 1) % botoes.Length; // avanca para prox botao
            AlternarSelecaoBotoes();
        }
    }

    private void AlternarSelecaoBotoes()
    {
        for (int i = 0; i < botoes.Length; i++)
        {
            bool isBotaoSelecionado = i == botaoSelecionadoIndice;
             botoes[i].interactable = isBotaoSelecionado;

            if (setas[i] != null)
            {
                setas[i].SetActive(isBotaoSelecionado);
            }
        }
    }
}