using UnityEngine;
using Vuforia;
//ps000
public class VirtualButtonScript : MonoBehaviour, IVirtualButtonEventHandler
{
    //public Interactable interactableObject;
    private VirtualButtonBehaviour virtualButton;

    public Animator animcontroller;


    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //interactableObject.Interact();
        Debug.Log("Se presionó");
        
        animcontroller.SetBool("Saludo", true);

    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Se levantó");

         animcontroller.SetBool("Saludo", false);

    }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        virtualButton = GetComponent<VirtualButtonBehaviour>();
    }

    void Start()
    {
        if (virtualButton != null)
        {
            virtualButton.RegisterEventHandler(this);
        }
    }
}
