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

public class MgShapeDoc : MgObject {
  private HandleRef swigCPtr;

  internal MgShapeDoc(IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgShapeDoc_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(MgShapeDoc obj) {
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

  public static int Type() {
    int ret = touchvgPINVOKE.MgShapeDoc_Type();
    return ret;
  }

  public MgShapeDoc cloneDoc() {
    IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_cloneDoc(swigCPtr);
    MgShapeDoc ret = (cPtr == IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public static MgShapeDoc createDoc() {
    IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_createDoc();
    MgShapeDoc ret = (cPtr == IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public void addRef() {
    touchvgPINVOKE.MgShapeDoc_addRef(swigCPtr);
  }

  public bool save(MgStorage s, int startIndex) {
    bool ret = touchvgPINVOKE.MgShapeDoc_save__SWIG_0(swigCPtr, MgStorage.getCPtr(s), startIndex);
    return ret;
  }

  public bool save(MgStorage s) {
    bool ret = touchvgPINVOKE.MgShapeDoc_save__SWIG_1(swigCPtr, MgStorage.getCPtr(s));
    return ret;
  }

  public bool load(MgShapeFactory factory, MgStorage s, bool addOnly) {
    bool ret = touchvgPINVOKE.MgShapeDoc_load__SWIG_0(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s), addOnly);
    return ret;
  }

  public bool load(MgShapeFactory factory, MgStorage s) {
    bool ret = touchvgPINVOKE.MgShapeDoc_load__SWIG_1(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s));
    return ret;
  }

  public void clear() {
    touchvgPINVOKE.MgShapeDoc_clear(swigCPtr);
  }

  public void clearCachedData() {
    touchvgPINVOKE.MgShapeDoc_clearCachedData(swigCPtr);
  }

  public int draw(GiGraphics gs) {
    int ret = touchvgPINVOKE.MgShapeDoc_draw(swigCPtr, GiGraphics.getCPtr(gs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d getExtent() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgShapeDoc_getExtent(swigCPtr), true);
    return ret;
  }

  public int getShapeCount() {
    int ret = touchvgPINVOKE.MgShapeDoc_getShapeCount(swigCPtr);
    return ret;
  }

  public MgShapes getCurrentShapes() {
    IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_getCurrentShapes(swigCPtr);
    MgShapes ret = (cPtr == IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public bool setCurrentShapes(MgShapes shapes) {
    bool ret = touchvgPINVOKE.MgShapeDoc_setCurrentShapes(swigCPtr, MgShapes.getCPtr(shapes));
    return ret;
  }

  public bool switchLayer(int index) {
    bool ret = touchvgPINVOKE.MgShapeDoc_switchLayer(swigCPtr, index);
    return ret;
  }

  public int getLayerCount() {
    int ret = touchvgPINVOKE.MgShapeDoc_getLayerCount(swigCPtr);
    return ret;
  }

  public GiContext context() {
    IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_context(swigCPtr);
    GiContext ret = (cPtr == IntPtr.Zero) ? null : new GiContext(cPtr, false);
    return ret;
  }

  public Matrix2d modelTransform() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.MgShapeDoc_modelTransform(swigCPtr), false);
    return ret;
  }

  public Box2d getPageRectW() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgShapeDoc_getPageRectW(swigCPtr), true);
    return ret;
  }

  public float getViewScale() {
    float ret = touchvgPINVOKE.MgShapeDoc_getViewScale(swigCPtr);
    return ret;
  }

  public void setPageRectW(Box2d rectW, float viewScale) {
    touchvgPINVOKE.MgShapeDoc_setPageRectW(swigCPtr, Box2d.getCPtr(rectW), viewScale);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public int getChangeCount() {
    int ret = touchvgPINVOKE.MgShapeDoc_getChangeCount(swigCPtr);
    return ret;
  }

  public override MgObject clone() {
    IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_clone(swigCPtr);
    MgObject ret = (cPtr == IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public override void copy(MgObject src) {
    touchvgPINVOKE.MgShapeDoc_copy(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    touchvgPINVOKE.MgShapeDoc_release(swigCPtr);
  }

  public override bool equals(MgObject src) {
    bool ret = touchvgPINVOKE.MgShapeDoc_equals(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getType() {
    int ret = touchvgPINVOKE.MgShapeDoc_getType(swigCPtr);
    return ret;
  }

  public override bool isKindOf(int type) {
    bool ret = touchvgPINVOKE.MgShapeDoc_isKindOf(swigCPtr, type);
    return ret;
  }

}

}
