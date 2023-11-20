using UnityEngine;
using UnityEngine.UI;

public class PlayerTypeToggle : MonoBehaviour
{
    public Toggle vrToggle;
    public Toggle pcToggle;

    void Start()
    {
        vrToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(vrToggle, true);
        });

        pcToggle.onValueChanged.AddListener(delegate {
            ToggleValueChanged(pcToggle, false);
        });
    }

    void ToggleValueChanged(Toggle changedToggle, bool isVR)
    {
        if (changedToggle.isOn)
        {
            MyGameManager.Instance.IsVRPlayer = isVR;
            Debug.Log("Is VR Player: " + isVR);

            // ������һ��Toggle��״̬
            if (isVR)
            {
                pcToggle.isOn = false;
            }
            else
            {
                vrToggle.isOn = false;
            }
        }
    }
}
