using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
   private static BackgroundMusic backgroundMusic;
   
   void Awake()
   {
        if(backgroundMusic == null)
        {
            backgroundMusic = this;
            DontDestroyOnLoad(backgroundMusic); // continuing background music in different scene
        }

        else
        {
            Destroy(gameObject);
        }
   }
}
