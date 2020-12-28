using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelFinisher : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator levelFinishAnimator;
    public Transform player;
    void Update()
    {
        if(player.position.z<transform.position.z+3f&& player.position.z > transform.position.z - 3f)
        {
            levelFinishAnimator.SetBool("levelFinish",true);
            Invoke("LevelFinishWithDelay",2f);
        }
    }
   void LevelFinishWithDelay()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
