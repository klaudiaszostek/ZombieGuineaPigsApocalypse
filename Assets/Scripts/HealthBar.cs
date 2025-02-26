using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

class HealthBar : MonoBehaviour
{
    [SerializeField] private PlayerGuineaPig playerHealth;
    [SerializeField] private Image totalHealthBar;
    [SerializeField] private Image currentHealthBar; 
    private void Start()
    {
        totalHealthBar.fillAmount = playerHealth.CurrentHP / 10;
    }
    private void Update()
    {
        currentHealthBar.fillAmount = playerHealth.CurrentHP / 10;
    }
}
