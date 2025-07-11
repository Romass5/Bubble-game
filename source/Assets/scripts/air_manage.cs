using UnityEngine;
using UnityEngine.UI;
public class air_manage : MonoBehaviour
{
    public Image airbar;
    public float airbar_amount;
    public float airbar_amount_max;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public void Decrease()
    {
        airbar_amount--;
        airbar.fillAmount = airbar_amount / airbar_amount_max;
    }

    public void Increase()
    {
        airbar_amount++;
        airbar.fillAmount = Mathf.Clamp(airbar_amount, 0, airbar_amount_max);
        airbar.fillAmount = airbar_amount / airbar_amount_max;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
