using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private Button hostButton;
    [SerializeField] private Button serverButton;
    [SerializeField] private Button clientButton;
    [SerializeField] private Canvas menuCanvas;

    void Start()
    {
        Debug.Log("UIManager: Adding button listeners...");

        // Add listener for host button
        hostButton.onClick.AddListener(() =>
        {
            Debug.Log("Host button clicked!");
            NetworkManager.Singleton.StartHost();
            menuCanvas.enabled = false;
            Debug.Log("Canvas should now be disabled.");
        });

        // Add listener for server button
        serverButton.onClick.AddListener(() => {
            Debug.Log("Server button clicked!");
            NetworkManager.Singleton.StartServer();
            menuCanvas.enabled = false;
            Debug.Log("Canvas should now be disabled.");
        });

        // Add listener for client button
        clientButton.onClick.AddListener(() => {
            Debug.Log("Client button clicked!");
            NetworkManager.Singleton.StartClient();
            menuCanvas.enabled = false;
            Debug.Log("Canvas should now be disabled.");
        });
    }
}
