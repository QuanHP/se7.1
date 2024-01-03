using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEditor.XR;

public class MessageFindOpponent : MonoBehaviour
{

    public Image myAvatar, enemyAvatar;
    public GameObject iconLoading;
    public GameObject numLoading;

    [HideInInspector]
    public bool isClose = false;

    public void CallStart()
    {
        PlayerPrefs.DeleteKey("PUNCloudBestRegion");
       
        Modules.fbEnemyAvatar = null;
        myAvatar.sprite = Modules.fbMyAvatar;
        if (myAvatar.sprite == null) myAvatar.sprite = Modules.iconAvatarNull;
        UpdateAvatarEnemy();
        iconLoading.SetActive(true);
        numLoading.SetActive(false);
        
        isClose = false;
        
    }

    public void UpdateAvatarEnemy()
    {
        enemyAvatar.sprite = Modules.fbEnemyAvatar;
        if (enemyAvatar.sprite == null) enemyAvatar.sprite = Modules.iconAvatarNull;
    }

    public void ButtonCloseBox()
    {
        CancelInvoke();
        transform.GetComponent<Animator>().SetTrigger("TriClose");
        Modules.PlayAudioClipFree(Modules.audioButton);
        isClose = true;
    }
}
