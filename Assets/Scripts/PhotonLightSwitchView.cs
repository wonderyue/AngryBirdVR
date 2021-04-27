namespace Photon.Pun
{
    using UnityEngine;

    [RequireComponent(typeof(Light))]
    [AddComponentMenu("Photon Networking/Photon LightSwitch View")]
    public class PhotonLightSwitchView : MonoBehaviourPun, IPunObservable
    {
        private Light lightComponent;
        private bool m_NetworkEnabled;
        public void Awake()
        {
            lightComponent = GetComponent<Light>();
        }

        public void Update()
        {
            if (!this.photonView.IsMine)
            {
                lightComponent.enabled = m_NetworkEnabled;
            }
        }

        public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
        {
            if (stream.IsWriting)
            {
                stream.SendNext(this.lightComponent.enabled);
            }
            else
            {
                this.m_NetworkEnabled = (bool)stream.ReceiveNext();
            }
        }
    }
}