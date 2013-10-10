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

public class BoundBox : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal BoundBox(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(BoundBox obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~BoundBox() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_BoundBox(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public BoundBox() : this(touchvgPINVOKE.new_BoundBox__SWIG_0(), true) {
  }

  public BoundBox(Point2d pnt1, Point2d pnt2) : this(touchvgPINVOKE.new_BoundBox__SWIG_1(Point2d.getCPtr(pnt1), Point2d.getCPtr(pnt2)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public BoundBox(Point2d arg0, Vector2d dir1, Vector2d dir2) : this(touchvgPINVOKE.new_BoundBox__SWIG_2(Point2d.getCPtr(arg0), Vector2d.getCPtr(dir1), Vector2d.getCPtr(dir2)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public BoundBox(BoundBox box) : this(touchvgPINVOKE.new_BoundBox__SWIG_3(BoundBox.getCPtr(box)), true) {
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void getMinMaxPoints(Point2d pnt1, Point2d pnt2) {
    touchvgPINVOKE.BoundBox_getMinMaxPoints(swigCPtr, Point2d.getCPtr(pnt1), Point2d.getCPtr(pnt2));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void get(Point2d arg0, Vector2d dir1, Vector2d dir2) {
    touchvgPINVOKE.BoundBox_get(swigCPtr, Point2d.getCPtr(arg0), Vector2d.getCPtr(dir1), Vector2d.getCPtr(dir2));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public BoundBox set(Point2d pnt1, Point2d pnt2) {
    BoundBox ret = new BoundBox(touchvgPINVOKE.BoundBox_set__SWIG_0(swigCPtr, Point2d.getCPtr(pnt1), Point2d.getCPtr(pnt2)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BoundBox set(Point2d arg0, Vector2d dir1, Vector2d dir2) {
    BoundBox ret = new BoundBox(touchvgPINVOKE.BoundBox_set__SWIG_1(swigCPtr, Point2d.getCPtr(arg0), Vector2d.getCPtr(dir1), Vector2d.getCPtr(dir2)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BoundBox extend(Point2d pnt) {
    BoundBox ret = new BoundBox(touchvgPINVOKE.BoundBox_extend(swigCPtr, Point2d.getCPtr(pnt)), false);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public BoundBox swell(float distance) {
    BoundBox ret = new BoundBox(touchvgPINVOKE.BoundBox_swell(swigCPtr, distance), false);
    return ret;
  }

  public bool contains(Point2d pnt) {
    bool ret = touchvgPINVOKE.BoundBox_contains(swigCPtr, Point2d.getCPtr(pnt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isDisjoint(BoundBox box) {
    bool ret = touchvgPINVOKE.BoundBox_isDisjoint(swigCPtr, BoundBox.getCPtr(box));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool isRect() {
    bool ret = touchvgPINVOKE.BoundBox_isRect(swigCPtr);
    return ret;
  }

  public BoundBox setToRect() {
    BoundBox ret = new BoundBox(touchvgPINVOKE.BoundBox_setToRect(swigCPtr), false);
    return ret;
  }

}

}
