using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;

public class GameplayScene : MonoBehaviour
{
    [SerializeField] Button _xButton;


    private void Start()
    {
        SetButtonListener(_xButton,ChangeScene);
    }

    void SetButtonListener(Button button, UnityAction action)
    {
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(action);
    }

    void ChangeScene()
    {
        Debug.Log("ChangeScene");
    }
}
