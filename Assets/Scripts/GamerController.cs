using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class GamerController : MonoBehaviour
{
    public MonoBehaviour[] ignoreCodes;
    public PhotonView photonView;

    // Start is called before the first frame update
    void Start()
    {
        photonView = GetComponent<PhotonView>();
        if (!photonView.IsMine)
        {
            foreach (var ignoreCode in ignoreCodes)
            {
                ignoreCode.enabled = false;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
