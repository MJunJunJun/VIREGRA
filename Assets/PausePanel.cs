using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PausePanel : MonoBehaviour
{
    public UI_InteractionController uiControl;
    [SerializeField]
    InputActionReference inputActionReference_UISwitcher;
    public void resumeGame()
    {
        uiControl.UIMODE();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
