using Assets.Scripts;
using Assets.Scripts.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : MonoBehaviour
{
    public EItems itemType;
    public float rotationSpeed = 8;
    public float duration = 5f; // Duration for rotation to complete
    public Vector3 finalRotation; // Final rotation angles in degrees
    private float sceneLoadDelay = 5.5f; // Delay before loading the next scene

    private bool isTheItem = false;
    private Quaternion initialRotation;
    private Quaternion targetRotation;
    private float rotationTime = 0f;
    private float elapsedTime = 0f;

    void Start()
    {
        isTheItem = Utils.CurrentItem == itemType;
        gameObject.SetActive(isTheItem);
        initialRotation = transform.rotation;
        targetRotation = Quaternion.Euler(finalRotation);
    }

    void Update()
    {
        if (!isTheItem) return;

        // Rotate the object over time towards the target rotation
        if (rotationTime < duration)
        {
            rotationTime += Time.deltaTime;
            float t = Mathf.Clamp01(rotationTime / duration);
            transform.rotation = Quaternion.Slerp(initialRotation, targetRotation, t);
        }

        // Track the elapsed time and load the scene after the delay
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= sceneLoadDelay)
        {
            SceneManager.LoadScene(Utils.NextScene, LoadSceneMode.Single);
        }
    }
}
