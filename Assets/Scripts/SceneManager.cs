using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using BNG;
namespace EscapeRoom{
    public class SceneManager : MonoBehaviour
    {
        public LoadSceneMode loadSceneMode = LoadSceneMode.Single;

        [Tooltip("If true, the ScreenFader component will fade the screen to black before loading a level.")]
        public bool UseSceenFader = true;

        [Tooltip("Wait this long in seconds before attempting to load the scene. Useful if you need to fade the screen out before attempting to load the level.")]
        public float ScreenFadeTime = 0.5f;

        ScreenFader sf;
        public static SceneManager Instance;
        // Start is called before the first frame update
        void Start()
        {
            Instance=this;
            //DontDestroyOnLoad(gameObject);
        }

        // Update is called once per frame
        void Update()
        {
            
        }
        public void GotoMenuRoom(){
            if(UseSceenFader) {
                //_loadSceneName = SceneName;

                StartCoroutine(FadeThenLoadScene(0));
            }
            //UnityEngine.SceneManagement.SceneManager.LoadScene(0);
        }
        public void GotoRoom1(){
            if(UseSceenFader) {
                //_loadSceneName = SceneName;

                StartCoroutine(FadeThenLoadScene(1));
            }
            //UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
        public void GotoRoom2(){
            if(UseSceenFader) {
                //_loadSceneName = SceneName;

                StartCoroutine(FadeThenLoadScene(2));
            }
            //UnityEngine.SceneManagement.SceneManager.LoadScene(2);
        }
        public void GotoRoom3(){
            if(UseSceenFader) {
                //_loadSceneName = SceneName;

                StartCoroutine(FadeThenLoadScene(3));
            }
            //UnityEngine.SceneManagement.SceneManager.LoadScene(3);
        }
        public void GotoEndRoom(){
            if(UseSceenFader) {
                //_loadSceneName = SceneName;

                StartCoroutine(FadeThenLoadScene(4));
            }
            //UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
        public void GotoGameOverScene(){
            if(UseSceenFader) {
                //_loadSceneName = SceneName;

                StartCoroutine(FadeThenLoadScene(5));
            }
        }
        public void ReStartScene(){
            if(UseSceenFader) {
                //_loadSceneName = SceneName;

                StartCoroutine(FadeThenLoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex));
            }
        }
        public void ResumeGame(){
            int idxScene=PlayerPrefs.GetInt("CurrentScene");
            if(idxScene<=0 ||string.IsNullOrEmpty(idxScene.ToString())){
                return;
            }
            else{
                if(UseSceenFader) {
                    //_loadSceneName = SceneName;

                    StartCoroutine(FadeThenLoadScene(idxScene));
                }
            }
        }
        public void ExitGame(){
            Application.Quit();
        }
        public IEnumerator FadeThenLoadScene(int sceneIdx) {

            if (UseSceenFader) {
                if (sf == null) {
                    sf = FindObjectOfType<ScreenFader>();
                    // May not have found anything
                    if (sf != null) {
                        sf.DoFadeIn();
                    }
                }
            }

            if(ScreenFadeTime > 0) {
                yield return new WaitForSeconds(ScreenFadeTime);
            }
            UnityEngine.SceneManagement.SceneManager.LoadScene(sceneIdx,loadSceneMode);
            //SceneManager.LoadScene(_loadSceneName, loadSceneMode);
        }
    }
}

