using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

public class UI_InteractionController : MonoBehaviour
{
    [SerializeField]
    GameObject UIController;

    [SerializeField]
    GameObject BaseController;

    [SerializeField]
    InputActionReference inputActionReference_UISwitcher;

    bool isUICanvasActive = false;

    [SerializeField]
    GameObject UICanvasGameobject;

    [SerializeField]
    Vector3 positionOffsetForUICanvasGameobject;
    public int JumlahPlayerPrefers;
    public string namaPlayerPreferes;
    public GameObject panelMenang, panelPause, panelkalah;
    public bool waktuhabis;//bernilai true juka waktu habis
    public bool win;

    #region Unity Method
    private void Start()
    {
        //Deactivating UI Canvas Gameobject by default
        UICanvasGameobject.SetActive(false);
        waktuhabis = false;
        //Deactivating UI Controller by default
        UIController.GetComponent<XRRayInteractor>().enabled = false;
        UIController.GetComponent<XRInteractorLineVisual>().enabled = false;
        PlayerPrefs.GetInt(namaPlayerPreferes, JumlahPlayerPrefers);

    }

    private void Update()
    {
        /*if (win)
        {
            //inputActionReference_UISwitcher.action.performed += ActivateUIMode;
             OnEnable();
        }
        if (waktuhabis)
        {
            OnEnable();
            //inputActionReference_UISwitcher.action.performed += ActivateUIMode;
        }*/

    }
    #endregion

    #region digunakan tidak
    public void OnEnable()
    {      
        inputActionReference_UISwitcher.action.performed += ActivateUIMode;
        if (win || waktuhabis)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 0;
        }
        
    }
    public void OnDisable()
    {
        inputActionReference_UISwitcher.action.performed -= ActivateUIMode;
        Time.timeScale = 0;
        if (win || waktuhabis)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
    #endregion



    



    #region UI Activate Mode
    /// <summary>
    /// This method is called when the player presses UI Switcher Button which is the input action defined in Default Input Actions.
    /// When it is called, UI interaction mode is switched on and off according to the previous state of the UI Canvas.
    /// </summary>
    /// <param name="obj"></param>
    public void ActivateUIMode(InputAction.CallbackContext obj)
    {
        if (win==false && waktuhabis == false)
        {
            panelPause.SetActive(true);
        }
        else
        {
            panelPause.SetActive(false);
        }
        /*else if (win==true && waktuhabis == false)
        {
            panelMenang.SetActive(true);
            panelkalah.SetActive(false);
            panelPause.SetActive(false);
        }
        else
        {
            panelMenang.SetActive(false);
            panelkalah.SetActive(true);
            panelPause.SetActive(false);
        }*/

        if (!isUICanvasActive)
        {
            isUICanvasActive = true;

            //Activating UI Controller by enabling its XR Ray Interactor and XR Interactor Line Visual
            UIController.GetComponent<XRRayInteractor>().enabled = true;
            UIController.GetComponent<XRInteractorLineVisual>().enabled = true;

            //Deactivating Base Controller by disabling its XR Direct Interactor
            BaseController.GetComponent<XRDirectInteractor>().enabled = false;

            //Adjusting the transform of the UI Canvas Gameobject according to the VR Player transform
            Vector3 positionVec = new Vector3(UIController.transform.position.x, positionOffsetForUICanvasGameobject.y, UIController.transform.position.z);
            Vector3 directionVec = UIController.transform.forward;
            directionVec.y = 0f;
            UICanvasGameobject.transform.position = positionVec + positionOffsetForUICanvasGameobject.magnitude * directionVec;
            UICanvasGameobject.transform.rotation = Quaternion.LookRotation(directionVec);

            //Activating the UI Canvas Gameobject
            UICanvasGameobject.SetActive(true);
        }
        else
        {
            isUICanvasActive = false;

            //De-Activating UI Controller by enabling its XR Ray Interactor and XR Interactor Line Visual
            UIController.GetComponent<XRRayInteractor>().enabled = false;
            UIController.GetComponent<XRInteractorLineVisual>().enabled = false;

            //Activating Base Controller by disabling its XR Direct Interactor
            BaseController.GetComponent<XRDirectInteractor>().enabled = true;

            //De-Activating the UI Canvas Gameobject
            UICanvasGameobject.SetActive(false);
        }

    }

    #endregion


}
