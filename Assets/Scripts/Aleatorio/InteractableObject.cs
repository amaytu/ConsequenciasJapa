using Assets.Scripts;
using Assets.Scripts.Utils;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InteractableObject : MonoBehaviour
{
    public EItems itemType;
    public float rotationSpeed = 8;
    public float rotationSensitivity = 5f; // Sensibilidade do movimento de rotação
    public int clicksNeeded = 5; 
    private int clickCount = 0;

    private bool isTheItem = false;
    private Vector3 initialMousePosition;
    private Quaternion initialRotation;

    void Start()
    {
        isTheItem = Utils.CurrentItem == itemType;
        gameObject.SetActive(isTheItem);
        initialRotation = transform.rotation;
    }

    void Update()
    {
        if (!isTheItem) return;

        if (Input.GetMouseButton(0))
        {
            Vector3 currentMousePosition = Input.mousePosition;
            Vector3 mouseDelta = currentMousePosition - initialMousePosition;
            float rotationX = -mouseDelta.y * rotationSensitivity;
            float rotationY = mouseDelta.x * rotationSensitivity;

            // Aplicar a rotação
            transform.rotation = initialRotation * Quaternion.Euler(rotationX, rotationY, 0);

        }

        if (Input.GetMouseButtonUp(0))
        {
            CheckIfTheAngleIsRight();
        }

        if (Input.GetMouseButtonUp(0))
        {
            clickCount++;

            if (clickCount >= clicksNeeded)
            {
                SceneManager.LoadScene(Utils.NextScene, LoadSceneMode.Single);
            }
        }

         void CheckIfTheAngleIsRight()
        {
            if (transform.rotation.eulerAngles.IsInRange(Utils.FinalAngle, 5))
            {
                SceneManager.LoadScene(Utils.NextScene, LoadSceneMode.Single);
            }
        }
    }
}
