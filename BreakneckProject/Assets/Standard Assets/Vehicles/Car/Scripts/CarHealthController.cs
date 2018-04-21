using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarHealthController : MonoBehaviour
{
    public GameObject HealthDisplay;
    public GameObject MessagePanel;

    public int MaxHealth;
    private int CurrentHealth;

	// Use this for initialization
	void Start ()
    {
        HealthDisplay = GameObject.Find("HealthDisplay");
        MessagePanel = GameObject.Find("Canvas").gameObject.transform.Find("MessagePanel").gameObject;
        CurrentHealth = MaxHealth;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (this.CompareTag("Player")) { UpdateHealthDisplay(); }
        if (CurrentHealth <= 0)
        {
            MessagePanel.SetActive(true);
            MessagePanel.GetComponent<MessagePanelController>().NewMessage("RACER ELIMINATED", 3.0f);
            GameObject.Destroy(this.gameObject);
        }
	}

    public void UpdateHealthDisplay()
    {
        HealthDisplay.GetComponent<Text>().text = "Health: " + CurrentHealth;
    }

    public void DealDamage(int damage)
    {
        CurrentHealth -= damage;
    }
}
