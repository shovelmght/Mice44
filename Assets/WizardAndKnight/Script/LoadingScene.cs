using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class LoadingScene 
{

    private class LoadingMono : MonoBehaviour { }

    //  loads the Scene in the background as the current Scene runs.
    public static IEnumerator LoadYourAsyncScene(string sceneLoad ,string sceneUnload )
    {

        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneLoad, LoadSceneMode.Additive);  //Load scene chosen

        if (sceneUnload != "")
        {
            AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(sceneUnload);  //Unload current scene, if there is one

            while (!asyncLoad.isDone && !asyncUnload.isDone)  // check uf unload and load is finich
            {
                yield return null;
            }
        }
        else
            while (!asyncLoad.isDone)   // check uf unload and load is finich
            {
                yield return null;
            }

        // Wait until the asynchronous scene fully loads
        GameManagerWizardAndKnight.instance.CallUnFade();        //fade to black to normal screen
        MusicManagerWizard.instance.ChangeSong();
    }

}
