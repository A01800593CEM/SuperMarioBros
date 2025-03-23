using System;
using UnityEditor.SearchService;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UIElements;

public class GameToMenu : MonoBehaviour
{
   private UIDocument MainMenu;
   void OnEnable()
   {
       MainMenu = GetComponent<UIDocument>();
       var root = MainMenu.rootVisualElement;
       var button = root.Q<Button>("backButton");
       button.RegisterCallback<ClickEvent>(Back);
   }

    private void Back(ClickEvent evt)
    {
        SceneManager.LoadScene("MainMenu");
    }
}