using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicIntro : MonoBehaviour
{
   private static BackgroundMusicIntro backgroundMusic;
   
   void Awake()
   {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            //DontDestroyOnLoad(backgroundMusic);
        }

        else
        {
            Destroy(gameObject);
        }
   }
}
