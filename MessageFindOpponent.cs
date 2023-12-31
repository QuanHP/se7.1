using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class MessageFindOpponent : MonoBehaviour
{   
    public Image myAvatar;
    public Image enemyAvatar;
    public GameObject findOpponentsBox;
    [HideInInspector]
    private bool isClose = false;
    public void CallStart()
    {
        PlayerPrefs.DeleteKey("PUNCloudBestRegion");

        Modules.fbEnemyAvatar = null;
        myAvatar.sprite = Modules.fbMyAvatar;
        if (myAvatar.sprite == null) myAvatar.sprite = Modules.iconAvatarNull;
        
        isClose = false;
        
    }

    public void ButtonCloseBox()
    {
        findOpponentsBox.GetComponent<Animator>().SetTrigger("TriClose");
        Modules.PlayAudioClipFree(Modules.audioButton);
        transform.gameObject.SetActive(false);
        Camera.main.GetComponent<PageMainGame>().ResetGame();

        isClose = true;
        // Gọi một phương thức hoặc thực hiện hành động khác để đóng hộp thoại.
        
    }
}
