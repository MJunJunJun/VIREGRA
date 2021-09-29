using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using System;

public class KontrolPistol : MonoBehaviour
{
    [SerializeField]
    GameObject UIController;
    [SerializeField]
    GameObject BaseController;
    [SerializeField]
    InputActionReference inputActionReference_UISwitcher;
    
    [SerializeField]
    InputActionReference TombolTembak;

    public Spawner spawnerBullet;
    

    bool isUICanvasActive = false;
    [SerializeField]
    public GameObject UICanvasGameobject;
    [SerializeField]
    Vector3 positionOffsetForUICanvasGameobject;
    public int JumlahPlayerPrefers;
    public int jumlahMisiSekarang;
    public string namaPlayerPreferes;
    public GameObject panelMenang, panelPause, panelkalah;
    public bool waktuhabis;//bernilai true juka waktu habis
    public bool win;
    public ActionBasedControllerManager kontrolTanganKanan;
    public bool petunjukPenggunaan;//untuk panel tutorial
    public bool adapetunjuk, level1;
    public bool berhenti;
    public GameObject pistol;
   // public GameObject cek;

    public bool final;
    public KontrolPistol kontrolPistolBos;
    //public UI_InteractionController kontrolBos;

    #region Unity Method
    private void Start()
    {
        //kontrolBos.enabled = false;
        kontrolPistolBos.enabled = true;
        jumlahMisiSekarang = 0;
        //Deactivating UI Canvas Gameobject by default
        UICanvasGameobject.SetActive(false);
        waktuhabis = false;
        panelkalah.SetActive(false);
        panelMenang.SetActive(false);
        //Deactivating UI Controller by default
        UIController.GetComponent<XRRayInteractor>().enabled = false;
        UIController.GetComponent<XRInteractorLineVisual>().enabled = false;
        //PlayerPrefs.GetInt(namaPlayerPreferes, JumlahPlayerPrefers);
        Time.timeScale = 1;
        if (petunjukPenggunaan)
        {
            Time.timeScale = 0;
        }

        if (level1)
        {
            UIMODE();
        }


        panelPause.SetActive(false);
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
        if (!berhenti) { TombolTembak.action.performed += Tembak; }
            
       
        
        //inputActionReference_UISwitcher.action.performed += pauseGame;

    }
    public void OnDisable()
    {
        inputActionReference_UISwitcher.action.performed -= ActivateUIMode;
        if (!berhenti) { TombolTembak.action.performed -= Tembak; }
        
        
        
        //inputActionReference_UISwitcher.action.performed -= pauseGame;

    }
    #endregion


    public void Tembak(InputAction.CallbackContext obj)
    {
        spawnerBullet.tembak();
        //cek.SetActive(true);
    }




    #region UI Activate Mode
    /// <summary>
    /// This method is called when the player presses UI Switcher Button which is the input action defined in Default Input Actions.
    /// When it is called, UI interaction mode is switched on and off according to the previous state of the UI Canvas.
    /// </summary>
    /// <param name="obj"></param>
    public void ActivateUIMode(InputAction.CallbackContext obj)
    {

        UIMODE();
    }

    public void selesaiPetunjuk()
    {
        petunjukPenggunaan = false;
        Time.timeScale = 1;
        UIMODE();
    }


    public void UIMODE()
    {



        if (win == true ||waktuhabis == true)
        {
           panelPause.SetActive(false);
        }
        else
        {
           panelPause.SetActive(true);
        }
        if (waktuhabis == true)
        {
            UICanvasGameobject.SetActive(true);
            panelkalah.SetActive(true);
            Time.timeScale = 1;
        }
        else
        {
            panelkalah.SetActive(false);
        }
        if (win == true)
        {
            UICanvasGameobject.SetActive(true);
            panelMenang.SetActive(true);
            Time.timeScale = 1;
            
        }
        else
        {
            panelMenang.SetActive(false);
        }



        if (!isUICanvasActive)
        {
           /*if (final)
            {
                kontrolPistolBos.enabled = false;
                kontrolBos.enabled = true;
            }*/

            if (!petunjukPenggunaan)
            {
               if (win || waktuhabis)
                {
                    Time.timeScale = 0;
                }
                else
                {
                    Time.timeScale = 0;
                }
                UICanvasGameobject.SetActive(true);
            }

            isUICanvasActive = true;
            berhenti = true;

            kontrolTanganKanan.enabled = false;



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

        }
        else
        {
            if (!petunjukPenggunaan)
            {
                if (win || waktuhabis)
                {
                    Time.timeScale = 0;
                }
                else
                {
                    Time.timeScale = 1;
                }
                //UICanvasGameobject.SetActive(false);
            }
            isUICanvasActive = false;
            UICanvasGameobject.SetActive(false);
            berhenti = false;
            kontrolTanganKanan.enabled = true;



            //De-Activating UI Controller by enabling its XR Ray Interactor and XR Interactor Line Visual
            UIController.GetComponent<XRRayInteractor>().enabled = false;
            UIController.GetComponent<XRInteractorLineVisual>().enabled = false;

            //Activating Base Controller by disabling its XR Direct Interactor
            BaseController.GetComponent<XRDirectInteractor>().enabled = true;

            //De-Activating the UI Canvas Gameobject

        }


    }
    public void winnn()
    {
        if (win == true || waktuhabis == true)
        {
            // panelPause.SetActive(false);
        }
        else
        {
            // panelPause.SetActive(true);
        }
        if (waktuhabis == true)
        {
            UICanvasGameobject.SetActive(true);
            panelkalah.SetActive(true);
            Time.timeScale = 1;
        }
        else
        {
            panelkalah.SetActive(false);
        }
        if (win == true)
        {
            UICanvasGameobject.SetActive(true);
            panelMenang.SetActive(true);
            Time.timeScale = 1;

        }
        else
        {
            panelMenang.SetActive(false);
        }



        if (!isUICanvasActive)
        {
            /* if (final)
             {
                 kontrolPistolBos.enabled = false;
                 kontrolBos.enabled = true;
             }*/

            if (!petunjukPenggunaan)
            {

                UICanvasGameobject.SetActive(true);
            }

            isUICanvasActive = true;
            berhenti = true;

            kontrolTanganKanan.enabled = false;



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

        }
        else
        {
            if (!petunjukPenggunaan)
            {

            }
            isUICanvasActive = false;
            UICanvasGameobject.SetActive(false);
            berhenti = false;
            kontrolTanganKanan.enabled = true;



            //De-Activating UI Controller by enabling its XR Ray Interactor and XR Interactor Line Visual
            UIController.GetComponent<XRRayInteractor>().enabled = false;
            UIController.GetComponent<XRInteractorLineVisual>().enabled = false;

            //Activating Base Controller by disabling its XR Direct Interactor
            BaseController.GetComponent<XRDirectInteractor>().enabled = true;

            //De-Activating the UI Canvas Gameobject

        }

    }

    public void Kalah()
    {

        if (waktuhabis == true)
        {
            UICanvasGameobject.SetActive(true);
            panelkalah.SetActive(true);
        }
        else
        {
            panelkalah.SetActive(false);
        }



    }

    #endregion


}
