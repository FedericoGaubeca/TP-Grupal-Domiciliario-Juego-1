using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public GameManager gameManager;
    public InputField resultInputField;
    public GameObject notificationPanel;
    public GameObject mensajePanel;
    public GameObject incorrectText;
    public GameObject correctText;
    public Button retryButton;
    public Button quitButton;

    void Start()
    {
        notificationPanel.SetActive(false);
        mensajePanel.SetActive(false);
        correctText.SetActive(false);
        incorrectText.SetActive(false);
    }

    public void OnCorregirButtonClicked()
    {
        int resultadoPlayer;
        if (int.TryParse(resultInputField.text, out resultadoPlayer)) //Investigue en google  "como hago para convertir el texto ingresado en el input field a int para poder compararlo con la respuesta correcta?"
        {
            int respuestaCorrecta = gameManager.ConseguirSumaTotal();

            if (resultadoPlayer == respuestaCorrecta)
            {
                notificationPanel.SetActive(true);
                correctText.SetActive(true);
            }
            else
            {
                notificationPanel.SetActive(true);
                incorrectText.SetActive(true);
            }
        }
        else
        {
            mensajePanel.SetActive(true);
        }
    }

    public void OnEntiendoButtonClicked()
    {
        mensajePanel.SetActive(false);
    }
}
