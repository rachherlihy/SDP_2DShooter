using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HealthBarStats : MonoBehaviour
{

    [SerializeField]
    private float fillAmount;

    [SerializeField]
    private Image Healthbar;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        HandleBar();
    }

    private void HandleBar()
    {
        Healthbar.fillAmount = Map(53,0,100,0,1);
    }

    private float Map(float currentHealth, float healthMin, float healthMax, float outMin, float outMax) {
        return (currentHealth - healthMin) * (outMax - outMin) / (healthMax - healthMin) + outMin;

    }
}
