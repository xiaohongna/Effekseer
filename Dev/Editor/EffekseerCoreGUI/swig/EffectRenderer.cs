//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 4.0.2
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Effekseer.swig {

public class EffectRenderer : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EffectRenderer(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EffectRenderer obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EffectRenderer() {
    Dispose(false);
  }

  public void Dispose() {
    Dispose(true);
    global::System.GC.SuppressFinalize(this);
  }

  protected virtual void Dispose(bool disposing) {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          EffekseerNativePINVOKE.delete_EffectRenderer(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
    }
  }

  public EffectRenderer() : this(EffekseerNativePINVOKE.new_EffectRenderer(), true) {
  }

  public bool Initialize(GraphicsDevice graphicsDevice, SoundDevice soundDevice, EffectSetting setting, int spriteCount, bool isSRGBMode) {
    bool ret = EffekseerNativePINVOKE.EffectRenderer_Initialize(swigCPtr, GraphicsDevice.getCPtr(graphicsDevice), SoundDevice.getCPtr(soundDevice), EffectSetting.getCPtr(setting), spriteCount, isSRGBMode);
    return ret;
  }

  public Vector2I GetScreenSize() {
    Vector2I ret = new Vector2I(EffekseerNativePINVOKE.EffectRenderer_GetScreenSize(swigCPtr), true);
    return ret;
  }

  public void ResizeScreen(Vector2I screenSize) {
    EffekseerNativePINVOKE.EffectRenderer_ResizeScreen(swigCPtr, Vector2I.getCPtr(screenSize));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public void PlayEffect() {
    EffekseerNativePINVOKE.EffectRenderer_PlayEffect(swigCPtr);
  }

  public void UpdatePaused() {
    EffekseerNativePINVOKE.EffectRenderer_UpdatePaused(swigCPtr);
  }

  public void Update() {
    EffekseerNativePINVOKE.EffectRenderer_Update__SWIG_0(swigCPtr);
  }

  public void Update(int frame) {
    EffekseerNativePINVOKE.EffectRenderer_Update__SWIG_1(swigCPtr, frame);
  }

  public void Render(RenderImage renderImage) {
    EffekseerNativePINVOKE.EffectRenderer_Render(swigCPtr, RenderImage.getCPtr(renderImage));
  }

  public void SetLODDistanceBias(float distanceBias) {
    EffekseerNativePINVOKE.EffectRenderer_SetLODDistanceBias(swigCPtr, distanceBias);
  }

  public Effect GetEffect() {
    global::System.IntPtr cPtr = EffekseerNativePINVOKE.EffectRenderer_GetEffect(swigCPtr);
    Effect ret = (cPtr == global::System.IntPtr.Zero) ? null : new Effect(cPtr, true);
    return ret;
  }

  public void SetEffect(Effect effect) {
    EffekseerNativePINVOKE.EffectRenderer_SetEffect(swigCPtr, Effect.getCPtr(effect));
  }

  public void ResetEffect() {
    EffekseerNativePINVOKE.EffectRenderer_ResetEffect(swigCPtr);
  }

  public ViewerEffectBehavior GetBehavior() {
    ViewerEffectBehavior ret = new ViewerEffectBehavior(EffekseerNativePINVOKE.EffectRenderer_GetBehavior(swigCPtr), false);
    return ret;
  }

  public void SetBehavior(ViewerEffectBehavior behavior) {
    EffekseerNativePINVOKE.EffectRenderer_SetBehavior(swigCPtr, ViewerEffectBehavior.getCPtr(behavior));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetCurrentLOD() {
    int ret = EffekseerNativePINVOKE.EffectRenderer_GetCurrentLOD(swigCPtr);
    return ret;
  }

  public int GetInstanceCount() {
    int ret = EffekseerNativePINVOKE.EffectRenderer_GetInstanceCount(swigCPtr);
    return ret;
  }

  public void SetStep(int step) {
    EffekseerNativePINVOKE.EffectRenderer_SetStep(swigCPtr, step);
  }

  public EffectRendererParameter GetParameter() {
    EffectRendererParameter ret = new EffectRendererParameter(EffekseerNativePINVOKE.EffectRenderer_GetParameter(swigCPtr), true);
    return ret;
  }

  public void SetParameter(EffectRendererParameter config) {
    EffekseerNativePINVOKE.EffectRenderer_SetParameter(swigCPtr, EffectRendererParameter.getCPtr(config));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public bool GetIsSRGBMode() {
    bool ret = EffekseerNativePINVOKE.EffectRenderer_GetIsSRGBMode(swigCPtr);
    return ret;
  }

  public int GetSquareMaxCount() {
    int ret = EffekseerNativePINVOKE.EffectRenderer_GetSquareMaxCount(swigCPtr);
    return ret;
  }

  public PostEffectParameter GetPostEffectParameter() {
    PostEffectParameter ret = new PostEffectParameter(EffekseerNativePINVOKE.EffectRenderer_GetPostEffectParameter(swigCPtr), true);
    return ret;
  }

  public void SetPostEffectParameter(PostEffectParameter param) {
    EffekseerNativePINVOKE.EffectRenderer_SetPostEffectParameter(swigCPtr, PostEffectParameter.getCPtr(param));
    if (EffekseerNativePINVOKE.SWIGPendingException.Pending) throw EffekseerNativePINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetAndResetDrawCall() {
    int ret = EffekseerNativePINVOKE.EffectRenderer_GetAndResetDrawCall(swigCPtr);
    return ret;
  }

  public int GetAndResetVertexCount() {
    int ret = EffekseerNativePINVOKE.EffectRenderer_GetAndResetVertexCount(swigCPtr);
    return ret;
  }

  public int RandomSeed {
    set {
      EffekseerNativePINVOKE.EffectRenderer_RandomSeed_set(swigCPtr, value);
    } 
    get {
      int ret = EffekseerNativePINVOKE.EffectRenderer_RandomSeed_get(swigCPtr);
      return ret;
    } 
  }

  public EffectRendererCallback Callback {
    set {
      EffekseerNativePINVOKE.EffectRenderer_Callback_set(swigCPtr, EffectRendererCallback.getCPtr(value));
    } 
    get {
      global::System.IntPtr cPtr = EffekseerNativePINVOKE.EffectRenderer_Callback_get(swigCPtr);
      EffectRendererCallback ret = (cPtr == global::System.IntPtr.Zero) ? null : new EffectRendererCallback(cPtr, false);
      return ret;
    } 
  }

}

}
