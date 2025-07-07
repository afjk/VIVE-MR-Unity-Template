using UnityEngine;
using VIVE.OpenXR.CompositionLayer;
using VIVE.OpenXR.Passthrough;

public class PassthroughSetter : MonoBehaviour
{
    private VIVE.OpenXR.Passthrough.XrPassthroughHTC activePassthroughID = 0;
    private LayerType currentActiveLayerType = LayerType.Underlay;
    private void Start()
    {
        StartPassthrough();
        SetPassthroughToUnderlay();
    }
    
    private void StartPassthrough()
    {
        PassthroughAPI.CreatePlanarPassthrough(out activePassthroughID, currentActiveLayerType, OnDestroyPassthroughFeatureSession);
    }
    
    private void OnDestroyPassthroughFeatureSession(VIVE.OpenXR.Passthrough.XrPassthroughHTC passthroughID)
    {
        PassthroughAPI.DestroyPassthrough(passthroughID);
        activePassthroughID = 0;
    }
    
    private void SetPassthroughToUnderlay()
    {
        if (activePassthroughID == 0){ return;}
        PassthroughAPI.SetPassthroughLayerType(activePassthroughID, LayerType.Underlay);
        currentActiveLayerType = LayerType.Underlay;
    }
}
