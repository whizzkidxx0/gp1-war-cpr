using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ColorChanger : MonoBehaviour
{
    public Material greyMat = null;
    public Material pinkMat= null;

    private MeshRenderer meshRenderer = null;
    private XRGrabInteractable grabInteractable = null;


    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.onActivate.AddListener(SetPink);
        grabInteractable.onDeactivate.AddListener(SetGray);
    }


    private void OnDestroy()
    {
        grabInteractable.onActivate.RemoveListener(SetPink);
        grabInteractable.onDeactivate.RemoveListener(SetGray);
    }

    private void SetGray(XRBaseInteractor interactor)
    {
        meshRenderer.material = greyMat;
    }

    private void SetPink(XRBaseInteractor interactor)
    {
        meshRenderer.material = pinkMat;
    }
}
