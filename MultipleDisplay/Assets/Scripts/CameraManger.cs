using UnityEngine;

namespace Assets
{
    public class CameraManger : MonoBehaviour {
        private void Start()
        {
            foreach (var display in Display.displays)
            {
                display.Activate();
            }
        }
    }
}
