/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

public class mgbase : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal mgbase(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(mgbase obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~mgbase() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_mgbase(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public static float toRange(float value, float tmin, float tmax) {
    float ret = touchvgPINVOKE.mgbase_toRange(value, tmin, tmax);
    return ret;
  }

  public static float to0_2PI(float angle) {
    float ret = touchvgPINVOKE.mgbase_to0_2PI(angle);
    return ret;
  }

  public static float toPI(float angle) {
    float ret = touchvgPINVOKE.mgbase_toPI(angle);
    return ret;
  }

  public static float deg2Rad(float deg) {
    float ret = touchvgPINVOKE.mgbase_deg2Rad(deg);
    return ret;
  }

  public static float rad2Deg(float rad) {
    float ret = touchvgPINVOKE.mgbase_rad2Deg(rad);
    return ret;
  }

  public static float dms2Deg(float angle) {
    float ret = touchvgPINVOKE.mgbase_dms2Deg(angle);
    return ret;
  }

  public static float deg2Dms(float angle) {
    float ret = touchvgPINVOKE.mgbase_deg2Dms(angle);
    return ret;
  }

  public static float getMidAngle(float fromAngle, float toAngle) {
    float ret = touchvgPINVOKE.mgbase_getMidAngle(fromAngle, toAngle);
    return ret;
  }

  public static float getMidAngle2(float angle1, float angle2) {
    float ret = touchvgPINVOKE.mgbase_getMidAngle2(angle1, angle2);
    return ret;
  }

  public static float getDiffAngle(float fromAngle, float toAngle) {
    float ret = touchvgPINVOKE.mgbase_getDiffAngle(fromAngle, toAngle);
    return ret;
  }

  public static int getGcd(int x, int y) {
    int ret = touchvgPINVOKE.mgbase_getGcd(x, y);
    return ret;
  }

  public static float roundReal(float value, int arg1) {
    float ret = touchvgPINVOKE.mgbase_roundReal(value, arg1);
    return ret;
  }

  public mgbase() : this(touchvgPINVOKE.new_mgbase(), true) {
  }

}

}
