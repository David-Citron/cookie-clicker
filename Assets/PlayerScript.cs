using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private int cookies;
    [SerializeField] private TMP_Text cookieCounterText;

    // Start is called before the first frame update
    void Start()
    {
        cookies = 0;
        UpdateCookieCounter();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddCookie()
    {
        cookies++;
        UpdateCookieCounter();
    }

    private void UpdateCookieCounter()
    {
        cookieCounterText.text = "Cookies: " + cookies;
    }
}
