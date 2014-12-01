/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

public class GiTransform : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal GiTransform(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(GiTransform obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~GiTransform() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_GiTransform(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public GiTransform(bool ydown) : this(touchvgPINVOKE.new_GiTransform__SWIG_0(ydown), true) {
  }

  public GiTransform() : this(touchvgPINVOKE.new_GiTransform__SWIG_1(), true) {
  }

  public GiTransform(GiTransform src) : this(touchvgPINVOKE.new_GiTransform__SWIG_2(GiTransform.getCPtr(src)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public GiTransform copy(GiTransform src) {
    GiTransform ret = new GiTransform(touchvgPINVOKE.GiTransform_copy(swigCPtr, GiTransform.getCPtr(src)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float getDpiX() {
    float ret = touchvgPINVOKE.GiTransform_getDpiX(swigCPtr);
    return ret;
  }

  public float getDpiY() {
    float ret = touchvgPINVOKE.GiTransform_getDpiY(swigCPtr);
    return ret;
  }

  public int getWidth() {
    int ret = touchvgPINVOKE.GiTransform_getWidth(swigCPtr);
    return ret;
  }

  public int getHeight() {
    int ret = touchvgPINVOKE.GiTransform_getHeight(swigCPtr);
    return ret;
  }

  public Point2d getCenterW() {
    Point2d ret = new Point2d(touchvgPINVOKE.GiTransform_getCenterW(swigCPtr), true);
    return ret;
  }

  public float getViewScale() {
    float ret = touchvgPINVOKE.GiTransform_getViewScale(swigCPtr);
    return ret;
  }

  public float getWorldToDisplayX(bool useViewScale) {
    float ret = touchvgPINVOKE.GiTransform_getWorldToDisplayX__SWIG_0(swigCPtr, useViewScale);
    return ret;
  }

  public float getWorldToDisplayX() {
    float ret = touchvgPINVOKE.GiTransform_getWorldToDisplayX__SWIG_1(swigCPtr);
    return ret;
  }

  public float getWorldToDisplayY(bool useViewScale) {
    float ret = touchvgPINVOKE.GiTransform_getWorldToDisplayY__SWIG_0(swigCPtr, useViewScale);
    return ret;
  }

  public float getWorldToDisplayY() {
    float ret = touchvgPINVOKE.GiTransform_getWorldToDisplayY__SWIG_1(swigCPtr);
    return ret;
  }

  public float displayToModel(float dist, bool mm) {
    float ret = touchvgPINVOKE.GiTransform_displayToModel__SWIG_0(swigCPtr, dist, mm);
    return ret;
  }

  public float displayToModel(float dist) {
    float ret = touchvgPINVOKE.GiTransform_displayToModel__SWIG_1(swigCPtr, dist);
    return ret;
  }

  public Matrix2d modelToWorld() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.GiTransform_modelToWorld(swigCPtr), false);
    return ret;
  }

  public Matrix2d worldToModel() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.GiTransform_worldToModel(swigCPtr), false);
    return ret;
  }

  public Matrix2d displayToWorld() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.GiTransform_displayToWorld(swigCPtr), false);
    return ret;
  }

  public Matrix2d worldToDisplay() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.GiTransform_worldToDisplay(swigCPtr), false);
    return ret;
  }

  public Matrix2d displayToModel() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.GiTransform_displayToModel__SWIG_2(swigCPtr), false);
    return ret;
  }

  public Matrix2d modelToDisplay() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.GiTransform_modelToDisplay(swigCPtr), false);
    return ret;
  }

  public bool setWndSize(int width, int height) {
    bool ret = touchvgPINVOKE.GiTransform_setWndSize(swigCPtr, width, height);
    return ret;
  }

  public void setResolution(float dpiX, float dpiY) {
    touchvgPINVOKE.GiTransform_setResolution__SWIG_0(swigCPtr, dpiX, dpiY);
  }

  public void setResolution(float dpiX) {
    touchvgPINVOKE.GiTransform_setResolution__SWIG_1(swigCPtr, dpiX);
  }

  public bool setModelTransform(Matrix2d mat) {
    bool ret = touchvgPINVOKE.GiTransform_setModelTransform(swigCPtr, Matrix2d.getCPtr(mat));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d getWndRectW() {
    Box2d ret = new Box2d(touchvgPINVOKE.GiTransform_getWndRectW(swigCPtr), true);
    return ret;
  }

  public Box2d getWndRectM() {
    Box2d ret = new Box2d(touchvgPINVOKE.GiTransform_getWndRectM(swigCPtr), true);
    return ret;
  }

  public Box2d getWndRect() {
    Box2d ret = new Box2d(touchvgPINVOKE.GiTransform_getWndRect(swigCPtr), true);
    return ret;
  }

  public float getMinViewScale() {
    float ret = touchvgPINVOKE.GiTransform_getMinViewScale(swigCPtr);
    return ret;
  }

  public float getMaxViewScale() {
    float ret = touchvgPINVOKE.GiTransform_getMaxViewScale(swigCPtr);
    return ret;
  }

  public Box2d getWorldLimits() {
    Box2d ret = new Box2d(touchvgPINVOKE.GiTransform_getWorldLimits(swigCPtr), true);
    return ret;
  }

  public void setViewScaleRange(float minScale, float maxScale) {
    touchvgPINVOKE.GiTransform_setViewScaleRange(swigCPtr, minScale, maxScale);
  }

  public Box2d setWorldLimits(Box2d rect) {
    Box2d ret = new Box2d(touchvgPINVOKE.GiTransform_setWorldLimits(swigCPtr, Box2d.getCPtr(rect)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomWnd(Point2d pt1, Point2d pt2, bool adjust) {
    bool ret = touchvgPINVOKE.GiTransform_zoomWnd__SWIG_0(swigCPtr, Point2d.getCPtr(pt1), Point2d.getCPtr(pt2), adjust);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomWnd(Point2d pt1, Point2d pt2) {
    bool ret = touchvgPINVOKE.GiTransform_zoomWnd__SWIG_1(swigCPtr, Point2d.getCPtr(pt1), Point2d.getCPtr(pt2));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomTo(Box2d rectWorld, RECT_2D rcTo, bool adjust) {
    bool ret = touchvgPINVOKE.GiTransform_zoomTo__SWIG_0(swigCPtr, Box2d.getCPtr(rectWorld), RECT_2D.getCPtr(rcTo), adjust);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomTo(Box2d rectWorld, RECT_2D rcTo) {
    bool ret = touchvgPINVOKE.GiTransform_zoomTo__SWIG_1(swigCPtr, Box2d.getCPtr(rectWorld), RECT_2D.getCPtr(rcTo));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomTo(Box2d rectWorld) {
    bool ret = touchvgPINVOKE.GiTransform_zoomTo__SWIG_2(swigCPtr, Box2d.getCPtr(rectWorld));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomTo(Point2d pntWorld, Point2d pxAt, bool adjust) {
    bool ret = touchvgPINVOKE.GiTransform_zoomTo__SWIG_3(swigCPtr, Point2d.getCPtr(pntWorld), Point2d.getCPtr(pxAt), adjust);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomTo(Point2d pntWorld, Point2d pxAt) {
    bool ret = touchvgPINVOKE.GiTransform_zoomTo__SWIG_4(swigCPtr, Point2d.getCPtr(pntWorld), Point2d.getCPtr(pxAt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomTo(Point2d pntWorld) {
    bool ret = touchvgPINVOKE.GiTransform_zoomTo__SWIG_5(swigCPtr, Point2d.getCPtr(pntWorld));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool zoomPan(float dxPixel, float dyPixel, bool adjust) {
    bool ret = touchvgPINVOKE.GiTransform_zoomPan__SWIG_0(swigCPtr, dxPixel, dyPixel, adjust);
    return ret;
  }

  public bool zoomPan(float dxPixel, float dyPixel) {
    bool ret = touchvgPINVOKE.GiTransform_zoomPan__SWIG_1(swigCPtr, dxPixel, dyPixel);
    return ret;
  }

  public bool zoomByFactor(float factor, Point2d pxAt, bool adjust) {
    bool ret = touchvgPINVOKE.GiTransform_zoomByFactor__SWIG_0(swigCPtr, factor, Point2d.getCPtr(pxAt), adjust);
    return ret;
  }

  public bool zoomByFactor(float factor, Point2d pxAt) {
    bool ret = touchvgPINVOKE.GiTransform_zoomByFactor__SWIG_1(swigCPtr, factor, Point2d.getCPtr(pxAt));
    return ret;
  }

  public bool zoomByFactor(float factor) {
    bool ret = touchvgPINVOKE.GiTransform_zoomByFactor__SWIG_2(swigCPtr, factor);
    return ret;
  }

  public bool zoomScale(float viewScale, Point2d pxAt, bool adjust) {
    bool ret = touchvgPINVOKE.GiTransform_zoomScale__SWIG_0(swigCPtr, viewScale, Point2d.getCPtr(pxAt), adjust);
    return ret;
  }

  public bool zoomScale(float viewScale, Point2d pxAt) {
    bool ret = touchvgPINVOKE.GiTransform_zoomScale__SWIG_1(swigCPtr, viewScale, Point2d.getCPtr(pxAt));
    return ret;
  }

  public bool zoomScale(float viewScale) {
    bool ret = touchvgPINVOKE.GiTransform_zoomScale__SWIG_2(swigCPtr, viewScale);
    return ret;
  }

  public bool zoom(Point2d centerW, float viewScale) {
    bool ret = touchvgPINVOKE.GiTransform_zoom(swigCPtr, Point2d.getCPtr(centerW), viewScale);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool enableZoom(bool enabled) {
    bool ret = touchvgPINVOKE.GiTransform_enableZoom(swigCPtr, enabled);
    return ret;
  }

  public float getZoomValue(Point2d centerW) {
    float ret = touchvgPINVOKE.GiTransform_getZoomValue(swigCPtr, Point2d.getCPtr(centerW));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int getZoomTimes() {
    int ret = touchvgPINVOKE.GiTransform_getZoomTimes(swigCPtr);
    return ret;
  }

}

}
