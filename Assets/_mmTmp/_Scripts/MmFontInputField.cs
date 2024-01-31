
using TMPro;
using UnityEngine;

[RequireComponent(typeof(TMP_InputField))]
public class MmFontInputField : MonoBehaviour
{
    private TMP_InputField _inputField;
    
    // Start is called before the first frame update
    private void Start()
    {
        _inputField = GetComponent<TMP_InputField>();
        if (_inputField == null)
        {
            Debug.Log("Input Field for MMFONT is NULL.");
            return; 
        }
        
        _inputField.onEndEdit.AddListener((str) =>
        {
            _inputField.text = str.Uni2Zg();
        });
    }
}
