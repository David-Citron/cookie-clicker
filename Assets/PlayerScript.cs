using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField] private int cookies;
    
    // Start is called before the first frame update
    void Start()
    {
        cookies = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddCookie()
    {
        cookies++;
    }
}
