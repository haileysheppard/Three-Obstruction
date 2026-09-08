using UnityEngine;

public class EnvironmentColorController : MonoBehaviour
{
    [Header("Color Groups")]
    [SerializeField] private GameObject redObjects;
    [SerializeField] private GameObject blueObjects;
    [SerializeField] private GameObject greenObjects;

    private void Start()
    {
        // Start with the red environment active.
        ActivateRed();
    }

    public void ActivateRed()
    {
        redObjects.SetActive(true);
        blueObjects.SetActive(false);
        greenObjects.SetActive(false);
    }

    public void ActivateBlue()
    {
        redObjects.SetActive(false);
        blueObjects.SetActive(true);
        greenObjects.SetActive(false);
    }

    public void ActivateGreen()
    {
        redObjects.SetActive(false);
        blueObjects.SetActive(false);
        greenObjects.SetActive(true);
    }
}