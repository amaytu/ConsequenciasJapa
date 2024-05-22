using UnityEngine;

public class MenuController : MonoBehaviour
{
    public GameObject final1Prefab;
    public GameObject final2Prefab;
    public GameObject final3Prefab;
    public GameObject final4Prefab;

    private void Start()
    {
        CheckFinalCompletion();
    }

    private void CheckFinalCompletion()
    {
        if (PlayerPrefs.GetInt("Final1Completed", 0) == 1)
        {
            ActivateFinalPrefab(final1Prefab);
        }
        if (PlayerPrefs.GetInt("Final2Completed", 0) == 1)
        {
            ActivateFinalPrefab(final2Prefab);
        }
        if (PlayerPrefs.GetInt("Final3Completed", 0) == 1)
        {
            ActivateFinalPrefab(final3Prefab);
        }
        if (PlayerPrefs.GetInt("Final4Completed", 0) == 1)
        {
            ActivateFinalPrefab(final4Prefab);
        }
    }

    private void ActivateFinalPrefab(GameObject prefab)
    {
        if (prefab != null)
        {
            prefab.SetActive(true);
        }
    }

    private void OnApplicationQuit()
    {
        PlayerPrefs.SetInt("Final1Completed", 0);
        PlayerPrefs.SetInt("Final2Completed", 0);
        PlayerPrefs.SetInt("Final3Completed", 0);
        PlayerPrefs.SetInt("Final4Completed", 0);
    }

    }
