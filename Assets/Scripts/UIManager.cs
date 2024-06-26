using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Text userAnswerText;
    public Button respondButton;
    public GameObject notificationPanel;
    public GameObject incorrectText;
    public GameObject correctText;
    public Button retryButton;
    public Button quitButton;

    void Start()
    {
        notificationPanel.SetActive(false);
    }
}
