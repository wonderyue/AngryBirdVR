using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class LightTurn : MonoBehaviour
{
    public Light target;
    private PhotonView photonView;

    private void Start()
    {
        photonView = target.GetComponent<PhotonView>();
    }
    public void Switch()
    {
        if (photonView != null)
            photonView.TransferOwnership(PhotonNetwork.LocalPlayer);
        target.enabled = !target.enabled;
    }
}
