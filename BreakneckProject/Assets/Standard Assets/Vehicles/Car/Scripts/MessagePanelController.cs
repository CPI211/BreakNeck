using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MessagePanelController : MonoBehaviour
{
    public float timer;
    private Text messageText;

    // Use this for initialization
    void Start()
    {
        messageText = gameObject.transform.Find("MessageText").GetComponent<Text>();
        timer = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > 0.0f)
        {
            timer -= Time.deltaTime;
        }

        else
        {
            gameObject.SetActive(false);
        }
    }

    public void NewMessage(string message, float TimeOnScreen)
    {
        gameObject.SetActive(true);
        messageText.text = message;
        timer = TimeOnScreen;
    }
}
