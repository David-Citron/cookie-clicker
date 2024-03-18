using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private int cookies;
    [SerializeField] private TMP_Text cookieCounterText;
    [SerializeField] private int passiveIncome;

    // Start is called before the first frame update
    void Start()
    {
        cookies = 0;
        passiveIncome = 0;
        UpdateCookieCounter();
        StartCoroutine(PassiveIncome());
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

    public void BuyUpgrade()
    {
        if (cookies >= 10)
        {
            cookies -= 10;
            UpdateCookieCounter();
            passiveIncome++;
        }
    }

    IEnumerator PassiveIncome()
    {
        while (true)
        {
            yield return new WaitForSecondsRealtime(1);
            cookies += passiveIncome;
            UpdateCookieCounter();
        }
    }
}
