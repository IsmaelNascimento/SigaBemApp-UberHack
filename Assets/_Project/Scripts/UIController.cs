using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] private InputField inputFieldAddress;

    private void Start()
    {
        inputFieldAddress.onEndEdit.AddListener(InputFieldAddressEnter);
    }

    public void OnButtonFacebookClicked()
    {
        Application.OpenURL("https://www.fb.com");
    }

    public void InputFieldAddressEnter(string search)
    {
        Utils.OpenMapDirectionstoDestiny(search);
    }
}