using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using TMPro;
public class LoginManager : MonoBehaviourPunCallbacks
{
    public string namaSceneHome;
    public TMP_InputField player_InputName;


    #region Unity Metyhod
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    #endregion

    #region UI CallBackMethod
    public void ConnectAnonymusly()
    {
        PhotonNetwork.ConnectUsingSettings();
    }

    public void ConnectToPhotonServer()
    {
        if (player_InputName != null)
        {
            PhotonNetwork.NickName = player_InputName.text;
            PhotonNetwork.ConnectUsingSettings();
        }
    }
    #endregion

    #region Photon Callsbacks Methods
    public override void OnConnected()
    {
        Debug.Log("On Connect is Called,the server is available");
    }
    public override void OnConnectedToMaster()
    {
        Debug.Log("Connect to maseter server with player name: "+PhotonNetwork.NickName);
        PhotonNetwork.LoadLevel(namaSceneHome);
    }

    #endregion




}