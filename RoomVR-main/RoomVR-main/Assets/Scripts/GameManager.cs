
using UnityEngine;
using UnityEngine.SceneManagement;

using Photon.Realtime;
using Photon.Pun;

#pragma warning disable 649

/// <summary>
/// Game manager.
/// Connects and watch Photon Status, Instantiate Player
/// Deals with quiting the room and the game
/// Deals with level loading (outside the in room synchronization)
/// </summary>
public class GameManager : MonoBehaviourPunCallbacks
{

    #region Public Fields

    static public GameManager Instance;

    #endregion

    #region Private Fields

    private GameObject instance;

    [Tooltip("PlayerObject")]
    [SerializeField]
    private GameObject playerObject;

    [Tooltip("The dafault position of player1")]
    [SerializeField]
    private Transform player1SpawnPoint;

    [Tooltip("The dafault position of player1")]
    [SerializeField]
    private Transform player2SpawnPoint;

    #endregion

    #region MonoBehaviour CallBacks

    /// <summary>
    /// MonoBehaviour method called on GameObject by Unity during initialization phase.
    /// </summary>
    void Start()
    {
        Instance = this;
        if (PhotonNetwork.IsMasterClient) 
        {
            playerObject.transform.position = player1SpawnPoint.position;
        } 
        else 
        {
            playerObject.transform.position = player2SpawnPoint.position;
        }
        PhotonNetwork.Instantiate("Prefabs/PhotonSpeaker", Vector3.zero, Quaternion.identity,0);
    }

    /// <summary>
    /// MonoBehaviour method called on GameObject by Unity on every frame.
    /// </summary>
    void Update()
    {
        // "back" button of phone equals "Escape". quit app if that's pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            LeaveRoom();
            QuitApplication();
        }
    }

    #endregion

    #region Photon Callbacks

    /// <summary>
    /// Called when a Player got connected.
    /// </summary>
    /// <param name="other">Other.</param>
    public override void OnPlayerEnteredRoom(Player other)
    {
        Debug.Log("OnPlayerEnteredRoom() " + other.NickName); // not seen if you're the player connecting
    }

    /// <summary>
    /// Called when a Photon Player got disconnected.
    /// </summary>
    /// <param name="other">Other.</param>
    public override void OnPlayerLeftRoom(Player other)
    {
        Debug.Log("OnPlayerLeftRoom() " + other.NickName); // seen when other disconnects
    }

    /// <summary>
    /// Called when the local player left the room. We need to load the launcher scene.
    /// </summary>
    public override void OnLeftRoom()
    {
        SceneManager.LoadScene("launcher");
    }

    #endregion

    #region Public Methods

    public void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
    }

    public void QuitApplication()
    {
        Application.Quit();
    }

    #endregion

    #region Private Methods


    #endregion
}