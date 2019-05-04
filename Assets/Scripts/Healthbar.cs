using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Healthbar : MonoBehaviour
{
    [SerializeField]
    Image foreground;


    public Health targetHealth;
    [SerializeField]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float healthRatio = targetHealth.health / targetHealth.maxHealth;
        //foreground.fillAmount = healthRatio;
        foreground.fillAmount = Mathf.Lerp(foreground.fillAmount, healthRatio, 0.2f);

        /*if (foreground.fillAmount > 0)
        {
            foreground.fillAmount -= 0.001f;
        }*/
    }
}
