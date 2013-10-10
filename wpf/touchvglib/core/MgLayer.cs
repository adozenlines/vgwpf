/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

using System;
using System.Runtime.InteropServices;

public class MgLayer : MgShapes {
  private HandleRef swigCPtr;

  internal MgLayer(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgLayer_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgLayer obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public new static int Type() {
    int ret = touchvgPINVOKE.MgLayer_Type();
    return ret;
  }

  public MgLayer cloneLayer() {
    IntPtr cPtr = touchvgPINVOKE.MgLayer_cloneLayer(swigCPtr);
    MgLayer ret = (cPtr == IntPtr.Zero) ? null : new MgLayer(cPtr, false);
    return ret;
  }

  public static MgLayer create(MgShapeDoc doc, int index) {
    IntPtr cPtr = touchvgPINVOKE.MgLayer_create(MgShapeDoc.getCPtr(doc), index);
    MgLayer ret = (cPtr == IntPtr.Zero) ? null : new MgLayer(cPtr, false);
    return ret;
  }

  public MgShapeDoc doc() {
    IntPtr cPtr = touchvgPINVOKE.MgLayer_doc(swigCPtr);
    MgShapeDoc ret = (cPtr == IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public override MgObject clone() {
    IntPtr cPtr = touchvgPINVOKE.MgLayer_clone(swigCPtr);
    MgObject ret = (cPtr == IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public override void copy(MgObject src) {
    touchvgPINVOKE.MgLayer_copy(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    touchvgPINVOKE.MgLayer_release(swigCPtr);
  }

  public override bool equals(MgObject src) {
    bool ret = touchvgPINVOKE.MgLayer_equals(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getType() {
    int ret = touchvgPINVOKE.MgLayer_getType(swigCPtr);
    return ret;
  }

  public override bool isKindOf(int type) {
    bool ret = touchvgPINVOKE.MgLayer_isKindOf(swigCPtr, type);
    return ret;
  }

}

}
