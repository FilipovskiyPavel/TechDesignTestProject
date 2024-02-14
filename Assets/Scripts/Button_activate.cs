using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_activate : MonoBehaviour
{
    [SerializeField] private GameObject _button;
    [SerializeField] private bool _button_on;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Activate()
    {
        if(_button_on)
        {
            _button.SetActive(true);

        }
    }
}
