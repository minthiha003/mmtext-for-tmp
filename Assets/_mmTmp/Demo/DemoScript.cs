using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DemoScript : MonoBehaviour
{
    [SerializeField] private TMP_InputField tmpInputField;
    [SerializeField] private TextMeshProUGUI tmpText;
    [SerializeField] private Button btnConvert; 
    
    
    // Start is called before the first frame update
    private void Start()
    {
        btnConvert.onClick.AddListener(OnClickConvert);
    }

    private void OnClickConvert()
    {
        tmpText.text = tmpInputField.text.Uni2Zg();
    }
}
